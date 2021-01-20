using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaJezykowaIO
{
    public class Osoba
    {
        public string login;
        public string haslo;

        public string imie;
        public string nazwisko;
        public int id;
        public List<Grupa> grupa;

        protected Osoba(string login, string haslo, string imie, string nazwisko, int id, List<Grupa> grupa)
        {
            // konstruktor inicjujący
            this.login = login;
            this.haslo = haslo;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.id = id;
            this.grupa = new List<Grupa>();
        }
    }
}
