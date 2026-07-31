using System;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Nox.Avalonia.PropertyGrid;

public class NoxPropertyGridTheme : Styles
{
    public NoxPropertyGridTheme(IServiceProvider? sp = null)
    {
        AvaloniaXamlLoader.Load(sp, this);
    }
}
