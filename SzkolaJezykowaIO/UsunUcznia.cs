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
    public partial class UsunUcznia : Form
    {
        public PanelLogowania panel = new PanelLogowania();
        public Admin admin;
        public UsunUcznia(Admin podajAdmina)
        {
            //specjalnie okno dostepne tylko dla admina pozwalajace usunac ucznia z systemu
            admin = podajAdmina;
            InitializeComponent();
            foreach (Uczen uczen in panel.listaUczniow)
            {
                comboBox1.Items.Add(uczen.imie+" "+uczen.nazwisko);
            }
            button1.Click += new EventHandler(this.Button1_Click);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0&& comboBox1.SelectedIndex<= panel.listaUczniow.Count)
            {
                foreach(Grupa grupa in panel.listaUczniow[comboBox1.SelectedIndex].grupa)
                {
                    grupa.listaUczniow.Remove(panel.listaUczniow[comboBox1.SelectedIndex]);
                }
                panel.listaUczniow.Remove(panel.listaUczniow[comboBox1.SelectedIndex]);
                MessageBox.Show("Usunięto ucznia");
            }
            else
                MessageBox.Show("Nie można usunąć ucznia");
        }
    }
}
