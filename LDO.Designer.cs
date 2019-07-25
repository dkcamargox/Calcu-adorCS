namespace Calculador
{
    partial class LDO
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LDO));
            this.btSair = new System.Windows.Forms.Button();
            this.CalcTensão = new System.Windows.Forms.RadioButton();
            this.CalcCorrente = new System.Windows.Forms.RadioButton();
            this.CalcResis = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btCalcula = new System.Windows.Forms.Button();
            this.entrada_1 = new System.Windows.Forms.TextBox();
            this.entrada_2 = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btLimpa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(671, 434);
            this.btSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(148, 55);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // CalcTensão
            // 
            this.CalcTensão.Location = new System.Drawing.Point(18, 176);
            this.CalcTensão.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalcTensão.Name = "CalcTensão";
            this.CalcTensão.Size = new System.Drawing.Size(297, 46);
            this.CalcTensão.TabIndex = 6;
            this.CalcTensão.TabStop = true;
            this.CalcTensão.Text = "Calcular a Tensão ( V = R . I )";
            this.CalcTensão.UseVisualStyleBackColor = true;
            this.CalcTensão.CheckedChanged += new System.EventHandler(this.CalcTensão_CheckedChanged);
            // 
            // CalcCorrente
            // 
            this.CalcCorrente.Location = new System.Drawing.Point(18, 317);
            this.CalcCorrente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalcCorrente.Name = "CalcCorrente";
            this.CalcCorrente.Size = new System.Drawing.Size(297, 42);
            this.CalcCorrente.TabIndex = 7;
            this.CalcCorrente.TabStop = true;
            this.CalcCorrente.Text = "Calcular a Corrente ( I = V / R )";
            this.CalcCorrente.UseVisualStyleBackColor = true;
            this.CalcCorrente.CheckedChanged += new System.EventHandler(this.CalcCorrente_CheckedChanged);
            // 
            // CalcResis
            // 
            this.CalcResis.Location = new System.Drawing.Point(18, 245);
            this.CalcResis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CalcResis.Name = "CalcResis";
            this.CalcResis.Size = new System.Drawing.Size(297, 47);
            this.CalcResis.TabIndex = 8;
            this.CalcResis.TabStop = true;
            this.CalcResis.Text = "Calculador a Resistencia ( R = V / I )";
            this.CalcResis.UseVisualStyleBackColor = true;
            this.CalcResis.CheckedChanged += new System.EventHandler(this.CalcResis_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(104, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(632, 112);
            this.label1.TabIndex = 10;
            this.label1.Text = "CALCULADOR DA LEI DE OHM PARA SINAIS CONTINUOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btCalcula
            // 
            this.btCalcula.Location = new System.Drawing.Point(359, 434);
            this.btCalcula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCalcula.Name = "btCalcula";
            this.btCalcula.Size = new System.Drawing.Size(148, 55);
            this.btCalcula.TabIndex = 11;
            this.btCalcula.Text = "Calcula";
            this.btCalcula.UseVisualStyleBackColor = true;
            this.btCalcula.Click += new System.EventHandler(this.Button1_Click);
            // 
            // entrada_1
            // 
            this.entrada_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entrada_1.Location = new System.Drawing.Point(410, 226);
            this.entrada_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.entrada_1.Name = "entrada_1";
            this.entrada_1.Size = new System.Drawing.Size(365, 26);
            this.entrada_1.TabIndex = 12;
            this.entrada_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entrada_1.TextChanged += new System.EventHandler(this.Entrada_2_TextChanged);
            // 
            // entrada_2
            // 
            this.entrada_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entrada_2.Location = new System.Drawing.Point(410, 276);
            this.entrada_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.entrada_2.Name = "entrada_2";
            this.entrada_2.Size = new System.Drawing.Size(365, 26);
            this.entrada_2.TabIndex = 13;
            this.entrada_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entrada_2.TextChanged += new System.EventHandler(this.Entrada_2_TextChanged_1);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(410, 374);
            this.lbl_resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(365, 34);
            this.lbl_resultado.TabIndex = 14;
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLimpa
            // 
            this.btLimpa.Location = new System.Drawing.Point(515, 434);
            this.btLimpa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(148, 55);
            this.btLimpa.TabIndex = 15;
            this.btLimpa.Text = "Limpa";
            this.btLimpa.UseVisualStyleBackColor = true;
            this.btLimpa.Click += new System.EventHandler(this.BtLimpa_Click_1);
            // 
            // LDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculador.Properties.Resources.peter_pó;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 511);
            this.ControlBox = false;
            this.Controls.Add(this.btLimpa);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.entrada_2);
            this.Controls.Add(this.entrada_1);
            this.Controls.Add(this.btCalcula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcResis);
            this.Controls.Add(this.CalcCorrente);
            this.Controls.Add(this.CalcTensão);
            this.Controls.Add(this.btSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LDO";
            this.Text = "Calculador da Lei de Ohm para DC";
            this.Load += new System.EventHandler(this.LDO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.RadioButton CalcTensão;
        private System.Windows.Forms.RadioButton CalcCorrente;
        private System.Windows.Forms.RadioButton CalcResis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCalcula;
        private System.Windows.Forms.TextBox entrada_1;
        private System.Windows.Forms.TextBox entrada_2;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btLimpa;
    }
}