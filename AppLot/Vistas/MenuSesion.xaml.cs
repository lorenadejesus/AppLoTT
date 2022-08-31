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
    public partial class MenuSesion : ContentPage
    {
        public MenuSesion()
        {
            InitializeComponent();
            BtnUsuario.Clicked += BtnUsuario_Clicked;
            BtnInstructor.Clicked += BtnInstructor_Clicked;
            BtnAdministrador.Clicked += BtnAdministrador_Clicked;
        }
        private void BtnUsuario_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UsuarioInicioSesion());
        }
        private void BtnInstructor_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstructorInicioSesion());
        }
        private void BtnAdministrador_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminInicioSesion());
        }
    }
}