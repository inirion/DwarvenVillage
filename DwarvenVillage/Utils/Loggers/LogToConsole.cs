using System;

namespace DwarvenVillage.Utils.Loggers
{
    class LogToConsole : ILogger
    {
        public string WriteLog(string message)
        {
            Console.WriteLine(message);
            return message;
        }
    }
}
