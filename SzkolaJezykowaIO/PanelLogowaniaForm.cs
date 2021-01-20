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
    public partial class PanelLogowaniaForm : Form
    {
        public PanelLogowania panel = new PanelLogowania();

        public PanelLogowaniaForm()
        {
            InitializeComponent();

            // MessageBox.Show("Witaj w Szkole Językowej eMKa");
            // MessageBox.Show("Zaloguj się na swoje konto");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] rodzajKonta =          //wypełnienie tablicy stringów opcjami do wybrania
            {
                "Uczeń",
                "Prowadzący",
                "Admin"
            };
            comboBox1.Items.AddRange(rodzajKonta);                  //dodanie opcji do comboboxa


        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex;            //zebranie indeksu wybranej opcji z comboboxa

            if (a == 0)
            {
                Uczen uczen = panel.ZalogujUcznia(textBox1.Text, textBox2.Text);
                if (uczen == null)
                    MessageBox.Show("Podano nieprawidlowe dane");
                else
                {
                    MessageBox.Show("zalogowano");
                    PanelUcznia panelUcznia = new PanelUcznia(uczen);
                    panelUcznia.Show();
                    this.Hide();
                }

            }

            else if (a == 1)
            {
                Prowadzacy prowadzacy = panel.ZalogujProwadzacego(textBox1.Text, textBox2.Text);
                if (prowadzacy == null)
                    MessageBox.Show("Podano nieprawidlowe dane");
                else
                {
                    MessageBox.Show("zalogowano");
                    PanelProwadzacego panelProwadzacego = new PanelProwadzacego(prowadzacy);
                    panelProwadzacego.Show();
                    this.Hide();
                }

            }

            else if (a == 2)
            {
                panel.czyZalogowanyAdmin = panel.ZalogujAdmina(textBox1.Text, textBox2.Text);
                if (panel.czyZalogowanyAdmin == false)
                    MessageBox.Show("Podano nieprawidlowe dane");
                else
                {
                    MessageBox.Show("zalogowano");
                    PanelAdmina panelAdmina = new PanelAdmina(panel.admin);
                    panelAdmina.Show();
                    this.Hide();
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Harmonogram harmonogram = new Harmonogram();
            harmonogram.Show();
        }
        // comboBox1.SelectedIndex.ToString()


    }
}
