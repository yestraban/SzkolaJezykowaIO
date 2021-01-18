namespace SzkolaJezykowaIO
{
    public class Zajecia
    {
        public string dzien_tygodnia;
        public string godzina;
        public string sala;
        public string nazwa_zajec;

        public Zajecia(string data, string godzina, string sala, string nazwa_zajec,Grupa grupa=null)
        {
            this.dzien_tygodnia = dzien_tygodnia;
            this.godzina = godzina;
            this.nazwa_zajec = nazwa_zajec;
            this.sala = sala;
            
        }
    }
}