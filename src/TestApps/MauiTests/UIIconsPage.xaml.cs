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