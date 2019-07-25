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
    public partial class RecToPol : Form
    {
        //marca
        public RecToPol()
        {
            InitializeComponent();
        }

        private void BtnRecToPol_Click(object sender, EventArgs e)
        {
            double entrada11, entrada12, resultado11 , resultado12;

            entrada11 = Double.Parse(parteREAL1.Text);
            entrada12 = Double.Parse(parteIMAGINARIA1.Text);

            resultado11 = Math.Round(Math.Sqrt(Math.Pow(entrada11, 2) + Math.Pow(entrada12, 2)), 2);
            
            resultado12 = Math.Atan(entrada11 / entrada12) * (180 / Math.PI);
            resultado1RecToPol.Text = Convert.ToString(resultado11);

            resultado2RecToPol.Text = "L" + Convert.ToString(resultado12) + "°";


        }

        private void RecToPol_Load(object sender, EventArgs e)
        {

        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            Close();
            MenuPrincipal.fecho();
        }

        private void ParteIMAGINARIA1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Resultado2RecToPol_Click(object sender, EventArgs e)
        {

        }
    }
}
