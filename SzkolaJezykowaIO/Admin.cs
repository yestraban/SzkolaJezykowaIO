using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaJezykowaIO
{
     public struct Oczekujacy
    {
       public Uczen uczen;
       public string poziomZaawansowania;
       public string jezyk;
    }
    public class Admin
    {
        public string login;
        public string haslo;
        public List<Oczekujacy> listaOczekujacych= new List<Oczekujacy>();

        public Admin(string login, string haslo) //konstruktor inicjujący
        {
            this.login = login;
            this.haslo = haslo;
        }

        public void dodajNaListe(Uczen uczen, string jezyk, string poziom)
        {
            Oczekujacy nowy = new Oczekujacy();
            nowy.uczen = uczen;
            nowy.jezyk = jezyk;
            nowy.poziomZaawansowania = poziom;
            this.listaOczekujacych.Add(nowy);
        }

        public void dodajDoGrupy(Uczen uczen, Grupa grupa)
        {
            uczen.grupa.Add(grupa);
            grupa.listaUczniow.Add(uczen);
        }

        public void edytujGrupe(Grupa grupa, string jezyk, string poziomZaawansowania, string nazwa, Prowadzacy prowadzacy)
        {
            if (jezyk != null)
                grupa.jezyk = jezyk;

            if (poziomZaawansowania != null)
                grupa.poziomZaawansowania = poziomZaawansowania;

            if (nazwa != null)
                grupa.nazwa = nazwa;

            if (prowadzacy != null)
                grupa.prowadzacy = prowadzacy;
        }

        public void usunUcznia(List<Uczen> listaUczniow, Uczen uczen)
        {
            listaUczniow.Remove(uczen);
        }

        public void usunProwadzacego(List<Prowadzacy> listaProwadzacych, Prowadzacy prowadzacy)
        {
            listaProwadzacych.Remove(prowadzacy);
        }

        public void usunGrupe(List<Grupa> listaGrup, Grupa grupa)
        {
            listaGrup.Remove(grupa);
        }
    }
}
