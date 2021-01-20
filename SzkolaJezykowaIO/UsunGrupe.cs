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
    public partial class UsunGrupe : Form
    {
        public PanelLogowania panel = new PanelLogowania();
        public Admin admin;
        public UsunGrupe(Admin podajAdmina)
        {
            admin = podajAdmina;
            InitializeComponent();
            foreach (Grupa grupa in panel.listaGrup)
            {
                comboBox1.Items.Add(grupa.nazwa);
            }
            button1.Click += new EventHandler(this.Button1_Click);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox1.SelectedIndex <= panel.listaGrup.Count)
            {
                panel.listaGrup[comboBox1.SelectedIndex].prowadzacy.grupa[0] = null;
                foreach (Uczen uczen in panel.listaGrup[comboBox1.SelectedIndex].listaUczniow)
                {
                    uczen.grupa.Remove(panel.listaGrup[comboBox1.SelectedIndex]);
                }
                panel.listaGrup.Remove(panel.listaGrup[comboBox1.SelectedIndex]);
                MessageBox.Show("Usunięto grupę");
            }
            else
                MessageBox.Show("Nie można usunąć grupy");
        }
    }
}
