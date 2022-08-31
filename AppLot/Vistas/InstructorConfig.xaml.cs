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
    public partial class InstructorConfig : ContentPage
    {
       
        public InstructorConfig()
        {
            InitializeComponent();
            
            btnActualizar.Clicked += btnActualizar_Clicked;
            btnEliminar.Clicked += btnEliminar_Clicked;

        }
       
        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            if (InstructorDADO.Delete_instructor(correoElectronico.Text))
            {
                DisplayAlert("Info", "Cuenta Eliminada", "OK");
                Navigation.PopToRootAsync();
            }
            else
                DisplayAlert("INFO", "ERROR", "OK");
            
        }
        //--------------------------------------------------------
        private void btnActualizar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nombre.Text) || !string.IsNullOrWhiteSpace(apellidoPA.Text) ||
                !string.IsNullOrWhiteSpace(apellidoMA.Text) || !string.IsNullOrWhiteSpace(edad.Text) ||
                !string.IsNullOrWhiteSpace(correoElectronico.Text) || !string.IsNullOrWhiteSpace(contrasena.Text) ||
                !string.IsNullOrWhiteSpace(calle.Text) || !string.IsNullOrWhiteSpace(numInterior.Text) ||
                !string.IsNullOrWhiteSpace(numExterior.Text) || !string.IsNullOrWhiteSpace(colonia.Text) ||
                !string.IsNullOrWhiteSpace(municipio.Text) || !string.IsNullOrEmpty(nombre.Text) ||
                !string.IsNullOrEmpty(apellidoPA.Text) || !string.IsNullOrEmpty(apellidoMA.Text) ||
                !string.IsNullOrEmpty(edad.Text) || !string.IsNullOrEmpty(correoElectronico.Text) ||
                !string.IsNullOrEmpty(contrasena.Text) || !string.IsNullOrEmpty(calle.Text) ||
                !string.IsNullOrEmpty(numInterior.Text) || !string.IsNullOrEmpty(numExterior.Text) ||
                !string.IsNullOrEmpty(colonia.Text) || !string.IsNullOrEmpty(municipio.Text))
            {
                InstructorUNO instructor = new InstructorUNO
                {
                    edad = Int16.Parse(this.edad.Text),
                    nombre = nombre.Text,
                    correoElectronico = this.correoElectronico.Text,
                    contrasena = this.contrasena.Text,
                    apellidoPa = this.apellidoPA.Text,
                    apellidoMa = this.apellidoPA.Text,
                    calle = this.calle.Text,
                    numExterior = this.numExterior.Text,
                    numInterior = this.numInterior.Text,
                    colonia = this.colonia.Text,
                    municipio = this.municipio.Text
                };
                //validacioNES

                if (validateProperties() == "Of")
                {
                    DisplayAlert("Alerta", "Debes ingresar los datos solicitados.", "Aceptar");

                }
                else if (nombre.Text.Contains("0") || nombre.Text.Contains("1") || nombre.Text.Contains("2") || nombre.Text.Contains("3") ||
                nombre.Text.Contains("4") || nombre.Text.Contains("5") || nombre.Text.Contains("6") || nombre.Text.Contains("7") ||
                nombre.Text.Contains("8") || nombre.Text.Contains("9"))
                {
                    DisplayAlert("Alerta", "El nombre contiene números.", "Aceptar");
                    nombre.TextColor = Color.IndianRed;
                    nombre.IsVisible = true;
                }
                else if (apellidoPA.Text.Contains("0") || apellidoPA.Text.Contains("1") || apellidoPA.Text.Contains("2") || apellidoPA.Text.Contains("3") ||
                apellidoPA.Text.Contains("4") || apellidoPA.Text.Contains("5") || apellidoPA.Text.Contains("6") || apellidoPA.Text.Contains("7") ||
                apellidoPA.Text.Contains("8") || apellidoPA.Text.Contains("9"))
                {
                    DisplayAlert("Alerta", "El apellido paterno contiene números.", "Aceptar");
                    apellidoPA.TextColor = Color.IndianRed;
                    apellidoPA.IsVisible = true;
                }
                else if (apellidoMA.Text.Contains("0") || apellidoMA.Text.Contains("1") || apellidoMA.Text.Contains("2") || apellidoMA.Text.Contains("3") ||
                apellidoMA.Text.Contains("4") || apellidoMA.Text.Contains("5") || apellidoMA.Text.Contains("6") || apellidoMA.Text.Contains("7") ||
                apellidoMA.Text.Contains("8") || apellidoMA.Text.Contains("9"))
                {
                    DisplayAlert("Alerta", "El apellido materno contiene números.", "Aceptar");
                    apellidoMA.TextColor = Color.IndianRed;
                    apellidoMA.IsVisible = true;
                }
                else if (contrasena.Text.Length > 8 && contrasena.Text.Length < 16)
                {
                    DisplayAlert("Alerta", "La contraseña debe tener entre 8 y 16 caracteres.", "Aceptar");
                    contrasena.TextColor = Color.IndianRed;
                    contrasena.IsVisible = true;
                }
                else if (edad.Text.Length != 2)
                {
                    DisplayAlert("Alerta", "No es mayor de edad", "Aceptar");
                    edad.TextColor = Color.IndianRed;
                    edad.IsVisible = true;

                }
                else if (esEmail() == "Of")
                {
                    DisplayAlert("Alerta", "El formato del correo electrónico es incorrecto.", "Aceptar");
                    correoElectronico.TextColor = Color.IndianRed;
                    correoElectronico.IsVisible = true;
                }
                else if(InstructorDADO.update_instructor(instructor))
                {

                    DisplayAlert("Informacion", "Actualizacion exitosa", "OK");
                }
                else
                {

                    DisplayAlert("Informacion", "No se puede actualizar", "OK");
                }//else secun
            }
            else
            {
                DisplayAlert("Campos vacios", "Debes introducir datos", "Entendido");

            }//else princ
        }//metodo ACTUALIZAR
        void LimpiarFormulario()
        {
            edad.Text = "";
            nombre.Text = "";
            correoElectronico.Text = "";
            contrasena.Text = "";
            apellidoPA.Text = "";
            apellidoMA.Text = "";
            calle.Text = "";
            numExterior.Text = "";
            numInterior.Text = "";
            colonia.Text = "";
            municipio.Text = "";
        }//LIMPIAR FORMULARIO
        string validateProperties()
        {
            string result = null;
            if ((string.IsNullOrWhiteSpace(nombre.Text)) || (string.IsNullOrWhiteSpace(apellidoPA.Text)) ||
                (string.IsNullOrWhiteSpace(apellidoMA.Text)) || (string.IsNullOrWhiteSpace(edad.Text)) ||
                (string.IsNullOrWhiteSpace(correoElectronico.Text)) || (string.IsNullOrWhiteSpace(contrasena.Text)) ||
                (string.IsNullOrWhiteSpace(calle.Text)) || (string.IsNullOrWhiteSpace(numInterior.Text)) ||
                (string.IsNullOrWhiteSpace(numExterior.Text)) || (string.IsNullOrWhiteSpace(colonia.Text)) ||
                (string.IsNullOrWhiteSpace(municipio.Text)) || (string.IsNullOrEmpty(nombre.Text)) ||
                (string.IsNullOrEmpty(apellidoPA.Text)) || (string.IsNullOrEmpty(apellidoMA.Text)) ||
                (string.IsNullOrEmpty(edad.Text)) || (string.IsNullOrEmpty(correoElectronico.Text)) ||
                (string.IsNullOrEmpty(contrasena.Text)) || (string.IsNullOrEmpty(calle.Text)) ||
                (string.IsNullOrEmpty(numInterior.Text)) || (string.IsNullOrEmpty(numExterior.Text)) ||
                (string.IsNullOrEmpty(colonia.Text)) || (string.IsNullOrEmpty(municipio.Text)))
            {
                result = "Of";
            }
            else
            {
                result = "Ok";
            }
            return result;
        }//VAL CAMPOS VACIOS
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
        }//VAL CORREO
    }
}