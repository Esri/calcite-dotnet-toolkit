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
    public sealed partial class ColorResourcesPage : Page
    {
        public ColorResourcesPage()
        {
            this.InitializeComponent();
            var calciteResource = App.Current.Resources.MergedDictionaries.OfType<XamlControlsResources>().First().MergedDictionaries.OfType<CalciteResources>().First();
            var rd = calciteResource.MergedDictionaries.Where(m => m.Source.OriginalString == "ms-appx:///Esri.Calcite.WinUI/Colors/Colors.xaml")?.First();
            var rdDark = ((ResourceDictionary)rd.ThemeDictionaries["Default"]);
            var rdLight = ((ResourceDictionary)rd.ThemeDictionaries["Light"]);
            gridView.ItemsSource = rdLight.OrderBy(r => r.Key).Concat(rd.OrderBy(r=>r.Key));
            gridView2.ItemsSource = rdDark.OrderBy(r => r.Key).Concat(rd.OrderBy(r => r.Key));
        }
    }
}
