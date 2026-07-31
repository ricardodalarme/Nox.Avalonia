using System.Collections.ObjectModel;

namespace Nox.Avalonia.Demo.DataGrids;

public class EditorGridViewModel
{
    public ObservableCollection<EditorItem> Items { get; }

    public EditorGridViewModel()
    {
        this.Items =
        [
            new ("Item 1", false, false),
            new ("Item 2", false, true),
            new ("Item 3", true, true),
            new ("Item 4", true, false),
        ];
    }
}
