using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaJezykowaIO
{
    public class Admin
    {
        public string login;
        public string haslo;
        public List<Uczen> listaOczekujacych;
        public List<Grupa> listaGrup;

        public Admin(string login, string haslo) //konstruktor inicjujący
        {
            this.login = login;
            this.haslo = haslo;
            this.listaOczekujacych = new List<Uczen>();
            this.listaGrup = new List<Grupa>();
        }

        public void dodajNaListe
    }
}
