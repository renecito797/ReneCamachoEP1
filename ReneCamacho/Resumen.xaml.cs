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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, double total)
        {
            InitializeComponent();

            lblUsuario.Text = usuario;
            txtNombre.Text = nombre;
            txtTotalPagar.Text = Convert.ToString(total);

        }
    }
}