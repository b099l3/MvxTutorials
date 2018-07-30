using System;
using MvvmCross.ViewModels;

namespace BottlingCalculator.Core.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private double _beerInLitres;
        public double BeerInLitres
        {
            get => _beerInLitres;
            set
            {
                if (SetProperty(ref _beerInLitres, value))
                {
                    RaisePropertyChanged(nameof(BeerBottles));
                    RaisePropertyChanged(nameof(Pints));
                    RaisePropertyChanged(nameof(WineBottles));
                    RaisePropertyChanged(nameof(MiniKegs));
                }
            }
        }

        public string BeerBottles => $"{Math.Round(BeerInLitres / 330, 2)} - beer bottles";

        public string Pints => $"{Math.Round(BeerInLitres / 568, 2)} -  pints";

        public string WineBottles => $"{Math.Round(BeerInLitres / 750, 2)} - wine bottles";

        public string MiniKegs => $"{Math.Round(BeerInLitres / 5000, 2)} - mini kegs";
    }
}