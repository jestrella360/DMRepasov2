using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DMRepasov2.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string pass = txtPass.Text;

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtPass.Text))
                DisplayAlert("Sin Datos", "Ingrese usuario y contraseña", "OK");
            else
            {
                if (txtUsuario.Text == "estudiante2022" && txtPass.Text == "uisrael2022")
                {
                    DisplayAlert("Ingreso existoso", "", "OK");
                    Navigation.PushAsync(new Registro(usuario, pass));
                }
                else
                    DisplayAlert("Ingreso Fallido", "Ingrese correctamente los datos", "OK");
            }
        }
    }
}