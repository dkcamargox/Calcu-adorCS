﻿using System;
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
    public partial class ResisSerie : Form
    { 
        
        public ResisSerie()
        {
            InitializeComponent();
            MenuPrincipal.abriu();
            lbl_resultado.Text = "0Ω";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal.fecho();
            Close();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void ResisSerie_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            float resistor1 = 0.0f;
            float resistor2 = 0.0f;
            float associacao;
            resistor1 = float.Parse(entrada_1.Text.Split('Ω')[0]);
            resistor2 = float.Parse(entrada_2.Text.Split('Ω')[0]);
            associacao = resistor2 + resistor1;
            lbl_resultado.Text = associacao.ToString() + "Ω";
        }

        private void Entrada_2_TextChanged(object sender, EventArgs e)
        {
            entrada_2.Text = entrada_2.Text.Split('Ω')[0] + 'Ω';
        }

        private void Entrada_1_TextChanged(object sender, EventArgs e)
        {
            entrada_1.Text = entrada_1.Text.Split('Ω')[0] + 'Ω';
        }

        private void Lbl_resultado_Click(object sender, EventArgs e)
        {

        }

        private void BtLimpa_Click(object sender, EventArgs e)
        {
            entrada_1.Text = "0Ω";
            entrada_2.Text = "0Ω";
            lbl_resultado.Text = "0Ω";
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
