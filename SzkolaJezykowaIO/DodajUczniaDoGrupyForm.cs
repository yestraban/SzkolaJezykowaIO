using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzkolaJezykowaIO
{
    public partial class DodajUczniaDoGrupyForm : Form
    {
        //dodawanie ucznia z listy oczekujących do istniejącej grupy
        public PanelLogowania panel = new PanelLogowania();
        public Admin admin;
        public DodajUczniaDoGrupyForm(Admin podajAdmina)
        {
            InitializeComponent();
            admin = podajAdmina;
            button1.Click += new EventHandler(this.Button1_Click);
            
            //wybieranie Oczekujacego oraz Grupy, do której chcemy go przydzielić

            //wypełnianie comboBox1 imionami z listy oczekujących
            if (admin.listaOczekujacych.Count > 0) //sprawdzenie, czy lista oczekujących nie jest pusta
            {
                foreach (Oczekujacy oczek in admin.listaOczekujacych)
                {
                    comboBox1.Items.Add(oczek.uczen.imie + " " + oczek.uczen.nazwisko + " " + oczek.jezyk + " " + oczek.poziomZaawansowania);
                }
            }

            //wypełnianie comboBox2 nazwami grup
            foreach (Grupa grupa in panel.listaGrup)
            {
                comboBox2.Items.Add(grupa.nazwa);
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //po naciśnięciu przycisku, wybrana osoba z listy oczekujących zostaje dodana do wybranej grupy 
            //oraz usunięta z listy oczekujących
            if (comboBox1.SelectedIndex >= 0)
            {
                panel.listaGrup[comboBox2.SelectedIndex].listaUczniow.Add(admin.listaOczekujacych[comboBox1.SelectedIndex].uczen);
                panel.listaUczniow.Add(admin.listaOczekujacych[comboBox1.SelectedIndex].uczen);
                admin.listaOczekujacych.Remove(admin.listaOczekujacych[comboBox1.SelectedIndex]);
                MessageBox.Show("Dodano ucznia do grupy");
            }
            else
                MessageBox.Show("Nie udało się dodać do grupy");
        }
    }
}
