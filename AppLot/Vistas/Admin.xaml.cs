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
    public partial class Admin : ContentPage
    {
        public Admin()
        {
            InitializeComponent();
            BtnVerC.Clicked += BtnVerC_Clicked;
            BtnGenC.Clicked += BtnGenC_Clicked;
            BtnAjustes.Clicked += BtnAjustes_Clicked;

        }

       

        private void BtnVerC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminCitas());
        }

        private void BtnGenC_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminAgendar());
        }
        private void BtnAjustes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdminPerfil());
        }

    }
}