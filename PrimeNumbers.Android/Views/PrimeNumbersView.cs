using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using PrimeNumbers.Core.ViewModels;

namespace PrimeNumbers.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class PrimeNumbersView : MvxActivity<PrimeNumbersViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            this.SetContentView(Resource.Layout.PrimeNumbersPage);
        }
    }
}