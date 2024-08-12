using System.Windows;

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                     //(used if a resource is not found in the page,
                                     // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                              //(used if a resource is not found in the page,
                                              // app, or any theme specific resource dictionaries)
)]
[assembly: System.Windows.Markup.XmlnsPrefix("http://schemas.esri.com/calcite/2024", "calcite")]
[assembly: System.Windows.Markup.XmlnsDefinition("http://schemas.esri.com/calcite/2024", "Esri.Calcite.WPF")]
[assembly: System.Windows.Markup.XmlnsDefinition("http://schemas.esri.com/calcite/2024", "Esri.Calcite.WPF.Helpers")]
