using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Nfc;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoTestSolution.Droid
{
    [Activity(Label = "Mono",Theme = "@style/MainTheme.Splash", MainLauncher = true,NoHistory = true)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
           
            // Create your application here
        }

        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }


        async void SimulateStartup()
        {
           
            await Task.Delay(2000); // Simulate a bit of startup work
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}