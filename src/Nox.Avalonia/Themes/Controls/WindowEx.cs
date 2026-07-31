using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace Nox.Avalonia.Themes.Controls;

public class WindowEx : Window
{
    public static readonly StyledProperty<IBrush> TitleBarBrushProperty = AvaloniaProperty.Register<WindowEx, IBrush>("TitleBarBrush");

    public IBrush TitleBarBrush
    {
        get => this.GetValue(TitleBarBrushProperty);
        set => this.SetValue(TitleBarBrushProperty, value);
    }

    protected override Type StyleKeyOverride => typeof(WindowEx);

    public WindowEx()
    {
    }
}