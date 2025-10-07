rmdir GeneratedResources /S /Q

dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-design-system\packages\calcite-ui-icons\docs\keywords.json calcite-design-system\packages\calcite-ui-icons\fantasticonrc.json calcite-design-system\packages\calcite-design-tokens GeneratedResources\WPF WPF
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-design-system\packages\calcite-ui-icons\docs\keywords.json calcite-design-system\packages\calcite-ui-icons\fantasticonrc.json calcite-design-system\packages\calcite-design-tokens GeneratedResources\Maui Maui
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-design-system\packages\calcite-ui-icons\docs\keywords.json calcite-design-system\packages\calcite-ui-icons\fantasticonrc.json calcite-design-system\packages\calcite-design-tokens GeneratedResources\WinUI WinUI
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-design-system\packages\calcite-ui-icons\docs\keywords.json calcite-design-system\packages\calcite-ui-icons\fantasticonrc.json calcite-design-system\packages\calcite-design-tokens GeneratedResources\UWP UWP
