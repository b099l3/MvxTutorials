using Android.App;
using Android.Content.PM;
using BottlingCalculator.Core;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.Platforms.Android.Views;

namespace BottlingCalculator.Droid
{
    [Activity(
        Label = "BottlingCalculator"
        , MainLauncher = true
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity<MvxAndroidSetup<App>, App>
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}