using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backoffice;
using NUnit.Framework;

namespace Backoffice_Unittests
{
    [TestFixture]
    class RechnungszeileUnittest
    {
        [Test]
        public void TestAddRechnungszeilen()
        {
            Rechnungszeile rezeile = new Rechnungszeile();
            int oldlength = BL.getRechnungszeilen(8).Count();
            rezeile.Betrag = 656;
            rezeile.Bezeichnung = "Zeile1";
            rezeile.Rechnungid = 8;
            rezeile.Status = ObjectStates.New;
            BL.saveRechnungszeile(rezeile);
            Assert.That(BL.getRechnungszeilen(8).Count, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getRechnungszeilen(8).First().Betrag, Is.EqualTo(656));
            Assert.That(BL.getRechnungszeilen(8).First().Bezeichnung, Is.EqualTo("Zeile1"));
            Assert.That(BL.getRechnungszeilen(8).First().Status, Is.EqualTo(ObjectStates.Modified));
        }

        [Test]
        public void TestDeleteRechnungsZeilen()
        {
            Rechnungszeile rezeile = new Rechnungszeile();
            int oldlength = BL.getRechnungszeilen(8).Count();
            rezeile = BL.getRechnungszeilen(8).Last();
            BL.deleteRechnungszeile(rezeile);
            Assert.That(BL.getRechnungszeilen(8).Count, Is.EqualTo(oldlength - 1));
            Assert.That(BL.getRechnungszeilen(8), Is.Not.EqualTo(rezeile));
        }

        [Test]
        public void TestAddRechnungszeilenMin()
        {
            Rechnungszeile rezeile = new Rechnungszeile(3,"rezeiletest",23.33,3,ObjectStates.New);
            BL.saveRechnungszeile(rezeile);
            Assert.That(BL.getRechnungszeilen(3).First().Betrag, Is.EqualTo(23.33));
            Assert.That(BL.getRechnungszeilen(3).First().Bezeichnung, Is.EqualTo("rezeiletest"));
        }

        [Test]
        public void TestCountRechnungszeilen()
        {
            Assert.That(BL.getRechnungszeilen(1).Count, Is.EqualTo(4));
        }
    }
}
