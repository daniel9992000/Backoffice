using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backoffice;
using NUnit.Framework;

namespace Backoffice_Unittests
{
    [TestFixture]
    class KontaktUnittests
    {
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
            Kontakt k = new Kontakt(899, "", "", "", "", ObjectStates.New);
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
            BL.deleteKontakt(k);
        }

        [Test]
        public void TestAddKontakt_Sonderzeichen()
        {
            Kontakt k = new Kontakt(89999, "ö54848", "487!,", "587=!-", "a.b@aon.at", ObjectStates.New);
            BL.saveKontakt(k);
            int index = BL.getKontakte().Count - 1;
            Assert.That(BL.getKontakte().ElementAt(index).Kontaktid, Is.EqualTo(index + 1));
            Assert.That(BL.getKontakte().ElementAt(index).Vorname, Is.EqualTo("ö54848"));
            Assert.That(BL.getKontakte().ElementAt(index).Nachname, Is.EqualTo("487!,"));
            Assert.That(BL.getKontakte().ElementAt(index).Firmenname, Is.EqualTo("587=!-"));
            Assert.That(BL.getKontakte().ElementAt(index).Email, Is.EqualTo("a.b@aon.at"));
            Assert.That(BL.getKunde(index).Status, Is.EqualTo(ObjectStates.Unmodified));
            BL.deleteKontakt(k);
        }

        [Test]
        public void TestDeleteKontakt()
        {
            Kontakt k = new Kontakt();
            int oldlength = BL.getKontakte().Count;
            k = BL.getKontakte().ElementAt(oldlength - 1);
            BL.deleteKontakt(k);
            Assert.That(BL.getKontakte().Count, Is.EqualTo(oldlength - 1));
            Assert.That(BL.getKontakte().Last(), Is.Not.EqualTo(k));

        }

        [Test]
        public void TestGetKontakte()
        {
            Assert.That(BL.getKontakte().Count, Is.EqualTo(1));
        }

        [Test]
        public void TestGetKontaktebySearch()
        {
            Assert.That(BL.getKontakte("Karl").Count, Is.EqualTo(1));
        }
    }
}
