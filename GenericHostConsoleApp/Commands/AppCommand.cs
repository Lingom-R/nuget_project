using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Logging;

namespace GenericHostConsoleApp.Commands;

[Command(Description = "Options reader")]
[Subcommand(typeof(ReadCommand))]
internal class AppCommand
{
    public int OnExecute(ILogger<AppCommand> logger, IConsole console, CommandLineApplication app)
    {
        logger.LogInformation("OnExecute called.");

        console.WriteLine("You must specify a subcommand.");
        console.WriteLine();
        app.ShowHelp();
        return 1;
    }
}
