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

    public partial class LDOAC : Form
    {
        private LDOACrec ldoACpol;
        private LDOACpol ldoACrec;
        private static bool aberto_form = false;
        public static void abriu()
        {
            aberto_form = true;
        }
        public static void fecho()
        {
            aberto_form = false;
        }

        public LDOAC()
        {
            InitializeComponent();
        }

        private void BtPol_Click(object sender, EventArgs e)
        {
            if(!aberto_form)
            {
                aberto_form = true;
                ldoACpol = new LDOACrec();
                ldoACpol.Show();
                Close();
            }
            
        }

        private void BtRec_Click(object sender, EventArgs e)
        {
            if (!aberto_form)
            {
                aberto_form = true;
                ldoACrec = new LDOACpol();
                ldoACrec.Show();
                Close();
            }
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            MenuPrincipal.fecho();
            Close();
        }

        private void LDOAC_Load(object sender, EventArgs e)
        {

        }
    }
}
