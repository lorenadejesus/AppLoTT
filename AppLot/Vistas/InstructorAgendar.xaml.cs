using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLot.Datos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLot.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InstructorAgendar : ContentPage
    {
        public InstructorAgendar()
        {
            InitializeComponent();
            BtnHomeAd.Clicked += BtnHomeAd_Clicked;
            BtnVerC.Clicked += BtnVerC_Clicked;
            btnAgendarCita.Clicked += BtnAgendarCita_Clicked;

        }

        private void BtnAgendarCita_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nombre.Text) || !string.IsNullOrWhiteSpace(sexo.Text) ||
                !string.IsNullOrWhiteSpace(codigoPostal.Text) || !string.IsNullOrWhiteSpace(edad.Text) ||
                !string.IsNullOrEmpty(nombre.Text) || !string.IsNullOrEmpty(sexo.Text) ||
                !string.IsNullOrEmpty(codigoPostal.Text) || string.IsNullOrEmpty(edad.Text))
            {
                citaUNO cita = new citaUNO
                {
                    edad = Int16.Parse(this.edad.Text),
                    codigoPostal = Int16.Parse(this.codigoPostal.Text),
                    nombre = nombre.Text,
                    sexo = this.sexo.Text,
                    fecha = (Dates.Date)this.fecha.Date,
                    hora = hora.Time,
                    situacion = this.situacion.Text

                };

                //===================000
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

                else if (sexo.Text.Contains("0") || sexo.Text.Contains("1") || sexo.Text.Contains("2") || sexo.Text.Contains("3") ||
                    sexo.Text.Contains("4") || sexo.Text.Contains("5") || sexo.Text.Contains("6") || sexo.Text.Contains("7") ||
                    sexo.Text.Contains("8") || sexo.Text.Contains("9"))
                {
                    DisplayAlert("Alerta", " Sexo no es válido.", "Aceptar");
                    sexo.TextColor = Color.IndianRed;
                    sexo.IsVisible = true;
                }

                else if (edad.Text.Length != 2)
                {
                    DisplayAlert("Alerta", "No es mayor de edad.", "Aceptar");
                    edad.TextColor = Color.IndianRed;
                    edad.IsVisible = true;

                }
                else if (codigoPostal.Text.Length != 5)
                {
                    DisplayAlert("Alerta", "El código postal no es válido.", "Aceptar");
                    codigoPostal.TextColor = Color.IndianRed;
                    codigoPostal.IsVisible = true;

                }

                else if (citaDAO.Create_cita(cita))
                {

                    DisplayAlert("Informacion", "Registro exitoso", "OK");
                    LimpiarFormulario();
                }
                else
                {

                    DisplayAlert("Informacion", "No se puede realizar la cita", "OK");
                }//else secun
            }
            else
            {
                DisplayAlert("Campos vacios", "Debes introducir datos", "Entendido");

            }//IF PRINC
        }//METODO CLICK

        private TimeSpan DateTime(string v)
        {
            throw new NotImplementedException();
        }

        private void BtnVerC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstructorCitas());
        }

        private void BtnHomeAd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Instructor());
        }
        void LimpiarFormulario()
        {
            edad.Text = "";
            codigoPostal.Text = "";
            nombre.Text = "";
            sexo.Text = "";
            situacion.Text = "";
        }
        string validateProperties()
        {
            string result = null;
            if ((string.IsNullOrWhiteSpace(nombre.Text)) || (string.IsNullOrWhiteSpace(sexo.Text)) ||
                (string.IsNullOrWhiteSpace(codigoPostal.Text)) || (string.IsNullOrWhiteSpace(edad.Text)) ||
                (string.IsNullOrWhiteSpace(situacion.Text)) || (string.IsNullOrEmpty(nombre.Text)) ||
                (string.IsNullOrEmpty(sexo.Text)) || (string.IsNullOrEmpty(codigoPostal.Text)) ||
                (string.IsNullOrEmpty(edad.Text)) || (string.IsNullOrEmpty(situacion.Text)))
            {
                result = "Of";
            }
            else
            {
                result = "Ok";
            }
            return result;
        }
    }
}