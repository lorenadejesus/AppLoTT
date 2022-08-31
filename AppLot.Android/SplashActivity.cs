using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppLot.Droid
{
    [Activity(Theme = "@style/Splash", MainLauncher = true, NoHistory = true, Label = "Gestión de citas")]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(600);
            StartActivity(new Intent(Application.Context,typeof(MainActivity)));
            // Create your application here
        }
    }
}