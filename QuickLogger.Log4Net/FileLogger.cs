using System.IO;

namespace QuickLogger.Log4Net
{
    public class FileLogger : BaseLog4NetLogger
    {
        public FileLogger(string configFilePath = "log4net.config", string appenderName = "log4netFileAppender") : base(configFilePath, appenderName)
        {
            IsEnabled = true;
        }
    }
}