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
        public void testaddkunde()
        {
            
            List<Kunde> klist = new List<Kunde>();
            klist = BL.getKunden();
            int oldlength = klist.Count;
            Kunde k = new Kunde();
            k.Vorname = "Max";
            k.Nachname = "Test";
            k.Email = "Hallo";
            k.Hausnummer = "44";
            k.Status = ObjectStates.New;
            BL.saveKunde(k);
            klist = BL.getKunden();
            Assert.That(klist.Count, Is.EqualTo(oldlength + 1));
        }
    }
}
