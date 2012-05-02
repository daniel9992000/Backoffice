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

    public class BL
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

        public static List<Angebot> getAngebote(int kundenid)
        {
            List<Angebot> tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getAngebotViewList(kundenid);
            }
            catch (DALException ex)
            {
               
            }
            return tmp;
        }

        public static List<Angebot> getAngeboteByProjektId(int projektid)
        {
            List<Angebot> tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getAngebotViewListByProjektId(projektid);
            }
            catch (DALException ex)
            {

            }
            return tmp;
        }

        public static Angebot getAngebot(int angebotid)
        {
            return DALFactory.getDAL().getAngebot(angebotid);
        }

        public static void saveAngebot(Angebot a)
        {
            if (a.Chance < 0 || a.Chance > 100)
            {
                throw new Exception("Angebot: Wert von Chance außerhalb der Grenzen!");
            }

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

        #region Ausgangsrechnungen
        public static void saveAusgang(Ausgang r)
        {
            DALFactory.getDAL().saveAusgang(r);
        }

        public static void deleteAusgang(Ausgang r)
        {
            DALFactory.getDAL().deleteAusgang(r);
        }

        public static List<Ausgang> getAusgaenge()
        {
            return DALFactory.getDAL().getAusgangViewList();
        }

        public static List<Ausgang> getAusgaenge(int kundenid)
        {
            return DALFactory.getDAL().getAusgangViewList(kundenid);
        }

        public static List<Ausgang> getAusgaengeByProjektId(int projektid)
        {
            return DALFactory.getDAL().getAusgangViewList(projektid);
        }
        #endregion

        #region Eingangsrechnungen
        public static void saveEingang(Eingang r)
        {
            DALFactory.getDAL().saveEingang(r);
        }

        public static void deleteEingang(Eingang r)
        {
            DALFactory.getDAL().deleteEingang(r);
        }

        public static List<Eingang> getEingaenge()
        {
            return DALFactory.getDAL().getEingangViewList();
        }

        public static List<Eingang> getEingaenge(int kontaktid)
        {
            return DALFactory.getDAL().getEingangViewList(kontaktid);
        }
        #endregion

        #region Rechnungszeilen
        public static List<Rechnungszeile> getRechnungszeilen(int rechnungid)
        {
            return DALFactory.getDAL().getRechnungszeilenViewList(rechnungid);
        }

        public static void saveRechnungszeile(Rechnungszeile r)
        {
            DALFactory.getDAL().saveRechnungszeile(r);
        }

        public static void deleteRechnungszeile(Rechnungszeile r)
        {
            DALFactory.getDAL().deleteRechnungszeile(r);
        }
        #endregion

        #region Buchung
        public static List<Buchung> getBuchungen()
        {
            return DALFactory.getDAL().getBuchungViewList();
        }

        public static List<Buchung> getBuchungen(int rechnungsid)
        {
            return DALFactory.getDAL().getBuchungViewList(rechnungsid);
        }

        public static void saveBuchung(Buchung b)
        {
            DALFactory.getDAL().saveBuchung(b);
        }

        public static void deleteBuchung(Buchung b)
        {
            DALFactory.getDAL().deleteBuchung(b);
        }
        #endregion

        #region Auswertungen

        public static double getRechnungssumme(int rechnungid)
        {
            return DALFactory.getDAL().getRechnungssumme(rechnungid);
        }

        public static List<Angebot> getJahresumsatzangebote()
        {
            return DALFactory.getDAL().getJahresumsatzViewList();
        }

        public static double[] getIstJahresumsatz()
        {
            return DALFactory.getDAL().getIstJahresumsatz();
        }

        public static List<Ausgang> getMonatsEinnahmen(int month, int year)
        {
            return DALFactory.getDAL().getEinnahmen(month, year);
        }

        public static List<Eingang> getMonatsAusgaben(int month, int year)
        {
            return DALFactory.getDAL().getAusgaben(month, year);
        }

        public static List<Angebot> getOffeneProjekte()
        {
            return DALFactory.getDAL().getAngebote();
        }

        public static List<Eingang> getoffeneEingangsRechnungen()
        {
            return DALFactory.getDAL().getOffeneERechnungen();
        }

        public static List<Ausgang> getoffeneAusgangsRechnungen()
        {
            return DALFactory.getDAL().getOffeneARechnungen();
        }
        #endregion

        #region Stunden
        public static List<Stunden> getStunden(string projektname)
        {
            return DALFactory.getDAL().getStundenViewList(projektname);
        }

        public static void saveStunde(Stunden s)
        {
            DALFactory.getDAL().saveStunden(s);
        }

        public static int getProjektStunden(string projektname)
        {
            return DALFactory.getDAL().getProjektStunden(projektname);
        }
        #endregion
    }
}
