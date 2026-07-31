using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Nox.Avalonia;

public class NoxTheme : Styles
{
    public NoxTheme(IServiceProvider? sp = null)
    {
        AvaloniaXamlLoader.Load(sp, this);
        EnsureThemeDictionaries();
    }

    private void EnsureThemeDictionaries()
    {
        if (Application.Current != null && this.Resources is { } resources)
            foreach (var kvp in resources.ThemeDictionaries)
                if (!Application.Current.Resources.ThemeDictionaries.ContainsKey(kvp.Key) && kvp.Value is ResourceDictionary rd)
                {
                    var copy = new ResourceDictionary();
                    foreach (var dictKey in rd.Keys)
                    {
                        if (rd.TryGetResource(dictKey, null, out var val))
                        {
                            copy[dictKey] = val;
                        }
                    }
                    Application.Current.Resources.ThemeDictionaries[kvp.Key] = copy;
                }
    }
}
