using System.Collections;
using AdvancedSharpAdbClient.Models;
using OpenCvSharp;
using Sdcb.PaddleOCR;

namespace UmamusumeCore.Interfaces;

public interface IImageProcessor
{
    public PaddleOcrResult ImageOCR();
    public Task<PaddleOcrAll> InitializeOCR();
    public Framebuffer ImageCapture();
    public Mat ImageProcessing();
}