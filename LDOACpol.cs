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
    public partial class LDOACpol : Form
    {
        public LDOACpol()
        {
            InitializeComponent();
            
        }

        private void LDOACpol_Load(object sender, EventArgs e)
        {

        }

        private void BtSair_Click_1(object sender, EventArgs e)
        {
            MenuPrincipal.fecho();
            LDOAC.fecho();
            Close();
        }
    }
}
