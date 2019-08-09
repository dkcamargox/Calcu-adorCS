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
    public partial class LDO : Form
    {
        

        public LDO()
        {
            InitializeComponent();
            MenuPrincipal.abriu();
        }
        private void LDO_Load(object sender, EventArgs e)
        {

        }
        private void BtSair_Click(object sender, EventArgs e)
        {
            Close();
            MenuPrincipal.fecho();
        }
        
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CalcResis_CheckedChanged(object sender, EventArgs e)
        {
            if(CalcResis.Checked == true)
            {
                entrada_1.Text = "0V";
                entrada_2.Text = "0A";
                lbl_resultado.Text = "0Ω"; 
            }
        }

        private void CalcCorrente_CheckedChanged(object sender, EventArgs e)
        {
            if(CalcCorrente.Checked == true)
            {
                entrada_1.Text = "0V";
                entrada_2.Text = "0Ω";
                lbl_resultado.Text = "0A";
            }
        }

        private void CalcTensão_CheckedChanged(object sender, EventArgs e)
        {
            if(CalcTensão.Checked == true)
            {
                entrada_1.Text = "0A";
                entrada_2.Text = "0Ω";
                lbl_resultado.Text = "0V";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //definir tudo aqui
            float valor1;
            float valor2;
            float resposta = 0.0f;
            if (CalcTensão.Checked)
            {
               
                valor1 = float.Parse(entrada_1.Text.Split('A')[0]);
                valor2 = float.Parse(entrada_2.Text.Split('Ω')[0]);
                
                resposta = valor1 * valor2;

                lbl_resultado.Text = resposta.ToString() + " V";
            }
            if (CalcResis.Checked)
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
            }
        }

        private void Entrada_2_TextChanged(object sender, EventArgs e)
        {
            if ( CalcTensão.Checked )
            {
                entrada_1.Text = entrada_1.Text.Split('A')[0] + 'A';
                entrada_2.Text = entrada_2.Text.Split('Ω')[0] + 'Ω';
            }
            if ( CalcResis.Checked )
            {
                entrada_1.Text = entrada_1.Text.Split('V')[0] + 'V';
                entrada_2.Text = entrada_2.Text.Split('A')[0] + 'A';
            }
            if ( CalcCorrente.Checked )
            {
                entrada_1.Text = entrada_1.Text.Split('V')[0] + 'V';
                entrada_2.Text = entrada_2.Text.Split('Ω')[0] + 'Ω';
            }

        }

        private void BtLimpa_Click_1(object sender, EventArgs e)
        {
            CalcCorrente.Checked = false;
            CalcResis.Checked = false;
            CalcTensão.Checked = false;
            entrada_1.Text = "";
            entrada_2.Text = "";
            lbl_resultado.Text = "";
           
        }

        private void Entrada_2_TextChanged_1(object sender, EventArgs e)
        {
            if (CalcTensão.Checked)
            {
                entrada_1.Text = entrada_1.Text.Split('A')[0] + 'A';
                entrada_2.Text = entrada_2.Text.Split('Ω')[0] + 'Ω';
            }
            else if (CalcResis.Checked)
            {
                entrada_1.Text = entrada_1.Text.Split('V')[0] + 'V';
                entrada_2.Text = entrada_2.Text.Split('A')[0] + 'A';
            }
            else if (CalcCorrente.Checked)
            {
                entrada_1.Text = entrada_1.Text.Split('V')[0] + 'V';
                entrada_2.Text = entrada_2.Text.Split('Ω')[0] + 'Ω';
            }
            else
            {
                entrada_1.Text = "";
                entrada_2.Text = "";
            }
        }
    }
}
