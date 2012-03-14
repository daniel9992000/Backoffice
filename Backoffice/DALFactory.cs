using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    class DALFactory
    {
        public static IDAL getDAL()
        {
            return new LocalDB(); 
        }

    }
}
