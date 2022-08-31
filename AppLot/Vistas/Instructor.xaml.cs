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
    public partial class Instructor : ContentPage
    {
        public Instructor()
        {
            InitializeComponent();
            BtnVerC.Clicked += BtnVerC_Clicked;
            BtnGenC.Clicked += BtnGenC_Clicked;
            BtnAjustes.Clicked += BtnAjustes_Clicked;

        }

       

        private void BtnVerC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstructorCitas());
        }

        private void BtnGenC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstructorAgendar());
        }
        private void BtnAjustes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InstructorPerfil());
        }

    }
}