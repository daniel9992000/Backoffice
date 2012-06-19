using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backoffice;
using NUnit.Framework;

namespace Backoffice_Unittests
{
    [TestFixture]
    class ProjektUnittests
    {
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
            Assert.That(BL.getProjekt(oldlength + 1).Projektid, Is.EqualTo(oldlength + 1));
            Assert.That(BL.getProjekt(oldlength + 1).Name, Is.EqualTo("Testprojekt"));
            Assert.That(BL.getProjekt(oldlength + 1).ToString(), Is.EqualTo("Testprojekt"));
        }

        [Test]
        public void TestDeleteProjekt()
        {
            Projekt p = new Projekt();
            int oldlength = BL.getProjekte().Count;
            p = BL.getProjekt(oldlength);
            BL.deleteProjekt(p);
            Assert.That(BL.getProjekte().Count, Is.EqualTo(oldlength - 1));
            Assert.That(BL.getProjekte().Last(), Is.Not.EqualTo(p));
        }

        [Test]
        public void TestAddProjektMin()
        {
            Projekt p = new Projekt(3,"testprojekt",ObjectStates.New);
            BL.saveProjekt(p);
            Assert.That(BL.getProjekt(4).Name, Is.EqualTo("testprojekt"));
            BL.deleteProjekt(p);
        }

        [Test]
        public void TestGetProjekte()
        {
            Assert.That(BL.getProjekte().Count ,Is.EqualTo(2));
        }

        [Test]
        public void TestGetProjektebySearch()
        {
            Assert.That(BL.getProjekte("Projekt 2").Count, Is.EqualTo(1));
        }

        [Test]
        public void TestGetProjektebyKundenid()
        {
            Assert.That(BL.getProjekte(1).Count, Is.EqualTo(1));
        }


        [Test]
        public void TestSaveStunden()
        {
            Stunden stunde = new Stunden("Projekt 2", "Karli", 33, DateTime.Now);
            BL.saveStunde(stunde);
            Assert.That(BL.getStunden("Projekt 2").Last().Stundenanz, Is.EqualTo(33));
        }

        [Test]
        public void TestGetProjektStunden()
        {
            Assert.That(BL.getProjektStunden("Projekt 1"), Is.EqualTo(34));
        }
    }
}
