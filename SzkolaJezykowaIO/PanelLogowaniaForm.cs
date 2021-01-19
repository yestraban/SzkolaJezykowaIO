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
    public partial class PanelLogowaniaForm : Form
    {
        public PanelLogowaniaForm()
        {
            InitializeComponent();
           // MessageBox.Show("Witaj w Szkole Językowej eMKa");
           // MessageBox.Show("Zaloguj się na swoje konto");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] rodzajKonta =
            {
                "Uczeń",
                "Prowadzący",
                "Admin"
            };
            comboBox1.Items.AddRange(rodzajKonta);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
       // comboBox1.SelectedIndex.ToString()


    }
}
