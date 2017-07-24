using QuickLogger.NLogAdapter;

namespace QuickLogger.Log4NetAdapter
{
    public class ConsoleLogger : BaseNLogLogger
    {
        public ConsoleLogger(string configFilePath ="nlog.config", string appenderName = "nlogConsoleAppender") : base(configFilePath, appenderName)
        {
            IsEnabled = true;
        }
    }
}