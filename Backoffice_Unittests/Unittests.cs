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
            k.Status = ObjectStates.New;
            BL.saveKunde(k);
            int index = BL.getKunden().Count;
            Assert.That(index, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getKunde(index).Vorname, Is.EqualTo("Max"));
            Assert.That(BL.getKunde(index).Nachname, Is.EqualTo("Test"));
            Assert.That(BL.getKunde(index).Email, Is.EqualTo("a.b@test.at"));
            Assert.That(BL.getKunde(index).Hausnummer, Is.EqualTo("44"));
        }

        [Test]
        public void TestDeleteKunde()
        {
            Kunde k = new Kunde();
            int oldlength = BL.getKunden().Count;
            k = BL.getKunde(oldlength);
            BL.deleteKunde(k);
            Assert.That(BL.getKunden().Count, Is.EqualTo(oldlength - 1));

        }

        [Test]
        public void TestAddKontakt()
        {
            int oldlength = BL.getKontakte().Count;
            Kontakt k = new Kontakt();
            k.Vorname = "Max";
            k.Nachname = "Test";
            k.Email = "a.b@test.at";
            k.Hausnummer = "44";
            k.Status = ObjectStates.New;
            BL.saveKontakt(k);
            int index = BL.getKontakte().Count - 1;
            Assert.That(BL.getKontakte().Count, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getKontakte().ElementAt(index).Vorname, Is.EqualTo("Max"));
            Assert.That(BL.getKontakte().ElementAt(index).Nachname, Is.EqualTo("Test"));
            Assert.That(BL.getKontakte().ElementAt(index).Email, Is.EqualTo("a.b@test.at"));
            Assert.That(BL.getKontakte().ElementAt(index).Hausnummer, Is.EqualTo("44"));
        }

        [Test]
        public void TestDeleteKontakt()
        {
            Kontakt k = new Kontakt();
            int oldlength = BL.getKontakte().Count;
            k = BL.getKontakte().ElementAt(oldlength-1);
            BL.deleteKontakt(k);
            Assert.That(BL.getKontakte().Count, Is.EqualTo(oldlength - 1));

        }

        [Test]
        public void TestAddAngebot()
        {
            Angebot a = new Angebot();
            a.Chance = 65;
            a.Titel = "Angebot 5";
            a.Datum = DateTime.Now;
            a.Dauer = 98;
            a.Kundenid = 1;
            a.Status = ObjectStates.New;
            int oldlength = BL.getAngebote().Count;
            BL.saveAngebot(a);
            int index = BL.getAngebote().Count;
            Assert.That(BL.getAngebote().Count, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getAngebot(index).Titel, Is.EqualTo("Angebot 5"));
            Assert.That(BL.getAngebot(index).Dauer, Is.EqualTo(98));
            Assert.That(BL.getAngebot(index).Chance, Is.EqualTo(65));
            Assert.That(BL.getAngebot(index).Kundenid, Is.EqualTo(1));
        }

        [Test]
        public void TestDeleteAngebot()
        {
            Angebot a = new Angebot();
            int oldlength = BL.getAngebote().Count;
            a = BL.getAngebote().ElementAt(oldlength - 1);
            BL.deleteAngebot(a);
            Assert.That(BL.getAngebote().Count, Is.EqualTo(oldlength - 1));
        }
    }
}
