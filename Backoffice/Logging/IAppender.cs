using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice.Logging
{
    public interface IAppender
    {
        void Configure();
        void Write(Level level, string message, Exception ex);
    }
}
