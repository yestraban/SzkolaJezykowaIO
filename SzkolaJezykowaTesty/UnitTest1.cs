﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SzkolaJezykowaIO;
using System.Collections;
using System.Collections.Generic;

namespace SzkolaJezykowaTesty
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LogowanieUcznia()
        {
            PanelLogowania a = new PanelLogowania();



            Uczen uczen = new Uczen("Jakub2015", "qwerty", "Stanislaw", "Marek", 1);

            uczen = a.zalogujUcznia("Jakub2015", "qwerty");

            Assert.AreEqual(uczen.imie, "Stanislaw");

        }
        [TestMethod]
        public void LogowanieUczniaZKoncaListy()
        {
            PanelLogowania a = new PanelLogowania();



            Uczen uczen = new Uczen("Pan_pawel", "duzybul", "Aleksander", "Wielki", 6);

            uczen = a.zalogujUcznia("Pan_pawel", "duzybul");

            Assert.AreEqual(uczen.imie, "Aleksander");

        }

        [TestMethod]
        public void LogowanieUczniaToFail()
        {
            PanelLogowania a = new PanelLogowania();



            Uczen uczen = new Uczen("Jakub2015", "qwerty", "Stanislaw", "Marek", 1);

            uczen = a.zalogujUcznia("login", "haslo");

            Assert.AreEqual(uczen, null);

        }

        [TestMethod]
        public void LogowanieProwadzacego()
        {
            PanelLogowania a = new PanelLogowania();



            Prowadzacy prowadzacy = new Prowadzacy("Squirtle123", "pikachu", "Grzegorz", "Adamiakowa", 1);

            prowadzacy = a.zalogujProwadzacego("Squirtle123", "pikachu");

            Assert.AreEqual(prowadzacy.imie, "Grzegorz");

        }

        [TestMethod]
        public void LogowanieAdmina()
        {
            PanelLogowania a = new PanelLogowania();

            a.czyZalogowanyAdmin = a.zalogujAdmina("szkolajezykowa", "admin123");

            Assert.IsTrue(a.czyZalogowanyAdmin);
        }

        [TestMethod]
        public void LogowaniedminaToFail()
        {
            PanelLogowania a = new PanelLogowania();

            a.czyZalogowanyAdmin = a.zalogujAdmina("random", "random");

            Assert.IsFalse(a.czyZalogowanyAdmin);
        }

        [TestMethod]
        public void DodawanieNaListeOczekujacych()
        {
            PanelLogowania a = new PanelLogowania();

            Uczen uczen = new Uczen("Jakub2015", "qwerty", "Stanislaw", "Marek", 1);

            a.admin.dodajNaListe(uczen);

            Assert.AreEqual(a.admin.listaOczekujacych[0].imie, "Stanislaw");
        }

        [TestMethod]
        public void DodawanieDoGrupy()
        {
            
            PanelLogowania a = new PanelLogowania();
            Uczen uczen = new Uczen("Jakub2015", "qwerty", "Stanislaw", "Marek", 1);
            Prowadzacy prowadzacy = new Prowadzacy("Squirtle123", "pikachu", "Grzegorz", "Adamiakowa", 1);
            Grupa grupa = new Grupa("angielski", "podstawowy", "podstawowy", prowadzacy, new List<Uczen>());

            a.admin.dodajDoGrupy(uczen, grupa);

            Assert.AreEqual(uczen, grupa.listaUczniow[0]);

            Assert.AreEqual(grupa, uczen.grupa[0]);
        }


        [TestMethod]
        public void edycjaGrupy()
        {
            PanelLogowania a = new PanelLogowania();
            Uczen uczen = new Uczen("Jakub2015", "qwerty", "Stanislaw", "Marek", 1);
            Prowadzacy prowadzacy = new Prowadzacy("Squirtle123", "pikachu", "Grzegorz", "Adamiakowa", 1);
            Grupa grupa = new Grupa("angielski", "podstawowy", "podstawowy", prowadzacy, new List<Uczen>());

            a.admin.edytujGrupe(grupa, null, null, "innanazwa", null);

            Assert.AreEqual(grupa.nazwa, "innanazwa");
        }
    }
}
