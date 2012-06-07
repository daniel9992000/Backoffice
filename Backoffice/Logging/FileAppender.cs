using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Backoffice.Logging
{
    class FileAppender : IAppender
    {
        string filename; 

        public void Configure()
        {
            filename = "log.txt";
        }

        public void Write(Level level, string message, Exception ex)
        {
            using (StreamWriter sw = File.AppendText(filename))
            {
                sw.Write("{0}  {1} ", DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString());
                sw.Write("{0} - {1}", level.ToString(), message);
                if (ex != null)
                {
                    sw.WriteLine(" - {0}", ex.Message);
                }
            }
        }
    }
}
