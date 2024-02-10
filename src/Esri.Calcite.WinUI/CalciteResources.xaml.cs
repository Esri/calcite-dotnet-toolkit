using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace Esri.Calcite.WinUI;

public sealed partial class CalciteResources : ResourceDictionary
{
    internal static Microsoft.UI.Xaml.Media.FontFamily CalciteUIFont = new Microsoft.UI.Xaml.Media.FontFamily("ms-appx:///Esri.Calcite.WinUI/Fonts/calcite-ui-icons.ttf#calcite-ui-icons");

    public CalciteResources()
    {
        this.InitializeComponent();

        //<x:String x:Key="calcite_glyphicon_2dExplore">&#xe001;</x:String>
        //var values = Enum.GetValues(typeof(Calcite.CalciteIcon));
        //foreach(var icon in values)
        //{
        //    Add("calcite_glyphicon_" + icon.ToString(), IconFileNameConverter.GetGlyph((CalciteIcon)icon));// "&#x" + ((int)icon).ToString("x2"));
        //}
    }
}
