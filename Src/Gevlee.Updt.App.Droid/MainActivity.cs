using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using com.refractored.fab;

namespace Gevlee.Updt.App.Droid
{
    [Activity(Label = "Updt", MainLauncher = true, Icon = "@drawable/ic_launcher", Theme = "@style/AppTheme")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);


            var listView = FindViewById<ListView>(Resource.Id.list);
            var fab = FindViewById<FloatingActionButton>(Resource.Id.fab);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

