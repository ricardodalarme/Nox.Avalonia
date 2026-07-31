using System;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Nox.Avalonia.DataGrid;

public class NoxDataGridTheme : Styles
{
    public NoxDataGridTheme(IServiceProvider? sp = null)
    {
        AvaloniaXamlLoader.Load(sp, this);
    }
}
