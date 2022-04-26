using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReneCamacho
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        double cuota;
        double total;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado: "+ usuario;  
           
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {

                double monto = Convert.ToDouble(txtMonto.Text);  

                if (monto < 1 || monto > 1800)
                {
                    DisplayAlert("Error", "Monto entre 1 y 1800", "salir");
                }

                else
                {
                    double saldo = (1800 - monto);
                    cuota = (saldo / 3) + ((1800 * 0.05));
                    total = monto + (cuota * 3);
                    txtPagoMensual.Text = cuota.ToString();

                }
                                
            }

            catch (Exception ex)
            {
                DisplayAlert("Error", "Error", "salir");
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 0)
            {
                await Navigation.PushAsync(new Resumen(lblUsuario.Text, txtNombre.Text, total));

            }
            else
            {
                await DisplayAlert("Error", "Debe ingresar un Nombre", "salir");

            }
        }
    }
}