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

namespace WinUITests.Samples
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ColorResourcesPage : Page
    {
        public ColorResourcesPage()
        {
            this.InitializeComponent();
            var calciteResource = App.Current.Resources.MergedDictionaries.OfType<CalciteResources>().First();
            var rd = calciteResource.MergedDictionaries.Where(m => m.Source.OriginalString == "ms-appx:///Esri.Calcite.WinUI/Styles/Colors.xaml")?.First();
            var rdLight = rd.ThemeDictionaries.Values.OfType<ResourceDictionary>().Where(m => m.Source.OriginalString == "ms-appx:///Esri.Calcite.WinUI/Styles/Colors.Light.xaml")?.First();
            var rdDark = rd.ThemeDictionaries.Values.OfType<ResourceDictionary>().Where(m => m.Source.OriginalString == "ms-appx:///Esri.Calcite.WinUI/Styles/Colors.Dark.xaml")?.First();
            gridView.ItemsSource = rdLight;
            gridView2.ItemsSource = rdDark;
        }
    }
}
