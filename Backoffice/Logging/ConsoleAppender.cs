using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice.Logging
{
    class ConsoleAppender : IAppender
    {
        public void Configure()
        {

        }

        public void Write(Level level, string message, Exception ex)
        {
            Console.Write("{0}  {1} ", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
            Console.Write("{0} - {1}", level.ToString(), message);
            if (ex != null)
            {
                Console.WriteLine(" - {0}", ex.Message);
            }
        }
    }
}
