using GenericHostConsoleApp.Commands;
using GenericHostConsoleApp.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

Host.CreateDefaultBuilder()
    .ConfigureServices((context, services) =>
    {
        services.AddOptions<Config>()
            .Bind(context.Configuration.GetSection(nameof(Config)))
            .ValidateDataAnnotations();

        services
            .AddSingleton(provider => provider
                .GetRequiredService<IOptionsSnapshot<Config>>()
                .Value);
    })
    .RunCommandLineApplicationAsync<AppCommand>(args);
