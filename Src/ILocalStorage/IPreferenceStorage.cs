namespace ILocalStorage;

public interface IPreferenceStorage
{
    /// <summary>
    /// 清空所有值
    /// </summary>
    /// <param name="sharedName">容器名称</param>
    void Clear(string? sharedName = null);

    /// <summary>
    /// 是否包含Key
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="sharedName">容器名称</param>
    /// <returns>是否包含Key</returns>
    bool ContainsKey(string key, string? sharedName = null);

    /// <summary>
    /// 获取key中的值
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="defaultValue">默认值</param>
    /// <param name="sharedName">容器名称</param>
    /// <returns>key对应的Value</returns>
    string? Get(string key, string? defaultValue, string? sharedName = null);

    /// <summary>
    /// 删除key
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="sharedName">容器名称</param>
    void Remove(string key, string? sharedName = null);

    /// <summary>
    /// 设置key value
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="value">值</param>
    /// <param name="sharedName">容器名称</param>
    void Set(string key, string value, string? sharedName = null);
}
