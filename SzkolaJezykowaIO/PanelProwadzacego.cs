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
    public partial class PanelProwadzacego : Form
    {
        public PanelLogowania panel = new PanelLogowania();
        public Prowadzacy prowadzacy;

        public PanelProwadzacego(Prowadzacy podajProwadzacego)
        {
            InitializeComponent();
            prowadzacy = podajProwadzacego;
            label2.Text = prowadzacy.imie + " " + prowadzacy.nazwisko;
            label3.Text = "grupy: \n";
            prowadzacy.grupa.ForEach(delegate (Grupa grupa)
            {
                label3.Text += (grupa.nazwa + " \n");
            });
            button1.Click += new EventHandler(this.button1_Click);
            button2.Click += new EventHandler(this.button2_Click);
            button3.Click += new EventHandler(this.button3_Click);
            button4.Click += new EventHandler(this.button4_Click);
            foreach (Grupa grupa in prowadzacy.grupa)
            {
                comboBox1.Items.Add(grupa.nazwa);
            }
            if (comboBox1.SelectedIndex >= 0)
            {
                foreach (Uczen ucz in prowadzacy.grupa[comboBox1.SelectedIndex].listaUczniow)
                {
                    comboBox2.Items.Add(ucz.imie + " " + ucz.nazwisko);
                }
            }
            else
            {
                foreach (Uczen ucz in prowadzacy.grupa[0].listaUczniow)
                {
                    comboBox2.Items.Add(ucz.imie + " " + ucz.nazwisko);
                }
            }
            if (comboBox2.SelectedIndex >= 0 && comboBox1.SelectedIndex >= 0)
            {
                foreach (Ocena ocena in prowadzacy.grupa[comboBox1.SelectedIndex].listaUczniow[comboBox2.SelectedIndex].listaOcen)
                {
                    comboBox3.Items.Add(ocena.opis + ": " + ocena.wartosc);
                }
            }
            else
            {
                foreach (Ocena ocena in prowadzacy.grupa[0].listaUczniow[0].listaOcen)
                {
                    comboBox3.Items.Add(ocena.opis + ": " + ocena.wartosc);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Uczen uczenDoWyswietlenia = prowadzacy.grupa[comboBox1.SelectedIndex].listaUczniow[comboBox2.SelectedIndex];
            string listaOcenString = "";
            uczenDoWyswietlenia.listaOcen.ForEach(delegate (Ocena ocena)
            {
                listaOcenString += (ocena.opis + ": " + ocena.wartosc + " (waga: " + ocena.waga + ")\n");
            });


            MessageBox.Show(uczenDoWyswietlenia.imie + " " + uczenDoWyswietlenia.nazwisko + "\nid:" + uczenDoWyswietlenia.id + "\ngrupa: " + prowadzacy.grupa[0] + "\nOceny:\n" + listaOcenString);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Uczen uczenDoOceny = prowadzacy.grupa[comboBox1.SelectedIndex].listaUczniow[comboBox2.SelectedIndex];


            double wartosc = Convert.ToDouble(Interaction.InputBox("podaj wartość"));
            double waga = Convert.ToDouble(Interaction.InputBox("podaj wagę"));
            string opis = Interaction.InputBox("podaj opis oceny");

            uczenDoOceny.listaOcen.Add(new Ocena(wartosc, waga, opis));
            MessageBox.Show("Ocena została dodana");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Ocena ocenaDoZmiany = prowadzacy.grupa[comboBox1.SelectedIndex].listaUczniow[comboBox2.SelectedIndex].listaOcen[comboBox3.SelectedIndex];
            double wartosc = Convert.ToDouble(Interaction.InputBox("podaj wartość"));
            double waga = Convert.ToDouble(Interaction.InputBox("podaj wagę"));
            string opis = Interaction.InputBox("podaj opis oceny");
            ocenaDoZmiany.wartosc = wartosc;
            ocenaDoZmiany.waga = waga;
            ocenaDoZmiany.opis = opis;
            prowadzacy.grupa[comboBox1.SelectedIndex].listaUczniow[comboBox2.SelectedIndex].listaOcen[comboBox3.SelectedIndex] = ocenaDoZmiany;
            MessageBox.Show("Ocena została zmieniona");
        }
        private void button4_Click(object sender, EventArgs e)// wyświetla najnowsze zadanie
        {
            Uczen uczenDoOceny = prowadzacy.grupa[comboBox1.SelectedIndex].listaUczniow[comboBox2.SelectedIndex];
            if (uczenDoOceny.listaZadan.Count != 0)
            {
                ZadanieDomowe zad = uczenDoOceny.listaZadan[uczenDoOceny.listaZadan.Count - 1];
                MessageBox.Show("Tytuł zadania: " + zad.tytul + "\nTreść: " + zad.tresc);
            }
            else
                MessageBox.Show("Brak zadań do wyświetlenia");
        }
    }
}
