using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AppLot.Datos;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLot.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuarioInicioSesion : ContentPage
    {
        public UsuarioInicioSesion()
        {
            InitializeComponent();
            btnIniciarclic.Clicked += BtnIniciarclic_Clicked;
            btnOlvi.Clicked += BtnOlvi_Clicked;


        }


     

        private async void BtnOlvi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Olv_contra());
        }


        private void BtnIniciarclic_Clicked(object sender, EventArgs e)
        {
            
            UsuarioUNO crudusuario = UsuarioDADO.BuscarUsuario(correoElectronico.Text, contrasena.Text);

            if (crudusuario != null)
            {
                Navigation.PushAsync(new Vistas.Usuario());
                LimpiarFormulario();
            }
            else
            {
                DisplayAlert("Datos incorrectos", "Revise el correo o la contraseña", "OK");
                
            }
            

        }//metodo iniciar ses
        void LimpiarFormulario()
        {
            correoElectronico.Text = "";
            contrasena.Text = "";

        }

        
        

    }
}
   