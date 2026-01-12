using Sdcb.PaddleOCR;

namespace UmamusumeCore.Interfaces;

public interface IAutomation
{
    public void Clicker(PaddleOcrResultRegion text);
    public void ScreenHandler();
}