using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace Esri.Calcite.WinUI;

/// <summary>
/// Containes the collection of Calcite resources that can be used in a WinUI application.
/// </summary>
public sealed partial class CalciteResources : ResourceDictionary
{
    internal static Microsoft.UI.Xaml.Media.FontFamily CalciteUIFont_Small = new Microsoft.UI.Xaml.Media.FontFamily("ms-appx:///Esri.Calcite.WinUI/Fonts/calcite-ui-icons-16.ttf#calcite-ui-icons-16");
    internal static Microsoft.UI.Xaml.Media.FontFamily CalciteUIFont_Medium = new Microsoft.UI.Xaml.Media.FontFamily("ms-appx:///Esri.Calcite.WinUI/Fonts/calcite-ui-icons-24.ttf#calcite-ui-icons-24");
    internal static Microsoft.UI.Xaml.Media.FontFamily CalciteUIFont_Large = new Microsoft.UI.Xaml.Media.FontFamily("ms-appx:///Esri.Calcite.WinUI/Fonts/calcite-ui-icons-32.ttf#calcite-ui-icons-32");

    /// <summary>
    /// Initializes a new instance of the <see cref="CalciteResources"/> class.
    /// </summary>
    public CalciteResources()
    {
        this.InitializeComponent();
    }

    /// <summary>
    /// Gets additional style resources for the specified <see cref="DependencyObject"/>.
    /// </summary>
    /// <param name="obj">The depenency object to get resources from.</param>
    /// <returns>Resource dictionary attached to the object.</returns>
    public static ResourceDictionary GetStyleResources(DependencyObject obj)
    {
        return (ResourceDictionary)obj.GetValue(StyleResourcesProperty);
    }

    /// <summary>
    /// Sets additional style resources for the specified <see cref="DependencyObject"/>.
    /// </summary>
    /// <param name="obj">The depenency object to set resources on.</param>
    /// <param name="value">The resource dictionary to attach</param>
    public static void SetStyleResources(DependencyObject obj, ResourceDictionary value)
    {
        obj.SetValue(StyleResourcesProperty, value);
    }

    /// <summary>
    /// Identifies the <c>StyleResources</c> attached property.
    /// </summary>
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
