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
    public partial class Usuario : ContentPage
    {
        public Usuario()
        {
            InitializeComponent();
            BtnPerfil.Clicked += BtnPerfil_Clicked;
            BtnCitas.Clicked += BtnCitas_Clicked;
            BtnAgendar.Clicked += BtnAgendar_Clicked;
        }

        private void BtnAgendar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsuarioAgendar());
        }

   

        private void BtnCitas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsuarioCitas());
        }

        private void BtnPerfil_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsuarioPerfil());
        }



    }
}