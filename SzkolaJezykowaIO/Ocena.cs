namespace SzkolaJezykowaIO
{
    public class Ocena
    {
        public double wartosc = 1.0;
        public double waga;
        public string opis;

        public Ocena(double wartosc, double waga, string opis)
        {
            this.wartosc = wartosc;
            this.waga = waga;
            this.opis = opis;
        }

        public void wyswietl()
        {
            System.Console.Write("Ocena: ", wartosc);
            System.Console.Write(" Waga ", waga);
            System.Console.Write(" Opis: ", opis);
        }



    }
}