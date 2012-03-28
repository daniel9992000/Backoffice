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
            List<Kunde> tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getKundeViewList();
            }
            catch (DALException ex)
            {
                
            }
            return tmp;
        }

        public static void saveKunde(Kunde k)
        {
            try
            {
                DALFactory.getDAL().saveKunde(k);
            }
            catch (DALException ex)
            {
                
            }            
        }

        public static void deleteKunde(Kunde k)
        {
            try
            {
                DALFactory.getDAL().deleteKunde(k);
            }
            catch (DALException ex)
            {

            }            
        }

        public static Kunde getKunde(int id)
        {
            Kunde tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getKunde(id);
            }
            catch (DALException ex)
            {
                
            }
            return tmp;
        }
        #endregion

        #region Angebote
        public static List<Angebot> getAngebote()
        {
            List<Angebot> tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getAngebotViewList();
            }
            catch (DALException ex)
            {

            }
            return tmp;
        }

        public static List<Angebot> getKundenAngebote(int kundenid)
        {
            List<Angebot> tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getKundenAngebote(kundenid);
            }
            catch (DALException ex)
            {
               
            }
            return tmp;
        }

        public static void saveAngebot(Angebot a)
        {
            try
            {  
                DALFactory.getDAL().saveAngebot(a);
            }
            catch (DALException ex)
            {
                
            }            
        }

        public static void deleteAngebot(Angebot a)
        {
            try
            {
                DALFactory.getDAL().deleteAngebot(a);
            }
            catch (DALException ex)
            {

            }            
        }        
        #endregion

        #region Projekte
        public static List<Projekt> getProjekte()
        {
            List<Projekt> tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getProjektViewList();
            }
            catch (DALException ex)
            {
                
            }
            return tmp;
        }

        public static void saveProjekt(Projekt p)
        {
            try
            {                
                DALFactory.getDAL().saveProjekt(p);
            }
            catch (DALException ex)
            {
               
            }
        }

        public static void deleteProjekt(Projekt p)
        {
            try
            {
                DALFactory.getDAL().deleteProjekt(p);
            }
            catch (DALException ex)
            {

            }
        }

        public static Projekt getProjekt(int id)
        {
            Projekt tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getProjekt(id);
            }
            catch (DALException ex)
            {
                
            }
            return tmp;
        }
        #endregion

        #region Kontakte
        public static List<Kontakt> getKontakte()
        {
            List<Kontakt> tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getKontaktViewList();
            }
            catch (DALException ex)
            {

            }
            return tmp;
        }

        public static void saveKontakt(Kontakt k)
        {
            try
            {
                DALFactory.getDAL().saveKontakt(k);
            }
            catch (DALException ex)
            {

            }
        }

        public static void deleteKontakt(Kontakt k)
        {
            try
            {
                DALFactory.getDAL().deleteKontakt(k);
            }
            catch (DALException ex)
            {

            }
        }

       
        #endregion
    }
}
