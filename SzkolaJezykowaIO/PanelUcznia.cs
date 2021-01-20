using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SzkolaJezykowaIO
{
    public partial class PanelUcznia : Form
    {
        public PanelLogowania panel = new PanelLogowania();
        public Uczen uczen;
        public PanelUcznia(Uczen podajUcznia)
        {
            InitializeComponent();
            //wyswietlanie
            uczen = podajUcznia;
            label2.Text = uczen.imie + " " + uczen.nazwisko;
            label3.Text = "grupy: \n";
            uczen.grupa.ForEach(delegate (Grupa grupa)
                {
                    label3.Text += (grupa.nazwa + " \n");
                });
        }

        private void PanelUcznia_Load(object sender, EventArgs e)
        {
            //ladowanie panelu
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string tytul = Interaction.InputBox("podaj tytuł");
            string tresc = Interaction.InputBox("podaj treść zadania");
            uczen.zlozZadanieDoOceny(tresc, tytul);
            MessageBox.Show("Wysłano zadanie " + tytul + " do oceny");
            //interakcje z zadaniem domowym
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(uczen.listaOcen == null)
            {
                MessageBox.Show("Brak ocen do wyświetlenia");
            }
            else
            {
                string listaOcenString="";
                uczen.listaOcen.ForEach(delegate (Ocena ocena)
                {
                    listaOcenString += (ocena.opis + ": " + ocena.wartosc + " (waga: " + ocena.waga + ")\n");
                    //interakcje oceny
                });
                MessageBox.Show(listaOcenString);
            }
        }


        private void Button3_Click_1(object sender, EventArgs e)
        {
            //dodawanie nowego ucznia do systemu
            string jezyk = Interaction.InputBox("podaj język");
            string poziomZaawansowania = Interaction.InputBox("podaj poziom zaawansowania");
            panel.admin.dodajNaListe(uczen, jezyk, poziomZaawansowania);

            MessageBox.Show("Dodano na listę oczekujących");
        }
    }
}
