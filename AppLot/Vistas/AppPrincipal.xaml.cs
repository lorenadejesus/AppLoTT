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
    public partial class AppPrincipal : ContentPage
    {
        public AppPrincipal()
        {
            InitializeComponent();
            BtnIniciarSesion.Clicked += BtnIniciarSesion_Clicked;
            BtnRegistrarse.Clicked += BtnRegistrarse_Clicked;
            BtnInfo.Clicked += BtnInfo_Clicked;
        }

        private void BtnRegistrarse_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro());
        }

        private void BtnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuSesion());
        }
        private void BtnInfo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Informacion());
        }
    }
}