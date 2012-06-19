using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backoffice;
using NUnit.Framework;

namespace Backoffice_Unittests
{
    [TestFixture]
    class AngebotUnittests
    {
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
            a = BL.getAngebot(4);
            int oldlength = BL.getAngebote().Count;
            BL.deleteAngebot(a);
            Assert.That(BL.getAngebote().Count, Is.EqualTo(oldlength - 1));
            Assert.That(BL.getAngebote().Last(), Is.Not.EqualTo(a));
        }

        [Test]
        public void TestAddAngebotMin()
        {
            Angebot a = new Angebot(15, "test", -0.4, DateTime.Now, 5, 2, 1, 1, ObjectStates.New);
            BL.saveAngebot(a);
            Assert.That(BL.getAngebotByProjektId(1).Titel, Is.EqualTo("test"));
            Assert.That(BL.getAngebotByProjektId(1).Dauer, Is.EqualTo(5));
            Assert.That(BL.getAngebotByProjektId(1).Kundenid, Is.Not.EqualTo(-1));
            BL.deleteAngebot(a);
        }

        [Test]
        public void TestGetAngeboteByProjektid()
        {
            Angebot a = new Angebot(15, "test", -0.4, DateTime.Now, 5, 2, 1, 1, ObjectStates.New);
            BL.saveAngebot(a);
            Assert.That(BL.getAngeboteByProjektId(1).Count, Is.EqualTo(2));
            BL.deleteAngebot(a);
        }

        [Test]
        public void TestGetAngebote()
        {
            Assert.That(BL.getAngebote().Count, Is.EqualTo(3));
        }

        [Test]
        public void TestGetAngeboteByKundenid()
        {
            Assert.That(BL.getAngebote(1).Count, Is.EqualTo(1));
        }

        [Test]
        public void TestGetAngeboteBySearch()
        {
            Assert.That(BL.getAngebote("Angebot 1").Count, Is.EqualTo(1));
        }
    }
}
