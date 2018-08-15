using Android.App;
using Android.Content.PM;
using BottlingCalculator.Core;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace BottlingCalculator.Droid
{
    [Activity(
        Label = "BottlingCalculator",
        Theme = "@style/MainTheme",
        MainLauncher = true,
        NoHistory = true,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenAppCompatActivity<MvxAppCompatSetup<App>, App>
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}