using System.IO;

namespace QuickLogger.Log4Net
{
    public class ConsoleLogger : BaseLog4NetLogger
    {
        public ConsoleLogger(string configFilePath ="log4net.config", string appenderName = "log4netConsoleLogger") : base(configFilePath, appenderName)
        {
            IsEnabled = true;
        }
    }
}