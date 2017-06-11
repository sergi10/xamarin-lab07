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

namespace PhoneApp
{
    [Activity(Label = "@string/ValidateLab")]
    public class ValidateActivity : Activity
    {
        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.UserDataLayout);

            //Lab06A
            var MessageView = FindViewById<TextView>(Resource.Id.ResultValidationTextView);
            var EmailEntry = FindViewById<TextView>(Resource.Id.emailEntry);
            var PasswordEntry = FindViewById<TextView>(Resource.Id.passwordEntry);
            var ValidateButton = FindViewById<Button>(Resource.Id.ValidateButton);

            var ServiceClient = new SALLab06.ServiceClient();

            ValidateButton.Click += async (object sender, System.EventArgs e) =>
            {
                string myDevice = Android.Provider.Settings.Secure.GetString(ContentResolver, Android.Provider.Settings.Secure.AndroidId);
                var Result = await ServiceClient.ValidateAsync(EmailEntry.Text, PasswordEntry.Text, myDevice);

                MessageView.Text = $"{ Result.Status}\n{ Result.Fullname}\n{ Result.Token}";
               // MessageView.Text = "asdfbib \napshdfaosdnfon\n apsodfna \t 123";
            };
     
        }
    }
}