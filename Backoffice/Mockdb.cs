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

            projekte = new List<Projekt>();
            projekte.Add(new Projekt(1, "Testprojekt", ObjectStates.Unmodified));
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
                a.Kundenid = angebote.Count + 1;
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
        #endregion


    }
}
