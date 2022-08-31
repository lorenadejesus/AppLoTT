using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLot.Datos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppLot.Vistas;

namespace AppLot.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InstructorRegistro : ContentPage
    {
        public InstructorRegistro()
        {
            InitializeComponent();
            btnGuardar.Clicked += BtnGuardar_Clicked;
        }
        private void BtnGuardar_Clicked(object sender, EventArgs e)
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
                municipio = this.municipio.Text,
                codigoPostal = this.municipio.Text

            };

            if (InstructorDADO.Create_instructor(instructor))
            {

                DisplayAlert("Informacion", "Registro exitoso", "OK");
                LimpiarFormulario();
            }
            else

                DisplayAlert("Informacion", "No se puede registrar", "OK");
        }
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
            codigoPostal.Text = "";
        }
    }
}