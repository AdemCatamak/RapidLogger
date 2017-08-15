using System;
using System.IO;
using System.Threading.Tasks;

namespace RapidLogger.NLogAdapter
{
    public abstract class BaseNLogLogger : ILogEngine
    {
        private readonly NLog.ILogger _logger;
        public bool IsEnabled { get; set; }

        protected BaseNLogLogger(string filePath, string appenderName)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"There is not file at {filePath}");

            string solutionName = AppDomain.CurrentDomain.FriendlyName.Replace(":", "-");
            NLog.GlobalDiagnosticsContext.Set("SolutionName", solutionName);

            FileInfo configFileInfo = new FileInfo(filePath);
            NLog.LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration(filePath, true);

            _logger = NLog.LogManager.GetLogger(appenderName);
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
            _logger.Error(exception, message);
        }

        public void Stop()
        {
            NLog.LogManager.Shutdown();
        }
    }
}