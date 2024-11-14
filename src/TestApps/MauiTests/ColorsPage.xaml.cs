using Esri.Calcite.Maui;

namespace MauiTests;

public partial class ColorsPage : ContentPage
{
    private static List<ColorEntry>? colors;

    public ColorsPage()
    {
        InitializeComponent();
        LoadIcons();
    }

    private void LoadIcons()
    {
        if (colors is null)
        {
            ResourceDictionary dic = App.Current!.Resources.MergedDictionaries.OfType<CalciteResources>().First();
            dic = dic.MergedDictionaries.Where(m => m.Source.OriginalString == "Resources/Styles/Brushes.xaml;assembly=Esri.Calcite.Maui").First();
            var dic2 = typeof(ResourceDictionary).GetField("_mergedInstance", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)!.
                GetValue(dic) as ResourceDictionary;
            var colorsDic = dic2!.MergedDictionaries.Where(m => m.Source.OriginalString == "Colors.xaml;assembly=Esri.Calcite.Maui").First();
            colors = new List<ColorEntry>();
            foreach (var key in colorsDic.Keys)
                colors.Add(new ColorEntry() { Name = key, Color = (Color)colorsDic[key] });
        }
        collectionView.ItemsSource = colors;
    }
}
public class ColorEntry
{
    public Color? Color { get; set; }
    public string? Name { get; set; }
}
