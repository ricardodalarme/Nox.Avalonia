using Avalonia;
using Avalonia.Styling;

namespace Nox.Avalonia;

public enum NoxThemeMode
{
    Dark,
    Light,
    System
}

public class NoxThemeManager
{
    private static NoxThemeManager? _instance;
    public static NoxThemeManager Instance => _instance ??= new NoxThemeManager();

    public NoxThemeMode CurrentMode { get; private set; } = NoxThemeMode.Dark;

    public event EventHandler<NoxThemeMode>? ThemeModeChanged;

    /// <summary>
    /// Switches the active theme variant between Dark, Light, or System on the fly.
    /// </summary>
    public void SetTheme(NoxThemeMode mode)
    {
        CurrentMode = mode;
        Application.Current?.RequestedThemeVariant = mode switch
        {
            NoxThemeMode.Light => ThemeVariant.Light,
            NoxThemeMode.Dark => ThemeVariant.Dark,
            _ => ThemeVariant.Default
        };
        ThemeModeChanged?.Invoke(this, mode);
    }

    /// <summary>
    /// Toggles between Dark and Light mode.
    /// </summary>
    public void ToggleTheme() => SetTheme(CurrentMode == NoxThemeMode.Dark ? NoxThemeMode.Light : NoxThemeMode.Dark);
}
