namespace RapidLogger.Log4NetAdapter
{
    public class ConsoleLogger : BaseLog4NetLogger
    {
        public ConsoleLogger(string configFilePath ="log4net.config", string appenderName = "log4netConsoleAppender") : base(configFilePath, appenderName)
        {
            IsEnabled = true;
        }
    }
}