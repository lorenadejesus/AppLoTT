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
    public partial class UsuarioPerfil : ContentPage
    {
        public UsuarioPerfil()
        {
            InitializeComponent();
            BtnCerrar.Clicked += BtnCerrar_Clicked;
            BtnConfiguracion.Clicked += BtnConfiguracion_Clicked;
            BtnCitas.Clicked += BtnCitas_Clicked;
            BtnHome.Clicked += BtnHome_Clicked;
            BtnAgendar.Clicked += BtnAgendar_Clicked;

        }

        private void BtnAgendar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsuarioAgendar());
        }

        private void BtnCerrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void BtnHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Usuario());
        }

        private void BtnCitas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsuarioCitas());
        }

        private void BtnConfiguracion_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsuarioConfig());
        }




    }
}