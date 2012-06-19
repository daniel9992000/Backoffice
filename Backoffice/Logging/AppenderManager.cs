using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice.Logging
{
    public enum Level
    {
        ALL,
        TRACE, 
        DEBUG, 
        INFO, 
        WARN, 
        ERROR, 
        FATAL
    }
    public class AppenderManager
    {
        static List<IAppender> appenders = null;

        public static void Configure()
        {
            appenders = new List<IAppender>();
            foreach (var item in Properties.Settings.Default.Appenders)
            {
                Type t = Type.GetType("Backoffice.Logging." + item);
                IAppender app = (IAppender)Activator.CreateInstance(t);
                appenders.Add(app);
            }
        }

        public static void Write(Level level, string message, Exception ex)
        {
            Level loglevel = (Level)Enum.Parse(typeof(Level), Properties.Settings.Default.LogLevel);
            
            foreach (var item in appenders)
            {
                item.Configure();
                if (level >= loglevel)
                {
                    item.Write(level, message, ex);
                }
                
            }
        }
    }
}
