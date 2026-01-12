using AdvancedSharpAdbClient.Models;

namespace UmamusumeCore.Interfaces;

public interface IADBConnect
{
    public string IsConnected();
    public void StartAdbServer();
    public DeviceData AdbGetDevice(IEnumerable<DeviceData> devices);

}