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
            string datasource = Properties.Settings.Default.DataSource;

            if(datasource.Equals("Mock"))
                return Mockdb.Instance;
            else if(datasource.Equals("Postgres"))
                return new LocalDB();
            else return Mockdb.Instance;
        }

    }
}
