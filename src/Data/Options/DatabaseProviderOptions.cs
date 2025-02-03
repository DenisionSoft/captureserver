using System.ComponentModel.DataAnnotations;

namespace Notissimus.CaptureServer.Data.Options;

public sealed class DatabaseProviderOptions
{
    public static readonly string OptionKey = "Database";

    public enum DataProvider
    {
        Psql
    }

    [Required]
    public DataProvider? Provider { get; set; }
}
