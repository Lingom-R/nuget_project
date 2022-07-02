using System.ComponentModel.DataAnnotations;

namespace GenericHostConsoleApp.Models;

internal class Config
{
    [Required]
    public string Option1 { get; set; } = string.Empty;
}
