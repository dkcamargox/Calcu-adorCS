namespace Calculador
{
    partial class LDOACpol
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
            this.CalcResis = new System.Windows.Forms.RadioButton();
            this.CalcCorrente = new System.Windows.Forms.RadioButton();
            this.CalcTensão = new System.Windows.Forms.RadioButton();
            this.titulo = new System.Windows.Forms.Label();
            this.saida_C = new System.Windows.Forms.Label();
            this.saida_R = new System.Windows.Forms.Label();
            this.btLimpa = new System.Windows.Forms.Button();
            this.btCalcula = new System.Windows.Forms.Button();
            this.entrada2_C = new System.Windows.Forms.TextBox();
            this.entrada1_C = new System.Windows.Forms.TextBox();
            this.entrada2_R = new System.Windows.Forms.TextBox();
            this.entrada1_R = new System.Windows.Forms.TextBox();
            this.btSair = new System.Windows.Forms.Button();
            this.mais1 = new System.Windows.Forms.Label();
            this.mais2 = new System.Windows.Forms.Label();
            this.mais3 = new System.Windows.Forms.Label();
            this.entrada2_SI = new System.Windows.Forms.Label();
            this.entrada1_SI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalcResis
            // 
            this.CalcResis.AutoSize = true;
            this.CalcResis.Location = new System.Drawing.Point(36, 100);
            this.CalcResis.Name = "CalcResis";
            this.CalcResis.Size = new System.Drawing.Size(198, 17);
            this.CalcResis.TabIndex = 40;
            this.CalcResis.TabStop = true;
            this.CalcResis.Text = "Calculador a Resistencia ( R = V / I )";
            this.CalcResis.UseVisualStyleBackColor = true;
            this.CalcResis.CheckedChanged += new System.EventHandler(this.CalcResis_CheckedChanged);
            // 
            // CalcCorrente
            // 
            this.CalcCorrente.Location = new System.Drawing.Point(36, 66);
            this.CalcCorrente.Name = "CalcCorrente";
            this.CalcCorrente.Size = new System.Drawing.Size(198, 17);
            this.CalcCorrente.TabIndex = 39;
            this.CalcCorrente.TabStop = true;
            this.CalcCorrente.Text = "Calcular a Corrente ( I = V / R )";
            this.CalcCorrente.UseVisualStyleBackColor = true;
            this.CalcCorrente.CheckedChanged += new System.EventHandler(this.CalcCorrente_CheckedChanged);
            // 
            // CalcTensão
            // 
            this.CalcTensão.Location = new System.Drawing.Point(36, 30);
            this.CalcTensão.Name = "CalcTensão";
            this.CalcTensão.Size = new System.Drawing.Size(198, 17);
            this.CalcTensão.TabIndex = 38;
            this.CalcTensão.TabStop = true;
            this.CalcTensão.Text = "Calcular a Tensão ( V = R . I )";
            this.CalcTensão.UseVisualStyleBackColor = true;
            this.CalcTensão.CheckedChanged += new System.EventHandler(this.CalcTensão_CheckedChanged);
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(395, 63);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(100, 23);
            this.titulo.TabIndex = 37;
            this.titulo.Text = "TITULO";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saida_C
            // 
            this.saida_C.Location = new System.Drawing.Point(284, 285);
            this.saida_C.Name = "saida_C";
            this.saida_C.Size = new System.Drawing.Size(130, 18);
            this.saida_C.TabIndex = 36;
            // 
            // saida_R
            // 
            this.saida_R.Location = new System.Drawing.Point(81, 285);
            this.saida_R.Name = "saida_R";
            this.saida_R.Size = new System.Drawing.Size(153, 18);
            this.saida_R.TabIndex = 35;
            // 
            // btLimpa
            // 
            this.btLimpa.Location = new System.Drawing.Point(455, 197);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(75, 23);
            this.btLimpa.TabIndex = 34;
            this.btLimpa.Text = "Limpa";
            this.btLimpa.UseVisualStyleBackColor = true;
            this.btLimpa.Click += new System.EventHandler(this.BtLimpa_Click);
            // 
            // btCalcula
            // 
            this.btCalcula.Location = new System.Drawing.Point(455, 138);
            this.btCalcula.Name = "btCalcula";
            this.btCalcula.Size = new System.Drawing.Size(75, 23);
            this.btCalcula.TabIndex = 33;
            this.btCalcula.Text = "Calcula";
            this.btCalcula.UseVisualStyleBackColor = true;
            this.btCalcula.Click += new System.EventHandler(this.BtCalcula_Click);
            // 
            // entrada2_C
            // 
            this.entrada2_C.Location = new System.Drawing.Point(287, 200);
            this.entrada2_C.Name = "entrada2_C";
            this.entrada2_C.Size = new System.Drawing.Size(100, 20);
            this.entrada2_C.TabIndex = 32;
            // 
            // entrada1_C
            // 
            this.entrada1_C.Location = new System.Drawing.Point(287, 138);
            this.entrada1_C.Name = "entrada1_C";
            this.entrada1_C.Size = new System.Drawing.Size(100, 20);
            this.entrada1_C.TabIndex = 31;
            // 
            // entrada2_R
            // 
            this.entrada2_R.Location = new System.Drawing.Point(81, 197);
            this.entrada2_R.Name = "entrada2_R";
            this.entrada2_R.Size = new System.Drawing.Size(153, 20);
            this.entrada2_R.TabIndex = 30;
            // 
            // entrada1_R
            // 
            this.entrada1_R.Location = new System.Drawing.Point(81, 138);
            this.entrada1_R.Name = "entrada1_R";
            this.entrada1_R.Size = new System.Drawing.Size(153, 20);
            this.entrada1_R.TabIndex = 29;
            this.entrada1_R.TextChanged += new System.EventHandler(this.Entrada1_R_TextChanged);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(457, 281);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 28;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // mais1
            // 
            this.mais1.AutoSize = true;
            this.mais1.Location = new System.Drawing.Point(254, 141);
            this.mais1.Name = "mais1";
            this.mais1.Size = new System.Drawing.Size(13, 13);
            this.mais1.TabIndex = 41;
            this.mais1.Text = "+";
            this.mais1.Click += new System.EventHandler(this.Mais1_Click);
            // 
            // mais2
            // 
            this.mais2.AutoSize = true;
            this.mais2.Location = new System.Drawing.Point(254, 200);
            this.mais2.Name = "mais2";
            this.mais2.Size = new System.Drawing.Size(13, 13);
            this.mais2.TabIndex = 42;
            this.mais2.Text = "+";
            this.mais2.Click += new System.EventHandler(this.Mais2_Click);
            // 
            // mais3
            // 
            this.mais3.AutoSize = true;
            this.mais3.Location = new System.Drawing.Point(254, 290);
            this.mais3.Name = "mais3";
            this.mais3.Size = new System.Drawing.Size(13, 13);
            this.mais3.TabIndex = 43;
            this.mais3.Text = "+";
            this.mais3.Click += new System.EventHandler(this.Mais3_Click);
            // 
            // entrada2_SI
            // 
            this.entrada2_SI.Location = new System.Drawing.Point(395, 201);
            this.entrada2_SI.Name = "entrada2_SI";
            this.entrada2_SI.Size = new System.Drawing.Size(29, 20);
            this.entrada2_SI.TabIndex = 45;
            this.entrada2_SI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.entrada2_SI.Click += new System.EventHandler(this.Entrada2_SI_Click);
            // 
            // entrada1_SI
            // 
            this.entrada1_SI.Location = new System.Drawing.Point(395, 139);
            this.entrada1_SI.Name = "entrada1_SI";
            this.entrada1_SI.Size = new System.Drawing.Size(29, 20);
            this.entrada1_SI.TabIndex = 46;
            this.entrada1_SI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.entrada1_SI.Click += new System.EventHandler(this.Entrada1_SI_Click);
            // 
            // a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculador.Properties.Resources.peter_pó;
            this.ClientSize = new System.Drawing.Size(566, 332);
            this.ControlBox = false;
            this.Controls.Add(this.entrada1_SI);
            this.Controls.Add(this.entrada2_SI);
            this.Controls.Add(this.mais3);
            this.Controls.Add(this.mais2);
            this.Controls.Add(this.mais1);
            this.Controls.Add(this.CalcResis);
            this.Controls.Add(this.CalcCorrente);
            this.Controls.Add(this.CalcTensão);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.saida_C);
            this.Controls.Add(this.saida_R);
            this.Controls.Add(this.btLimpa);
            this.Controls.Add(this.btCalcula);
            this.Controls.Add(this.entrada2_C);
            this.Controls.Add(this.entrada1_C);
            this.Controls.Add(this.entrada2_R);
            this.Controls.Add(this.entrada1_R);
            this.Controls.Add(this.btSair);
            this.Name = "a";
            this.Text = "LDOACpol";
            this.Load += new System.EventHandler(this.A_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton CalcResis;
        private System.Windows.Forms.RadioButton CalcCorrente;
        private System.Windows.Forms.RadioButton CalcTensão;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label saida_C;
        private System.Windows.Forms.Label saida_R;
        private System.Windows.Forms.Button btLimpa;
        private System.Windows.Forms.Button btCalcula;
        private System.Windows.Forms.TextBox entrada2_C;
        private System.Windows.Forms.TextBox entrada1_C;
        private System.Windows.Forms.TextBox entrada2_R;
        private System.Windows.Forms.TextBox entrada1_R;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label mais1;
        private System.Windows.Forms.Label mais2;
        private System.Windows.Forms.Label mais3;
        private System.Windows.Forms.Label entrada2_SI;
        private System.Windows.Forms.Label entrada1_SI;
    }
}