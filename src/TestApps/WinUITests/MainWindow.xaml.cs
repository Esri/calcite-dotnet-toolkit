// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Esri.Calcite.WinUI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace WinUITests
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.SystemBackdrop = new MicaBackdrop();
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
                }
            }
        }
    }
}
