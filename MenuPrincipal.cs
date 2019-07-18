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
    //teste EAE MEU
    public partial class MenuPrincipal : Form
    {
        
        private ResisSerie resisSerie;
        private ResisParalelo resisParalelo;
        private LDO ldo;
        private PolToRec poltorec;
        private static bool aberto_form = false;
        public static void abriu()
        {
            aberto_form = true;
        }
        public static void fecho()
        {
            aberto_form = false;
        }
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e) { }
        
        private void BtRserie_Click(object sender, EventArgs e)
        {
            if ( !aberto_form )
            {
            resisSerie = new ResisSerie();
            aberto_form = true;
            resisSerie.Show();
            }
            
            
        }

        private void BtRparalelo_Click(object sender, EventArgs e)
        {
            if ( !aberto_form )
            {
                aberto_form = true;
                resisParalelo = new ResisParalelo();
                resisParalelo.Show();
            }
        }

        private void BtDC_Click(object sender, EventArgs e)
        {
            if ( !aberto_form )
            {
                aberto_form = true;
                ldo = new LDO();
                ldo.Show();
            }
        }
        private void BtSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtPolRec_Click(object sender, EventArgs e)
        {
            if (!aberto_form )
            {
                aberto_form = true;
                poltorec = new PolToRec();
                poltorec.Show();
                //hello
            }
        }
    }
}
