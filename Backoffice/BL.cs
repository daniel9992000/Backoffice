using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    public enum ObjectStates
    {
        New, Modified, Unmodified, Deleted
    }

    class BL
    {
        public static List<Kunde> getKunden()
        {
            return DALFactory.getDAL().getKundeViewList();
        }

        public static void saveKunde(Kunde k)
        {
            DALFactory.getDAL().saveKunde(k);
        }

        public static void deleteKunde(Kunde k)
        {
            DALFactory.getDAL().deleteKunde(k);
        }
    }
}
