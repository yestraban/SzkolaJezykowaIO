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

    public partial class EdytujGrupeForm : Form
    {
        public PanelLogowania panel = new PanelLogowania();
        public Admin admin;
        public EdytujGrupeForm(Admin podajAdmina)
        {
            admin = podajAdmina;
            InitializeComponent();
            foreach (Grupa grupa in panel.listaGrup)
            {
                comboBox1.Items.Add(grupa.nazwa);
            }
            foreach (Prowadzacy prowadzacy in panel.listaProwadzacych)
            {
                comboBox1.Items.Add(prowadzacy.imie + " " + prowadzacy.nazwisko);
            }
            button1.Click += new EventHandler(this.Button1_Click);
            button2.Click += new EventHandler(this.Button2_Click);
            button3.Click += new EventHandler(this.Button3_Click);
            button4.Click += new EventHandler(this.Button4_Click);

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                string nazwa = Interaction.InputBox("Podaj nową nazwę");
                panel.listaGrup[comboBox1.SelectedIndex].nazwa = nazwa;
                MessageBox.Show("Nazwa grupy została zmieniona");
            }
            else
                MessageBox.Show("Nie można dokonać zmian");
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                string poziom = Interaction.InputBox("Podaj nowy poziom");
                panel.listaGrup[comboBox1.SelectedIndex].poziomZaawansowania = poziom;
                MessageBox.Show("Poziom grupy został zmieniony");
            }
            else
                MessageBox.Show("Nie można dokonać zmian");
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                string jezyk = Interaction.InputBox("Podaj nowy język");
                panel.listaGrup[comboBox1.SelectedIndex].jezyk = jezyk;
                MessageBox.Show("Język grupy został zmieniony");
            }
            else
                MessageBox.Show("Nie można dokonać zmian");
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox2.SelectedIndex >= 0)
            {
                panel.listaGrup[comboBox1.SelectedIndex].prowadzacy = panel.listaProwadzacych[comboBox2.SelectedIndex];
                MessageBox.Show("Prowadzący grupy został zmieniony");
            }
            else
                MessageBox.Show("Nie można dokonać zmian");
        }
    }
}
