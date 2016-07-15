using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SmartPlugApp
{
    [Activity(Label = "Smart Plug App", MainLauncher = true, Icon = "@drawable/icon")]
    public class LoginActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Login);

            var loginButton = this.FindViewById<Button>(Resource.Id.loginButton);
            loginButton.Click += delegate { loginButton.Text = $"Login clicked @ {DateTime.Now}"; }; 
        }
    }
}