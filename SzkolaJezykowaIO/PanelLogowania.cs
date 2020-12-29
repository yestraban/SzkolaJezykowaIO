using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SzkolaJezykowaIO
{
    public partial class PanelLogowania : UserControl

    {
        public List<Uczen> listaUczniow= new List<Uczen>();
        public PanelLogowania()
        {
            InitializeComponent();

        }

        private void PanelLogowania_Load(object sender, EventArgs e)
        {

        }
    }
}
