using System;
using System.Collections.Generic;
using Dock.Avalonia.Controls;
using Dock.Model.Controls;
using Dock.Model.Core;
using Dock.Model.Mvvm;
using Dock.Model.Mvvm.Controls;

namespace Nox.Avalonia.Dock.Demo.ViewModels;

public class ToolViewModel : Tool
{
    public string Description { get; set; } = string.Empty;
}

public class DocumentViewModel : Document
{
    public string ContentText { get; set; } = string.Empty;
}

public class MainDockFactory : Factory
{
    private IRootDock? _rootDock;
    private IDocumentDock? _documentDock;

    public override IRootDock CreateLayout()
    {
        var solutionExplorer = new ToolViewModel
        {
            Id = "SolutionExplorer",
            Title = "Solution Explorer",
            Description = "Solution Explorer Tool Window"
        };

        var properties = new ToolViewModel
        {
            Id = "Properties",
            Title = "Properties",
            Description = "Properties / Inspector Tool Window"
        };

        var output = new ToolViewModel
        {
            Id = "Output",
            Title = "Output",
            Description = "Build Output & Terminal"
        };

        var doc1 = new DocumentViewModel
        {
            Id = "Doc1",
            Title = "MainWindow.axaml",
            ContentText = "<Window xmlns=\"https://github.com/avaloniaui\"\n        Title=\"Nox Dock Demo\">\n    <DockControl Layout=\"{Binding Layout}\" />\n</Window>"
        };

        var doc2 = new DocumentViewModel
        {
            Id = "Doc2",
            Title = "Program.cs",
            ContentText = "namespace Nox.Avalonia.Dock.Demo;\n\npublic class Program {\n    public static void Main(string[] args) => ...\n}"
        };

        var leftDock = new ToolDock
        {
            Id = "LeftDock",
            Proportion = 0.25,
            ActiveDockable = solutionExplorer,
            VisibleDockables = CreateList<IDockable>(solutionExplorer)
        };

        var rightDock = new ToolDock
        {
            Id = "RightDock",
            Proportion = 0.25,
            ActiveDockable = properties,
            VisibleDockables = CreateList<IDockable>(properties)
        };

        var bottomDock = new ToolDock
        {
            Id = "BottomDock",
            Proportion = 0.3,
            ActiveDockable = output,
            VisibleDockables = CreateList<IDockable>(output)
        };

        var documentDock = new DocumentDock
        {
            Id = "DocumentDock",
            IsCollapsable = false,
            ActiveDockable = doc1,
            VisibleDockables = CreateList<IDockable>(doc1, doc2)
        };

        _documentDock = documentDock;

        var centerPane = new ProportionalDock
        {
            Orientation = Orientation.Vertical,
            VisibleDockables = CreateList<IDockable>(
                documentDock,
                new ProportionalDockSplitter(),
                bottomDock
            )
        };

        var mainLayout = new ProportionalDock
        {
            Orientation = Orientation.Horizontal,
            VisibleDockables = CreateList<IDockable>(
                leftDock,
                new ProportionalDockSplitter(),
                centerPane,
                new ProportionalDockSplitter(),
                rightDock
            )
        };

        var rootDock = CreateRootDock();
        rootDock.IsCollapsable = false;
        rootDock.ActiveDockable = mainLayout;
        rootDock.DefaultDockable = mainLayout;
        rootDock.VisibleDockables = CreateList<IDockable>(mainLayout);

        _rootDock = rootDock;

        return rootDock;
    }

    public override void InitLayout(IDockable layout)
    {
        ContextLocator = new Dictionary<string, Func<object?>>
        {
            [nameof(IRootDock)] = () => _rootDock,
            [nameof(IDocumentDock)] = () => _documentDock
        };

        HostWindowLocator = new Dictionary<string, Func<IHostWindow?>>
        {
            [nameof(IDockWindow)] = () => new HostWindow()
        };

        base.InitLayout(layout);
    }
}
