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
    public sealed partial class UIIconsPage : Page
    {
        List<IconEntry> icons = new List<IconEntry>();
        public UIIconsPage()
        {
            this.InitializeComponent();
            icons = new List<IconEntry>();
            foreach (var i in Enum.GetValues(typeof(CalciteIcon)))
            {
                icons.Add(new IconEntry() { Icon = (CalciteIcon)i });
            }
            gridView.ItemsSource = icons;
        }

        private void OnFilterKeyDown(object sender, KeyRoutedEventArgs e)
        {
            if(e.Key == Windows.System.VirtualKey.Enter)
            {
                gridView.ItemsSource = icons.Where(i => i.Name.Contains(search.Text.Trim(), StringComparison.InvariantCultureIgnoreCase));
            }
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
