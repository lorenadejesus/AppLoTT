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
    public partial class InstructorCitas : ContentPage
    {
        public InstructorCitas()
        {
            InitializeComponent();
            
        }

        private void cancelar_Clicked(object sender, EventArgs e)
        {

        }
    }
}