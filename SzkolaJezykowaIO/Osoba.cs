using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaJezykowaIO
{
    public class Osoba
    {
        string login;
        string haslo;

        public string imie;
        public string nazwisko;
        public int id;
        public List<Grupa> grupa;
    }
}
