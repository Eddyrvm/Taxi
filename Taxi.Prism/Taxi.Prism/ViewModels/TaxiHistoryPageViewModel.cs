﻿using Prism.Navigation;

namespace Taxi.Prism.ViewModels
{
    public class TaxiHistoryPageViewModel : ViewModelBase
    {
        public TaxiHistoryPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Ver Hotorial del Taxi";
        }
    }
}
