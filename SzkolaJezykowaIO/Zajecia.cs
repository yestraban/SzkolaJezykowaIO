namespace SzkolaJezykowaIO
{
    public class Zajecia
    {
        public string dzien_tygodnia;
        public string godzina;
        public string sala;
        public string nazwa_zajec;
        public Grupa grupa;

        public Zajecia(string dzien_tygodnia, string godzina, string sala, string nazwa_zajec, Grupa grupa)
        {
            //konstruktor parametryzujacy
            this.dzien_tygodnia = dzien_tygodnia;
            this.godzina = godzina;
            this.sala = sala;
            this.nazwa_zajec = nazwa_zajec;
            this.grupa = grupa;

        }
    }
}