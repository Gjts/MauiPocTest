/*
 *┌──────────────────────────────────────────┐
 *│  描    述：                                   
 *│  创 建 人：HardieBao
 *│  创建时间：16/5/2023 9:51:14
 *│  修 改 人：
 *│  修改时间： 
 *│　版    本：1.0                                                                     
 *└──────────────────────────────────────────┘
*/
using Comm.Net.Enums;
using NLog;

namespace Comm.Net.Utils;

public static class NLogUtils
{
    private static readonly Logger FileLogger = LogManager.GetLogger("logfile");

    /// <summary>
    /// 写日志到文件
    /// </summary>
    /// <param name="logLevel">日志等级</param>
    /// <param name="logType">日志类型</param>
    /// <param name="logTitle">标题（255字符）</param>
    /// <param name="message">信息</param>
    /// <param name="exception">异常</param>
    public static void WriteFileLog(NLog.LogLevel logLevel, LogType logType, string logTitle, string message, Exception exception = null)
    {
        LogEventInfo theEvent = new LogEventInfo(logLevel, FileLogger.Name, message);
        theEvent.Properties["LogType"] = logType.ToString();
        theEvent.Properties["LogTitle"] = logTitle;
        theEvent.Exception = exception;

        FileLogger.Log(theEvent);
    }
}
