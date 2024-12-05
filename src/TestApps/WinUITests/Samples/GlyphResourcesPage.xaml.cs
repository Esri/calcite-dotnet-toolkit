// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Esri.Calcite.WinUI;
using Microsoft.UI.Xaml.Controls;
using System.Linq;

namespace WinUITests.Samples
{
    public sealed partial class GlyphResourcesPage : Page
    {
        public GlyphResourcesPage()
        {
            this.InitializeComponent();
            var calciteResource = App.Current.Resources.MergedDictionaries.OfType<XamlControlsResources>().First().MergedDictionaries.OfType<CalciteResources>().First();
            var rd = calciteResource.MergedDictionaries.Where(m => m.Source.OriginalString == "ms-appx:///Esri.Calcite.WinUI/Icons/Glyphs.xaml")?.First();
            gridView.ItemsSource = rd.Select(r=>new GlyphItem() {  Key = r.Key as string, Glyph = r.Value as string }).ToList(); //ToList to avoid exception in AoT mode;
        }
    }
    public class GlyphItem
    {
        public string Key { get; set; }
        public string Glyph { get; set; }
        public string Markup => $"{{StaticResource {Key}}}";
    }
}
