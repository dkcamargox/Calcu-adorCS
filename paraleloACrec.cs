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
    public partial class paraleloACrec : Form
    {
        public paraleloACrec()
        {
            InitializeComponent();
        }

        private void BtnCALCULArecparalelo_Click(object sender, EventArgs e)
        {
            double parter1, parter2, partei1, partei2, aaux, jbaux, aux11, aux12, aux21, aux22, aux31, aux32, aux41, aux42, at, jbt, z, teta;

            parter1 = Double.Parse(real1.Text);
            parter2 = Double.Parse(real2.Text);
            partei1 = Double.Parse(im1.Text);
            partei2 = Double.Parse(im2.Text);

            aaux = parter1 + parter2;
            jbaux = partei1 + partei2;

            aux11 = Math.Round(Math.Sqrt(Math.Pow(parter1, 2) + Math.Pow(partei1, 2)), 2);
            aux12 = Math.Round(Math.Atan(parter1 / partei1) * (180 / Math.PI), 2);

            aux21 = Math.Round(Math.Sqrt(Math.Pow(parter2, 2) + Math.Pow(partei2, 2)), 2);
            aux22 = Math.Round(Math.Atan(parter2 / partei2) * (180 / Math.PI), 2);

            aux31 = aux11 * aux21;
            aux32 = aux12 + aux22;

            aux41 = Math.Round(Math.Sqrt(Math.Pow(aaux, 2) + Math.Pow(jbaux, 2)), 2);
            aux42 = Math.Round(Math.Atan(aaux / jbaux) * (180 / Math.PI), 2);

            z = aux31 / aux41;
            teta = aux32 - aux42;

            at = Math.Round(z * Math.Cos((Math.PI / 180) * teta), 2);
            jbt = Math.Round(z * Math.Sin((Math.PI / 180) * teta), 2);

            if(jbt>0)
            {
                resultadorecparalelo.Text = Convert.ToString(at) + "+j" + Convert.ToString(jbt); 
            }
            else
            {
                resultadorecparalelo.Text = Convert.ToString(at) + "-j" + Convert.ToString(jbt*-1.0);
            }



        }

        private void BtnQUITAR1_Click(object sender, EventArgs e)
        {
            Close();
            MenuPrincipal.fecho();
        }
    }
}
