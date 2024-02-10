using Esri.Calcite.Maui;

namespace MauiTests;

public partial class ColorsPage : ContentPage
{
    private static List<ColorEntry>? darkColors;
    private static List<ColorEntry>? lightColors;

    public ColorsPage()
    {
        InitializeComponent();
        LoadIcons();
    }

    private void LoadIcons()
    {
        if (darkColors is null)
        {
            ResourceDictionary dic = App.Current.Resources.MergedDictionaries.OfType<CalciteResources>().First();
            dic = dic.MergedDictionaries.Where(m => m.Source.OriginalString == "Resources/Styles/Styles.xaml;assembly=Esri.Calcite.Maui").First();
            var dic2 = typeof(ResourceDictionary).GetField("_mergedInstance", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).
                GetValue(dic) as ResourceDictionary;
            var dark = dic2.MergedDictionaries.Where(m => m.Source.OriginalString == "Colors.Dark.xaml;assembly=Esri.Calcite.Maui").First();
            var light = dic2.MergedDictionaries.Where(m => m.Source.OriginalString == "Colors.Light.xaml;assembly=Esri.Calcite.Maui").First();
            darkColors = new List<ColorEntry>();
            foreach (var key in dark.Keys)
                darkColors.Add(new ColorEntry() { Name = key, Color= (Color)dark[key] });
            lightColors = new List<ColorEntry>();
            foreach (var key in light.Keys)
                lightColors.Add(new ColorEntry() { Name = key, Color = (Color)light[key] });
        }
        collectionView.ItemsSource = darkColors;
        collectionView2.ItemsSource = lightColors;
    }

    public class ColorEntry
    {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}