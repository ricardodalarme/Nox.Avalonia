using Avalonia.Controls;
using Avalonia.Interactivity;

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
    }
}
