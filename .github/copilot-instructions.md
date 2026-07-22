# Calcite .NET repository instructions

## Environment and commands

- Work from a Visual Studio 2022 Developer PowerShell on Windows. Install the `.NET desktop development`, `Windows application development`, and `.NET Multi-platform App UI development` workloads. The repository uses .NET SDK `9.0.100` (`src\global.json`).
- CI builds the three shipping projects independently; prefer these commands over building the whole solution because the solution also contains platform-specific sample apps:

  ```powershell
  msbuild /restore /t:Build .\src\Esri.Calcite.Wpf\Esri.Calcite.WPF.csproj /p:Configuration=Release
  msbuild /restore /t:Build .\src\Esri.Calcite.WinUI\Esri.Calcite.WinUI.csproj /p:Configuration=Release
  msbuild /restore /t:Build .\src\Esri.Calcite.Maui\Esri.Calcite.Maui.csproj /p:Configuration=Release
  ```

- Build one affected project during iteration by changing `Release` to `Debug`. Release builds create NuGet packages under `artifacts\NuGet\Release`.
- Build the resource generator with:

  ```powershell
  dotnet build .\Tools\ResourceGenerator\ResourceGenerator.csproj
  ```

- There are no automated test projects or standalone lint script. Projects named `WpfTests`, `WinUITests`, and `MauiTests` are interactive sample/gallery applications, not test-runner projects, so there is no single-test command. Use the affected app as the visual test surface; `WpfTests` can be launched with:

  ```powershell
  dotnet run --project .\src\TestApps\WpfTests\WpfTests.csproj
  ```

  Launch the packaged WinUI and platform-specific MAUI apps from Visual Studio with the intended architecture/target.
- C# analyzer, formatting, naming, file-header, and XML-documentation rules live in `src\.editorconfig` and are surfaced by builds. Treat warnings introduced by a change as failures.

## Architecture

- This repository ships three XAML resource libraries: `Esri.Calcite.WPF`, `Esri.Calcite.WinUI`, and `Esri.Calcite.Maui`. Each package combines hand-authored framework styles and helper APIs under `src\Esri.Calcite.*` with linked generated colors, glyphs, icon enums, and icon helpers under `GeneratedResources\<framework>`.
- `CalciteResources` is each framework's public composition root. It merges generated colors/brushes/glyphs with framework styles and controls theme behavior:
  - WPF switches light/dark dictionaries at runtime and swaps `ControlOverrides.xaml` with `ControlNoOverrides.xaml` when implicit styling is disabled.
  - WinUI uses theme dictionaries and `ThemeResource` references.
  - MAUI uses `AppThemeBinding`; `UseCalcite()` registers icon fonts and custom handler mappings.
- `calcite-design-system` is a Git submodule and the upstream source for UI-icon metadata and design tokens. `Tools\ResourceGenerator` transforms those inputs into the four committed trees under `GeneratedResources` (`Maui`, `UWP`, `WPF`, and `WinUI`). UWP output remains part of generation even though no UWP library is currently in the solution.
- Shipping project files link generated sources rather than copying them into `src`. Their `GetResources` target downloads the icon-font release selected by `CalciteUIIconsVersion` in `src\Directory.Build.props`.
- `src\TestApps` provides visual galleries and integration examples for the corresponding project references. User-facing setup and resource behavior are documented in `docs\wpf.md`, `docs\winui.md`, `docs\maui.md`, and `docs\brushes.md`.
- Package metadata is centralized in `src\Directory.Build.props`; package versions come from Nerdbank.GitVersioning via `src\version.json`.

## Repository conventions

- Do not hand-edit `GeneratedResources`. For icon or design-token refreshes, initialize the submodule and follow `.github\skills\update-calcite-resources\SKILL.md`; it defines stable-tag selection, compatibility probes, four-platform generation, release metadata, documentation synchronization, line-ending cleanup, and required builds. `GenerateResources.cmd` deletes and recreates the entire generated tree, so preserve unrelated worktree changes.
- Keep generated icon/color changes logically synchronized across all four generated platforms. If generated semantic colors change, update the corresponding values and swatches in `docs\brushes.md`.
- Preserve framework-specific resource lookup semantics: WPF brushes use `DynamicResource`, WinUI brushes use `ThemeResource`, and MAUI brushes/colors use `AppThemeBinding`. Resource keys use the `Calcite...Color`, `Calcite...Brush`, and `CalciteUIIcons_Glyph_...` families.
- Hand-authored control support is intentionally framework-specific. Add XAML dictionaries to the framework's composition dictionary (`ControlStyles.xaml`, WinUI `Styles\Controls\Controls.xaml`, or MAUI style dictionaries), and update implicit-style layers separately when a style should apply by default.
- Maintain the existing public XAML namespace mappings and namespace casing: WPF uses `Esri.Calcite.WPF`, while WinUI and MAUI use `Esri.Calcite.WinUI` and `Esri.Calcite.Maui`.
- All public C# APIs require XML documentation. New C# files under `src` must use the copyright header configured in `src\.editorconfig`; follow its field naming rules (`s_` for private/internal static fields and `_camelCase` for other private/internal fields).
- When changing public resource keys, styles, icons, theme behavior, or setup, update the matching framework document and the relevant sample app so the documented usage and visual gallery stay aligned.
