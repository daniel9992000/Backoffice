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

        public Mockdb()
        {
            kunden.Add(new Kunde(1, "Daniel", "Herzog"));
            kunden.Add(new Kunde(2, "Christoph", "Lindmaier"));

            projekte.Add(new Projekt(1, "Testprojekt"));
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
                int index;
                index = kunden.IndexOf(k);
                kunden[index].Kundenid = k.Kundenid;
                kunden[index].Vorname = k.Vorname;
                kunden[index].Nachname = k.Nachname;
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
            throw new NotImplementedException();
        }

        public void deleteProjekt(Projekt p)
        {
            throw new NotImplementedException();
        }

        public List<Projekt> getProjektViewList()
        {
            throw new NotImplementedException();
        }
    }
}
