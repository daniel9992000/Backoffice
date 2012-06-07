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
                Logging.Logger.Info("Alle Kunden auslesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Kundendaten!", ex);
                throw new BLException("Kundendaten konnten nicht auslesen werden!");
            }
            return tmp;
        }

        public static List<Kunde> getKunden(string search)
        {
            List<Kunde> tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getKundeViewList(search);
                Logging.Logger.Info("Kunden mit Suchstring " + search + " auslesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Kundendaten mit Suchstring " + search + " konnten nicht auslesen werden!", ex);
                throw new BLException("Kundendaten konnten nicht auslesen werden!");
            }
            return tmp;
        }

        public static Kunde getKunde(int id)
        {
            Kunde tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getKunde(id);
                Logging.Logger.Info("Kunde mit ID " + id + " auslesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen vom Kunden mit ID " + id, ex);
                throw new BLException("Kunde konnte nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static void saveKunde(Kunde k)
        {
            try
            {
                DALFactory.getDAL().saveKunde(k);
                Logging.Logger.Info("Kunde mit ID " + k.Kundenid + " gespeichert!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Speicher des Kunden mit der ID " + k.Kundenid, ex);
                throw new BLException("Kunde konnte nicht gepspeichert werden!");
            }            
        }

        public static void deleteKunde(Kunde k)
        {
            try
            {
                if (DALFactory.getDAL().getAngebotViewList(k.Kundenid).Count > 0)
                {
                    Logging.Logger.Warn("Kunde mit ID " + k.Kundenid + " kann nicht gelöscht werden, da Angebote existieren, die zugeordnet sind!");
                    throw new BLException("Kunde kann nicht gelöscht werden, da ihm Angebote zugeordnet sind!");
                }
                else if (DALFactory.getDAL().getAusgangViewList(k.Kundenid).Count > 0)
                {
                    Logging.Logger.Warn("Kunde mit ID " + k.Kundenid + " kann nicht gelöscht werden, da Ausgangsrechnungen existieren, die zugeordnet sind!");
                    throw new BLException("Kunde kann nicht gelöscht werden, da ihm Ausgangsrechnungen zugeordnet sind!");
                }
                else
                {
                    DALFactory.getDAL().deleteKunde(k);
                    Logging.Logger.Info("Kunde mit ID " + k.Kundenid + " gelöscht!");
                }
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Löschen des Kunden mit der ID " + k.Kundenid, ex);
                throw new BLException("Kunde konnte nicht gelöscht werden!");
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
                Logging.Logger.Info("Alle Angebotsdaten auslesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Alle Angebotsdaten konnten nicht ausgelesen werden!", ex);
                throw new BLException("Angebotsdaten konnten nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static List<Angebot> getAngebote(string search)
        {
            List<Angebot> tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getAngebotViewList(search);
                Logging.Logger.Info("Angebote mit Suchbegriff " + search + " ausgelesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Angebote mit Suchbegriff " + search, ex);
                throw new BLException("Angebote konnten nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static List<Angebot> getAngebote(int kundenid)
        {
            List<Angebot> tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getAngebotViewList(kundenid);
                Logging.Logger.Info("Angebote mit KundenID " + kundenid + " ausgelesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Angebote mit KundenID " + kundenid + " konnten nicht ausgelesen werden!", ex);
                throw new BLException("Angebote konnten nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static List<Angebot> getAngeboteByProjektId(int projektid)
        {
            List<Angebot> tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getAngebotViewListByProjektId(projektid);
                Logging.Logger.Info("Angebote mit ProjektID " + projektid + " ausgelesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Angebote mit ProjektID " + projektid + " konnten nicht ausgelesen werden!", ex);
                throw new BLException("Angebote konnten nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static Angebot getAngebot(int angebotid)
        {
            Angebot tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getAngebot(angebotid);
                Logging.Logger.Info("Angebot mit ID " + angebotid + " ausgelesen!");
            }
            catch(DALException ex)
            {
                Logging.Logger.Error("Angebot mit ID " + angebotid + " konnte nicht ausgelesen werden!", ex);
                throw new BLException("Angebot konnte nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static Angebot getAngebotByProjektId(int projektid)
        {
            var tmp = new Angebot();

            try
            {
                tmp = DALFactory.getDAL().getAngebotByProjektId(projektid);
            }
            catch (DALException ex)
            {
                throw;
            }

            return tmp;
        }

        public static void saveAngebot(Angebot a)
        {
            try
            {
                if (a.Chance < 0 || a.Chance > 100)
                {
                    Logging.Logger.Warn("Wert von Chance außerhalb der Grenzen!");
                    throw new BLException("Angebot: Wert von Chance außerhalb der Grenzen!");
                }
                var tmpang = DALFactory.getDAL().getAngebot(a.Angebotid);
          
                if (!a.Projektid.HasValue)
                {
                    DALFactory.getDAL().saveAngebot(a);
                    Logging.Logger.Info("Angebot mit ID " + a.Angebotid + " gespeichert!");
                }
                else
                {
                    if (!tmpang.Projektid.HasValue)
                        tmpang.Projektid = a.Projektid;
                    if (DALFactory.getDAL().getAngebotViewListByProjektId(tmpang.Projektid.Value).Count <= 1 && a.Status == ObjectStates.Modified && tmpang.Projektid != a.Projektid)
                    {
                        Logging.Logger.Warn("Angebot mit ID " + a.Angebotid + " kann nicht gespeichert werden, da ein Projekt sonst kein Angebot hat");
                        throw new BLException("Angebot kann nicht gespeichert werden, da ein Projekt sonst kein Angebot hat!");
                    }
                    else
                    {
                        DALFactory.getDAL().saveAngebot(a);
                        Logging.Logger.Info("Angebot mit ID " + a.Angebotid + " gespeichert!");
                    }
                }
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Angebot mit ID " + a.Angebotid + " konnte nicht gespeichert werden!", ex);
                throw new BLException("Angebot konnte nicht gespeichert werden!");
            }            
        }

        public static void deleteAngebot(Angebot a)
        {
            var tmp = new List<Angebot>();
            try
            {
                if (a.Projektid != null)
                {
                    tmp = DALFactory.getDAL().getAngebotViewListByProjektId(a.Projektid.Value);
                }                

                if (tmp.Count == 1)
                {
                    Logging.Logger.Warn("Angebot mit ID " + a.Angebotid + " kann nicht gelöscht werden, da das Projekt mit ID " + a.Projektid.Value + " sonst kein Angebot zugeordnet hat!");
                    throw new BLException("Angebot kann nicht gelöscht werden, da das Projekt " + DALFactory.getDAL().getProjekt(a.Projektid.Value).Name + " sonst kein Angebot mehr zugeordnet hat!");
                }
                else
                {
                    DALFactory.getDAL().deleteAngebot(a);
                    Logging.Logger.Info("Angebot mit ID " + a.Angebotid + " gelöscht!");
                }
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Angebot mit ID " + a.Angebotid + " konnte nicht gelöscht werden!", ex);
                throw new BLException("Angebot konnte nicht gelöscht werden!");
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
                Logging.Logger.Info("Alle Projekte ausgelesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Alle Projekte konnten nicht ausgelesen werden!", ex);
                throw new BLException("Projekte konnten nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static List<Projekt> getProjekte(string search)
        {
            List<Projekt> tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getProjektViewList(search);
                Logging.Logger.Info("Projekte mit Suchbegriff " + search + " ausgelesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Projekte mit Suchbegriff " + search + " konnten nicht ausgelesen werden!", ex);
                throw new BLException("Projekte konnten nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static List<Projekt> getProjekte(int kundenid)
        {
            var projekte = new List<Projekt>();

            if (kundenid != 0)
            {
                var angebote = DALFactory.getDAL().getAngebotViewList(kundenid);
                foreach (var item in angebote)
                {
                    int? pid = 0;
                    if (item.Projektid.HasValue)
                         pid = item.Projektid;
                    bool exist = false;
                    foreach (var p in projekte)
                    {
                        if (pid.Value == p.Projektid)
                        {
                            exist = true;
                            break;
                        }
                    }

                    if (!exist)
                    {
                        if (pid != null)
                        {
                            projekte.Add(BL.getProjekt(pid.Value));
                        }
                    }
                }
            }

            return projekte;
        }

        public static void saveProjekt(Projekt p)
        {
            try
            {                
                DALFactory.getDAL().saveProjekt(p);
                Logging.Logger.Info("Projekt mit ID " + p.Projektid + " gespeichert!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Projekt mit ID " + p.Projektid + " konnte nicht gespeichert!", ex);
                throw new BLException("Projekt konnte nicht gespeichert werden!");
            }
        }

        public static void deleteProjekt(Projekt p)
        {
            try
            {
                if (DALFactory.getDAL().getAusgangViewListByProjektId(p.Projektid).Count > 0)
                {
                    Logging.Logger.Warn("Projekt kann nicht gelöscht werden, da diesem Ausgangsrechnungen zugeordnet sind!");
                    throw new BLException("Projekt kann nicht gelöscht werden, da diesem noch Ausgangsrechnungen zugeordnet sind!");
                }
                else
                {
                    DALFactory.getDAL().deleteProjekt(p);
                    Logging.Logger.Info("Projekt mit ID " + p.Projektid + " gelöscht!");
                }
                
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Projekt mit ID " + p.Projektid + " konnte nicht gelöscht!", ex);
                throw new BLException("Projekt konnte nicht gelöscht werden!");
            }
        }

        public static Projekt getProjekt(int id)
        {
            Projekt tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getProjekt(id);
                Logging.Logger.Info("Projekt mit ID " + id + " ausgelesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Projekt mit ID " + id + " konnte nicht ausgelesen werden!", ex);
                throw new BLException("Projekt konnte nicht ausgelesen werden!");
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
                Logging.Logger.Info("Alle Kontaktdaten ausgelesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Kontaktdaten!", ex);
                throw new BLException("Kontaktdaten konnten nicht auslesen werden!");
            }
            return tmp;
        }

        public static List<Kontakt> getKontakte(string search)
        {
            List<Kontakt> tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getKontaktViewList(search);
                Logging.Logger.Info("Kontakte mit Suchbegriff " + search + " ausgelesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Kontaktdaten mit Suchbegriff " + search + "!", ex);
                throw new BLException("Kontaktdaten konnten nicht auslesen werden!");
            }
            return tmp;
        }

        public static void saveKontakt(Kontakt k)
        {
            try
            {
                DALFactory.getDAL().saveKontakt(k);
                Logging.Logger.Info("Kontakt mit ID " + k.Kontaktid + " gespeichert!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Kontakt mit ID " + k.Kontaktid + " konnte nicht gespeichert werden!", ex);
                throw new BLException("Kontakt konnte nicht gespeichert werden!");
            }
        }

        public static void deleteKontakt(Kontakt k)
        {
            try
            {
                if (DALFactory.getDAL().getEingangViewList(k.Kontaktid).Count > 0)
                {
                    Logging.Logger.Warn("Kontakt mit ID " + k.Kontaktid + " kann nicht gelöscht werden, da Eingangsrechnungen existieren, die zugeordnet sind!");
                    throw new BLException("Kontakt kann nicht gelöscht werden, da ihm Eingangsrechungen zugeordnet sind!");
                }
                else
                {
                    DALFactory.getDAL().deleteKontakt(k);
                    Logging.Logger.Info("Kontakt mit ID " + k.Kontaktid + " gelöscht!");
                }
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Kontakt mit ID " + k.Kontaktid + " konnte nicht gelöscht werden!", ex);
                throw new BLException("Kontakt konnte nicht gelöscht werden!");
            }
        }

       
        #endregion

        #region Rechungen
        public static List<Rechnung> getRechnungen()
        {
            List<Rechnung> tmp = new List<Rechnung>();
            try
            {
                foreach (var item in DALFactory.getDAL().getAusgangViewList())
                {
                    tmp.Add(item);
                }

                foreach (var item in DALFactory.getDAL().getEingangViewList())
                {
                    tmp.Add(item);
                }
                Logging.Logger.Info("Alle Rechnungen ausgelesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen aller Rechnungen!", ex);
                throw new BLException("Rechnungen konnten nicht ausgelesen werden!");
            }

            return tmp;
        }

        public static Rechnung getRechnung(int rechnungsid)
        {
            Rechnung tmp = null;
            try
            {
                tmp = DALFactory.getDAL().getRechung(rechnungsid);
                Logging.Logger.Info("Rechnung mit ID " + rechnungsid + " ausgelesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Rechung mit ID " + rechnungsid, ex);
                throw new BLException("Rechnung konnte nicht ausgelesen werden!");
            }

            return tmp;
        }
        #endregion

        #region Ausgangsrechnungen
        public static void saveAusgang(Ausgang r)
        {            
            try
            {
                DALFactory.getDAL().saveAusgang(r);
                Logging.Logger.Info("Ausgangsrechnung mit ID " + r.Rechnungid + " gespeichert!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Speichern der Ausgangsrechnung mit ID " + r.Rechnungid, ex);
                throw new BLException("Ausgangsrechnung konnte nicht gespeichert werden!");
            }
        }

        public static void deleteAusgang(Ausgang r)
        {            
            try
            {
                DALFactory.getDAL().deleteAusgang(r);
                Logging.Logger.Info("Ausgangsrechnung mit ID " + r.Rechnungid + " gelöscht!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Löschen der Ausgangsrechnung mit ID " + r.Rechnungid, ex);
                throw new BLException("Ausgangsrechnung konnte nicht gelöscht werden!");
            }
        }

        public static List<Ausgang> getAusgaenge()
        {
            var tmp = new List<Ausgang>();
            try
            {
                tmp = DALFactory.getDAL().getAusgangViewList();
                Logging.Logger.Info("Alle Ausgangsrechnungen ausgelesen!");
            }
            catch (BLException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Ausgangsrechnungen", ex);
                throw new BLException("Ausgangsrechnungen konnten nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static List<Ausgang> getAusgaenge(string search)
        {
            var tmp = new List<Ausgang>();
            try
            {
                tmp = DALFactory.getDAL().getAusgangViewList(search);
                Logging.Logger.Info("Ausgangsrechnungen mit Suchbegriff " + search + " ausgelesen!");
            }
            catch (BLException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Ausgangsrechnungen mit Suchbegriff " + search, ex);
                throw new BLException("Ausgangsrechnungen konnten nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static List<Ausgang> getAusgaenge(int kundenid)
        {
            var tmp = new List<Ausgang>();
            try
            {
                tmp = DALFactory.getDAL().getAusgangViewList(kundenid);
                Logging.Logger.Info("Ausgangsrechnungen mit Kunden ID " + kundenid + " ausgelesen!");
            }
            catch (BLException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Ausgangsrechnungen mit Kunden ID " + kundenid, ex);
                throw new BLException("Ausgangsrechnungen konnten nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static List<Ausgang> getAusgaengeByProjektId(int projektid)
        {
            var tmp = new List<Ausgang>();
            try
            {
                tmp = DALFactory.getDAL().getAusgangViewList(projektid);
                Logging.Logger.Info("Ausgangsrechnungen mit Projekt ID " + projektid + " ausgelesen!");
            }
            catch (BLException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Ausgangsrechnungen mit Projekt ID " + projektid, ex);
                throw new BLException("Ausgangsrechnungen konnten nicht ausgelesen werden!");
            }
            return tmp;
        }
        #endregion

        #region Eingangsrechnungen
        public static void saveEingang(Eingang r)
        {            
            try
            {
                DALFactory.getDAL().saveEingang(r);
                Logging.Logger.Info("Eingangsrechnung mit ID " + r.Rechnungid + " gespeichert!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Speichern der Eingangsrechnung mit ID " + r.Rechnungid, ex);
                throw new BLException("Eingangsrechnung konnte nicht gespeichert werden!");
            }
        }

        public static void deleteEingang(Eingang r)
        {            
            try
            {
                DALFactory.getDAL().deleteEingang(r);
                Logging.Logger.Info("Eingangsrechnung mit ID " + r.Rechnungid + " gelöscht!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Löschen der Eingangsrechnung mit ID " + r.Rechnungid, ex);
                throw new BLException("Eingangsrechnung konnte nicht gelöscht werden!");
            }
        }

        public static List<Eingang> getEingaenge()
        {
            var tmp = new List<Eingang>();
            try
            {
                tmp = DALFactory.getDAL().getEingangViewList();
                Logging.Logger.Info("Alle Eingangsrechnungen ausgelesen!");
            }
            catch (BLException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Eingangsrechnungen", ex);
                throw new BLException("Eingangsrechnungen konnten nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static List<Eingang> getEingaenge(string search)
        {
            var tmp = new List<Eingang>();
            try
            {
                tmp = DALFactory.getDAL().getEingangViewList(search);
                Logging.Logger.Info("Alle Eingangsrechnungen mit Suchbegriff " + search + " ausgelesen!");
            }
            catch (BLException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Eingangsrechnungen mit Suchbegriff " + search, ex);
                throw new BLException("Eingangsrechnungen konnten nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static List<Eingang> getEingaenge(int kontaktid)
        {
            var tmp = new List<Eingang>();
            try
            {
                tmp = DALFactory.getDAL().getEingangViewList(kontaktid);
                Logging.Logger.Info("Alle Eingangsrechnungen mit Kontakt ID " + kontaktid + " ausgelesen!");
            }
            catch (BLException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Eingangsrechnungen mit Kontakt ID " + kontaktid, ex);
                throw new BLException("Eingangsrechnungen konnten nicht ausgelesen werden!");
            }
            return tmp;
        }
        #endregion

        #region Rechnungszeilen
        public static List<Rechnungszeile> getRechnungszeilen(int rechnungid)
        {
            List<Rechnungszeile> tmp = new List<Rechnungszeile>();
            try
            {
                tmp = DALFactory.getDAL().getRechnungszeilenViewList(rechnungid);
                Logging.Logger.Info("Rechungszeilen der Rechnung mit ID " + rechnungid + " ausgelesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Rechnungszeilen der Rechnung mit ID " + rechnungid + "!", ex);
                throw new BLException("Rechungszeilen konnten nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static void saveRechnungszeile(Rechnungszeile r)
        {
            try
            {
                DALFactory.getDAL().saveRechnungszeile(r);
                Logging.Logger.Info("Rechnungszeile mit ID " + r.Reid + " gespeichert!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Speichern der Rechnungszeile mit ID " + r.Reid, ex);
                throw new BLException("Rechnungszeile konnte nicht gespeichert werden!");
            }
           
        }

        public static void deleteRechnungszeile(Rechnungszeile r)
        {
            try
            {
                DALFactory.getDAL().deleteRechnungszeile(r);
                Logging.Logger.Info("Rechnungszeile mit ID " + r.Reid + " gelöscht!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Löschen der Rechnungszeile mit ID " + r.Reid, ex);
                throw new BLException("Rechnungszeile konnte nicht gelöscht werden!");
            }
            
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

        public static List<Buchungskategorie> getBuchungsKategorie()
        {
            return DALFactory.getDAL().getBuchungsKategorien();
        }

        public static Buchungskategorie getBuchungsKategorie(int id)
        {
            return DALFactory.getDAL().getBuchungsKategorie(id);
        }
        #endregion

        #region Auswertungen

        public static double getRechnungssumme(int rechnungid)
        {
            return DALFactory.getDAL().getRechnungssumme(rechnungid);
        }

        public static double getOffeneSumme(int rechnungsid)
        {
            double rsum = 0, bsum = 0;
            var buchungen = new List<Buchung>();
            buchungen = DALFactory.getDAL().getBuchungViewList(rechnungsid);
            rsum = DALFactory.getDAL().getRechnungssumme(rechnungsid);
            foreach (var item in buchungen)
            {
                bsum += item.Betrag;
            }

            return (rsum - bsum);
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
            var tmp = new List<Stunden>();
            try
            {
                tmp = DALFactory.getDAL().getStundenViewList(projektname);
                Logging.Logger.Info("Alle Stunden vom Projekt " + projektname + " ausgelesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Stunden vom Projekt " + projektname, ex);
                throw new BLException("Stunden konnten nicht ausgelesen werden!");
            }
            return tmp;
        }

        public static void saveStunde(Stunden s)
        {
            try
            {
                DALFactory.getDAL().saveStunden(s);
                Logging.Logger.Info("Stunden für Projekt " + s.Projektname + " gespeichert!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Speichern der Stunden für Projekt " + s.Projektname, ex);
                throw new BLException("Stunden konnten nicht gespeichert werden!");
            }
            
        }

        public static int getProjektStunden(string projektname)
        {
            int tmp = 0;
            try
            {
                tmp = DALFactory.getDAL().getProjektStunden(projektname);
                Logging.Logger.Info("Stundden für Projekt " + projektname + " ausgelesen!");
            }
            catch (DALException ex)
            {
                Logging.Logger.Error("Fehler beim Auslesen der Stunden für Projekt " + projektname, ex);
                throw new BLException("Stunden konnten nicht ausgelesen werden!");
            }
            return tmp;
        }
        #endregion
    }
}
