using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculador
{
    public partial class LDOACrec : Form
    {
        public LDOACrec()
        {
            InitializeComponent();
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
           
            MenuPrincipal.fecho();
            LDOAC.fecho();
            Close();
            
        }
    }
}
