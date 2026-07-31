using System;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Nox.Avalonia;

public class NoxTheme : Styles
{
    public NoxTheme(IServiceProvider? sp = null)
    {
        AvaloniaXamlLoader.Load(sp, this);
    }
}
