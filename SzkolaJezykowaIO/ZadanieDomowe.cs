using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaJezykowaIO
{
    public class ZadanieDomowe
    {
        //prosta obsluga zadan domowych
        public string tresc;
        public string tytul;

        public ZadanieDomowe (string tresc, string tytul)
        {
            this.tresc = tresc;
            this.tytul = tytul;
        }

        public void wyswietl()
        {
            System.Console.WriteLine("Tytuł: "+ tytul);
            System.Console.WriteLine("Treść: " + tresc);
        }
    }
}