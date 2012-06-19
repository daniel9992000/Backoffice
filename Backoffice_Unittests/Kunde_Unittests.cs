using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backoffice;
using NUnit.Framework;

namespace Backoffice_Unittests
{
    [TestFixture]
    class Kunde_Unittests
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
            BL.deleteKunde(k);
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
            BL.deleteKunde(k);
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
        public void TestGetKunden()
        {
            Assert.That(BL.getKunden().Count, Is.EqualTo(2));
        }

        [Test]
        public void TestGetKontaktebySearch()
        {
            Assert.That(BL.getKunden("Daniel").Count, Is.EqualTo(1));
        }
    }
}
