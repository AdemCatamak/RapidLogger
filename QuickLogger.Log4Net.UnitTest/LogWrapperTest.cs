using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuickLogger.Log4Net.UnitTest
{
    [TestClass]
    public class BaseLog4NetTest
    {
        private readonly string _loggerDirectory = $"C:\\Logger\\{AppDomain.CurrentDomain.FriendlyName.Replace(":", "-")}";

        private readonly string filePath = "log4net.config";

        [TestCleanup]
        public void QuickLogger_Log4Net_UnitTest__BaseLog4NetTest__Cleanup()
        {
            if (Directory.Exists(_loggerDirectory))
            {
                Directory.Delete(_loggerDirectory, true);
            }
        }

        [TestMethod]
        public void QuickLogger_Log4Net_UnitTest__BaseLog4NetTest__Debug()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     BaseLog4NetLogger wraper = new FileLogger(filePath);
                                     wraper.Debug("Some Info");
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4Net_UnitTest__BaseLog4NetTest__DebugAsync()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     BaseLog4NetLogger wraper = new FileLogger(filePath);
                                     wraper.DebugAsync("Some Info");
                                 });
            task.Start();
            task.Wait();

            // Async debug işlemi sebebiyle test sonucu yanlış çıkabilir.
            // Thread işlemini bir saniye bekletmek Log işleminin tamamlanması için yeterli olmayabilir.
            Thread.Sleep(1000);

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }


        [TestMethod]
        public void QuickLogger_Log4Net_UnitTest__BaseLog4NetTest__Info()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     BaseLog4NetLogger wraper = new FileLogger(filePath);
                                     wraper.Info("Some Info");
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4Net_UnitTest__BaseLog4NetTest__InfoAsync()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     BaseLog4NetLogger wraper = new FileLogger(filePath);
                                     wraper.InfoAsync("Some Info");
                                 });
            task.Start();
            task.Wait();

            // Async info işlemi sebebiyle test sonucu yanlış çıkabilir.
            // Thread işlemini bir saniye bekletmek Log işleminin tamamlanması için yeterli olmayabilir.
            Thread.Sleep(1000);

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4Net_UnitTest__BaseLog4NetTest__Error_Exception()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     BaseLog4NetLogger wraper = new FileLogger(filePath);
                                     wraper.Error(new Exception("Test exception"));
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4Net_UnitTest__BaseLog4NetTest__ErrorAsync_Exception()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     BaseLog4NetLogger wraper = new FileLogger(filePath);
                                     wraper.ErrorAsync(new Exception("Test exception"));
                                 });
            task.Start();
            task.Wait();

            // Async error işlemi sebebiyle test sonucu yanlış çıkabilir.
            // Thread işlemini bir saniye bekletmek Log işleminin tamamlanması için yeterli olmayabilir.
            Thread.Sleep(1000);

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4Net_UnitTest__BaseLog4NetTest__Error()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     BaseLog4NetLogger wraper = new FileLogger(filePath);
                                     wraper.Error("Some Info", new Exception("Test exception"));
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4Net_UnitTest__BaseLog4NetTest__ErrorAsync()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     BaseLog4NetLogger wraper = new FileLogger(filePath);
                                     wraper.ErrorAsync("Some Info", new Exception("Test exception"));
                                 });
            task.Start();
            task.Wait();

            // Async error işlemi sebebiyle test sonucu yanlış çıkabilir.
            // Thread işlemini bir saniye bekletmek Log işleminin tamamlanması için yeterli olmayabilir.
            Thread.Sleep(1000);

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4Net_UnitTest__BaseLog4NetTest__Error_NullParameterForException()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     BaseLog4NetLogger wraper = new FileLogger(filePath);
                                     wraper.Error("Some Info", null);
                                 });
            task.Start();
            task.Wait();

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }

        [TestMethod]
        public void QuickLogger_Log4Net_UnitTest__BaseLog4NetTest__ErrorAsync_NullParameterForException()
        {
            // Act
            Task task = new Task(() =>
                                 {
                                     BaseLog4NetLogger wraper = new FileLogger(filePath);
                                     wraper.ErrorAsync("Some Info", null);
                                 });
            task.Start();
            task.Wait();

            // Async error işlemi sebebiyle test sonucu yanlış çıkabilir.
            // Thread işlemini bir saniye bekletmek Log işleminin tamamlanması için yeterli olmayabilir.
            Thread.Sleep(1000);

            // Assert
            string logFileName = DateTime.Now.ToString("yyyy-MM-dd") + ".log";
            string logFilePath = $"{_loggerDirectory}\\{logFileName}";
            Assert.IsTrue(File.Exists(logFilePath));
        }
    }
}