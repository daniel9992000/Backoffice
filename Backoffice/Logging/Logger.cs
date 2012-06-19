using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice.Logging
{
    public class Logger
    {
        public static void Trace(Object message)
        {
            AppenderManager.Configure();
            AppenderManager.Write(Level.TRACE, message.ToString(), null);
        }

        public static void Debug(Object message)
        {
            AppenderManager.Configure();
            AppenderManager.Write(Level.DEBUG, message.ToString(), null);
        }

        public static void Info(Object message)
        {
            AppenderManager.Configure();
            AppenderManager.Write(Level.INFO, message.ToString(), null);
        }

        public static void Warn(Object message)
        {
            AppenderManager.Configure();
            AppenderManager.Write(Level.WARN, message.ToString(), null);
        }

        public static void Warn(Object message, Exception ex)
        {
            AppenderManager.Configure();
            AppenderManager.Write(Level.WARN, message.ToString(), ex);
        }

        public static void Error(Object message, Exception ex)
        {
            AppenderManager.Configure();
            AppenderManager.Write(Level.ERROR, message.ToString(), ex);
        }

        public static void Fatal(Object message, Exception ex)
        {
            AppenderManager.Configure();
            AppenderManager.Write(Level.FATAL, message.ToString(), ex);
        }
    }
}
