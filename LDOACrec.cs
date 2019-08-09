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
    public partial class LDOACrec : Form
    {
        private const int tam = 2;

        public LDOACrec()
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

               /* v[0] = (r[0] * i[0]) - (r[1] * i[1]);
                v[1] = (r[1] * i[0]) + (i[1] * r[0]);*/


                vR = (rR * iR) - (rC * iC);
                vC = (rC * iR) + (iC * rR);

                saida_C.Text = vC.ToString();
                saida_R.Text = vR.ToString();

            }
            /*if (CalcResis.Checked)
            {
                valor1 = float.Parse(entrada_1.Text.Split('V')[0]);
                valor2 = float.Parse(entrada_2.Text.Split('A')[0]);

                resposta = valor1 / valor2;

                lbl_resultado.Text = resposta.ToString() + " Ω";
            }
            if (CalcCorrente.Checked)
            {
                valor1 = float.Parse(entrada_1.Text.Split('V')[0]);
                valor2 = float.Parse(entrada_2.Text.Split('Ω')[0]);

                resposta = valor1 / valor2;

                lbl_resultado.Text = resposta.ToString() + " A";
            }*/
        }

        private void Entrada1_R_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
