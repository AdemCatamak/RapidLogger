using QuickLogger.NLogAdapter;

namespace QuickLogger.Log4NetAdapter
{
    public class FileLogger : BaseNLogLogger
    {
        public FileLogger(string configFilePath = "nlog.config", string appenderName = "nlogFileAppender") : base(configFilePath, appenderName)
        {
            IsEnabled = true;
        }
    }
}