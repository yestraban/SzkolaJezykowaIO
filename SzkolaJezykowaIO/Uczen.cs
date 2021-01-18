using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaJezykowaIO
{
    public class Uczen : Osoba
    {
        public List<Ocena> listaOcen;
        public List<ZadanieDomowe> listaZadan;
        public Uczen(string login, string haslo, string imie,
        string nazwisko, int id, List<Grupa> grupa = null,

        List<Ocena> listaOcen = null, List<ZadanieDomowe> listaZadan = null) : base(login, haslo, imie, nazwisko, id, grupa)

        { }

        public void zapiszNaZajecia()
        { }

        public void wyswietlOceny()
        {
            if (listaOcen == null)
            {
                System.Console.WriteLine("Brak ocen do wyświetlenia");
            }
            else
            {
                listaOcen.ForEach(delegate(Ocena ocena) 
                  { ocena.wyswietl(); });
            }
        }

        public void zlozZadanieDoOceny()
        {
            System.Console.WriteLine("Tytuł zadania: ");
            string tytul = Console.ReadLine();
            System.Console.WriteLine("Treść zadania: ");
            string tresc = Console.ReadLine();
            ZadanieDomowe zadanie = new ZadanieDomowe(tresc, tytul);
            listaZadan.Add(zadanie);
        }
    }
}
