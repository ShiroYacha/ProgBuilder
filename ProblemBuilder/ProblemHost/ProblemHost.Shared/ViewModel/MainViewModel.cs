using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ProblemHost.ViewModel
{
    public class MainViewModel:ViewModelBase
    {
        public ICommand NavigateToHackerRankCommand
        {
            get
            {
                return new RelayCommand(NavigateToHackerRank);
            }
        }

        private void NavigateToHackerRank()
        {
            Messenger.Default.Send<NavigationMessage>(new NavigationMessage() { TargetPageType=typeof(HackerRankPage)});
        }
    }
}
