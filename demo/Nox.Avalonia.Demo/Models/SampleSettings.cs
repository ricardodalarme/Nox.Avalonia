using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Avalonia.Media;
using PropertyModels.ComponentModel;
using PropertyModels.ComponentModel.DataAnnotations;

namespace Nox.Avalonia.Demo.Models;

public enum RenderEngine
{
    Skia,
    Direct3D11,
    Vulkan,
    Metal
}

public class DatabaseOptions
{
    [DisplayName("Host Name")]
    public string Host { get; set; } = "localhost";

    [DisplayName("Port")]
    public int Port { get; set; } = 5432;
}

public class SampleSettings
{
    [Category("General")]
    [DisplayName("Application Name")]
    [Description("The name of the application displayed in the title bar.")]
    public string AppName { get; set; } = "Nox Theme Showcase";

    [Category("General")]
    [DisplayName("Enable Dark Mode")]
    public bool DarkMode { get; set; } = true;

    [Category("General")]
    [DisplayName("Rendering Engine")]
    public RenderEngine Engine { get; set; } = RenderEngine.Skia;

    [Category("Appearance")]
    [DisplayName("Accent Color")]
    public Color AccentColor { get; set; } = Colors.DeepSkyBlue;

    [Category("Appearance")]
    [DisplayName("UI Scale %")]
    [Trackable(50, 200)]
    public int UiScale { get; set; } = 100;

    [Category("Advanced")]
    [DisplayName("Max Log Files")]
    [Range(1, 50)]
    public int MaxLogFiles { get; set; } = 5;

    [Category("Advanced")]
    [DisplayName("Log Directory Path")]
    [PathBrowsable(Filters = "Log Files(*.log)|*.log|All Files(*.*)|*.*")]
    public string LogPath { get; set; } = "/var/log/nox.log";

    [Category("Security")]
    [DisplayName("Admin Password")]
    [PasswordPropertyText(true)]
    public string AdminPassword { get; set; } = "SecretPassword123";

    [Category("Database")]
    [DisplayName("Connection Config")]
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public DatabaseOptions Database { get; set; } = new();
}
