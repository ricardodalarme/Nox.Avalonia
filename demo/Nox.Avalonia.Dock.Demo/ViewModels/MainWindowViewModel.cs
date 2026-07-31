using Dock.Model.Controls;
using Dock.Model.Core;

namespace Nox.Avalonia.Dock.Demo.ViewModels;

public class MainWindowViewModel
{
    public IFactory Factory { get; }
    public IRootDock? Layout { get; set; }

    public MainWindowViewModel()
    {
        Factory = new MainDockFactory();
        Layout = Factory.CreateLayout();
        if (Layout != null)
        {
            Factory.InitLayout(Layout);
        }
    }
}
