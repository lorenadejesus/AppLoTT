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
    public partial class InstructorPerfil : ContentPage
    {
        public InstructorPerfil()
        {
            InitializeComponent();
            BtnCerrar.Clicked += BtnCerrar_Clicked;
            BtnAct.Clicked += BtnAct_Clicked;
            BtnCitas.Clicked += BtnCitas_Clicked;
            BtnHome.Clicked += BtnHome_Clicked;
            BtnAgendar.Clicked += BtnAgendar_Clicked;
            BtnConfiguracion.Clicked += BtnConfiguracion_Clicked;
        }

        private void BtnAgendar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstructorAgendar());
        }

        private void BtnCerrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void BtnHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Instructor());
        }

        private void BtnCitas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstructorCitas());
        }

        private void BtnConfiguracion_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstructorConfig());
        }

        private void BtnAct_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstructorActividad());
        }




    }
}