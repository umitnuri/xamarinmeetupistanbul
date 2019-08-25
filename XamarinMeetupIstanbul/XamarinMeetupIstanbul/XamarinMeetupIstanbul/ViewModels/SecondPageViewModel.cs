using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace XamarinMeetupIstanbul.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Second Page";
        }
        public DelegateCommand GoBack 
            => new DelegateCommand(async ()=>await NavigationService.GoBackAsync());
    }
}
