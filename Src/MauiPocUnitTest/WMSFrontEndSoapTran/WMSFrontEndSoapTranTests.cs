using MauiPocUnitTest;

namespace Transformation.WMSFrontEndSoapTran.Tests;

[TestClass()]
public class WMSFrontEndSoapTranTests :
    ConfigSingletonT<WMSFrontEndSoapTran>,
    IBaseUnitTest
{
    public Task InitializeClass(TestContext context)
    {
        throw new NotImplementedException();
    }

    public Task Initialize()
    {
        throw new NotImplementedException();
    }

    [TestMethod()]
    public void getPasswordAsyncTest()
    {

        Assert.Fail();
    }

    [TestMethod()]
    public void getUserInfoAsyncTest()
    {

        Assert.Fail();
    }

    public Task Cleanup()
    {
        throw new NotImplementedException();
    }

    public Task CleanClass()
    {
        throw new NotImplementedException();
    }
}