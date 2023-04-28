namespace MauiPocUnitTest;

public interface IBaseUnitTest
{
    /// <summary>
    /// 刚初始化执行一次 执行时间复杂度 O(1)
    /// </summary>
    /// <param name="context"></param>
    [ClassInitialize]
    Task InitializeClass(TestContext context);

    /// <summary>
    /// 每次方法初始化都执行一次 执行时间复杂度 O(n)
    /// </summary>
    [TestInitialize]
    Task Initialize();

    /// <summary>
    /// 每个方法执行完都执行一次 执行时间复杂度 O(n)
    /// </summary>
    [TestCleanup]
    Task Cleanup();

    /// <summary>
    /// 所有方法调用完执行一次 执行时间复杂度 O(1)
    /// </summary>
    [ClassCleanup()]
    Task CleanClass();
}
