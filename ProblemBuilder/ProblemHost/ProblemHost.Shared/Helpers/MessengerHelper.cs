using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ProblemHost
{
    public static class MessengerHelper
    {
        public static void RegisterNavigationMessage(Page page)
        {
            Messenger.Default.Register<NavigationMessage>(page, NavigateToPageType);
        }

        public static void NavigateToPageType(NavigationMessage message)
        {
            // Target page type
            Type targetPageType = message.TargetPageType;

            // Get current frame
            var frame = (Frame)Window.Current.Content;

            // Set the frame source, which initiates navigation
            frame.Navigate(targetPageType);
        }

        public static void UnRegisterNavigationMessage(Page page)
        {
            Messenger.Default.Unregister<NavigationMessage>(page, NavigateToPageType);
        }
    }
}
