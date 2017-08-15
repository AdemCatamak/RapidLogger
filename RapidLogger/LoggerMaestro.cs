using System;
using System.Collections.Generic;

namespace RapidLogger
{
    public class LoggerMaestro
    {
        private readonly Dictionary<string, ILogEngine> _loggers = new Dictionary<string, ILogEngine>();
        public IEnumerable<string> LoggerNames => _loggers.Keys;

        public void AddLogger(string loggerName, ILogEngine logger)
        {
            _loggers.Add(loggerName, logger);
        }

        public void RemoveLogger(string loggerName)
        {
            _loggers.Remove(loggerName);
        }


        public void ActivateLogger(string loggerName)
        {
            ILogEngine logger = _loggers[loggerName];
            logger.IsEnabled = true;

            _loggers.Remove(loggerName);
            _loggers.Add(loggerName, logger);
        }

        public void DeactivateLogger(string loggerName)
        {
            ILogEngine logger = _loggers[loggerName];
            logger.IsEnabled = false;

            _loggers.Remove(loggerName);
            _loggers.Add(loggerName, logger);
        }


        public void Debug(string message)
        {
            foreach (ILogEngine logger in _loggers.Values)
            {
                if (logger.IsEnabled)
                    logger.Debug(message);
            }
        }


        public void Info(string message)
        {
            foreach (ILogEngine logger in _loggers.Values)
            {
                if (logger.IsEnabled)
                    logger.Info(message);
            }
        }


        public void Warning(string message)
        {
            foreach (ILogEngine logger in _loggers.Values)
            {
                if (logger.IsEnabled)
                    logger.Warning(message);
            }
        }


        public void Error(string message, Exception exception)
        {
            foreach (ILogEngine logger in _loggers.Values)
            {
                if (logger.IsEnabled)
                    logger.Error(message, exception);
            }
        }

        public void Error(Exception exception)
        {
            foreach (ILogEngine logger in _loggers.Values)
            {
                if (logger.IsEnabled)
                    logger.Error(exception);
            }
        }
    }
}