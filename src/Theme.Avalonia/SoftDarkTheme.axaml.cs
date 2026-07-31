using System;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Theme.Avalonia;

public class SoftDarkTheme : Styles
{
    public SoftDarkTheme(IServiceProvider? sp = null)
    {
        AvaloniaXamlLoader.Load(sp, this);
    }
}
