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
            this.btSair = new System.Windows.Forms.Button();
            this.entrada1_R = new System.Windows.Forms.TextBox();
            this.entrada2_R = new System.Windows.Forms.TextBox();
            this.entrada1_C = new System.Windows.Forms.TextBox();
            this.entrada2_C = new System.Windows.Forms.TextBox();
            this.btCalcula = new System.Windows.Forms.Button();
            this.btLimpa = new System.Windows.Forms.Button();
            this.saida_R = new System.Windows.Forms.Label();
            this.saida_C = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.CalcResis = new System.Windows.Forms.RadioButton();
            this.CalcCorrente = new System.Windows.Forms.RadioButton();
            this.CalcTensão = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(431, 262);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 15;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // entrada1_R
            // 
            this.entrada1_R.Location = new System.Drawing.Point(130, 120);
            this.entrada1_R.Name = "entrada1_R";
            this.entrada1_R.Size = new System.Drawing.Size(100, 20);
            this.entrada1_R.TabIndex = 16;
            // 
            // entrada2_R
            // 
            this.entrada2_R.Location = new System.Drawing.Point(130, 179);
            this.entrada2_R.Name = "entrada2_R";
            this.entrada2_R.Size = new System.Drawing.Size(100, 20);
            this.entrada2_R.TabIndex = 17;
            // 
            // entrada1_C
            // 
            this.entrada1_C.Location = new System.Drawing.Point(300, 120);
            this.entrada1_C.Name = "entrada1_C";
            this.entrada1_C.Size = new System.Drawing.Size(100, 20);
            this.entrada1_C.TabIndex = 18;
            // 
            // entrada2_C
            // 
            this.entrada2_C.Location = new System.Drawing.Point(300, 179);
            this.entrada2_C.Name = "entrada2_C";
            this.entrada2_C.Size = new System.Drawing.Size(100, 20);
            this.entrada2_C.TabIndex = 19;
            // 
            // btCalcula
            // 
            this.btCalcula.Location = new System.Drawing.Point(431, 120);
            this.btCalcula.Name = "btCalcula";
            this.btCalcula.Size = new System.Drawing.Size(75, 23);
            this.btCalcula.TabIndex = 20;
            this.btCalcula.Text = "Calcula";
            this.btCalcula.UseVisualStyleBackColor = true;
            // 
            // btLimpa
            // 
            this.btLimpa.Location = new System.Drawing.Point(431, 179);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(75, 23);
            this.btLimpa.TabIndex = 21;
            this.btLimpa.Text = "Limpa";
            this.btLimpa.UseVisualStyleBackColor = true;
            // 
            // saida_R
            // 
            this.saida_R.Location = new System.Drawing.Point(127, 267);
            this.saida_R.Name = "saida_R";
            this.saida_R.Size = new System.Drawing.Size(130, 18);
            this.saida_R.TabIndex = 22;
            // 
            // saida_C
            // 
            this.saida_C.Location = new System.Drawing.Point(286, 267);
            this.saida_C.Name = "saida_C";
            this.saida_C.Size = new System.Drawing.Size(130, 18);
            this.saida_C.TabIndex = 23;
            // 
            // titulo
            // 
            this.titulo.Location = new System.Drawing.Point(371, 45);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(100, 23);
            this.titulo.TabIndex = 24;
            this.titulo.Text = "TITULO";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalcResis
            // 
            this.CalcResis.AutoSize = true;
            this.CalcResis.Location = new System.Drawing.Point(12, 82);
            this.CalcResis.Name = "CalcResis";
            this.CalcResis.Size = new System.Drawing.Size(198, 17);
            this.CalcResis.TabIndex = 27;
            this.CalcResis.TabStop = true;
            this.CalcResis.Text = "Calculador a Resistencia ( R = V / I )";
            this.CalcResis.UseVisualStyleBackColor = true;
            // 
            // CalcCorrente
            // 
            this.CalcCorrente.Location = new System.Drawing.Point(12, 48);
            this.CalcCorrente.Name = "CalcCorrente";
            this.CalcCorrente.Size = new System.Drawing.Size(198, 17);
            this.CalcCorrente.TabIndex = 26;
            this.CalcCorrente.TabStop = true;
            this.CalcCorrente.Text = "Calcular a Corrente ( I = V / R )";
            this.CalcCorrente.UseVisualStyleBackColor = true;
            // 
            // CalcTensão
            // 
            this.CalcTensão.Location = new System.Drawing.Point(12, 12);
            this.CalcTensão.Name = "CalcTensão";
            this.CalcTensão.Size = new System.Drawing.Size(198, 17);
            this.CalcTensão.TabIndex = 25;
            this.CalcTensão.TabStop = true;
            this.CalcTensão.Text = "Calcular a Tensão ( V = R . I )";
            this.CalcTensão.UseVisualStyleBackColor = true;
            // 
            // LDOACrec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculador.Properties.Resources.foto_foda6;
            this.ClientSize = new System.Drawing.Size(566, 332);
            this.ControlBox = false;
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
            this.Name = "LDOACrec";
            this.Text = "LDOACrec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TextBox entrada1_R;
        private System.Windows.Forms.TextBox entrada2_R;
        private System.Windows.Forms.TextBox entrada1_C;
        private System.Windows.Forms.TextBox entrada2_C;
        private System.Windows.Forms.Button btCalcula;
        private System.Windows.Forms.Button btLimpa;
        private System.Windows.Forms.Label saida_R;
        private System.Windows.Forms.Label saida_C;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.RadioButton CalcResis;
        private System.Windows.Forms.RadioButton CalcCorrente;
        private System.Windows.Forms.RadioButton CalcTensão;
    }
}