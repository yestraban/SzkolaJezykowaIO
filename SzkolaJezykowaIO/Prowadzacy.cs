using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaJezykowaIO
{
    public class Prowadzacy : Osoba
    {
        public Prowadzacy(string login, string haslo, string imie,
        string nazwisko, int id, List<Grupa> grupa = null) : base(login, haslo, imie, nazwisko, id, grupa)
        { }

        void wyswietlUcznia()
        {
            //najpierw oceny, zajecia do zrobienia
        }
        
        void dodajOcene(Uczen uczen)
        {

            System.Console.WriteLine("Podaj ocenę");
            double wartosc = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Podaj wagę oceny");
            double waga = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Podaj opis oceny");
            string opis = Console.ReadLine();
            Ocena ocena = new Ocena(wartosc, waga, opis);
            uczen.listaOcen.Add(ocena);
        }

        void edycjaOcen(Ocena ocena)
        {
            System.Console.WriteLine("Podaj ocenę");
            double wartosc = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Podaj wagę oceny");
            double waga = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Podaj opis oceny");
            string opis = Console.ReadLine();
            ocena.wartosc = wartosc;
            ocena.waga = waga;
            ocena.opis = opis;
        }

        void sprawdzZadanieDomowe(ZadanieDomowe zadanie)
        {
            zadanie.wyswietl();
        }

    }
}
