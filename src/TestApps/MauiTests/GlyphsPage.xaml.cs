using Esri.Calcite.Maui;

namespace MauiTests;

public partial class GlyphsPage : ContentPage
{
    private static List<KeyValuePair<string, object>>? glyphs;

    public GlyphsPage()
    {
        InitializeComponent();
        LoadIcons();
    }

    private void LoadIcons()
    {
        if (glyphs is null)
        {
            ResourceDictionary dic = App.Current.Resources.MergedDictionaries.OfType<CalciteResources>().First();
            dic = dic.MergedDictionaries.Where(m => m.Source.OriginalString == "Resources/Icons/Glyphs.xaml;assembly=Esri.Calcite.Maui").First();
            glyphs = new List<KeyValuePair<string, object>>(dic.Count);
            foreach (var key in dic.Keys)
            {
                glyphs.Add(new KeyValuePair<string, object>(key, dic[key]));
            }
        }
        collectionView.ItemsSource =  glyphs;
    }

    private void search_TextChanged(object sender, TextChangedEventArgs e)
    {
        
    }
}