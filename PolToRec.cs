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
    public partial class PolToRec : Form
    {
        public PolToRec()
        {
            InitializeComponent();
            MenuPrincipal.abriu();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            double entrada1, entrada2, resultado1, resultado2;

            entrada1 = Double.Parse(partereal.Text);
            entrada2 = Double.Parse(parteangular.Text);



            resultado1 = Math.Round(Math.Cos(entrada2 * 2.0 * Math.PI / 360.0)*entrada1, 2);
            resultado2 = Math.Round(Math.Sin(entrada2 * 2.0 * Math.PI / 360.0)*entrada1, 2);
            

            resultadoreal.Text = resultado1.ToString();

            if(resultado2>0)
            {
                resultadoimaginario.Text = "+j" + Convert.ToString(resultado2);
            }

            else if(resultado2<0)
            {
                resultadoimaginario.Text = "-j" + Convert.ToString(resultado2*-1.0);
            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Resultadoimaginario_Click(object sender, EventArgs e)
        {

        }

        private void Resultadoreal_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Parteangular_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Close();
            MenuPrincipal.fecho();
        }
    }
}
