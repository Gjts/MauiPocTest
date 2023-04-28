using System.Xml;
using Comm.Net.Models.User;
using WMSFrontEnd;

namespace Comm.Net.Utils;

public static class WebServiceHelper
{
    //public static void GetServiceClass()
    //{
    //    // 获取 Web 服务中所有类的名称
    //    var serviceType = typeof(YourWebService);
    //    var serviceAssembly = Assembly.GetAssembly(serviceType);
    //    var classNames = serviceAssembly.GetTypes()
    //        .Where(t => t.IsClass && t.GetCustomAttribute<WebServiceAttribute>() != null)
    //        .Select(t => t.Name).ToList();

    //    // 遍历打印每个类的名称
    //    foreach (var className in classNames)
    //    {
    //        className);
    //    }
    //}

    private static string ConvertTo<T>(T data)
    {
        string result = string.Empty;
        if (data is ArrayOfXElement arrayOfXElement)
        {
            // 使用userInfo对象
            result = arrayOfXElement.Nodes[1].ToString();
        }
        else
        {

        }

        return result;
    }
    public static UserInfo ParseFromXml<T>(T data)
    {
        var xml = ConvertTo(data);
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xml);

        XmlNode tableNode = doc.SelectSingleNode("//Table");
        XmlElement tableElement = (XmlElement)tableNode;

        UserInfo userInfo = new UserInfo();

        userInfo.USER_ID = TryParseDecimal(tableElement["USER_ID"].InnerText);
        userInfo.USER_NAME = tableElement["USER_NAME"].InnerText;
        userInfo.RESPONSIBILITY_NAME = tableElement["RESPONSIBILITY_NAME"].InnerText;
        userInfo.START_DATE = TryParseDateTime(tableElement["START_DATE"].InnerText);
        userInfo.END_DATE = null;
        userInfo.RESPONSIBILITY_KEY = tableElement["RESPONSIBILITY_KEY"].InnerText;
        userInfo.APPLICATION_SHORT_NAME = tableElement["APPLICATION_SHORT_NAME"].InnerText;
        userInfo.DEFAULT_OU = TryParseDecimal(tableElement["DEFAULT_OU"].InnerText);
        userInfo.APPLICATION_ID = TryParseDecimal(tableElement["APPLICATION_ID"].InnerText);
        userInfo.RESPONSIBILITY_ID = TryParseDecimal(tableElement["RESPONSIBILITY_ID"].InnerText);
        userInfo.DEFAULT_IO = TryParseDecimal(tableElement["DEFAULT_IO"].InnerText);

        return userInfo;
    }

    private static decimal? TryParseDecimal(string input)
    {
        if (decimal.TryParse(input, out decimal result))
        {
            return result;
        }
        return null;
    }

    private static DateTime? TryParseDateTime(string input)
    {
        if (DateTime.TryParse(input, out DateTime result))
        {
            return result;
        }
        return null;
    }

}