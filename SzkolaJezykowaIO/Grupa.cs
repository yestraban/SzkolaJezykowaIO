using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaJezykowaIO
{
    public class Grupa
    {
        public string jezyk;
        public string poziomZaawansowania;
        public string nazwa;
        public Prowadzacy prowadzacy;
        public List<Uczen> listaUczniow;

        public Grupa(string jezyk, string poziomZaawansowania, string nazwa, Prowadzacy prowadzacy,
            List<Uczen> listaUczniow)
        {
            // konstruktor inicjujący
            this.jezyk = jezyk;
            this.poziomZaawansowania = poziomZaawansowania;
            this.nazwa = nazwa;
            this.listaUczniow = listaUczniow;
        }
    }
}
