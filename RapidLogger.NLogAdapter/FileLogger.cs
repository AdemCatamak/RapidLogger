namespace RapidLogger.NLogAdapter
{
    public class FileLogger : BaseNLogLogger
    {
        public FileLogger(string configFilePath = "nlog.config", string appenderName = "nlogFileAppender") : base(configFilePath, appenderName)
        {
            IsEnabled = true;
        }
    }
}