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
    public partial class MenuPrincipal : Form
    {
        private ResisSerie resisSerie;
        private ResisParalelo resisParalelo;
        private LDO ldo;
        private PolToRec poltorec;
        private RecToPol RecToPol;
        private serieACrec SerieACrec;
        private paraleloACrec paraleloACrec;
        private LDOAC ldoAC;
        private paraleloACpol ParaleloACpol;
        private serieACpol SerieACpol;
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
                
            }
        }

        private void BtnRecToPol_Click(object sender, EventArgs e)
        {
            if (!aberto_form)
            {
                aberto_form = true;
                RecToPol = new RecToPol();
                RecToPol.Show();

            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSerieACrec_Click(object sender, EventArgs e)
        {
            if (!aberto_form)
            {
                aberto_form = true;
                SerieACrec = new serieACrec();
                SerieACrec.Show();

            }
        }

        private void BtnParaleloACrec_Click(object sender, EventArgs e)
        {
            if (!aberto_form)
            {
                aberto_form = true;
                paraleloACrec = new paraleloACrec();
                paraleloACrec.Show();

            }
        }

        private void BtLDOAC_Click(object sender, EventArgs e)
        {
            if (!aberto_form)
            {
                ldoAC = new LDOAC();
                aberto_form = true;
                ldoAC.Show();
            }
        }

        private void BtparaleloACpol_Click(object sender, EventArgs e)
        {
            if (!aberto_form)
            {
                ParaleloACpol = new paraleloACpol();
                aberto_form = true;
                ParaleloACpol.Show();
            }
        }

        private void BtSérieACpol_Click(object sender, EventArgs e)
        {
            if (!aberto_form)
            {
                SerieACpol = new serieACpol();
                aberto_form = true;
                SerieACpol.Show();
            }
        }
    }
}
