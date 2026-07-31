using System;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Nox.Avalonia.Dock;

public class DockNoxTheme : Styles
{
    public DockNoxTheme(IServiceProvider? sp = null)
    {
        AvaloniaXamlLoader.Load(sp, this);
    }
}
