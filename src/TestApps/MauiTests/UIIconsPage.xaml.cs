using Esri.Calcite.Maui;

namespace MauiTests;

public partial class UIIconsPage : ContentPage
{
    List<IconEntry> icons = new List<IconEntry>();

    public UIIconsPage()
    {
        InitializeComponent();
        icons = new List<IconEntry>();
        foreach (var i in Enum.GetValues(typeof(CalciteIcon)))
        {
            icons.Add(new IconEntry() { Icon = (CalciteIcon)i });
        }
        collectionView.ItemsSource = icons;
    }


    private void search_TextChanged(object sender, TextChangedEventArgs e)
    {
        collectionView.ItemsSource = icons.Where(i => i.Name.Contains(search.Text.Trim(), StringComparison.InvariantCultureIgnoreCase));
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
