using AdvancedSharpAdbClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using UmamusumeCLI;
using UmamusumeCore.Interfaces;
using UmamusumeCore.Models;
using UmamusumeCore.Services;

await Host.CreateDefaultBuilder(args)
    // 1️⃣  tell the host to load **config.json**
    .ConfigureAppConfiguration(cfg =>
    {
        cfg.AddJsonFile("config.json",
            optional: false,
            reloadOnChange: true);
    })
    // 2️⃣  register your DI services
    .ConfigureServices((hostCtx, services) =>
    {
        // strongly-typed config binding
        services.Configure<AutomationConfig>(
            hostCtx.Configuration);
        services.AddSingleton<IValidator,      Validator>();
        services.AddSingleton<IADBConnect,     ADBConnect>();
        services.AddSingleton<IImageProcessor, ImageProcessor>();
        services.AddSingleton<IAdbClient,      AdbClient>();
        services.AddSingleton<IAutomation,      Automation>();


        // orchestrator
        services.AddHostedService<Runner>();
    })
    // 3️⃣  one centralized logger factory
    .ConfigureLogging(b => b.ClearProviders()
        .AddConsole()
        .SetMinimumLevel(LogLevel.Information))
    .RunConsoleAsync();