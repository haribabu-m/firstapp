﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace SmartPlugApp
{
    [Activity(Label = "Smart Plug App", Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++);
                if (button.Text.StartsWith("5"))
                {
                    var intent = new Intent();
                    intent.SetClass(this, typeof(LoginActivity));
                    StartActivity(intent);
                }
            };
        }
    }
}

