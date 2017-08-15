using System;
using System.IO;
using System.Threading.Tasks;

namespace RapidLogger.Log4NetAdapter
{
    public abstract class BaseLog4NetLogger : ILogEngine
    {
        private readonly log4net.ILog _logger;

        public bool IsEnabled { get; set; }

        protected BaseLog4NetLogger(string filePath, string appenderName)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"There is not file at {filePath}");


            log4net.GlobalContext.Properties["SolutionName"] = AppDomain.CurrentDomain.FriendlyName.Replace(":", "-");

            FileInfo configFileInfo = new FileInfo(filePath);
            log4net.Config.XmlConfigurator.ConfigureAndWatch(configFileInfo);

            _logger = log4net.LogManager.GetLogger(appenderName);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Warning(string message)
        {
            _logger.Warn(message);
        }

        public void Error(Exception exception)
        {
            _logger.Error(exception);
        }

        public void Error(string message, Exception exception)
        {
            _logger.Error(message, exception);
        }


        public void Stop()
        {
            log4net.LogManager.Shutdown();
        }
    }
}