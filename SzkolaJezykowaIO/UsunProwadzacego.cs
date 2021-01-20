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

    public partial class UsunProwadzacego : Form
    {
        public PanelLogowania panel = new PanelLogowania();
        public Admin admin;
        public UsunProwadzacego(Admin podajAdmina)
        {
            admin = podajAdmina;
            InitializeComponent();
            foreach (Prowadzacy prowadzacy in panel.listaProwadzacych)
            {
                comboBox1.Items.Add(prowadzacy.imie + " " + prowadzacy.nazwisko);
            }
            button1.Click += new EventHandler(this.Button1_Click);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0 && comboBox1.SelectedIndex <= panel.listaProwadzacych.Count)
            {
                panel.listaProwadzacych[comboBox1.SelectedIndex].grupa[0].prowadzacy = null;
                panel.listaProwadzacych.Remove(panel.listaProwadzacych[comboBox1.SelectedIndex]);
                MessageBox.Show("Usunięto prowadzącego");
            }
            else
                MessageBox.Show("Nie można usunąć prowadzącego");
        }
    }
}
