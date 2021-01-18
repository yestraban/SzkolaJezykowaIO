using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolaJezykowaIO
{
    public class ZadanieDomowe
    {
        private string tresc;
        private string tytul;

        public ZadanieDomowe (string tresc, string tytul)
        {
            this.tresc = tresc;
            this.tytul = tytul;
        }
    }
}