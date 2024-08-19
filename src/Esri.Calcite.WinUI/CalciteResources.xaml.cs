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

    public static ResourceDictionary GetStyleResources(DependencyObject obj)
    {
        return (ResourceDictionary)obj.GetValue(StyleResourcesProperty);
    }

    public static void SetStyleResources(DependencyObject obj, ResourceDictionary value)
    {
        obj.SetValue(StyleResourcesProperty, value);
    }

    public static readonly DependencyProperty StyleResourcesProperty =
        DependencyProperty.RegisterAttached("StyleResources", typeof(ResourceDictionary), typeof(CalciteResources),
            new PropertyMetadata(null, (s, e) => OnStyleResourcesChanged(s, e.OldValue as ResourceDictionary, e.NewValue as ResourceDictionary)));

    private static void OnStyleResourcesChanged(DependencyObject s, ResourceDictionary? oldDictionary, ResourceDictionary? newDictionary)
    {
        if (s is FrameworkElement element)
        {
            if (newDictionary is not null)
            {
                ResourceDictionary rd = new ResourceDictionary(); // Clone the dictionary
                foreach (var r in newDictionary)
                    rd.Add(r);
                element.Resources.MergedDictionaries.Add(rd);
            }
        }
    }
}
