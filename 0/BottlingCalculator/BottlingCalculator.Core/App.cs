using MvvmCross.ViewModels;
using BottlingCalculator.Core.ViewModels;

namespace BottlingCalculator.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<HomeViewModel>();
        }
    }
}
