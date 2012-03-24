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
        #region Kunden
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

        public static Kunde getKunde(int id)
        {
            return DALFactory.getDAL().getKunde(id);
        }
        #endregion

        #region Angebote
        public static List<Angebot> getAngebote()
        {
            return DALFactory.getDAL().getAngebotViewList();
        }

        public static void saveAngebot(Angebot a)
        {
            DALFactory.getDAL().saveAngebot(a);
        }

        public static void deleteAngebot(Angebot a)
        {
            DALFactory.getDAL().deleteAngebot(a);
        }
        #endregion

        #region Projekte
        public static List<Projekt> getProjekte()
        {
            return DALFactory.getDAL().getProjektViewList();
        }

        public static void saveProjekt(Projekt p)
        {
            DALFactory.getDAL().saveProjekt(p);
        }

        public static void deleteProjekt(Projekt p)
        {
            DALFactory.getDAL().deleteProjekt(p);
        }

        public static Projekt getProjekt(int id)
        {
            return DALFactory.getDAL().getProjekt(id);
        }
        #endregion
    }
}
