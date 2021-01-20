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
        }

        

        
    }
}
