rmdir GeneratedResources /S /Q
dotnet msbuild /t:GenerateFont Tools\ResourceGenerator\ResourceGenerator.csproj
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-ui-icons\docs\icons.json Tools\calcite-ui-icons-codepoints.json calcite-colors\dist\colors.scss GeneratedResources\WPF WPF
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-ui-icons\docs\icons.json Tools\calcite-ui-icons-codepoints.json calcite-colors\dist\colors.scss GeneratedResources\Maui Maui
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-ui-icons\docs\icons.json Tools\calcite-ui-icons-codepoints.json calcite-colors\dist\colors.scss GeneratedResources\WinUI WinUI
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-ui-icons\docs\icons.json Tools\calcite-ui-icons-codepoints.json calcite-colors\dist\colors.scss GeneratedResources\UWP UWP