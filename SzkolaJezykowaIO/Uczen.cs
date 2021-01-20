using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaJezykowaIO
{
    public class Uczen : Osoba
    {
        public List<Ocena> listaOcen= new List<Ocena>();
        public List<ZadanieDomowe> listaZadan= new List<ZadanieDomowe>();
        public Uczen(string login, string haslo, string imie,
        string nazwisko, int id, List<Grupa> grupa = null, List<Ocena> listaOcen = null, 
        List<ZadanieDomowe> listaZadan = null) : base(login, haslo, imie, nazwisko, id, grupa)
        {

        }
        public void zlozZadanieDoOceny(string tresc, string tytul)
        {
            ZadanieDomowe zadanie = new ZadanieDomowe(tresc, tytul);
            listaZadan.Add(zadanie);
        }
    }
}
