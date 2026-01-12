using UmamusumeCore.Interfaces;

namespace UmamusumeCore.Services;

public class Validator:IValidator
{
    public void AddressCheck(string[] address)
    {
        if (address == null || address.Length < 2 || address.Length > 2)
        {
            throw new ArgumentException("Invalid address");
        }
    }
}