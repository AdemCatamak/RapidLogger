using System.IO;

namespace QuickLogger.Log4Net
{
    public class ConsoleLogger : BaseLog4NetLogger
    {
        public ConsoleLogger(string configFilePath, string appenderName = "log4netConsoleLogger") : base(configFilePath, appenderName)
        {
        }
    }
}