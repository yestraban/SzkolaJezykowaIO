using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzkolaJezykowaIO
{
    public partial class PanelLogowania : UserControl

    {
        public Admin admin = new Admin("szkolajezykowa", "admin123");
        public bool czyZalogowanyAdmin = false;
        public List<Uczen> listaUczniow= new List<Uczen>();
        public List<Prowadzacy> listaProwadzacych = new List<Prowadzacy>();
        public List<Grupa> listaGrup = new List<Grupa>();
        public List<Zajecia> listaZajec = new List<Zajecia>();
        //KLASA DO WYPELNIANIA OBIEKTOW
        public PanelLogowania()
        {
            InitializeComponent();
            //tutaj tworzyc obiekty
            

            listaUczniow.Add(new Uczen("Jakub2015","qwerty","Stanislaw", "Marek", 1));
            listaUczniow.Add(new Uczen("FranekKimono","ytrewq","Jakub", "Krzysztofinski", 2));
            listaUczniow.Add(new Uczen("niezlykozak","nagasaki123","Ferdynand", "Panderewski", 3));
            listaUczniow.Add(new Uczen("zabujca2012","picobelo","Miguel", "Cortez", 4));
            listaUczniow.Add(new Uczen("PrzyszlyPapiez","habemuspapam","Karol", "Pawel", 5));
            listaUczniow.Add(new Uczen("Pan_pawel","duzybul","Aleksander", "Wielki", 6));
            listaUczniow.Add(new Uczen("fan_maklowicza","koperek", "Krzysztof", "Karpaty", 7));
            listaUczniow.Add(new Uczen("ziemniak", "1235", "Fryderyk", "Chopin",8));
            listaUczniow.Add(new Uczen("kolega_od_linkow", "2137", "Jan", "Kowalski", 9));
            listaUczniow.Add(new Uczen("niemiecka_sila", "windowsvista", "Norbert", "Gierczak", 10));
            listaUczniow.Add(new Uczen("robertsmurfica", "okon", "Szymon", "Dolny", 11));

            listaProwadzacych.Add(new Prowadzacy("Squirtle123", "pikachu", "Grzegorz", "Adamiakowa", 1));
            listaProwadzacych.Add(new Prowadzacy("Bulbazaur123", "charizard", "Kamil", "Lufa", 2));
            listaProwadzacych.Add(new Prowadzacy("ajem", "juar", "Adam", "Miauczynski", 3));
            listaProwadzacych.Add(new Prowadzacy("messerschmitt", "jednarunda", "Endriu", "Golota", 4));
            listaGrup.Add(new Grupa("angielski", "podstawowy", "ang_podstawowy", listaProwadzacych[0],
                new List<Uczen> {listaUczniow[0], listaUczniow[1], listaUczniow[2]}));
            listaGrup.Add(new Grupa("hiszpanski", "podstawowy", "hiszp_podstawowy", listaProwadzacych[1],
                new List<Uczen> {listaUczniow[5], listaUczniow[6], listaUczniow[7], listaUczniow[8], listaUczniow[0]}));
            listaGrup.Add(new Grupa("angielski", "rozszerzony", "ang_rozszerzony", listaProwadzacych[2],
                new List<Uczen> {listaUczniow[3], listaUczniow[4], listaUczniow[5]}));
            listaGrup.Add(new Grupa("niemiecki", "podstawowy", "niem_rozszerzony", listaProwadzacych[3],
               new List<Uczen>{ listaUczniow[1],listaUczniow[9],listaUczniow[10],listaUczniow[2]}));
            listaUczniow[0].grupa.Add(listaGrup[0]);
            listaUczniow[0].grupa.Add(listaGrup[1]);// z zera jest w dwoch grupach
            listaUczniow[1].grupa.Add(listaGrup[0]);
            listaUczniow[1].grupa.Add(listaGrup[3]);
            listaUczniow[2].grupa.Add(listaGrup[0]);
            listaUczniow[2].grupa.Add(listaGrup[3]);
            listaUczniow[3].grupa.Add(listaGrup[2]); 
            listaUczniow[4].grupa.Add(listaGrup[2]); 
            listaUczniow[5].grupa.Add(listaGrup[2]);
            listaUczniow[5].grupa.Add(listaGrup[1]);
            listaUczniow[6].grupa.Add(listaGrup[1]);
            listaUczniow[7].grupa.Add(listaGrup[1]);
            listaUczniow[8].grupa.Add(listaGrup[1]);
            listaUczniow[9].grupa.Add(listaGrup[3]);
            listaUczniow[10].grupa.Add(listaGrup[3]);
           

            listaProwadzacych[0].grupa.Add(listaGrup[0]);
            listaProwadzacych[1].grupa.Add(listaGrup[1]);
            listaProwadzacych[2].grupa.Add(listaGrup[2]);
            listaProwadzacych[3].grupa.Add(listaGrup[3]);
            //na grupe przypada prowadzacy i kilku uczniow
            
            
           listaZajec.Add(new Zajecia("Poniedzialek", "15:00", "nr 1", "ang_podstawowy",listaGrup[0]));
           listaZajec.Add(new Zajecia("Czwartek", "16:00", "nr 1", "ang_podstawowy",listaGrup[0]));
           listaZajec.Add(new Zajecia("Czwartek", "17:00", "nr 1", "ang_podstawowy",listaGrup[0]));
           listaZajec.Add(new Zajecia("Piatek", "15:00", "nr 1", "ang_podstawowy",listaGrup[0]));
           listaZajec.Add(new Zajecia("Poniedzialek", "16:00", "nr 2", "ang_rozszerzony",listaGrup[2]));
           listaZajec.Add(new Zajecia("Sroda", "15:00", "nr 2", "ang_rozszerzony",listaGrup[2]));
           listaZajec.Add(new Zajecia("Sroda", "16:00", "nr 2", "ang_rozszerzony",listaGrup[2]));
           listaZajec.Add(new Zajecia("Piatek", "17:00", "nr 2", "ang_rozszerzony",listaGrup[2]));
           listaZajec.Add(new Zajecia("Wtorek", "16:00", "nr 1", "niem_podstawowy",listaGrup[3]));
           listaZajec.Add(new Zajecia("Środa", "15:00", "nr 1", "niem_podstawowy",listaGrup[3]));
           listaZajec.Add(new Zajecia("Czwartek", "16:00", "nr 2", "hiszp_podstawowy",listaGrup[1]));
           listaZajec.Add(new Zajecia("Piatek", "16:00", "nr 1", "hiszp_podstawowy",listaGrup[1]));
          
           
           
          


        }

       
         

        public Uczen zalogujUcznia(string login, string haslo)
        {
            int i = 0;
            while(i<listaUczniow.Count())
            {
                if (listaUczniow[i].login == login && listaUczniow[i].haslo == haslo)
                    return listaUczniow[i];
                i++;
            }
            return null;
        }


        public Prowadzacy zalogujProwadzacego(string login, string haslo)
        {
            int i = 0;
            while (i<listaProwadzacych.Count())
            {
                if (listaProwadzacych[i].login == login && listaProwadzacych[i].haslo == haslo)
                    return listaProwadzacych[i];
                i++;
            }
            return null;
        }

        public bool zalogujAdmina(string login, string haslo)
        {
            if (login == admin.login && haslo == admin.haslo)
                return true;
            else
                return false;
        }

        private void PanelLogowania_Load(object sender, EventArgs e)
        {

        }
    }
}
