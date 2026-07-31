# Theme.Avalonia

A modern, sleek dark theme library for Avalonia UI applications targeting **.NET 10**.

## Features

- **Modern Avalonia Theme Architecture**: Built on Avalonia 11+ `Styles` and `ThemeDictionaries`.
- **Easy One-Line Setup**: Simply include `<theme:SoftDarkTheme />` in your `App.axaml`.
- **Central Package Management (CPM)**: Clean dependency management for .NET 10 solutions.
- **XML Solution Format**: Uses `.slnx` for concise solution management.

---

## Installation

Add the `Theme.Avalonia` package to your project:

```bash
dotnet add package Theme.Avalonia
```

---

## Quick Start

Register the theme in your `App.axaml`:

```xml
<Application xmlns="https://github.com/avaloniaui"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:theme="clr-namespace:Theme.Avalonia;assembly=Theme.Avalonia"
             x:Class="YourApp.App"
             RequestedThemeVariant="Dark">
    <Application.Styles>
        <SimpleTheme/>
        <theme:SoftDarkTheme />
    </Application.Styles>
</Application>
```

---

## Repository Structure

- `src/Theme.Avalonia`: Core Avalonia Theme library.
- `demo/Theme.Avalonia.Demo`: Sample application demonstrating controls and theme usage.
- `Themes.slnx`: Solution file using the .NET XML solution persistence model.

---

## License

[MIT License](LICENSE)
