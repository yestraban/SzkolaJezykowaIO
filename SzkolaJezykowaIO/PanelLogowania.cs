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
            listaUczniow.Add(new Uczen("kiler2137","picobelo","Miguel", "Cortez", 4));
            listaUczniow.Add(new Uczen("PrzyszlyPapiez","habemuspapam","Karol", "Pawel", 5));
            listaUczniow.Add(new Uczen("Pan_pawel","duzybul","Aleksander", "Wielki", 6));

            listaProwadzacych.Add(new Prowadzacy("Squirtle123", "pikachu", "Grzegorz", "Adamiakowa", 1));
            listaProwadzacych.Add(new Prowadzacy("Bulbazaur123", "charizard", "Kamil", "Lufa", 2));
            listaGrup.Add(new Grupa("angielski", "podstawowy", "podstawowy", listaProwadzacych[0],
                new List<Uczen> {listaUczniow[0], listaUczniow[1], listaUczniow[2]}));
            listaGrup.Add(new Grupa("angielski", "rozszerzona", "rozszerzona", listaProwadzacych[1],
                new List<Uczen> {listaUczniow[3], listaUczniow[4], listaUczniow[5]}));
            listaUczniow[0].grupa.Add(listaGrup[0]);
            listaUczniow[1].grupa.Add(listaGrup[0]);
            listaUczniow[2].grupa.Add(listaGrup[0]);
            listaUczniow[3].grupa.Add(listaGrup[1]);
            listaUczniow[4].grupa.Add(listaGrup[1]);
            listaUczniow[5].grupa.Add(listaGrup[1]);
            listaProwadzacych[0].grupa.Add(listaGrup[0]);
            listaProwadzacych[1].grupa.Add(listaGrup[1]);


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
