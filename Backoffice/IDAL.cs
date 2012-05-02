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
        List<Angebot> getAngebotViewList(int kundenid);
        List<Angebot> getAngebotViewListByProjektId(int projektid);
        Angebot getAngebot(int angebotid);
        Angebot getAngebot(int? projektid);

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

        //Ausgangsrechnungen
        void saveAusgang(Ausgang r);
        void deleteAusgang(Ausgang r);
        List<Ausgang> getAusgangViewList();
        List<Ausgang> getAusgangViewList(int kundenid);
        List<Ausgang> getAusgangViewListByProjektId(int projektid);

        //Eingangsrechnungen
        void saveEingang(Eingang r);
        void deleteEingang(Eingang r);
        List<Eingang> getEingangViewList();
        List<Eingang> getEingangViewList(int kontaktid);


        //Rechnungszeilen
        void saveRechnungszeile(Rechnungszeile r);
        void deleteRechnungszeile(Rechnungszeile r);
        List<Rechnungszeile> getRechnungszeilenViewList(int rechnungid);

        //Buchungen
        void saveBuchung(Buchung b);
        void deleteBuchung(Buchung b);
        List<Buchung> getBuchungViewList(int rechnungid);


        //Auswertungen
        double getRechnungssumme(int rechnungid);
        List<Angebot> getJahresumsatzViewList();
        double[] getIstJahresumsatz();
        List<Ausgang> getEinnahmen(int month, int year);
        List<Eingang> getAusgaben(int month, int year);
        List<Angebot> getAngebote();
        List<Eingang> getOffeneERechnungen();
        List<Ausgang> getOffeneARechnungen();
        
        //Stunden
        List<Stunden> getStundenViewList(string projektname);
        void saveStunden(Stunden s);
        int getProjektStunden(string projektname);
    }
}
