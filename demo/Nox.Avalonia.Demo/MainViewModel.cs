using System.Collections.ObjectModel;
using System.Windows.Input;
using Nox.Avalonia.Demo.DataGrids;
using Nox.Avalonia.Demo.MVVM;

namespace Nox.Avalonia.Demo;

public class MainViewModel : BaseViewModel
{
    private int numericValue = 42;

    public DataGridViewModel DataGridViewModel { get; }

    public EditorGridViewModel EditorGridViewModel { get; }

    public Models.SampleSettings Settings { get; } = new();

    public ObservableCollection<string> SomeItems { get; }

    public int NumericValue
    {
        get => this.numericValue;
        set => this.RaisePropertyChanged(ref this.numericValue, value);
    }

    public ICommand AddContentCommand { get; set; }

    public MainViewModel()
    {
        this.DataGridViewModel = new DataGridViewModel();
        this.EditorGridViewModel = new EditorGridViewModel();
        this.SomeItems = new ObservableCollection<string>()
        {
            "1024x576",
            "1280x720",
            "1920x1080",
            "3840x2160",
        };

        this.AddContentCommand = new RelayCommand(() =>
        {
            this.SomeItems.Add("item 1");
            this.SomeItems.Add("item 2");
            this.SomeItems.Add("item 3");
        });
    }
}
