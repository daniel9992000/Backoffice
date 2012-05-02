using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Backoffice;

namespace Backoffice_Unittests
{
    [TestFixture]
    public class Unittests
    {
        [Test]
        public void TestAddKunde()
        {
            int oldlength = BL.getKunden().Count;
            Kunde k = new Kunde();
            k.Vorname = "Max";
            k.Nachname = "Test";
            k.Email = "a.b@test.at";
            k.Hausnummer = "44";
            k.Adresse = "Hauptstraße 101";
            k.Plz = "2275";
            k.Ort = "Bernhardsthal";
            k.Telefon = "+4369912760033";
            k.Bemerkungen = "Hallo";
            k.Status = ObjectStates.New;
            BL.saveKunde(k);
            int index = BL.getKunden().Count;
            Assert.That(index, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getKunde(index).Vorname, Is.EqualTo("Max"));
            Assert.That(BL.getKunde(index).Nachname, Is.EqualTo("Test"));
            Assert.That(BL.getKunde(index).Email, Is.EqualTo("a.b@test.at"));
            Assert.That(BL.getKunde(index).Hausnummer, Is.EqualTo("44"));
            Assert.That(BL.getKunde(index).Adresse, Is.EqualTo("Hauptstraße 101"));
            Assert.That(BL.getKunde(index).Plz, Is.EqualTo("2275"));
            Assert.That(BL.getKunde(index).Ort, Is.EqualTo("Bernhardsthal"));
            Assert.That(BL.getKunde(index).Telefon, Is.EqualTo("+4369912760033"));
            Assert.That(BL.getKunde(index).Bemerkungen, Is.EqualTo("Hallo"));
            Assert.That(BL.getKunde(index).ToString(), Is.EqualTo("Max Test"));
            Assert.That(BL.getKunde(index).Status, Is.EqualTo(ObjectStates.Modified));
        }

        [Test]
        public void TestAddKunde_empty()
        {
            int oldlength = BL.getKunden().Count;
            Kunde k = new Kunde(6, "", "", "");
            k.Hausnummer = "";
            k.Adresse = String.Empty;
            k.Plz = String.Empty;
            k.Ort = String.Empty;
            k.Telefon = String.Empty;
            k.Bemerkungen = String.Empty;
            k.Status = ObjectStates.New;
            BL.saveKunde(k);
            int index = BL.getKunden().Count;
            Assert.That(index, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getKunde(index).Vorname, Is.EqualTo(String.Empty));
            Assert.That(BL.getKunde(index).Nachname, Is.EqualTo(String.Empty));
            Assert.That(BL.getKunde(index).Email, Is.EqualTo(String.Empty));
            Assert.That(BL.getKunde(index).Hausnummer, Is.EqualTo(String.Empty));
            Assert.That(BL.getKunde(index).Adresse, Is.EqualTo(String.Empty));
            Assert.That(BL.getKunde(index).Plz, Is.EqualTo(String.Empty));
            Assert.That(BL.getKunde(index).Ort, Is.EqualTo(String.Empty));
            Assert.That(BL.getKunde(index).Telefon, Is.EqualTo(String.Empty));
            Assert.That(BL.getKunde(index).Bemerkungen, Is.EqualTo(String.Empty));
            Assert.That(BL.getKunde(index).Status, Is.EqualTo(ObjectStates.Modified));
        }

        [Test]
        public void TestAddKunde_Sonderzeichen()
        {
            Kunde k = new Kunde(89999, "ö54848", "487!,", "587=!-", ObjectStates.New);
            BL.saveKunde(k);
            int index = BL.getKunden().Count;
            Assert.That(BL.getKunde(index).Vorname, Is.EqualTo("ö54848"));
            Assert.That(BL.getKunde(index).Nachname, Is.EqualTo("487!,"));
            Assert.That(BL.getKunde(index).Email, Is.EqualTo("587=!-"));
            Assert.That(BL.getKunde(index).Status, Is.EqualTo(ObjectStates.Modified));
        }

        [Test]
        public void TestDeleteKunde()
        {
            Kunde k = new Kunde();
            int oldlength = BL.getKunden().Count;
            k = BL.getKunde(oldlength);
            BL.deleteKunde(k);
            Assert.That(BL.getKunden().Count, Is.EqualTo(oldlength - 1));
            Assert.That(BL.getKunden().Last(), Is.Not.EqualTo(k));

        }

        [Test]
        public void TestAddKontakt()
        {
            int oldlength = BL.getKontakte().Count;
            Kontakt k = new Kontakt();
            k.Firmenname = "Testfirma";
            k.Vorname = "Max";
            k.Nachname = "Test";
            k.Email = "a.b@test.at";
            k.Hausnummer = "44";
            k.Adresse = "Hauptstraße 101";
            k.Plz = "2275";
            k.Ort = "Bernhardsthal";
            k.Telefon = "+4369912760033";
            k.Bemerkungen = "Ich bin eine Bemerkung!";
            k.Status = ObjectStates.New;
            BL.saveKontakt(k);
            int index = BL.getKontakte().Count - 1;
            Assert.That(BL.getKontakte().Count, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getKontakte().ElementAt(index).Firmenname, Is.EqualTo("Testfirma"));
            Assert.That(BL.getKontakte().ElementAt(index).Vorname, Is.EqualTo("Max"));
            Assert.That(BL.getKontakte().ElementAt(index).Nachname, Is.EqualTo("Test"));
            Assert.That(BL.getKontakte().ElementAt(index).Email, Is.EqualTo("a.b@test.at"));
            Assert.That(BL.getKontakte().ElementAt(index).Hausnummer, Is.EqualTo("44"));
            Assert.That(BL.getKontakte().ElementAt(index).Adresse, Is.EqualTo("Hauptstraße 101"));
            Assert.That(BL.getKontakte().ElementAt(index).Plz, Is.EqualTo("2275"));
            Assert.That(BL.getKontakte().ElementAt(index).Ort, Is.EqualTo("Bernhardsthal"));
            Assert.That(BL.getKontakte().ElementAt(index).Telefon, Is.EqualTo("+4369912760033"));
            Assert.That(BL.getKontakte().ElementAt(index).Bemerkungen, Is.EqualTo("Ich bin eine Bemerkung!"));
            Assert.That(BL.getKontakte().ElementAt(index).ToString(), Is.EqualTo("Max Test"));
            Assert.That(BL.getKontakte().ElementAt(index).Status, Is.EqualTo(ObjectStates.Unmodified));
        }

        [Test]
        public void TestAddKontatk_empty()
        {
            int oldlength = BL.getKontakte().Count;
            Kontakt k = new Kontakt(899,"","","","",ObjectStates.New);
            k.Hausnummer = "";
            k.Adresse = String.Empty;
            k.Plz = String.Empty;
            k.Ort = String.Empty;
            k.Telefon = String.Empty;
            k.Bemerkungen = String.Empty;
            k.Status = ObjectStates.New;
            BL.saveKontakt(k);
            int index = BL.getKontakte().Count;
            Assert.That(index, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getKontakte().ElementAt(index - 1).Firmenname, Is.EqualTo(String.Empty));
            Assert.That(BL.getKontakte().ElementAt(index - 1).Vorname, Is.EqualTo(String.Empty));
            Assert.That(BL.getKontakte().ElementAt(index - 1).Nachname, Is.EqualTo(String.Empty));
            Assert.That(BL.getKontakte().ElementAt(index - 1).Email, Is.EqualTo(String.Empty));
            Assert.That(BL.getKontakte().ElementAt(index - 1).Hausnummer, Is.EqualTo(String.Empty));
            Assert.That(BL.getKontakte().ElementAt(index - 1).Adresse, Is.EqualTo(String.Empty));
            Assert.That(BL.getKontakte().ElementAt(index - 1).Plz, Is.EqualTo(String.Empty));
            Assert.That(BL.getKontakte().ElementAt(index - 1).Ort, Is.EqualTo(String.Empty));
            Assert.That(BL.getKontakte().ElementAt(index - 1).Telefon, Is.EqualTo(String.Empty));
            Assert.That(BL.getKontakte().ElementAt(index - 1).Bemerkungen, Is.EqualTo(String.Empty));
            Assert.That(BL.getKontakte().ElementAt(index - 1).Status, Is.EqualTo(ObjectStates.Unmodified));
        }

        [Test]
        public void TestAddKontakt_Sonderzeichen()
        {
            Kontakt k = new Kontakt(89999, "ö54848", "487!,", "587=!-", "a.b@aon.at" ,ObjectStates.New);
            BL.saveKontakt(k);
            int index = BL.getKunden().Count;
            Assert.That(BL.getKontakte().ElementAt(index).Kontaktid, Is.EqualTo(index + 1));
            Assert.That(BL.getKontakte().ElementAt(index).Vorname, Is.EqualTo("ö54848"));
            Assert.That(BL.getKontakte().ElementAt(index).Nachname, Is.EqualTo("487!,"));
            Assert.That(BL.getKontakte().ElementAt(index).Firmenname, Is.EqualTo("587=!-"));
            Assert.That(BL.getKontakte().ElementAt(index).Email, Is.EqualTo("a.b@aon.at"));
            Assert.That(BL.getKunde(index).Status, Is.EqualTo(ObjectStates.Unmodified));
        }

        [Test]
        public void TestDeleteKontakt()
        {
            Kontakt k = new Kontakt();
            int oldlength = BL.getKontakte().Count;
            k = BL.getKontakte().ElementAt(oldlength-1);
            BL.deleteKontakt(k);
            Assert.That(BL.getKontakte().Count, Is.EqualTo(oldlength - 1));
            Assert.That(BL.getKontakte().Last(), Is.Not.EqualTo(k));

        }

        [Test]
        public void TestAddAngebot()
        {
            Angebot a = new Angebot();
            a.Chance = 65;
            a.Titel = "Angebot 5";
            a.Datum = DateTime.Parse("16-04-2013");
            a.Dauer = 98;
            a.Kundenid = 1;
            a.Projektid = 2;
            a.Summe = 334;
            a.Status = ObjectStates.New;
            int oldlength = BL.getAngebote().Count;
            BL.saveAngebot(a);
            int index = BL.getAngebote().Count;
            Assert.That(BL.getAngebot(index).Angebotid, Is.EqualTo(index));
            Assert.That(BL.getAngebote().Count, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getAngebot(index).Titel, Is.EqualTo("Angebot 5"));
            Assert.That(BL.getAngebot(index).Dauer, Is.EqualTo(98));
            Assert.That(BL.getAngebot(index).Chance, Is.EqualTo(65));
            Assert.That(BL.getAngebot(index).Kundenid, Is.EqualTo(1));
            Assert.That(BL.getAngebot(index).Projektid, Is.EqualTo(2));
            Assert.That(BL.getAngebot(index).Summe, Is.EqualTo(334));
            Assert.That(BL.getAngebot(index).Datum, Is.EqualTo(DateTime.Parse("16-04-2013")));
            Assert.That(BL.getAngebot(index).Status, Is.EqualTo(ObjectStates.Modified));
        }

        [Test]
        public void TestDeleteAngebot()
        {
            Angebot a = new Angebot();
            int oldlength = BL.getAngebote().Count;
            a = BL.getAngebote().ElementAt(oldlength - 1);
            BL.deleteAngebot(a);
            Assert.That(BL.getAngebote().Count, Is.EqualTo(oldlength - 1));
            Assert.That(BL.getAngebote().Last(), Is.Not.EqualTo(a));
        }

        [Test]
        public void TestAddProjekt()
        {
            Projekt p = new Projekt();
            int oldlength = BL.getProjekte().Count;
            p.Name = "Testprojekt";
            p.Stunden = 56;
            p.Status = ObjectStates.New;
            BL.saveProjekt(p);
            Assert.That(BL.getProjekte().Count, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getProjekt(oldlength+1).Projektid, Is.EqualTo(oldlength+1));
            Assert.That(BL.getProjekt(oldlength+1).Name, Is.EqualTo("Testprojekt"));
            Assert.That(BL.getProjekt(oldlength+1).Stunden, Is.EqualTo(56));
            Assert.That(BL.getProjekt(oldlength+1).ToString(), Is.EqualTo("Testprojekt"));
        }

        [Test]
        public void TestDeleteProjekt()
        {
            Projekt p = new Projekt();
            int oldlength = BL.getProjekte().Count;
            p = BL.getProjekt(oldlength);
            BL.deleteProjekt(p);
            Assert.That(BL.getProjekte().Count, Is.EqualTo(oldlength -1));
            Assert.That(BL.getProjekte().Last(), Is.Not.EqualTo(p));
        }

        [Test]
        public void TestAddEingang()
        {
            Eingang r = new Eingang();
            int oldlength = BL.getEingaenge().Count;
            r.Bezeichnung = "Testeingangsrechnung";
            r.Betrag = 656;
            r.Path = "C:";
            r.Status = ObjectStates.New;
            BL.saveEingang(r);
            Assert.That(BL.getEingaenge().Count, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getEingaenge().ElementAt(oldlength).Betrag, Is.EqualTo(656));
            Assert.That(BL.getEingaenge().ElementAt(oldlength).Bezeichnung, Is.EqualTo("Testeingangsrechnung"));
            Assert.That(BL.getEingaenge().ElementAt(oldlength).Path, Is.EqualTo("C:"));
        }

        [Test]
        public void TestDeleteEingang()
        {
            Eingang r = new Eingang();
            int oldlength = BL.getEingaenge().Count;
            r = BL.getEingaenge().Last();
            BL.deleteEingang(r);
            Assert.That(BL.getEingaenge().Count, Is.EqualTo(oldlength -1));
            Assert.That(BL.getEingaenge().Last(), Is.Not.EqualTo(r));
        }

        [Test]
        public void TestAddAusgang()
        {
            Ausgang a = new Ausgang();
            int oldlength = BL.getAusgaenge().Count();
            a.Bezeichnung = "Testausgangsrechnung";
            a.Kundenid = 1;
            a.Status = ObjectStates.New;
            BL.saveAusgang(a);
            Assert.That(BL.getAusgaenge().Count, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getAusgaenge().ElementAt(oldlength).Bezeichnung, Is.EqualTo("Testausgangsrechnung"));
            Assert.That(BL.getAusgaenge().ElementAt(oldlength).Kundenid, Is.EqualTo(1));
        }

        [Test]
        public void DeleteAusgang()
        {
            Ausgang a = new Ausgang();
            int oldlength = BL.getAusgaenge().Count();
            a = BL.getAusgaenge().Last();
            BL.deleteAusgang(a);
            Assert.That(BL.getAusgaenge().Count, Is.EqualTo(oldlength - 1));
            Assert.That(BL.getAusgaenge().Last(), Is.Not.EqualTo(a));
        }
    }
}
