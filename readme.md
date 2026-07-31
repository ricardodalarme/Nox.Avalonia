# Nox.Avalonia

A sleek, modern dark theme library for Avalonia UI applications created by **Ricardo Dalarme**, targeting **.NET 10**.

## Features

- **Modern Avalonia Theme Architecture**: Built on Avalonia 11+ `Styles` and `ThemeDictionaries`.
- **Easy One-Line Setup**: Simply include `<nox:NoxTheme />` in your `App.axaml`.
- **Central Package Management (CPM)**: Clean dependency management for .NET 10 solutions.
- **XML Solution Format**: Uses `.slnx` for concise solution persistence.

---

## Installation

Add the `Nox.Avalonia` package to your project:

```bash
dotnet add package Nox.Avalonia
```

---

## Quick Start

Register the theme in your `App.axaml`:

```xml
<Application xmlns="https://github.com/avaloniaui"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:nox="clr-namespace:Nox.Avalonia;assembly=Nox.Avalonia"
             x:Class="YourApp.App"
             RequestedThemeVariant="Dark">
    <Application.Styles>
        <SimpleTheme/>
        <nox:NoxTheme />
    </Application.Styles>
</Application>
```

---

## Repository Structure

- `src/Nox.Avalonia`: Core Avalonia Theme library.
- `demo/Nox.Avalonia.Demo`: Sample application demonstrating controls and theme usage.
- `Nox.slnx`: Solution file using the .NET XML solution persistence model.

---

## License

[MIT License](LICENSE) &copy; 2026 Ricardo Dalarme
