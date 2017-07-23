using System;
using System.IO;
using System.Threading.Tasks;

namespace QuickLogger.Log4Net
{
    public abstract class BaseLog4NetLogger : ILogEngine
    {
        private readonly log4net.ILog _logger;

        protected BaseLog4NetLogger(string filePath, string appenderName)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"There is not file at {filePath} ");


            log4net.GlobalContext.Properties["SolutionName"] = AppDomain.CurrentDomain.FriendlyName.Replace(":", "-");

            FileInfo configFileInfo = new FileInfo(filePath);
            log4net.Config.XmlConfigurator.ConfigureAndWatch(configFileInfo);

            _logger = log4net.LogManager.GetLogger(appenderName);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void DebugAsync(string message)
        {
            Task.Run(() => { Debug(message); });
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void InfoAsync(string message)
        {
            Task.Run(() => { Info(message); });
        }

        public void Warning(string message)
        {
            throw new NotImplementedException();
        }

        public void WarningAsync(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(Exception exception)
        {
            throw new NotImplementedException();
        }

        public void ErrorAsync(Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void ErrorAsync(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled { get; set; }
    }
}