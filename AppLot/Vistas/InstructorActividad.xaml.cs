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
    public partial class InstructorActividad : ContentPage
    {
        public InstructorActividad()
        {
            InitializeComponent();
            BtnHomeAd.Clicked += BtnHomeAd_Clicked;
            BtnVerC.Clicked += BtnVerC_Clicked;
            btnAgendarCita.Clicked += BtnAgendarCita_Clicked;



        }
        private void BtnAgendarCita_Clicked(object sender, EventArgs e)
        {
            actividadUNO act = new actividadUNO
            {
               
                nombreActividad = this.nombreActividad.Text,
                dia = (string)this.dia.SelectedItem,
                hora = hora.Time,
                desc = this.desc.Text



            };

            if (actividadesDAO.Create_act(act))
            {

                DisplayAlert("Informacion", "Actividad Registrada", "OK");
                
            }
            else

                DisplayAlert("Informacion", "ERROR!", "OK");
        }



        private void BtnHomeAd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Admin());
        }
        private void BtnVerC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Admin());
        }

        
    }
}