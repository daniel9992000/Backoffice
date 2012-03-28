using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Backoffice
{
    public interface IDAL
    {
        void buildconnection();

        //Kunden
        void saveKunde(Kunde k);
        void deleteKunde(Kunde k);
        List<Kunde> getKundeViewList();
        Kunde getKunde(int id);

        //Angebote
        void saveAngebot(Angebot a);
        void deleteAngebot(Angebot a);
        List<Angebot> getAngebotViewList();
        List<Angebot> getKundenAngebote(int kundenid);

        //Projekte
        void saveProjekt(Projekt p);
        void deleteProjekt(Projekt p);
        List<Projekt> getProjektViewList();
        Projekt getProjekt(int id);

        //Kontakte
        void saveKontakt(Kontakt k);
        void deleteKontakt(Kontakt k);
        List<Kontakt> getKontaktViewList();
        Kontakt getKontakt(int id);
        
    }
}
