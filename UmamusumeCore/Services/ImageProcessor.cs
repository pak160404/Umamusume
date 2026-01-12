using System.Collections;
using System.Runtime.InteropServices;
using AdvancedSharpAdbClient;
using AdvancedSharpAdbClient.DeviceCommands;
using AdvancedSharpAdbClient.Models;
using Microsoft.Extensions.Logging;
using OpenCvSharp;
using Sdcb.PaddleInference;
using Sdcb.PaddleOCR;
using Sdcb.PaddleOCR.Models;
using Sdcb.PaddleOCR.Models.Online;
using UmamusumeCore.Interfaces;

namespace UmamusumeCore.Services;

public class ImageProcessor:IImageProcessor
{
    private readonly ILogger<ImageProcessor> _logger;
    private readonly IADBConnect _adbConnect;
    private readonly IAdbClient _adbClient;
    
    public ImageProcessor(ILogger<ImageProcessor> logger, IADBConnect adbConnect,IAdbClient adbClient)
    {
        _logger = logger;
        _adbConnect = adbConnect;
        _adbClient = adbClient;
    }

    public async Task<PaddleOcrAll> InitializeOCR()
    {
        try
        {
            FullOcrModel model = await OnlineFullModels.EnglishV4.DownloadAsync();
            PaddleOcrAll all = new PaddleOcrAll(model, PaddleDevice.Mkldnn())
            {
                AllowRotateDetection = true,
                Enable180Classification = false,
            };
            return all;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }

    }

    public PaddleOcrResult ImageOCR()
    {
        try
        {
            var image = ImageProcessing();
            PaddleOcrResult result = InitializeOCR().Result.Run(image);
            foreach (PaddleOcrResultRegion region in result.Regions)
            {
                _logger.LogInformation($"Text: {region.Text} Score: {region.Score} Rect: {region.Rect} ");
            }

            return result;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }

    }

    public Framebuffer ImageCapture()
    {
        try
        {
            var device = _adbConnect.AdbGetDevice(_adbClient.GetDevices());
            var screenshotBuffer = _adbClient.GetFrameBuffer(device);
            return screenshotBuffer;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }

    }
    
    public Mat ImageProcessing()
    {
        try
        {
            var screenshotBuffer = ImageCapture();
            var width = (int)screenshotBuffer.Header.Width;      // 1080
            var height = (int)screenshotBuffer.Header.Height;    // 2280
    
            // Calculate based on header
            int expectedPixels = width * height;                 // 2,462,400 pixelsdisk
    
            // Calculate based on actual data
            int actualPixels = screenshotBuffer.Data.Length / 4; // 4,194,304 pixels
    
            // Use the SMALLER count to prevent overflow
            int safePixelCount = Math.Min(expectedPixels, actualPixels);
    
            var rgbData = new byte[safePixelCount * 3];
    
            // Process only the safe number of pixels
            for (int pixel = 0; pixel < safePixelCount; pixel++)
            {
                int rgbaIndex = pixel * 4;
                int rgbIndex = pixel * 3;
        
                rgbData[rgbIndex] = screenshotBuffer.Data[rgbaIndex];         // R
                rgbData[rgbIndex + 1] = screenshotBuffer.Data[rgbaIndex + 1]; // G
                rgbData[rgbIndex + 2] = screenshotBuffer.Data[rgbaIndex + 2]; // B
            }
    
            var mat = new Mat(height, width, MatType.CV_8UC3);
            Marshal.Copy(rgbData, 0, mat.Data, rgbData.Length);
    
            return mat;
        }
        catch (Exception e)
        {
            _logger.LogError(e.Message);
            throw;
        }

    }

}