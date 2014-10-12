using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using MPDS.Problem.Builder;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace ProblemHost.ViewModel
{
    public class HackerRankViewModel:ViewModelBase
    {
        public List<Problem> Problems
        {
            get;
            set;
        }

        public Problem SelectedProblem
        {
            get;
            set;
        }

        public bool CanEvaluate
        {
            get
            {
                return SelectedProblem != null;
            }
        }

        public ICommand NavigateBackToMainCommand
        {
            get
            {
                return new RelayCommand(NavigateBackToMainPage);
            }
        }

        public ICommand EvaluateProblemCommand
        {
            get
            {
                return new RelayCommand(EvaluateProblem);
            }
        }

        private void NavigateBackToMainPage()
        {
            Messenger.Default.Send<NavigationMessage>(new NavigationMessage() { TargetPageType = typeof(MainPage) });
        }

        private void EvaluateProblem()
        {

        }

    }
}
