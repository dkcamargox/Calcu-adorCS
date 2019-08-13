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
    public partial class paraleloACpol : Form
    {
        public paraleloACpol()
        {
            InitializeComponent();
            MenuPrincipal.abriu();
        }

        private void BtnCALCULApolparalelo_Click(object sender, EventArgs e)
        {
            double r11, r12, r21, r22, rt1, rt2, a1, a2, jb1, jb2, at, jbt, raux11, raux12, raux21, raux22;

            r11 = Double.Parse(real1.Text);
            r12 = Double.Parse(ang1.Text);

            r21 = Double.Parse(real2.Text);
            r22 = Double.Parse(ang2.Text);

            a1 = Math.Round(r11 * Math.Cos((Math.PI / 180) * r12), 2);
            jb1 = Math.Round(r11 * Math.Sin((Math.PI / 180) * r12), 2);

            a2 = Math.Round(r21 * Math.Cos((Math.PI / 180) * r22), 2);
            jb2 = Math.Round(r21 * Math.Sin((Math.PI / 180) * r22), 2);

            raux11 = Math.Round((r11 * r21), 2);
            raux12 = Math.Round((r12 + r22), 2);


            at = a1 + a2;
            jbt = jb1 + jb2;

            raux21 = Math.Round(Math.Sqrt(Math.Pow(at, 2) + Math.Pow(jbt, 2)), 2);
            raux22 = Math.Round(Math.Atan(at / jbt) * (180 / Math.PI), 2);

            rt1 = Math.Round((raux11 / raux21), 2);
            rt2 = Math.Round((raux12 - raux22), 2);

            resultadopolparalelo.Text = Convert.ToString(rt1) + " L " + Convert.ToString(rt2) + "°";



        }

        private void BtnQUITAR1_Click(object sender, EventArgs e)
        {
            MenuPrincipal.fecho();
            Close();
        }
    }
}
