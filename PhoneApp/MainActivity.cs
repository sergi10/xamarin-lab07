using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading.Tasks;

namespace PhoneApp
{
    [Activity(Label = "Phone App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        static readonly System.Collections.Generic.List<string> PhoneNumbers = new System.Collections.Generic.List<string>();

        protected async override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.UserDataLayout);
            var Intent = new Android.Content.Intent(this, typeof(ValidateActivity));
            StartActivity(Intent);     
        }
    }
}
