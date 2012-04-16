using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice
{
    class Mockdb : IDAL
    {
        List<Kunde> kunden;
        List<Projekt> projekte;
        List<Angebot> angebote;
        List<Kontakt> kontakte;
        List<Rechnung> rechnungen;
        List<Rechnungszeile> zeilen;

        private static Mockdb instance = null;

        public static Mockdb Instance
        {
            get 
            {
                if (instance == null)
                    instance = new Mockdb();

                return instance;
            }
           
        }

        private Mockdb()
        {
            kunden = new List<Kunde>();
            kunden.Add(new Kunde(1, "Daniel", "Herzog", "danielherzog@gmx.at", ObjectStates.Unmodified));
            kunden.Add(new Kunde(2, "Christoph", "Lindmaier", "christoph.lindmaier@gmx.at", ObjectStates.Unmodified));

            angebote = new List<Angebot>();
            angebote.Add(new Angebot(1, "Angebot 1", 12000.00, DateTime.Today, 200, 80, 1, 1, ObjectStates.Unmodified));
            angebote.Add(new Angebot(2, "Angebot 2", 2500000.00, DateTime.Today, 800, 95, 2, 2, ObjectStates.Unmodified));

            projekte = new List<Projekt>();
            projekte.Add(new Projekt(1, "Projekt 1", ObjectStates.Unmodified));
            projekte.Add(new Projekt(2, "Projekt 2", ObjectStates.Unmodified));

            kontakte = new List<Kontakt>();
            kontakte.Add (new Kontakt(1,"Testfirma", "Karl", "Maier", "test.firma@firma.at", ObjectStates.Unmodified));

            rechnungen = new List<Rechnung>();
            rechnungen.Add(new Rechnung(1, "Rechnung 1", DateTime.Today, 1, 1, ObjectStates.Unmodified));
            rechnungen.Add(new Rechnung(2, "Rechnung 2", DateTime.Today, 1, 1, ObjectStates.Unmodified));

            zeilen = new List<Rechnungszeile>();
            zeilen.Add(new Rechnungszeile(1, "Spezifikation", 2000.00, 1, 1, ObjectStates.Unmodified));
            zeilen.Add(new Rechnungszeile(2, "Design", 10000.00, 1, 1, ObjectStates.Unmodified));
            zeilen.Add(new Rechnungszeile(3, "Implementierung", 8000.00, 1, 1, ObjectStates.Unmodified));
            zeilen.Add(new Rechnungszeile(4, "Testen", 1000.00, 1, 1, ObjectStates.Unmodified));
        }

        public void buildconnection()
        {
            throw new NotImplementedException();
        }

        #region Kunden
        public void saveKunde(Kunde k)
        {
            if (k.Status == ObjectStates.New)
            {
                k.Status = ObjectStates.Unmodified;
                k.Kundenid = kunden.Count + 1;
                kunden.Add(k);
            }
            else if (k.Status == ObjectStates.Modified)
            {
                int index = kunden.IndexOf(k);
                kunden[index].Kundenid = k.Kundenid;
                kunden[index].Vorname = k.Vorname;
                kunden[index].Nachname = k.Nachname;
                kunden[index].Email = k.Email;
                kunden[index].Adresse = k.Adresse;
                kunden[index].Hausnummer = k.Hausnummer;
                kunden[index].Plz = k.Plz;
                kunden[index].Ort = k.Ort;
                kunden[index].Telefon = k.Telefon;
                kunden[index].Bemerkungen = k.Bemerkungen;
                kunden[index].Status = ObjectStates.Unmodified;
            }
        }

        public void deleteKunde(Kunde k)
        {   
            kunden.Remove(k);
        }

        public List<Kunde> getKundeViewList()
        {
            return kunden;
        }

        public Kunde getKunde(int id)
        {
            foreach (var item in kunden)
            {
                if(item.Kundenid == id)
                {
                    return item;
                }
            }
            return null;
        }
        #endregion

        #region Projekte
        public void saveProjekt(Projekt p)
        {
            if (p.Status == ObjectStates.New)
            {
                p.Status = ObjectStates.Unmodified;
                p.Projektid = projekte.Count + 1;
                projekte.Add(p);
            }
            else if (p.Status == ObjectStates.Modified)
            {
                int index = projekte.IndexOf(p);
                projekte[index].Projektid = p.Projektid;
                projekte[index].Name = p.Name;
                projekte[index].Status = ObjectStates.Unmodified;
            }
        }

        public void deleteProjekt(Projekt p)
        {
            projekte.Remove(p);
        }

        public List<Projekt> getProjektViewList()
        {
            return projekte;
        }

        public Projekt getProjekt(int id)
        {
            foreach (var item in projekte)
            {
                if (item.Projektid == id)
                    return item;
            }
            return null;
        }
        #endregion

        #region Angebote
        public void saveAngebot(Angebot a)
        {
            if (a.Status == ObjectStates.New)
            {
                a.Status = ObjectStates.Unmodified;
                a.Angebotid = angebote.Count + 1;
                angebote.Add(a);
            }
            else if (a.Status == ObjectStates.Modified)
            {
                int index = angebote.IndexOf(a);
                angebote[index].Angebotid = a.Angebotid;
                angebote[index].Chance = a.Chance;
                angebote[index].Datum = a.Datum;
                angebote[index].Dauer = a.Dauer;
                angebote[index].Kundenid = a.Kundenid;
                angebote[index].Projektid = a.Projektid;
                angebote[index].Summe = a.Summe;
                angebote[index].Status = ObjectStates.Unmodified;
            }
        }

        public void deleteAngebot(Angebot a)
        {
            angebote.Remove(a);
        }

        public List<Angebot> getAngebotViewList()
        {
            return angebote;
        }

        public List<Angebot> getKundenAngebote(int kundenid)
        {
            List<Angebot> tmp = new List<Angebot>();

            foreach (var item in angebote)
            {
                if (item.Kundenid == kundenid)
                    tmp.Add(item);
            }

            return tmp;
        }

        public Angebot getProjektAngebot(int? projektid)
        {
            Angebot tmp = null;

            foreach (var item in angebote)
            {
                if (item.Projektid == projektid)
                {
                    tmp = item;
                    break;
                }
            }

            return tmp;
        }
        #endregion

        #region Kontakte
        public void saveKontakt(Kontakt k)
        {
            if (k.Status == ObjectStates.New)
            {
                k.Status = ObjectStates.Unmodified;
                k.Kontaktid = kontakte.Count + 1;
                kontakte.Add(k);
            }
            else if (k.Status == ObjectStates.Modified)
            {
                int index = kontakte.IndexOf(k);
                kontakte[index].Kontaktid = k.Kontaktid;
                kontakte[index].Firmenname = k.Firmenname;
                kontakte[index].Vorname = k.Vorname;
                kontakte[index].Nachname = k.Nachname;
                kontakte[index].Status = ObjectStates.Unmodified;
            }
        }

        public void deleteKontakt(Kontakt k)
        {
            kontakte.Remove(k);
        }

        public List<Kontakt> getKontaktViewList()
        {
            return kontakte;
        }

        public Kontakt getKontakt(int id)
        {
            foreach (var item in kontakte)
            {
                if (item.Kontaktid == id)
                {
                    return item;
                }
            }
            return null;
        }
        #endregion

        #region Rechnung
        public void saveRechnung(Rechnung r)
        {
            if (r.Status == ObjectStates.New)
            {
                r.Status = ObjectStates.Unmodified;
                r.Rechnungid = rechnungen.Count + 1;
                rechnungen.Add(r);
            }
            else if (r.Status == ObjectStates.Modified)
            {
                int index = rechnungen.IndexOf(r);
                rechnungen[index].Rechnungid = r.Rechnungid;
                rechnungen[index].Bezeichnung = r.Bezeichnung;
                rechnungen[index].Datum = r.Datum;
                rechnungen[index].Status = ObjectStates.Unmodified;
            }
        }

        public void deleteRechung(Rechnung r)
        {
            rechnungen.Remove(r);
        }

        public List<Rechnung> getRechnungViewList()
        {
            return rechnungen;
        }

        public List<Rechnung> getKundenRechnungen(int kundenid)
        {
            List<Rechnung> tmp = new List<Rechnung>();

            foreach (var item in rechnungen)
            {
                if (item.Kundenid == kundenid)
                    tmp.Add(item);
            }

            return tmp;
        }
        #endregion       
    
        #region Rechnungszeile
        public void saveRechnungszeile(Rechnungszeile r)
        {
            if (r.Status == ObjectStates.New)
            {
                r.Status = ObjectStates.Unmodified;
                r.Reid = zeilen.Count + 1;
                zeilen.Add(r);
            }
            else if (r.Status == ObjectStates.Modified)
            {
                int index = zeilen.IndexOf(r);
                zeilen[index].Reid = r.Reid;
                zeilen[index].Betrag = r.Betrag;
                zeilen[index].Bezeichnung = r.Bezeichnung;
                zeilen[index].Angebotid = r.Angebotid;
                zeilen[index].Rechnungid = r.Rechnungid;
                zeilen[index].Status = ObjectStates.Unmodified;
            }
        }

        public void deleteRechnungszeile(Rechnungszeile r)
        {
            zeilen.Remove(r);
        }

        public List<Rechnungszeile> getRechnungszeilenViewList(int rechnungid)
        {
            List<Rechnungszeile> tmp = new List<Rechnungszeile>();
            foreach (var item in zeilen)
            {
                if (item.Rechnungid == rechnungid)
                    tmp.Add(item);
            }

            return tmp;
        }
        #endregion

        #region Auswertungen
        public List<Angebot> getJahresumsatzViewList()
        {
            List<Angebot> alist = new List<Angebot>();
            foreach (var item in angebote)
            {
                if (item.Datum.Year == DateTime.Now.Year && item.Chance >0)
                {
                    alist.Add(item);
                }
            }
            return alist;
        }

        public double[] getIstJahresumsatz()
        {
            double[] werte = new double[2]{0,0};
            foreach (var item in angebote)
            {
                if (item.Datum.Year == DateTime.Now.Year && item.Chance > 0)
                {
                    werte[0]++;
                    werte[1] += item.Summe;
                }
            }
            return werte;
        }


        public List<Rechnung> getEinnahmen(int month, int year)
        {
             List<Rechnung> rlist = new List<Rechnung>();
             foreach (var item in rechnungen)
             {
                 if ((item.Datum.Value.Year) == year && (item.Datum.Value.Month == month))
                 {
                     rlist.Add(item);
                 }
             }
             return rlist;
        }

        public List<Rechnung> getAusgaben(int month, int year)
        {
            List<Rechnung> rlist = new List<Rechnung>();
            foreach (var item in rechnungen)
            {
                if ((item.Datum.Value.Year) == year && (item.Datum.Value.Month == month))
                {
                    rlist.Add(item);
                }
            }
            return rlist;
        }
        #endregion


        public List<Angebot> getAngebotViewList(int kundenid)
        {
            List<Angebot> tmp = new List<Angebot>();

            foreach (var item in angebote)
            {
                if (item.Kundenid == kundenid)
                    tmp.Add(item);
            }

            return tmp;
        }

        public List<Angebot> getAngebotViewList(int? projektid)
        {
            List<Angebot> tmp = new List<Angebot>();

            foreach (var item in angebote)
            {
                if (item.Projektid == projektid)
                    tmp.Add(item);
            }

            return tmp;
        }

        public Angebot getAngebot(int? projektid)
        {
            throw new NotImplementedException();
        }

        public List<Rechnung> getRechnungViewList(int kundenid)
        {
            throw new NotImplementedException();
        }


        public List<Angebot> getAngebote()
        {
            List<Angebot> alist = new List<Angebot>();
            foreach (var item in angebote)
            {
                if (item.Chance > 0 && !item.Projektid.HasValue)
                {
                    alist.Add(item);
                }
            }
            return alist;
        }
    }
}
