using GalaSoft.MvvmLight.Ioc;
using ProblemHost.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemHost.ViewModel
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<HackerRankViewModel>();

        }

        public MainViewModel MainViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainViewModel>();
            }
        }

        public HackerRankViewModel HackerRankViewModel
        {
            get
            {
                return SimpleIoc.Default.GetInstance<HackerRankViewModel>();
            }
        }

    }
}
