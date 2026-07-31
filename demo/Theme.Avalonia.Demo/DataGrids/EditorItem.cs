using Theme.Avalonia.Demo.MVVM;

namespace Theme.Avalonia.Demo.DataGrids;

public class EditorItem : BaseViewModel
{
    private string name = string.Empty;
    private bool isVisible;
    private bool isEnabled;

    public string Name
    {
        get => this.name;
        set => this.RaisePropertyChanged(ref this.name, value);
    }

    public bool IsVisible
    {
        get => this.isVisible;
        set => this.RaisePropertyChanged(ref this.isVisible, value);
    }

    public bool IsEnabled
    {
        get => this.isEnabled;
        set => this.RaisePropertyChanged(ref this.isEnabled, value);
    }

    public EditorItem()
    {
    }

    public EditorItem(string name, bool isVisible, bool isEnabled)
    {
        this.name = name;
        this.isVisible = isVisible;
        this.isEnabled = isEnabled;
    }
}
