using AdvancedSharpAdbClient;
using AdvancedSharpAdbClient.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using UmamusumeCore.Interfaces;
using UmamusumeCore.Models;

namespace UmamusumeCore.Services;

public class ADBConnect : IADBConnect
{
    private readonly IOptions<AutomationConfig> _config;
    private readonly ILogger<ADBConnect> _logger;
    private readonly IValidator _validator;
    private readonly IAdbClient _adbClient;

    public ADBConnect(ILogger<ADBConnect> logger, IOptions<AutomationConfig> config, IValidator validator, IAdbClient adbClient)
    {
        _logger = logger;
        _config = config;
        _validator = validator;
        _adbClient = adbClient;
    }

    public void StartAdbServer()
    {
        var server = new AdbServer();
        try
        {
            var result = server.StartServer("./platform-tools/adb");
            switch (result)
            {
                case StartServerResult.Started:
                    _logger.LogInformation("Started adb server");
                    break;
                case StartServerResult.AlreadyRunning:
                    _logger.LogInformation("Adb server already running");
                    break;
                case StartServerResult.Starting:
                    _logger.LogInformation("Starting adb server");
                    break;
                case StartServerResult.RestartedOutdatedDaemon:
                    _logger.LogInformation("Restarted outdated adb server");
                    break;
                default:
                    _logger.LogError("starting adb server failed");
                    break;
            }
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
    }

    public string IsConnected()
    {
        try
        {
            string status;
            var deviceAddress = _config.Value.Adb.Device_Address.Split(':');
            var port = int.Parse(deviceAddress[1]);
            status = _adbClient.Connect(deviceAddress[0], port);
            if (status.Contains("failed"))
            {
                var pairAddress = _config.Value.Adb.Pair_Address.Split(':');
                _validator.AddressCheck(pairAddress);
                var pairPort = int.Parse(pairAddress[1]);
                //status = adbClient.Pair(pairAddress[0], pairPort, _config.Value.Adb.Pair_Code);
                _adbClient.Pair("192.168.2.62", 38727,"140383");
                status = _adbClient.Connect(deviceAddress[0], port);
            }

            return status;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
    }

    public DeviceData AdbGetDevice(IEnumerable<DeviceData> devices)
    {
        return devices.FirstOrDefault();
    }
}