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
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;

namespace WinUITests.Samples
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UIIconsPage : Page
    {
        List<IconEntry> icons = new List<IconEntry>();
        public UIIconsPage()
        {
            this.InitializeComponent();
            icons = new List<IconEntry>();
            foreach (var i in Enum.GetValues<CalciteIcon>())
            {
                icons.Add(new IconEntry() { Icon = (CalciteIcon)i });
            }
            gridView.ItemsSource = icons;
        }

        private void OnFilterKeyDown(object sender, KeyRoutedEventArgs e)
        {
            if(e.Key == Windows.System.VirtualKey.Enter)
            {
                gridView.ItemsSource = icons.Where(i => i.Name.Contains(search.Text.Trim(), StringComparison.InvariantCultureIgnoreCase)).ToList();
            }
        }

        private void CopyHexCode_Click(object sender, RoutedEventArgs e)
        {
            var icon = (sender as FrameworkElement).DataContext as IconEntry;
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(icon.GlyphHex);
            Clipboard.SetContent(dataPackage);
        }

        private void CopyName_Click(object sender, RoutedEventArgs e)
        {
            var icon = (sender as FrameworkElement).DataContext as IconEntry;
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(icon.Name);
            Clipboard.SetContent(dataPackage);
        }

        private void CopyIconSource_Click(object sender, RoutedEventArgs e)
        {
            var icon = (sender as FrameworkElement).DataContext as IconEntry;
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText($"{{cal:CalciteIconSource Icon={Name}, Scale=Small, SymbolSize=16}}");
            Clipboard.SetContent(dataPackage);
        }

        private void CopyIconSourceElement_Click(object sender, RoutedEventArgs e)
        {
            var icon = (sender as FrameworkElement).DataContext as IconEntry;
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText($"{{cal:CalciteIconSourceElement Icon={Name}, Scale=Small, SymbolSize=16}}");
            Clipboard.SetContent(dataPackage);
        }

        private void CopySymbolIcon_Click(object sender, RoutedEventArgs e)
        {
            var icon = (sender as FrameworkElement).DataContext as IconEntry;
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText($"<cal:SymbolIcon Symbol=\"{icon.Name}\" IconScale=\"Large\" />");
            Clipboard.SetContent(dataPackage);
        }
    }

    public class IconEntry
    {
        public CalciteIcon Icon { get; set; }
        public string Glyph => ((char)(GlyphId)).ToString();
        public string GlyphHex => $"&#x{GlyphId.ToString("x2")};";
        public int GlyphId => (int)Icon;
        public string Name => Icon.ToString();
        
    }
}
