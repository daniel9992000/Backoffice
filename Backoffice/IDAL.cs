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
        Angebot getProjektAngebot(int? projektid);

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

        //Rechnungen
        void saveRechnung(Rechnung r);
        void deleteRechung(Rechnung r);
        List<Rechnung> getRechnungViewList();
        List<Rechnung> getKundenRechnungen(int kundenid);

        //Rechnungszeilen
        void saveRechnungszeile(Rechnungszeile r);
        void deleteRechnungszeile(Rechnungszeile r);
        List<Rechnungszeile> getRechnungszeilenViewList(int rechnungid);

        //Auswertungen
        List<Angebot> getJahresumsatzViewList();
        double[] getIstJahresumsatz();
        List<Rechnung> getEinnahmen(int month, int year);
        List<Rechnung> getAusgaben(int month, int year);
    }
}
