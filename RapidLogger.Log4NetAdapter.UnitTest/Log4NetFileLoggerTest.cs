using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RapidLogger.Log4NetAdapter.UnitTest
{
    [TestClass]
    public class BaseLog4NetTest
    {
        private readonly string _loggerDirectory = $"C:\\Logger\\{AppDomain.CurrentDomain.FriendlyName.Replace(":", "-")}";
        private readonly string filePath = "log4net.config";

        private BaseLog4NetLogger _logWrapper;

        [TestCleanup]
        public void QuickLogger_Log4NetAdapter_UnitTest__BaseLog4NetTest__Cleanup()
        {
            _logWrapper?.Stop();
            if (Directory.Exists(_loggerDirectory))
            {
                Directory.Delete(_loggerDirectory, true);
            }
        }

        [TestMethod]
        public void QuickLogger_Log4NetAdapter_UnitTest__BaseLog4NetTest__Debug()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     _logWrapper = new FileLogger(filePath);
                                     _logWrapper.Debug("Some Info");
                                     _logWrapper.Stop();
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4NetAdapter_UnitTest__BaseLog4NetTest__DebugAsync()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     _logWrapper = new FileLogger(filePath);
                                     _logWrapper.DebugAsync("Some Info");
                                     Thread.Sleep(1000);
                                     _logWrapper.Stop();
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }


        [TestMethod]
        public void QuickLogger_Log4NetAdapter_UnitTest__BaseLog4NetTest__Info()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     _logWrapper = new FileLogger(filePath);
                                     _logWrapper.Info("Some Info");
                                     _logWrapper.Stop();
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4NetAdapter_UnitTest__BaseLog4NetTest__InfoAsync()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     _logWrapper = new FileLogger(filePath);
                                     _logWrapper.InfoAsync("Some Info");
                                     Thread.Sleep(1000);
                                     _logWrapper.Stop();
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4NetAdapter_UnitTest__BaseLog4NetTest__Error_Exception()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     _logWrapper = new FileLogger(filePath);
                                     _logWrapper.Error(new Exception("Test exception"));
                                     _logWrapper.Stop();
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4NetAdapter_UnitTest__BaseLog4NetTest__ErrorAsync_Exception()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     _logWrapper = new FileLogger(filePath);
                                     _logWrapper.ErrorAsync(new Exception("Test exception"));
                                     Thread.Sleep(1000);
                                     _logWrapper.Stop();
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4NetAdapter_UnitTest__BaseLog4NetTest__Error()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     _logWrapper = new FileLogger(filePath);
                                     _logWrapper.Error("Some Info", new Exception("Test exception"));
                                     _logWrapper.Stop();
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4NetAdapter_UnitTest__BaseLog4NetTest__ErrorAsync()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     _logWrapper = new FileLogger(filePath);
                                     _logWrapper.ErrorAsync("Some Info", new Exception("Test exception"));
                                     Thread.Sleep(1000);
                                     _logWrapper.Stop();
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4NetAdapter_UnitTest__BaseLog4NetTest__Error_NullParameterForException()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     _logWrapper = new FileLogger(filePath);
                                     _logWrapper.Error("Some Info", null);
                                     _logWrapper.Stop();
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4NetAdapter_UnitTest__BaseLog4NetTest__ErrorAsync_NullParameterForException()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     _logWrapper = new FileLogger(filePath);
                                     _logWrapper.ErrorAsync("Some Info", null);
                                     Thread.Sleep(1000);
                                     _logWrapper.Stop();
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }
    }
}