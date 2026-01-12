using AdvancedSharpAdbClient;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using UmamusumeCore.Interfaces;
using UmamusumeCore.Models;

namespace UmamusumeCLI;

public class Runner : BackgroundService
{
    private readonly AutomationConfig  _cfg;
    private readonly IADBConnect     _adb;
    private readonly IImageProcessor _img;
    private readonly ILogger<Runner> _log;
    private readonly IAdbClient  _adbClient;
    private readonly IAutomation _automation;

    public Runner(IOptions<AutomationConfig> opt, IADBConnect adb, IImageProcessor img, ILogger<Runner> log, IAdbClient adbClient, IAutomation automation)
    {
        _cfg = opt.Value;
        _adb = adb;
        _img      = img;
        _log      = log;
        _adbClient = adbClient;
        _automation = automation;
    }
    
    protected override async Task ExecuteAsync(
        CancellationToken stoppingToken)
    {
        _log.LogInformation("Uma Musume Friend Points Automation");
        
        _log.LogInformation("Device = {Address}", _cfg.Adb.Device_Address);
        _log.LogInformation("Pair Address = {PAddress}",_cfg.Adb.Pair_Address);
        _adb.StartAdbServer();
        _log.LogInformation(_adb.IsConnected());
        _automation.ScreenHandler();

        // keep the host alive until Ctrl-C
        await Task.Delay(Timeout.Infinite, stoppingToken);
    }
}