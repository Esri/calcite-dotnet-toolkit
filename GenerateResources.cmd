dotnet msbuild /t:GenerateFont Tools\ResourceGenerator\ResourceGenerator.csproj
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-ui-icons\docs\icons.json Tools\calcite-ui-icons-codepoints.json .Generated\WPF WPF
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-ui-icons\docs\icons.json Tools\calcite-ui-icons-codepoints.json .Generated\Maui Maui
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-ui-icons\docs\icons.json Tools\calcite-ui-icons-codepoints.json .Generated\WinUI WinUI
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-ui-icons\docs\icons.json Tools\calcite-ui-icons-codepoints.json .Generated\UWP UWP