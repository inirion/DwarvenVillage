using System;
using System.Collections.Generic;
using System.Text;

namespace DwarvenVillage.Utils.Loggers
{
    class Logger
    {
        public static ILogger logger = null;

        public static string WriteLog(string message)
        {
            if (logger != null)
                return logger.WriteLog(message);
            else
            {
                string err = "Error in WriteLog method, logger object not initialized";
                Console.WriteLine(err);
                return err;
            }
                
        }
    }
}
