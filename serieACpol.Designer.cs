namespace Calculador
{
    partial class serieACpol
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
            this.labelpolserie6 = new System.Windows.Forms.Label();
            this.btnQUITARpolserie = new System.Windows.Forms.Button();
            this.btnCALCULApolserie = new System.Windows.Forms.Button();
            this.labelpolserietitulo = new System.Windows.Forms.Label();
            this.resultadopolserie = new System.Windows.Forms.Label();
            this.labelpolserie5 = new System.Windows.Forms.Label();
            this.labelpolserie3 = new System.Windows.Forms.Label();
            this.labelpolserie2 = new System.Windows.Forms.Label();
            this.labelpolserie1 = new System.Windows.Forms.Label();
            this.ang2 = new System.Windows.Forms.TextBox();
            this.real2 = new System.Windows.Forms.TextBox();
            this.ang1 = new System.Windows.Forms.TextBox();
            this.real1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelpolserie6
            // 
            this.labelpolserie6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelpolserie6.Location = new System.Drawing.Point(15, 265);
            this.labelpolserie6.Name = "labelpolserie6";
            this.labelpolserie6.Size = new System.Drawing.Size(179, 40);
            this.labelpolserie6.TabIndex = 54;
            this.labelpolserie6.Text = "Resultado:";
            // 
            // btnQUITARpolserie
            // 
            this.btnQUITARpolserie.Location = new System.Drawing.Point(401, 286);
            this.btnQUITARpolserie.Name = "btnQUITARpolserie";
            this.btnQUITARpolserie.Size = new System.Drawing.Size(99, 36);
            this.btnQUITARpolserie.TabIndex = 53;
            this.btnQUITARpolserie.Text = "Sair";
            this.btnQUITARpolserie.UseVisualStyleBackColor = true;
            this.btnQUITARpolserie.Click += new System.EventHandler(this.BtnQUITARpolserie_Click);
            // 
            // btnCALCULApolserie
            // 
            this.btnCALCULApolserie.Location = new System.Drawing.Point(401, 244);
            this.btnCALCULApolserie.Name = "btnCALCULApolserie";
            this.btnCALCULApolserie.Size = new System.Drawing.Size(99, 36);
            this.btnCALCULApolserie.TabIndex = 52;
            this.btnCALCULApolserie.Text = "Calcular";
            this.btnCALCULApolserie.UseVisualStyleBackColor = true;
            this.btnCALCULApolserie.Click += new System.EventHandler(this.BtnCALCULApolserie_Click);
            // 
            // labelpolserietitulo
            // 
            this.labelpolserietitulo.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.labelpolserietitulo.Location = new System.Drawing.Point(36, 10);
            this.labelpolserietitulo.Name = "labelpolserietitulo";
            this.labelpolserietitulo.Size = new System.Drawing.Size(464, 34);
            this.labelpolserietitulo.TabIndex = 51;
            this.labelpolserietitulo.Text = "ASSOCIADOR EM PARALELO AC POLAR";
            // 
            // resultadopolserie
            // 
            this.resultadopolserie.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.resultadopolserie.Location = new System.Drawing.Point(215, 265);
            this.resultadopolserie.Name = "resultadopolserie";
            this.resultadopolserie.Size = new System.Drawing.Size(117, 40);
            this.resultadopolserie.TabIndex = 50;
            this.resultadopolserie.Text = "0 + 0°";
            // 
            // labelpolserie5
            // 
            this.labelpolserie5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpolserie5.Location = new System.Drawing.Point(281, 150);
            this.labelpolserie5.Name = "labelpolserie5";
            this.labelpolserie5.Size = new System.Drawing.Size(271, 25);
            this.labelpolserie5.TabIndex = 49;
            this.labelpolserie5.Text = "Digite a parte imaginária da 2.ª impedância:";
            // 
            // labelpolserie3
            // 
            this.labelpolserie3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpolserie3.Location = new System.Drawing.Point(281, 63);
            this.labelpolserie3.Name = "labelpolserie3";
            this.labelpolserie3.Size = new System.Drawing.Size(271, 25);
            this.labelpolserie3.TabIndex = 48;
            this.labelpolserie3.Text = "Digite a parte imaginária da 1.ª impedância:";
            // 
            // labelpolserie2
            // 
            this.labelpolserie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpolserie2.Location = new System.Drawing.Point(19, 150);
            this.labelpolserie2.Name = "labelpolserie2";
            this.labelpolserie2.Size = new System.Drawing.Size(233, 25);
            this.labelpolserie2.TabIndex = 47;
            this.labelpolserie2.Text = "Digite a parte real da 2.ª impedância:";
            // 
            // labelpolserie1
            // 
            this.labelpolserie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpolserie1.Location = new System.Drawing.Point(19, 63);
            this.labelpolserie1.Name = "labelpolserie1";
            this.labelpolserie1.Size = new System.Drawing.Size(233, 25);
            this.labelpolserie1.TabIndex = 46;
            this.labelpolserie1.Text = "Digite a parte real da 1.ª impedância:";
            // 
            // ang2
            // 
            this.ang2.Location = new System.Drawing.Point(341, 194);
            this.ang2.Name = "ang2";
            this.ang2.Size = new System.Drawing.Size(126, 20);
            this.ang2.TabIndex = 45;
            // 
            // real2
            // 
            this.real2.Location = new System.Drawing.Point(59, 194);
            this.real2.Name = "real2";
            this.real2.Size = new System.Drawing.Size(126, 20);
            this.real2.TabIndex = 44;
            // 
            // ang1
            // 
            this.ang1.Location = new System.Drawing.Point(341, 103);
            this.ang1.Name = "ang1";
            this.ang1.Size = new System.Drawing.Size(126, 20);
            this.ang1.TabIndex = 43;
            // 
            // real1
            // 
            this.real1.Location = new System.Drawing.Point(59, 103);
            this.real1.Name = "real1";
            this.real1.Size = new System.Drawing.Size(126, 20);
            this.real1.TabIndex = 42;
            // 
            // serieACpol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculador.Properties.Resources.peter_pó;
            this.ClientSize = new System.Drawing.Size(566, 332);
            this.Controls.Add(this.labelpolserie6);
            this.Controls.Add(this.btnQUITARpolserie);
            this.Controls.Add(this.btnCALCULApolserie);
            this.Controls.Add(this.labelpolserietitulo);
            this.Controls.Add(this.resultadopolserie);
            this.Controls.Add(this.labelpolserie5);
            this.Controls.Add(this.labelpolserie3);
            this.Controls.Add(this.labelpolserie2);
            this.Controls.Add(this.labelpolserie1);
            this.Controls.Add(this.ang2);
            this.Controls.Add(this.real2);
            this.Controls.Add(this.ang1);
            this.Controls.Add(this.real1);
            this.Name = "serieACpol";
            this.Text = "serieACpol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelpolserie6;
        private System.Windows.Forms.Button btnQUITARpolserie;
        private System.Windows.Forms.Button btnCALCULApolserie;
        private System.Windows.Forms.Label labelpolserietitulo;
        private System.Windows.Forms.Label resultadopolserie;
        private System.Windows.Forms.Label labelpolserie5;
        private System.Windows.Forms.Label labelpolserie3;
        private System.Windows.Forms.Label labelpolserie2;
        private System.Windows.Forms.Label labelpolserie1;
        private System.Windows.Forms.TextBox ang2;
        private System.Windows.Forms.TextBox real2;
        private System.Windows.Forms.TextBox ang1;
        private System.Windows.Forms.TextBox real1;
    }
}