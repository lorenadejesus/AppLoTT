using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLot.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Olv_contra : ContentPage
    {
        public Olv_contra()
        {
            InitializeComponent();
            btnRest.Clicked += BtnRest_Clicked;
            btnVol.Clicked += BtnVol_Clicked;
        }

        private void BtnVol_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsuarioInicioSesion());
        }

        private void BtnRest_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Aviso", "Se ha enviado la contraseña", "OK");
        }
        
    }
}