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
        public string Glyph16 => ((char)(GlyphId16)).ToString();
        public string GlyphHex16 => $"&#x{GlyphId16.ToString("x2")};";
        public int GlyphId16 => (int)Icon;
        public string Glyph24 => ((char)(GlyphId24)).ToString();
        public int GlyphId24 => (int)Icon + 1;
        public string GlyphHex24 => $"&#x{GlyphId24.ToString("x2")};";
        public string Glyph32 => ((char)(GlyphId32)).ToString();
        public int GlyphId32 => (int)Icon + 2;
        public string GlyphHex32 => $"&#x{GlyphId32.ToString("x2")};";
        public string Name => Icon.ToString();
    }
}
