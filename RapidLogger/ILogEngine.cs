using System;

namespace RapidLogger
{
    public interface ILogEngine
    {
        bool IsEnabled { get; set; }

        void Debug(string message);

        void Info(string message);

        void Warning(string message);

        void Error(Exception exception);

        void Error(string message, Exception exception);
    }
}