using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backoffice;
using NUnit.Framework;

namespace Backoffice_Unittests
{
    [TestFixture]
    class AusgangsrechnungUnittests
    {
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
        public void TestDeleteAusgang()
        {
            Ausgang a = new Ausgang();
            int oldlength = BL.getAusgaenge().Count();
            a = BL.getAusgaenge().Last();
            BL.deleteAusgang(a);
            Assert.That(BL.getAusgaenge().Count, Is.EqualTo(oldlength - 1));
            Assert.That(BL.getAusgaenge().Last(), Is.Not.EqualTo(a));
        }

        [Test]
        public void TestGetAusgangsrechnungen()
        {
            Assert.That(BL.getAusgaenge().Count, Is.EqualTo(3));
        }

        [Test]
        public void TestGetAusgangsrechnungByProjektid()
        {
            Assert.That(BL.getAusgaengeByProjektId(1).Count, Is.EqualTo(2));
        }
    }
}
