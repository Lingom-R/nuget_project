using GenericHostConsoleApp.Models;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace GenericHostConsoleApp.Commands;

[Command(Description = "Print out options.")]
internal class ReadCommand
{
    public int OnExecute(ILogger<ReadCommand> logger, IConsole console, Config config)
    {
        logger.LogInformation("OnExecute called.");

        var json = JsonSerializer.Serialize(config);
        console.WriteLine(json);
        return 0;
    }
}
