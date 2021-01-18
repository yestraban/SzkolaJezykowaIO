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
            listaUczniow.Add(new Uczen("kiler2137","picobelo","Miguel", "Cortez", 4));
            listaUczniow.Add(new Uczen("PrzyszlyPapiez","habemuspapam","Karol", "Pawel", 5));
            listaUczniow.Add(new Uczen("Pan_pawel","duzybul","Aleksander", "Wielki", 6));
            listaUczniow.Add(new Uczen("fan_maklowicza","koperek", "Krzysztof", "Karpaty", 7));
            listaUczniow.Add(new Uczen("ziemniak", "1235", "Fryderyk", "Chopin",8));
            listaUczniow.Add(new Uczen("kolega_od_linkow","2137", "Jan","Kowalski",9));

            listaProwadzacych.Add(new Prowadzacy("Squirtle123", "pikachu", "Grzegorz", "Adamiakowa", 1));
            listaProwadzacych.Add(new Prowadzacy("Bulbazaur123", "charizard", "Kamil", "Lufa", 2));
            listaProwadzacych.Add(new Prowadzacy("ajem", "juar", "Adam", "Miauczynski", 3));
            listaGrup.Add(new Grupa("angielski", "podstawowy", "ang_podstawowy", listaProwadzacych[0],
                new List<Uczen> {listaUczniow[0], listaUczniow[1], listaUczniow[2]}));
            listaGrup.Add(new Grupa("hiszpanski", "podstawowy", "hiszp_podstawowy", listaProwadzacych[1],
                new List<Uczen> {listaUczniow[5], listaUczniow[6], listaUczniow[7], listaUczniow[8], listaUczniow[0]}));
            listaGrup.Add(new Grupa("angielski", "rozszerzony", "ang_rozszerzony", listaProwadzacych[2],
                new List<Uczen> {listaUczniow[3], listaUczniow[4], listaUczniow[5]}));
            listaUczniow[0].grupa.Add(listaGrup[0]);
            listaUczniow[0].grupa.Add(listaGrup[1]);// z zera jest w dwoch grupach
            listaUczniow[1].grupa.Add(listaGrup[0]);
            listaUczniow[2].grupa.Add(listaGrup[0]);
            listaUczniow[3].grupa.Add(listaGrup[2]); 
            listaUczniow[4].grupa.Add(listaGrup[2]); 
            listaUczniow[5].grupa.Add(listaGrup[2]);
            listaUczniow[5].grupa.Add(listaGrup[1]);
            listaUczniow[6].grupa.Add(listaGrup[1]);
            listaUczniow[7].grupa.Add(listaGrup[1]);
            listaUczniow[8].grupa.Add(listaGrup[1]);
           

            listaProwadzacych[0].grupa.Add(listaGrup[0]);
            listaProwadzacych[1].grupa.Add(listaGrup[1]);
            listaProwadzacych[2].grupa.Add(listaGrup[2]);
            //na grupe przypada prowadzacy i kilku uczniow
            
            
           listaZajec.Add(new Zajecia("Poniedzialek", "15:00", "nr 1", "ang_podstawowy",listaGrup[0]));
           listaZajec.Add(new Zajecia("Wtorek", "14:00", "nr 15", "ang_rozszerzony",listaGrup[2]));

        }

        private void PanelLogowania_Load(object sender, EventArgs e)
        {

        }
    }
}
