using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SzkolaJezykowaIO;

namespace SzkolaJezykowaTesty
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLogowaniaUcznia()
        {
            PanelLogowania a=new PanelLogowania();

            

            Uczen uczen= new Uczen("Jakub2015", "qwerty", "Stanislaw", "Marek", 1);

            uczen = a.zalogujUcznia("Jakub2015", "qwerty");

            Assert.AreEqual(uczen.imie, "Stanislaw");

        }
        [TestMethod]
        public void TestLogowaniaUczniaZKoncaListy()
        {
            PanelLogowania a = new PanelLogowania();



            Uczen uczen = new Uczen("Pan_pawel", "duzybul", "Aleksander", "Wielki", 6);

            uczen = a.zalogujUcznia("Pan_pawel", "duzybul");

            Assert.AreEqual(uczen.imie, "Aleksander");

        }

        [TestMethod]
        public void TestLogowaniaUczniaToFail()
        {
            PanelLogowania a = new PanelLogowania();



            Uczen uczen = new Uczen("Jakub2015", "qwerty", "Stanislaw", "Marek", 1);

            uczen = a.zalogujUcznia("login", "haslo");

            Assert.AreEqual(uczen, null);

        }

        [TestMethod]
        public void TestLogowaniaProwadzacego()
        {
            PanelLogowania a = new PanelLogowania();



            Prowadzacy prowadzacy = new Prowadzacy("Squirtle123", "pikachu", "Grzegorz", "Adamiakowa", 1);

            prowadzacy = a.zalogujProwadzacego("Squirtle123", "pikachu");

            Assert.AreEqual(prowadzacy.imie, "Grzegorz");

        }

        [TestMethod]
        public void TestLogowaniaAdmina()
        {
            PanelLogowania a = new PanelLogowania();

            a.czyZalogowanyAdmin = a.zalogujAdmina("szkolajezykowa", "admin123");

            Assert.IsTrue(a.czyZalogowanyAdmin);
        }

        [TestMethod]
        public void TestLogowaniaAdminaToFail()
        {
            PanelLogowania a = new PanelLogowania();

            a.czyZalogowanyAdmin = a.zalogujAdmina("random", "random");

            Assert.IsFalse(a.czyZalogowanyAdmin);
        }
    }
}
