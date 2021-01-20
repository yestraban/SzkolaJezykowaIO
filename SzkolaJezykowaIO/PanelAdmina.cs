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
    public partial class PanelAdmina : Form
    {
        public PanelLogowania panel = new PanelLogowania();
        public Admin admin;
        public PanelAdmina(Admin podajAdmina)
        {
            InitializeComponent();
            admin = podajAdmina;
            button1.Click += new EventHandler(this.Button1_Click);
            button2.Click += new EventHandler(this.Button2_Click);
            button3.Click += new EventHandler(this.Button3_Click);
            button4.Click += new EventHandler(this.Button4_Click);
            button5.Click += new EventHandler(this.Button5_Click);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DodajUczniaDoGrupyForm dodajUcznia = new DodajUczniaDoGrupyForm(admin);
            dodajUcznia.Show();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            EdytujGrupeForm edytujGrupe = new EdytujGrupeForm(admin);
            edytujGrupe.Show();
        }
        private void Button3_Click(object sender, EventArgs e)
        {

        }
        private void Button4_Click(object sender, EventArgs e)
        {

        }
        private void Button5_Click(object sender, EventArgs e)
        {

        }



    }
}
