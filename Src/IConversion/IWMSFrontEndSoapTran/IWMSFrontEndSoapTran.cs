using Comm.Net.Models;

namespace ITransformation;
public interface IWMSFrontEndSoapTran<in Input, out Output>
    where Input : IBaseInput
    where Output : IBaseOutput
{
    Task<string> getPasswordAsync(Input input);

    Task<IBaseOutput> getUserInfoAsync(Input input);
}
