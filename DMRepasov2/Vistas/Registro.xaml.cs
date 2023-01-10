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
    public partial class Registro : ContentPage
    {
        private string usuario;
        private string pass;

        public Registro(string usuario, string pass)
        {
            InitializeComponent();
            string user = lblUsuario.Text;
            lblUsuario.Text = usuario + user;
        }
    }
}