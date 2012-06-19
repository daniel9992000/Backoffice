using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backoffice;
using NUnit.Framework;

namespace Backoffice_Unittests
{
    [TestFixture]
    class EingangsrechnungUnittests
    {
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
            Assert.That(BL.getEingaenge().Count, Is.EqualTo(oldlength - 1));
            Assert.That(BL.getEingaenge().Last(), Is.Not.EqualTo(r));
        }

        [Test]
        public void TestAddEingangMin()
        {
            Eingang r = new Eingang(5,"Eingangtest",DateTime.Now,323.434,"C:",1,ObjectStates.New);
            BL.saveEingang(r);
            Assert.That(BL.getEingaenge(1).Last().Betrag, Is.EqualTo(323.434));
            Assert.That(BL.getEingaenge(1).Last().Bezeichnung, Is.EqualTo("Eingangtest"));
            Assert.That(BL.getEingaenge(1).Last().Path, Is.EqualTo("C:"));
            BL.deleteEingang(r);
        }

        [Test]
        public void TestGetKontaktEingaenge()
        {
            Assert.That(BL.getEingaenge(1).Count, Is.EqualTo(1));
        }

        [Test]
        public void TestGetEingaenge()
        {
            Assert.That(BL.getEingaenge().Count, Is.EqualTo(1));
        }

        [Test]
        public void TestGetEingaengebySearch()
        {
            Assert.That(BL.getEingaenge("Eingangsrechnung 1").Count, Is.EqualTo(1));
        }
    }
}
