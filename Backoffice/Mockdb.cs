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
        List<Ausgang> ausgaenge;
        List<Eingang> eingaenge;
        List<Rechnungszeile> zeilen;
        List<Buchung> buchungen;
        List<Buchungskategorie> kategorie;
        List<Stunden> stunden;
        int rechnungid = 0;

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
            angebote.Add(new Angebot(1, "Angebot 1", 12000.00, DateTime.Parse("17.03.2012"), 200, 80, 1, 1, ObjectStates.Unmodified));
            angebote.Add(new Angebot(2, "Angebot 2", 25000.00, DateTime.Parse("17.03.2012"), 800, 95, 2, 2, ObjectStates.Unmodified));
            angebote.Add(new Angebot(3, "Angebot 3", 10000.00, DateTime.Parse("18.04.2012"), 500, 70, 2, 2, ObjectStates.Unmodified));

            projekte = new List<Projekt>();
            projekte.Add(new Projekt(1, "Projekt 1", ObjectStates.Unmodified));
            projekte.Add(new Projekt(2, "Projekt 2", ObjectStates.Unmodified));

            kontakte = new List<Kontakt>();
            kontakte.Add (new Kontakt(1, "Karl", "Maier", "Testfirma", "test.firma@firma.at", ObjectStates.Unmodified));

            ausgaenge = new List<Ausgang>();
            ausgaenge.Add(new Ausgang(1, "Ausgangsrechnung 1", DateTime.Parse("20.03.2012"), 1, 1, ObjectStates.Unmodified));
            rechnungid++;
            ausgaenge.Add(new Ausgang(2, "Ausgangsrechnung 2", DateTime.Parse("21.03.2012"), 1, 1, ObjectStates.Unmodified));
            rechnungid++;

            eingaenge = new List<Eingang>();
            eingaenge.Add(new Eingang(3, "Eingangsrechnung 1", DateTime.Parse("30.03.2012"), 888.98, "C:", 1, ObjectStates.Unmodified));
            rechnungid++;

            zeilen = new List<Rechnungszeile>();
            zeilen.Add(new Rechnungszeile(1, "Spezifikation", 2000.00, 1, 1, ObjectStates.Unmodified));
            zeilen.Add(new Rechnungszeile(2, "Design", 10000.00, 1, 1, ObjectStates.Unmodified));
            zeilen.Add(new Rechnungszeile(3, "Implementierung", 8000.00, 1, 1, ObjectStates.Unmodified));
            zeilen.Add(new Rechnungszeile(4, "Testen", 1000.00, 1, 1, ObjectStates.Unmodified));
            zeilen.Add(new Rechnungszeile(5, "Design", 1000.00, 2, 2, ObjectStates.Unmodified));

            kategorie = new List<Buchungskategorie>();
            kategorie.Add(new Buchungskategorie(1, "Einnahme"));
            kategorie.Add(new Buchungskategorie(2, "Ausgabe"));
            kategorie.Add(new Buchungskategorie(3, "SVA"));
            kategorie.Add(new Buchungskategorie(4, "USt"));

            buchungen = new List<Buchung>();
            buchungen.Add(new Buchung(1,11000.00,1, DateTime.Now,1,ObjectStates.Unmodified));
            buchungen.Add(new Buchung(2,10000.00,1, DateTime.Now,1,ObjectStates.Unmodified));
            buchungen.Add(new Buchung(3,500.00,1, DateTime.Now, 2, ObjectStates.Unmodified));

            stunden = new List<Stunden>();
            stunden.Add(new Stunden("Projekt 1", "Karl Huf", 8, DateTime.Parse("30.03.2012")));
            stunden.Add(new Stunden("Projekt 1", "Karl Huf", 8, DateTime.Parse("31.03.2012")));
            stunden.Add(new Stunden("Projekt 1", "Karl Huf", 8, DateTime.Parse("01.04.2012")));
            stunden.Add(new Stunden("Projekt 1", "Karl Huf", 10, DateTime.Parse("02.04.2012")));
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

        public List<Kunde> getKundeViewList(string search)
        {
            search = search.ToLower();
            List<Kunde> tmp = new List<Kunde>();
            foreach (var item in kunden)
            {
                if (item.Vorname.ToLower().Contains(search) || 
                    item.Nachname.ToLower().Contains(search) ||
                    item.Email.ToLower().Contains(search) ||
                    item.Adresse.ToLower().Contains(search) ||
                    item.Ort.ToLower().Contains(search) ||
                    item.Plz.ToLower().Contains(search))

                    tmp.Add(item);
            }
            return tmp;
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
            List<Projekt> tmp = new List<Projekt>();
            foreach (var item in projekte)
            {
                item.Stunden = getProjektStunden(item.Name);
                tmp.Add(item);
            }

            return tmp;
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
                angebote[index].Titel = a.Titel;
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
        
        public List<Angebot> getAngebotViewList(string search)
        {
            List<Angebot> tmp = new List<Angebot>();
            search = search.ToLower();
            foreach (var item in angebote)
            {
                if (item.Titel.ToLower().Contains(search) ||
                    item.Summe.ToString().ToLower().Contains(search) ||
                    item.Chance.ToString().ToLower().Contains(search) ||
                    item.Datum.ToString().ToLower().Contains(search)
                    )
                {
                    tmp.Add(item);
                }
            }

            return tmp;
        }

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

        public List<Angebot> getAngebotViewListByProjektId(int projektid)
        {
            List<Angebot> tmp = new List<Angebot>();

            foreach (var item in angebote)
            {
                if (item.Projektid == projektid)
                {
                    tmp.Add(item);                   
                }
            }

            return tmp;
        }

        public Angebot getAngebot(int? projektid)
        {
            Angebot a = new Angebot();
            foreach (var item in angebote)
            {
                if (item.Projektid == projektid.Value)
                    a = item;
            }
            return a;

        }

        public Angebot getAngebot(int angebotid)
        {            
            foreach (var item in angebote)
            {
                if (item.Angebotid == angebotid)
                    return item;
            }
            return new Angebot();
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

        public List<Kontakt> getKontaktViewList(string search)
        {
            List<Kontakt> tmp = new List<Kontakt>();
            search = search.ToLower();
            foreach (var item in kontakte)
            {
                if (item.Vorname.ToLower().Contains(search) ||
                    item.Nachname.ToLower().Contains(search) ||
                    item.Firmenname.ToLower().Contains(search) ||
                    item.Email.ToLower().Contains(search) ||
                    item.Ort.ToLower().Contains(search) ||
                    item.Adresse.ToLower().Contains(search) ||
                    item.Plz.ToLower().Contains(search))
                {
                    tmp.Add(item);
                }
            }
            return tmp;
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

        #region Rechungen
        public Rechnung getRechung(int id)
        {
            foreach (var item in ausgaenge)
            {
                if (item.Rechnungid == id)
                    return item;
            }

            foreach (var item in eingaenge)
            {
                if (item.Rechnungid == id)
                    return item;
            }

            return null;
        }
        #endregion

        #region Ausgangsrechnungen
        public void saveAusgang(Ausgang r)
        {
            if (r.Status == ObjectStates.New)
            {
                r.Status = ObjectStates.Unmodified;
                r.Rechnungid = rechnungid + 1;
                rechnungid++;
                ausgaenge.Add(r);
            }
            else if (r.Status == ObjectStates.Modified)
            {
                int index = ausgaenge.IndexOf(r);
                ausgaenge[index].Rechnungid = r.Rechnungid;
                ausgaenge[index].Bezeichnung = r.Bezeichnung;
                ausgaenge[index].Datum = r.Datum.Value;
                ausgaenge[index].Projektid = r.Projektid;
                ausgaenge[index].Status = ObjectStates.Unmodified;
            }
        }

        public void deleteAusgang(Ausgang r)
        {
            ausgaenge.Remove(r);
        }
       
        public List<Ausgang> getAusgangViewList()
        {
            return ausgaenge;
        }

        public List<Ausgang> getAusgangViewList(int kundenid)
        {
            List<Ausgang> tmp = new List<Ausgang>();

            foreach (var item in ausgaenge)
            {
                if (item.Kundenid == kundenid)
                    tmp.Add(item);
            }

            return tmp;
        }

        public List<Ausgang> getAusgangViewListByProjektId(int projektid)
        {
            List<Ausgang> tmp = new List<Ausgang>();

            foreach (var item in ausgaenge)
            {
                if (item.Projektid == projektid)
                    tmp.Add(item);
            }

            return tmp;
        }   
        #endregion     
  
        #region Eingangsrechnungen

        public void saveEingang(Eingang r)
        {
            if (r.Status == ObjectStates.New)
            {
                r.Status = ObjectStates.Unmodified;
                r.Rechnungid = rechnungid + 1;
                rechnungid++;
                eingaenge.Add(r);
            }
            else if (r.Status == ObjectStates.Modified)
            {
                int index = eingaenge.IndexOf(r);
                eingaenge[index].Rechnungid = r.Rechnungid;
                eingaenge[index].Bezeichnung = r.Bezeichnung;
                eingaenge[index].Datum = r.Datum;
                eingaenge[index].Path = r.Path;
                eingaenge[index].Kontaktid = r.Kontaktid;
                eingaenge[index].Status = ObjectStates.Unmodified;
            }
        }

        public void deleteEingang(Eingang r)
        {
            eingaenge.Remove(r);
        }

        public List<Eingang> getEingangViewList()
        {
            return eingaenge;
        }

        public List<Eingang> getEingangViewList(int kontaktid)
        {
            List<Eingang> tmp = new List<Eingang>();

            foreach (var item in eingaenge)
            {
                if (item.Kontaktid == kontaktid)
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


        public List<Eingang> getAusgaben(int month, int year)
        {
             List<Eingang> rlist = new List<Eingang>();
             foreach (var item in eingaenge)
             {
                 if ((item.Datum.Value.Year) == year && (item.Datum.Value.Month == month))
                 {
                     rlist.Add(item);
                 }
             }
             return rlist;
        }

        public List<Ausgang> getEinnahmen(int month, int year)
        {
            List<Ausgang> rlist = new List<Ausgang>();
            foreach (var item in ausgaenge)
            {
                if ((item.Datum.Value.Year) == year && (item.Datum.Value.Month == month))
                {
                    rlist.Add(item);
                }
            }
            return rlist;
        }
        #endregion           

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

        public List<Ausgang> getOffeneARechnungen()
        {
            List<Ausgang> rlist = new List<Ausgang>();
            double summerezeile, summebuchung;
            foreach (var item in ausgaenge)
            {   
                summerezeile = summebuchung = 0;
                foreach (var rzeile in zeilen)
                {   
                    if (rzeile.Rechnungid == item.Rechnungid)
                        summerezeile+= rzeile.Betrag;
                }
                foreach (var buchung in buchungen)
                {
                    if (buchung.Rechnungid == item.Rechnungid)
                        summebuchung += buchung.Betrag;
                }
                if (summebuchung != summerezeile)
                    rlist.Add(item);
            }
            return rlist;
        }

        public List<Eingang> getOffeneERechnungen() //noch richtig implementieren
        {
            List<Eingang> rlist = new List<Eingang>();
            double summerezeile, summebuchung;
            foreach (var item in eingaenge)
            {
                summerezeile = summebuchung = 0;
                summerezeile = item.Betrag;
                foreach (var buchung in buchungen)
                {
                    if (buchung.Rechnungid == item.Rechnungid)
                        summebuchung += buchung.Betrag;
                }
                if (summebuchung != summerezeile)
                    rlist.Add(item);
            }
            return rlist;
        }

        #region Buchung
        public void saveBuchung(Buchung b)
        {
            if (b.Status == ObjectStates.New)
            {
                b.Status = ObjectStates.Unmodified;
                b.Buchungid = buchungen.Count + 1;
                buchungen.Add(b);
            }
            else if (b.Status == ObjectStates.Modified)
            {
                int index = buchungen.IndexOf(b);
                buchungen[index].Buchungid = b.Buchungid;
                buchungen[index].Betrag = b.Betrag;
                buchungen[index].Datum = b.Datum;
                buchungen[index].Kategorie = b.Kategorie;
                buchungen[index].Rechnungid = b.Rechnungid;
                buchungen[index].Status = ObjectStates.Unmodified;
            }
        }

        public void deleteBuchung(Buchung b)
        {
            buchungen.Remove(b);
        }

        public List<Buchung> getBuchungViewList()
        {
            List<Buchung> tmp = new List<Buchung>();
            tmp = buchungen;
            return tmp;
        }

        public List<Buchung> getBuchungViewList(int rechnungid)
        {
            List<Buchung> blist = new List<Buchung>();
            foreach (var item in buchungen)
            {
                if (item.Rechnungid == rechnungid)
                {
                    blist.Add(item);
                }
            }
            return blist;
        }

        public List<Buchungskategorie> getBuchungsKategorien()
        {
            return kategorie;
        }

        public Buchungskategorie getBuchungsKategorie(int id)
        {
            foreach (var item in kategorie)
            {
                if (item.Bkatid == id)
                    return item;
            }
            return new Buchungskategorie();
        }
        #endregion

        public List<Stunden> getStundenViewList(string projektname)
        {
            List<Stunden> slist = new List<Stunden>();
            foreach (var item in stunden)
            {
                if (item.Projektname == projektname)
                    slist.Add(item);
            }
            return slist;
        }

        public void saveStunden(Stunden s)
        {
            stunden.Add(s);
        }

       

        public double getRechnungssumme(int rechnungid)
        {
            double summe = 0;
            foreach (var item in zeilen)
            {
                if (item.Rechnungid == rechnungid)
                    summe += item.Betrag;
            }
            return summe;
        }

        public int getProjektStunden(string projektname)
        {
            int anz = 0;
            foreach (var item in stunden)
            {
                if (item.Projektname.Equals(projektname))
                    anz += item.Stundenanz;
            }
            return anz;
        }

    }
}
