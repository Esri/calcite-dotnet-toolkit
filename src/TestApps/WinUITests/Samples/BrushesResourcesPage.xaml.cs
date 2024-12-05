using Esri.Calcite.WinUI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using System.Linq;
using Windows.ApplicationModel.DataTransfer;

namespace WinUITests.Samples
{
    public sealed partial class BrushesResourcesPage : Page
    {
        public BrushesResourcesPage()
        {
            this.InitializeComponent();
            var calciteResource = App.Current.Resources.MergedDictionaries.OfType<XamlControlsResources>().First().MergedDictionaries.OfType<CalciteResources>().First();
            var rd = calciteResource.MergedDictionaries.Where(m => m.Source.OriginalString == "ms-appx:///Esri.Calcite.WinUI/Colors/Brushes.xaml")?.First();
            gridView.ItemsSource = (rd.ThemeDictionaries.First().Value as ResourceDictionary).OrderBy(r => r.Key).Select(r=>new BrushItem() {  Key = (string)r.Key, Value = (Brush)r.Value }).ToList(); //ToList to avoid exception in AoT mode
        }

        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            var brush = (sender as FrameworkElement).DataContext as BrushItem;
            DataPackage dataPackage = new DataPackage();
            dataPackage.SetText(brush.Markup);
            Clipboard.SetContent(dataPackage);
        }
    }

    public class BrushItem
    {
        public string Key { get; set; }
        public Brush Value { get; set; }
        public string Markup => $"{{StaticResource {Key}}}";
    }
}
