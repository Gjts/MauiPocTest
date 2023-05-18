namespace MauiPocUnitTest;

public class ConfigSingletonT<T> where T : class, new()
{
    // 保存类的唯一实例
    private static T? _instance;

    // 用于线程安全地创建实例的锁对象
    private static readonly object _lock = new object();

    // 受保护的构造函数，以确保这个类不会被直接实例化
    protected ConfigSingletonT() { }

    // 类的唯一实例属性
    public static T Instance
    {
        get
        {
            // 如果实例不存在
            if (_instance == null)
            {
                // 加锁，保证线程安全
                lock (_lock)
                {
                    // 再次检查实例是否存在，防止多线程竞争下创建多个实例
                    if (_instance == null)
                    {
                        // 创建新实例
                        _instance = new T();
                    }
                }
            }

            return _instance;
        }
    }
}
