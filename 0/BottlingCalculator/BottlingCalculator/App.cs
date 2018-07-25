using MvvmCross.ViewModels;
using BottlingCalculator.ViewModels;

namespace BottlingCalculator
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<HomeViewModel>();
        }
    }
}