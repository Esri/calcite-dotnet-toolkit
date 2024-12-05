using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System;

namespace WinUITests
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.ExtendsContentIntoTitleBar = true;
            WinUIEx.WindowManager.Get(this).PersistenceId = "MainWindow";
            this.SystemBackdrop = new MicaBackdrop();
            NavView.SelectedItem = NavView.MenuItems[0];
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            var ison = ((ToggleSwitch)sender).IsOn;
            (this.Content as FrameworkElement).RequestedTheme = ison ? ElementTheme.Dark : ElementTheme.Light;
        }

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                //contentFrame.Navigate(typeof(SampleSettingsPage));
            }
            else
            {
                var selectedItem = (Microsoft.UI.Xaml.Controls.NavigationViewItem)args.SelectedItem;
                if (selectedItem != null)
                {
                    string selectedItemTag = ((string)selectedItem.Tag);
                    sender.Header = selectedItem.Content?.ToString();
                    string pageName = "WinUITests.Samples." + selectedItemTag;
                    Type pageType = Type.GetType(pageName);
                    if (pageType is not null)
                        contentFrame.Navigate(pageType);
                    else
                    {
                        sender.Header = null;
                        contentFrame.Navigate(typeof(Samples.HomePage));
                    }
                }
            }
        }

        private void TitleBar_PaneToggleRequested(WinUIEx.TitleBar sender, object args)
        {
            NavView.IsPaneOpen = !NavView.IsPaneOpen;
        }
    }
}
