using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Styling;

namespace Nox.Avalonia.PropertyGrid;

public class NoxPropertyGridTheme : Styles
{
    static NoxPropertyGridTheme()
    {
        Control.LoadedEvent.AddClassHandler<global::Avalonia.PropertyGrid.Controls.PropertyGrid>((pg, e) =>
        {
            ApplyHeaderFontFix(pg);
        });
    }

    public NoxPropertyGridTheme(IServiceProvider? sp = null)
    {
        AvaloniaXamlLoader.Load(sp, this);
    }

    private static void ApplyHeaderFontFix(global::Avalonia.PropertyGrid.Controls.PropertyGrid pg)
    {
        var columnName = pg.FindControl<TextBlock>("ColumnName");
        if (columnName != null)
        {
            columnName.FontSize = 12;
            columnName.FontWeight = FontWeight.SemiBold;
        }

        var columnProperties = pg.FindControl<TextBlock>("ColumnProperties");
        if (columnProperties != null)
        {
            columnProperties.FontSize = 12;
            columnProperties.FontWeight = FontWeight.SemiBold;
        }
    }
}
