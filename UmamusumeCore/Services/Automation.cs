using System.Drawing;
using System.Net.Mime;
using AdvancedSharpAdbClient;
using AdvancedSharpAdbClient.DeviceCommands;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Sdcb.PaddleOCR;
using UmamusumeCore.Interfaces;
using UmamusumeCore.Models;

namespace UmamusumeCore.Services;

public class Automation: IAutomation
{
    private readonly ILogger<Automation> _logger;
    private readonly IValidator _validator;
    private readonly IImageProcessor _imageProcessor;
    private readonly IAdbClient _adbClient;
    private readonly IADBConnect _adbConnect;

    public Automation( ILogger<Automation> logger, IValidator validator,
        IImageProcessor imageProcessor, IAdbClient adbClient, IADBConnect adbConnect)
    {
        _logger = logger;
        _validator = validator;
        _imageProcessor = imageProcessor;
        _adbClient = adbClient;
        _adbConnect = adbConnect;
    }

    public Point DrawingPointConverter(OpenCvSharp.Point2f point)
    {
        Point centerPoint = new Point(
            (int)Math.Round(point.X),
            (int)Math.Round(point.Y)
        );
        return centerPoint;
    }

    public PaddleOcrResultRegion TextFinder(string text)
    {
        try
        {
            var result = _imageProcessor.ImageOCR().Regions.FirstOrDefault(u => u.Text.Contains(text,StringComparison.OrdinalIgnoreCase));
            return result;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
    }
        
    public void Clicker(PaddleOcrResultRegion result)
    {
        try
        {
            _adbClient.Click(_adbConnect.AdbGetDevice(_adbClient.GetDevices()),DrawingPointConverter(result.Rect.Center));

        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }
    }

    public void ScreenHandler()
    {
        try
        {
            _logger.LogInformation("1. Find and Click Career");
            var temp = TextFinder("career");
            while(temp.Text ==null)
            {
                _adbClient.ClickBackButton(_adbConnect.AdbGetDevice(_adbClient.GetDevices()));
                temp = TextFinder("Career");
            }
            Clicker(temp);
            _logger.LogInformation("2. Find and Click Next on Scenario");
            temp = TextFinder("next");
            Clicker(temp);
            
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}