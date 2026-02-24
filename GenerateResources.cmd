rmdir GeneratedResources /S /Q

dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-design-system\packages\ui-icons\docs\keywords.json calcite-design-system\packages\ui-icons\fantasticonrc.json calcite-design-system\packages\design-tokens GeneratedResources\WPF WPF
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-design-system\packages\ui-icons\docs\keywords.json calcite-design-system\packages\ui-icons\fantasticonrc.json calcite-design-system\packages\design-tokens GeneratedResources\Maui Maui
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-design-system\packages\ui-icons\docs\keywords.json calcite-design-system\packages\ui-icons\fantasticonrc.json calcite-design-system\packages\design-tokens GeneratedResources\WinUI WinUI
dotnet run --project Tools\ResourceGenerator\ResourceGenerator.csproj calcite-design-system\packages\ui-icons\docs\keywords.json calcite-design-system\packages\ui-icons\fantasticonrc.json calcite-design-system\packages\design-tokens GeneratedResources\UWP UWP
