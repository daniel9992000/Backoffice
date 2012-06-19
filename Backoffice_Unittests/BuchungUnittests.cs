using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Backoffice;

namespace Backoffice_Unittests
{
    [TestFixture]
    class BuchungUnittests
    {
        [Test]
        public void TestAddBuchung()
        {
            Buchung b = new Buchung();
            int oldlength = BL.getBuchungen().Count();
            b.Betrag = 656;
            b.Datum = DateTime.Parse("2012-4-4");
            b.Kategorie = 1;
            b.Rechnungid = 3;
            b.Status = ObjectStates.New;
            BL.saveBuchung(b);
            Assert.That(BL.getBuchungen().Count, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getBuchungen().ElementAt(oldlength).Betrag, Is.EqualTo(656));
            Assert.That(BL.getBuchungen().ElementAt(oldlength).Datum, Is.EqualTo(DateTime.Parse("2012-4-4")));
            Assert.That(BL.getBuchungen().ElementAt(oldlength).Kategorie, Is.EqualTo(1));
            Assert.That(BL.getBuchungen().ElementAt(oldlength).Rechnungid, Is.EqualTo(3));
            Assert.That(BL.getBuchungen().ElementAt(oldlength).Status, Is.EqualTo(ObjectStates.Unmodified));
        }

        [Test]
        public void TestDeleteBuchung()
        {
            Buchung b = new Buchung();
            int oldlength = BL.getBuchungen().Count();
            b = BL.getBuchungen().Last();
            BL.deleteBuchung(b);
            Assert.That(BL.getBuchungen().Count, Is.EqualTo(oldlength - 1));
            Assert.That(BL.getBuchungen().Last(), Is.Not.EqualTo(b));
        }

        [Test]
        public void TestAddBuchungMin()
        {
            Buchung b = new Buchung(4,23.33,1,DateTime.Now,1,ObjectStates.New);
            BL.saveBuchung(b);
            Assert.That(BL.getBuchungen(1).Last().Betrag, Is.EqualTo(23.33));
            Assert.That(BL.getBuchungen(1).Last().Kategorie, Is.EqualTo(1));
            BL.deleteBuchung(b);
        }

        [Test]
        public void TestCountBuchungen()
        {
            Assert.That(BL.getBuchungen(1).Count, Is.EqualTo(2));
        }

        [Test]
        public void TestCountBuchungsKategorie()
        {
            Assert.That(BL.getBuchungsKategorie().Count, Is.EqualTo(4));
        }

        [Test]
        public void TestCountBuchungsKategorieEinnahme()
        {
            Assert.That(BL.getBuchungsKategorie(1).Bezeichung, Is.EqualTo("Einnahme"));
        }

        [Test]
        public void TestCountBuchungsKategorieAusgabe()
        {
            Assert.That(BL.getBuchungsKategorie(2).Bezeichung, Is.EqualTo("Ausgabe"));
        }

        [Test]
        public void TestCountBuchungsKategorieSVA()
        {
            Assert.That(BL.getBuchungsKategorie(3).Bezeichung, Is.EqualTo("SVA"));
        }

        [Test]
        public void TestCountBuchungsKategorieUSt()
        {
            Assert.That(BL.getBuchungsKategorie(4).Bezeichung, Is.EqualTo("USt"));
        }
    }
}
