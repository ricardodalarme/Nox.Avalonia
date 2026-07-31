using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Nox.Avalonia;

namespace Nox.Avalonia.Demo.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        this.InitializeComponent();
        this.DataContext = new MainViewModel();
    }

    private void ChangeTheme(object? sender, RoutedEventArgs e)
    {
        if (sender is MenuItem menuItem && menuItem.Tag is string themeTag)
            switch (themeTag)
            {
                case "Dark":
                    NoxThemeManager.Instance.SetTheme(NoxThemeMode.Dark);
                    break;
                case "Light":
                    NoxThemeManager.Instance.SetTheme(NoxThemeMode.Light);
                    break;
            }
    }
}
