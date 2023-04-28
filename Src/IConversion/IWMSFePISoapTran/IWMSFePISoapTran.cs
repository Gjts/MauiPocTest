using Comm.Net.Models;

namespace ITransformation;

public interface IWMSFePISoapTran<in Input, out Output>
    where Input : IBaseInput
    where Output : IBaseOutput
{
    Task<string> HelloWorldAsync();

    Task<IBaseOutput> getPackingSearchAsync(Input input);

    Task<IBaseOutput> getPIConfigAsync(Input input);

    /// <summary>
    /// 获取版本号
    /// </summary>
    /// <param name="login">登录信息</param>
    /// <returns>版本号</returns>
    Task<string> getCurrentVersionAsync(Input input);

    Task<IBaseOutput> getPIRecAsync(Input input);

    Task<IBaseOutput> updatePIAsync(Input input);

    Task<IBaseOutput> getPIDetailAsync(Input input);

    Task<IBaseOutput> validatePIAsync(Input input);
}
