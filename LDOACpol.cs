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
        private const int tam = 2;

        public LDOACpol()
        {
            InitializeComponent();
        }

        

        private void BtSair_Click(object sender, EventArgs e)
        {
            MenuPrincipal.fecho();
            LDOAC.fecho();
            Close();
        }

        private void CalcTensão_CheckedChanged(object sender, EventArgs e)
        {
            if (CalcTensão.Checked == true)
            {
                entrada1_R.Text = "0";
                entrada1_C.Text = "0";
                entrada1_SI.Text = "A";
                entrada2_R.Text = "0";
                entrada2_C.Text = "0";
                entrada2_SI.Text = "Ω";
                saida_R.Text = "0";
                saida_C.Text = "j0V";

            }
        }

        private void CalcCorrente_CheckedChanged(object sender, EventArgs e)
        {
            if (CalcCorrente.Checked == true)
            {
                entrada1_R.Text = "0";
                entrada1_C.Text = "0";
                entrada1_SI.Text = "V";
                entrada2_R.Text = "0";
                entrada2_C.Text = "0";
                entrada2_SI.Text = "Ω";
                saida_R.Text = "0";
                saida_C.Text = "j0A";

            }
        }

        private void CalcResis_CheckedChanged(object sender, EventArgs e)
        {
            if (CalcResis.Checked == true)
            {
                entrada1_R.Text = "0";
                entrada1_C.Text = "0";
                entrada1_SI.Text = "V";
                entrada2_R.Text = "0";
                entrada2_C.Text = "0";
                entrada2_SI.Text = "A";
                saida_R.Text = "0";
                saida_C.Text = "j0Ω";

            }
        }

        private void BtLimpa_Click(object sender, EventArgs e)
        {
            CalcCorrente.Checked = false;
            CalcResis.Checked = false;
            CalcTensão.Checked = false;
            entrada1_R.Text = "";
            entrada1_C.Text = "";
            entrada1_SI.Text = "";
            entrada2_R.Text = "";
            entrada2_C.Text = "";
            entrada2_SI.Text = "";
            saida_R.Text = "";
            saida_C.Text = "";
        }

        private void BtCalcula_Click(object sender, EventArgs e)
        {
            float vR, vC;
            float rR, rC;
            float iR, iC;

            if (CalcTensão.Checked)
            {

                rR = float.Parse(entrada1_R.Text);
                rC = float.Parse(entrada1_C.Text);

                iR = float.Parse(entrada2_R.Text);
                iC = float.Parse(entrada2_C.Text);

                vR = rR * iR;
                vC = rC + iC;

                saida_C.Text = "L" + vC.ToString() + "V";
                saida_R.Text = vR.ToString();

            }
            if (CalcCorrente.Checked)
            {
                //entrada 1 = V
                //entrada 2 = OHM
                vR = float.Parse(entrada1_R.Text); 
                vC = float.Parse(entrada1_C.Text); 

                rR = float.Parse(entrada2_R.Text); 
                rC = float.Parse(entrada2_C.Text); 

                iR = vR / rR;
                iC = vC - rC;

                saida_C.Text = "L" + iC.ToString() + "A";
                saida_R.Text = iR.ToString();
            }
            if (CalcResis.Checked)
            {
                //entrada 1 = V
                //entrada 2 = A
                vR = float.Parse(entrada1_R.Text); 
                vC = float.Parse(entrada1_C.Text); 

                iR = float.Parse(entrada2_R.Text); 
                iC = float.Parse(entrada2_C.Text); 



                rR = vR / iR;
                rC = vC - iC;

                saida_C.Text = "L" + rC.ToString() + "Ω";
                saida_R.Text = rR.ToString();
            }

        }

        private void Entrada1_R_TextChanged(object sender, EventArgs e)
        {

        }

        private void A_Load(object sender, EventArgs e)
        {

        }

        private void Mais3_Click(object sender, EventArgs e)
        {

        }

        private void Mais2_Click(object sender, EventArgs e)
        {

        }

        private void Mais1_Click(object sender, EventArgs e)
        {

        }

        private void Entrada1_SI_Click(object sender, EventArgs e)
        {

        }

        private void Entrada2_SI_Click(object sender, EventArgs e)
        {

        }
    }
}
