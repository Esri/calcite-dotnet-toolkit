using Esri.Calcite.Maui;

namespace MauiTests;

public partial class BrushesPage : ContentPage
{
    private static List<BrushEntry>? brushes;

    public BrushesPage()
    {
        InitializeComponent();
        LoadIcons();
    }

    private void LoadIcons()
    {
        if (brushes is null)
        {
            ResourceDictionary dic = App.Current.Resources.MergedDictionaries.OfType<CalciteResources>().First();
            var brushDic = dic.MergedDictionaries.Where(m => m.Source.OriginalString == "Resources/Styles/Brushes.xaml;assembly=Esri.Calcite.Maui").First();
            brushes = new List<BrushEntry>();
            foreach (var key in brushDic.Keys)
                brushes.Add(new BrushEntry() { Name = key, Brush= (Brush)brushDic[key] });
        }
        collectionView.ItemsSource = brushes;
    }

    public class BrushEntry
    {
        public Brush Brush { get; set; }
        public string Name { get; set; }
    }
}