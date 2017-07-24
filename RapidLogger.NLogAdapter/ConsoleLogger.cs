namespace RapidLogger.NLogAdapter
{
    public class ConsoleLogger : BaseNLogLogger
    {
        public ConsoleLogger(string configFilePath ="nlog.config", string appenderName = "nlogConsoleAppender") : base(configFilePath, appenderName)
        {
            IsEnabled = true;
        }
    }
}