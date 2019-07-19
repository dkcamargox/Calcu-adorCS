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
    public partial class serieACrec : Form
    {
        public serieACrec()
        {
            InitializeComponent();
        }

        private void SerieACrec_Load(object sender, EventArgs e)
        {

        }

        private void BtnCALCULArecserie_Click(object sender, EventArgs e)
        {
            double entrada1, entrada2,entrada3,entrada4, resultado1, resultado2;

            entrada1 = Double.Parse(real1.Text);
            entrada2 = Double.Parse(im1.Text);
            entrada3 = Double.Parse(real2.Text);
            entrada4 = Double.Parse(im2.Text);

            resultado1 = entrada1 + entrada3;
            resultado2 = entrada2 + entrada4;

            if (resultado2 >= 0)
            {
                resultadorecserie.Text = Convert.ToString(resultado1) + "+j" + Convert.ToString(resultado2);
            }
            else
            {
                resultadorecserie.Text = Convert.ToString(resultado1) + "-j" + Convert.ToString(resultado2*-1.0);
            }

            



        }

        private void BtnQUITAR_Click(object sender, EventArgs e)
        {
            Close();
            MenuPrincipal.fecho();
        }
    }
}
