using Avalonia;
using Avalonia.Controls;

namespace Nox.Avalonia.Themes.Attached;

public static class DisabledButtonExtras
{
    public static readonly AttachedProperty<bool> IgnoreDisabledBackgroundProperty =
        AvaloniaProperty.RegisterAttached<Control, bool>("IgnoreDisabledBackground", typeof(DisabledButtonExtras));

    /// <summary>
    /// Sets whether to leave the background unaffected when a button is disabled
    /// </summary>
    public static void SetIgnoreDisabledBackground(Control obj, bool value) => obj.SetValue(IgnoreDisabledBackgroundProperty, value);

    /// <summary>
    /// Gets whether to leave the background unaffected when a button is disabled
    /// </summary>
    public static bool GetIgnoreDisabledBackground(Control obj) => obj.GetValue(IgnoreDisabledBackgroundProperty);
}
