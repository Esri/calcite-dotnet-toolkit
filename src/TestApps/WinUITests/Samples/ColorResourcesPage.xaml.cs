using Esri.Calcite.WinUI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;
using System.Linq;
using Windows.ApplicationModel.DataTransfer;

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
            List<ColorItem> items = rdLight.OrderBy(r => r.Key).Concat(rd.OrderBy(r => r.Key)).Select(r => new ColorItem() { Key = (string)r.Key, LightValue = (Windows.UI.Color)r.Value, DarkValue = (Windows.UI.Color)r.Value }).ToList(); //ToList to avoid exception in AoT mode;==
            foreach(var item in rdDark)
            {
                items.First(f => f.Key == (string)item.Key).DarkValue = (Windows.UI.Color)item.Value;
            }
            gridView3.ItemsSource = items;
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            var color = (sender as FrameworkElement).DataContext as ColorItem;
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(color.Markup);
            Clipboard.SetContent(dataPackage);
        }
    }

    public class ColorItem
    {
        public string Key { get; set; }
        public Windows.UI.Color LightValue { get; set; }
        public Windows.UI.Color DarkValue { get; set; }
        public string Markup
        {
            get
            {
                if (LightValue != DarkValue)
                    return $"{{ThemeResource {Key}}}";
                else
                    return $"{{StaticResource {Key}}}";
            }
        }
    }
}
