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
    public partial class AdminPerfil : ContentPage
    {
        public AdminPerfil()
        {
            InitializeComponent();
            BtnCerrar.Clicked += BtnCerrar_Clicked;
            BtnCitas.Clicked += BtnCitas_Clicked;
            BtnHome.Clicked += BtnHome_Clicked;
            BtnAgendar.Clicked += BtnAgendar_Clicked;
            BtnConfiguracion.Clicked += BtnConfiguracion_Clicked;
            BtnRegistrarInstru.Clicked += BtnRegistrarInstru_Clicked;
        }

        private void BtnRegistrarInstru_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstructorRegistro());
        }

        private void BtnAgendar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminAgendar());
        }

        private void BtnCerrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private  void BtnHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Admin());
        }

        private void BtnCitas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminCitas());
        }
        private void BtnConfiguracion_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsuarioConfig());
        }





    }
}