using BottlingCalculator.Core.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;

namespace BottlingCalculator.iOS.Views
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class HomeView : MvxViewController
    {
        public HomeView() : base("HomeView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var set = this.CreateBindingSet<HomeView, HomeViewModel>();
            set.Bind(BeerInputTextField).To(vm => vm.BeerInLitres);
            set.Bind(BeerBottlesLabel).To(vm => vm.BeerBottles);
            set.Bind(PintsLabel).To(vm => vm.Pints);
            set.Bind(WineBottlesLabel).To(vm => vm.WineBottles);
            set.Bind(KegsLabel).To(vm => vm.MiniKegs);
            set.Apply();
        }
    }
}

