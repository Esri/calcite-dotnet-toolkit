---
name: update-calcite-resources
description: Update calcite-dotnet to the latest stable @esri/calcite-ui-icons release, regenerate icon and color resources, synchronize brush documentation, remove line-ending-only churn, and build the affected projects. Use when upgrading Calcite UI Icons or refreshing GeneratedResources.
---

# Update Calcite resources

Run this workflow from the repository root on Windows. Preserve unrelated and pre-existing worktree changes throughout.

## 1. Record the current state

1. Run `git status --short` and record every pre-existing changed path.
2. Read the current submodule commit and icon version:

   ```powershell
   $oldSubmoduleCommit = git -C .\calcite-design-system rev-parse HEAD
   $currentVersion = (Get-Content .\calcite-design-system\packages\ui-icons\package.json -Raw | ConvertFrom-Json).version
   ```

3. Stop if the submodule contains uncommitted changes. Never discard changes from the user.

## 2. Resolve the latest stable release

Use the Calcite Design System submodule's remote tags as the authoritative release list. A stable version must have the form `major.minor.patch` and must not contain a dash.

```powershell
$tagPrefix = '@esri/calcite-ui-icons@'
$versions = git -C .\calcite-design-system ls-remote --tags --refs origin "refs/tags/$tagPrefix*" |
    ForEach-Object {
        $ref = ($_ -split '\s+')[1]
        ([Uri]::UnescapeDataString($ref) -replace '^refs/tags/', '').Substring($tagPrefix.Length)
    }
$latestVersion = $versions |
    Where-Object { $_ -match '^\d+\.\d+\.\d+$' -and $_ -notmatch '-' } |
    Sort-Object { [version]$_ } |
    Select-Object -Last 1
```

Stop without modifying anything if:

- the remote tags do not contain a stable version;
- `$latestVersion` equals `$currentVersion`; or
- the remote tag listing does not contain the exact tag `@esri/calcite-ui-icons@$latestVersion`.

Fetch the exact selected tag:

```powershell
$tag = "@esri/calcite-ui-icons@$latestVersion"
git -C .\calcite-design-system fetch origin "refs/tags/$tag`:refs/tags/$tag"
```

Do not substitute a preview tag or an arbitrary branch commit.

## 3. Move the submodule and version references

Check out the verified tag in detached-HEAD state:

```powershell
git -C .\calcite-design-system checkout --detach $tag
```

Confirm that `packages\ui-icons\package.json` now reports `$latestVersion`. If it does not, return the submodule to `$oldSubmoduleCommit` and stop.

Update `src\Directory.Build.props`:

- set `CalciteUIIconsVersion` to `$latestVersion`;
- update the package release note text and URL to the same version.

Do not update unrelated dependencies in the submodule or parent repository.

## 4. Check JSON compatibility before overwriting resources

Review upstream input changes:

```powershell
git -C .\calcite-design-system diff --stat "$oldSubmoduleCommit..HEAD" -- `
    packages/design-tokens/src/tokens/core `
    packages/design-tokens/src/tokens/semantic/color `
    packages/ui-icons/docs/keywords.json `
    packages/ui-icons/fantasticonrc.json
```

Build `Tools\ResourceGenerator\ResourceGenerator.csproj`, then run a WPF generation probe into a temporary directory outside `GeneratedResources`. Use:

- `calcite-design-system\packages\ui-icons\docs\keywords.json`
- `calcite-design-system\packages\ui-icons\fantasticonrc.json`
- `calcite-design-system\packages\design-tokens`

If parsing fails, inspect the exact changed JSON nodes and update the generator narrowly. It must continue to accept the previous release's format as well as the new one. In particular, preserve support for both legacy `value`/`type` and DTCG `$value`/`$type` token properties, and distinguish primitive `JValue` nodes from `JObject` nodes before casting or traversing.

After changing the parser:

1. rerun the probe with the new submodule;
2. run it against inputs from `$oldSubmoduleCommit`;
3. compare the old-format output with the resources from before the update.

Do not regenerate tracked resources until both formats succeed and the old-format output remains equivalent.

## 5. Regenerate every platform

Build the generator once, then run its executable for `Maui`, `UWP`, `WPF`, and `WinUI`, writing to the matching directory under `GeneratedResources`.

Equivalent command shape:

```powershell
$generator = '.\Tools\ResourceGenerator\bin\Debug\net8.0\ResourceGenerator.exe'
$keywords = '.\calcite-design-system\packages\ui-icons\docs\keywords.json'
$glyphs = '.\calcite-design-system\packages\ui-icons\fantasticonrc.json'
$tokens = '.\calcite-design-system\packages\design-tokens'

& $generator $keywords $glyphs $tokens '.\GeneratedResources\Maui' 'Maui'
& $generator $keywords $glyphs $tokens '.\GeneratedResources\UWP' 'UWP'
& $generator $keywords $glyphs $tokens '.\GeneratedResources\WPF' 'WPF'
& $generator $keywords $glyphs $tokens '.\GeneratedResources\WinUI' 'WinUI'
```

Treat any nonzero exit code as a failure and stop before proceeding.

## 6. Validate the generated diff

Inspect `git diff --stat`, `git diff --numstat`, and the complete generated diff.

Confirm:

- new enum members, helper mappings, and glyph resources correspond to additions in `keywords.json` and `fantasticonrc.json`;
- removed or renumbered icons are supported by the upstream diff;
- generated color additions and value changes correspond to design-token changes;
- the same logical icon and color changes appear across all four platforms;
- there is no broad reordering, formatting churn, truncation, or unrelated output.

Warnings about keyword entries without codepoints may be upstream data, but investigate any warning involving an icon that should have been generated.

## 7. Synchronize color documentation

If any generated `Colors.xaml` content changed, update `docs\brushes.md` in the same change.

Use the generated WPF semantic light and dark resources as the source of truth:

- update each affected resource row's light and dark values;
- update both the visible hexadecimal text and its `placehold.co` swatch URL;
- add or remove documented semantic resources when appropriate;
- keep alpha-bearing resource values intact in the visible text, using the RGB portion for the swatch where required.

Core palette entries that are not part of the documented semantic resource table do not require new rows, but any affected documented semantic color must match generated output.

## 8. Remove line-ending-only changes

Compare the final status with the state recorded in step 1. For each file touched by generation:

1. verify whether `git diff` contains a content change;
2. if the path is only reported modified because its line endings changed, restore that specific path from the index;
3. never restore a file that had a pre-existing user change or a real generated content change.

The final diff must contain only meaningful version, generator, generated-resource, and documentation updates.

## 9. Prepare package release metadata

Before building, update and verify the release metadata:

1. In `src\version.json`, increment the package's minor version by one and reset the patch version to zero. For example, change `1.0.0` to `1.1.0`. Do not carry forward a prerelease suffix unless the user explicitly requests a prerelease.
2. In `src\Directory.Build.props`, confirm that `CalciteUIIconsVersion` exactly equals `$latestVersion`.
3. In the same `PropertyGroup`, replace `PackageReleaseNotes` with an accurate statement about the newly generated symbols. Follow the existing list-item format and include the icon release version and its exact release URL. For example:

   ```xml
   <PackageReleaseNotes>
       - Added &lt;count&gt; new Calcite symbols by upgrading Calcite Icons to version &lt;version&gt;: https://github.com/Esri/calcite-design-system/releases/tag/%40esri%2Fcalcite-ui-icons%40&lt;version&gt;
   </PackageReleaseNotes>
   ```

Derive the symbol count from the meaningful additions to the generated `CalciteIcon` enum, not from line counts. If the update includes renamed or changed symbols, describe those accurately rather than presenting all changes as additions. Ensure the release-note URL and `CalciteUIIconsVersion` both use the selected stable version.

## 10. Build

Use the same project-level builds as CI from a Visual Studio developer environment:

```powershell
dotnet build .\Tools\ResourceGenerator\ResourceGenerator.csproj --no-restore
msbuild /restore /t:Build .\src\Esri.Calcite.Wpf\Esri.Calcite.WPF.csproj /p:Configuration=Release
msbuild /restore /t:Build .\src\Esri.Calcite.WinUI\Esri.Calcite.WinUI.csproj /p:Configuration=Release
msbuild /restore /t:Build .\src\Esri.Calcite.Maui\Esri.Calcite.Maui.csproj /p:Configuration=Release
```

All projects must build. Resolve errors caused by the resource update; report environment or pre-existing failures accurately rather than claiming success.

## 11. Final review

Before finishing, confirm:

- the submodule points exactly to the latest stable icon release tag;
- the package version was incremented by one minor version;
- `CalciteUIIconsVersion` and `PackageReleaseNotes` use that same icon version;
- `PackageReleaseNotes` accurately describes the new or changed symbols;
- no preview version was selected;
- all four generated resource sets are synchronized;
- `docs\brushes.md` matches changed semantic colors;
- no line-ending-only files remain in the diff;
- all required builds succeeded;
- no temporary probe files were left in the repository.
- Run `grep "fill:none" ./ -rl` or equivalent on `.\calcite-design-system\packages\ui-icons\icons`, and report matching files as potentially-malformed symbols