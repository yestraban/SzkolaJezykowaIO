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

        public Admin(string login, string haslo) //konstruktor inicjujący
        {
            this.login = login;
            this.haslo = haslo;
            this.listaOczekujacych = new List<Uczen>();
        }

        public void dodajNaListe(Uczen uczen)
        {
            this.listaOczekujacych.Add(uczen);
        }

        public void dodajDoGrupy(Uczen uczen, Grupa grupa)
        {
            uczen.grupa.Add(grupa);
            grupa.listaUczniow.Add(uczen);
        }

        public void edytujGrupe(Grupa grupa, string jezyk, string poziomZaawansowania, string nazwa, Prowadzacy prowadzacy)
        {
            if (jezyk != null)
                grupa.jezyk = jezyk;

            if (poziomZaawansowania != null)
                grupa.poziomZaawansowania = poziomZaawansowania;

            if (nazwa != null)
                grupa.nazwa = nazwa;

            if (prowadzacy != null)
                grupa.prowadzacy = prowadzacy;
        }

    }
}
