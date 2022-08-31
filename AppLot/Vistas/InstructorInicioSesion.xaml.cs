using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AppLot.Datos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLot.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InstructorInicioSesion : ContentPage
    {
        public InstructorInicioSesion()
        {
            InitializeComponent();
            btnIniciarInst.Clicked += BtnIniciarAdmin_Clicked;
            btnOlvi.Clicked += BtnOlvi_Clicked;
        }

        private void BtnIniciarAdmin_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(correoElectronico.Text) || !string.IsNullOrWhiteSpace(contrasena.Text) ||
                !string.IsNullOrEmpty(correoElectronico.Text) || !string.IsNullOrEmpty(contrasena.Text))
            {
                InstructorUNO crudinstructor = InstructorDADO.BuscarUsuario(correoElectronico.Text, contrasena.Text);
                if (validateProperties() == "Of")
                {
                    DisplayAlert("Alerta", "Debes ingresar los datos solicitados.", "Aceptar");

                }
                else if (contrasena.Text.Length > 8 && contrasena.Text.Length < 16)
                {
                    DisplayAlert("Alerta", "La contraseña debe tener entre 8 y 16 caracteres.", "Aceptar");
                    contrasena.TextColor = Color.IndianRed;
                    contrasena.IsVisible = true;
                }
                else if (esEmail() == "Of")
                {
                    DisplayAlert("Alerta", "El formato del correo electrónico es incorrecto.", "Aceptar");
                    correoElectronico.TextColor = Color.IndianRed;
                    correoElectronico.IsVisible = true;
                }
                else if(crudinstructor != null)
                {
                    Navigation.PushAsync(new Vistas.Instructor());
                    LimpiarFormulario();
                }
                else { 
                    DisplayAlert("MAL!!!", "No existe", "ok");
                    LimpiarFormulario();
                }
            }
            else
            {
                DisplayAlert("Campos vacios", "Debes introducir datos", "Entendido");
            }//if princ
        }

        private void BtnOlvi_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Olv_contra());
        }

        void LimpiarFormulario()
        {
            correoElectronico.Text = "";
            contrasena.Text = "";

        }
        string validateProperties()
        {
            string result = null;
            if ((string.IsNullOrWhiteSpace(correoElectronico.Text)) || (string.IsNullOrWhiteSpace(contrasena.Text)) ||
                (string.IsNullOrEmpty(correoElectronico.Text)) || (string.IsNullOrEmpty(contrasena.Text)))
            {
                result = "Of";
            }
            else
            {
                result = "Ok";
            }
            return result;
        }
        string esEmail()
        {
            string email = null;
            bool isEmail = Regex.IsMatch(correoElectronico.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!isEmail)
            {
                email = "Of";
            }
            else
            {
                email = "Ok";
            }
            return email;
        }

    }
}
