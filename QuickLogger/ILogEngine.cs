using System;

namespace QuickLogger
{
    public interface ILogEngine
    {
        bool IsEnabled { get; set; }

        void Debug(string message);
        void DebugAsync(string message);

        void Info(string message);
        void InfoAsync(string message);

        void Warning(string message);
        void WarningAsync(string message);

        void Error(Exception exception);
        void ErrorAsync(Exception exception);

        void Error(string message, Exception exception);
        void ErrorAsync(string message, Exception exception);
    }
}