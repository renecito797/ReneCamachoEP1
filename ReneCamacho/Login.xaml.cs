using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReneCamacho
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            if (user == "rcamacho" && contraseña == "uisrael2022")
            {

               await DisplayAlert("!BIENVENIDO!", "Inicio de sesión con éxito", "OK");
                await Navigation.PushAsync(new Registro(txtUsuario.Text));
            }

            else
            {
                await DisplayAlert("Alerta", "Usuario o Contraeña Incorrecta", "SALIR");

            }
        }
    }
}
