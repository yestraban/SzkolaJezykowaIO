using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaJezykowaIO
{
    public class Prowadzacy:Osoba
    {
        public Prowadzacy(string login, string haslo, string imie,
        string nazwisko, int id, List<Grupa> grupa):base(login,haslo,imie,nazwisko,id,grupa)
        {}
    }
}
