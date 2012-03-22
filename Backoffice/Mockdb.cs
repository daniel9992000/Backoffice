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

            projekte = new List<Projekt>();
            projekte.Add(new Projekt(1, "Testprojekt", ObjectStates.Unmodified));
        }

        public void buildconnection()
        {
            throw new NotImplementedException();
        }

        public void saveKunde(Kunde k)
        {
            if (k.Status == ObjectStates.New)
            {
                k.Status = ObjectStates.Unmodified;
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

        public void saveProjekt(Projekt p)
        {
            if (p.Status == ObjectStates.New)
            {
                p.Status = ObjectStates.Unmodified;
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
    }
}
