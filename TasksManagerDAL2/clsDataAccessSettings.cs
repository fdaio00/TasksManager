using System;
using System.Diagnostics;
using System.IO;

namespace TasksManagerDAL2
{
    public static class clsDataAccessSettings
    {

        public static string ConnectionString = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TasksManagerDB.db")}";
        //public static string ConnectionString = @"Data Source=C:\Users\Fedaa\source\repos\TasksManager\TasksManagerDB.db";

        static public void SetErrorLoggingEvent(string exMessage, string sourceName = "Tasks Manager")
        {

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");

            }
            EventLog.WriteEntry(sourceName, exMessage, EventLogEntryType.Error);
        }



        public static void LogError(string message)
        {
                string _logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

            try
            {
                File.AppendAllText(_logFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}");
            }
            catch (Exception)
            {
                // Handle logging error if necessary
            }
        }

    }
}
