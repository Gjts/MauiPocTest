﻿using ILocalStorage;

namespace LocalStorage;

public class PreferenceStorage : IPreferenceStorage
{
    /// <summary>
    /// 清空所有值
    /// </summary>
    /// <param name="sharedName">容器名称</param>
    public void Clear(string? sharedName = null)
    {
        Preferences.Clear();
    }

    /// <summary>
    /// 是否包含Key
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="sharedName">容器名称</param>
    /// <returns>是否包含Key</returns>
    public bool ContainsKey(string key, string? sharedName = null)
    {
        return Preferences.ContainsKey(key);
    }

    /// <summary>
    /// 获取key中的值
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="defaultValue">默认值</param>
    /// <param name="sharedName">容器名称</param>
    /// <returns>key对应的Value</returns>
    public string? Get(string key, string defaultValue, string? sharedName = null)
    {
        return Preferences.Get(key, defaultValue);
    }

    /// <summary>
    /// 删除key
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="sharedName">容器名称</param>
    public void Remove(string key, string? sharedName = null)
    {
        Preferences.Remove(key);
    }

    /// <summary>
    /// 设置key value
    /// </summary>
    /// <param name="key">键</param>
    /// <param name="value">值</param>
    /// <param name="sharedName">容器名称</param>
    public void Set(string key, string value, string? sharedName = null)
    {
        Preferences.Set(key, value);
    }
}
