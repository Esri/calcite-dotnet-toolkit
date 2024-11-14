using Esri.Calcite.Maui;

namespace MauiTests;

public partial class GlyphsPage : ContentPage
{
    private static List<Glyph>? glyphs;

    public GlyphsPage()
    {
        InitializeComponent();
        LoadIcons();
    }

    private void LoadIcons()
    {
        if (glyphs is null)
        {
            ResourceDictionary dic = App.Current!.Resources.MergedDictionaries.OfType<CalciteResources>().First();
            dic = dic.MergedDictionaries.Where(m => m.Source.OriginalString == "Resources/Icons/Glyphs.xaml;assembly=Esri.Calcite.Maui").First();
            glyphs = new List<Glyph>(dic.Count);
            foreach (var key in dic.Keys)
            {
                glyphs.Add(new Glyph() { Name = key, Value = dic[key] });
            }
        }
        collectionView.ItemsSource =  glyphs;
    }

    private void search_TextChanged(object sender, TextChangedEventArgs e)
    {
        
    }
}
public class Glyph
{
    public string? Name { get; set; }
    public object? Value { get; set; }

}