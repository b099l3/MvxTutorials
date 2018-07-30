using BottlingCalculator.Core;
using Foundation;
using MvvmCross.Platforms.Ios.Core;

namespace BottlingCalculator.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
    }
}
