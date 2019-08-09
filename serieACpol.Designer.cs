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

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serieACpol));
            this.labelpolserie6 = new System.Windows.Forms.Label();
            this.btnQUITAR = new System.Windows.Forms.Button();
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
            this.labelpolserie6.AutoSize = true;
            this.labelpolserie6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpolserie6.Location = new System.Drawing.Point(116, 281);
            this.labelpolserie6.Name = "labelpolserie6";
            this.labelpolserie6.Size = new System.Drawing.Size(79, 18);
            this.labelpolserie6.TabIndex = 28;
            this.labelpolserie6.Text = "Resultado:";
            // 
            // btnQUITAR
            // 
            this.btnQUITAR.Location = new System.Drawing.Point(408, 281);
            this.btnQUITAR.Name = "btnQUITAR";
            this.btnQUITAR.Size = new System.Drawing.Size(68, 27);
            this.btnQUITAR.TabIndex = 27;
            this.btnQUITAR.Text = "Sair";
            this.btnQUITAR.UseVisualStyleBackColor = true;
            this.btnQUITAR.Click += new System.EventHandler(this.BtnQUITAR_Click);
            // 
            // btnCALCULApolserie
            // 
            this.btnCALCULApolserie.Location = new System.Drawing.Point(217, 200);
            this.btnCALCULApolserie.Name = "btnCALCULApolserie";
            this.btnCALCULApolserie.Size = new System.Drawing.Size(127, 51);
            this.btnCALCULApolserie.TabIndex = 26;
            this.btnCALCULApolserie.Text = "Calcular";
            this.btnCALCULApolserie.UseVisualStyleBackColor = true;
            this.btnCALCULApolserie.Click += new System.EventHandler(this.BtnCALCULApolserie_Click);
            // 
            // labelpolserietitulo
            // 
            this.labelpolserietitulo.AutoSize = true;
            this.labelpolserietitulo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpolserietitulo.Location = new System.Drawing.Point(40, 23);
            this.labelpolserietitulo.Name = "labelpolserietitulo";
            this.labelpolserietitulo.Size = new System.Drawing.Size(482, 36);
            this.labelpolserietitulo.TabIndex = 25;
            this.labelpolserietitulo.Text = "ASSOCIADOR EM SÉRIE POLAR";
            // 
            // resultadopolserie
            // 
            this.resultadopolserie.AutoSize = true;
            this.resultadopolserie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadopolserie.Location = new System.Drawing.Point(249, 276);
            this.resultadopolserie.Name = "resultadopolserie";
            this.resultadopolserie.Size = new System.Drawing.Size(66, 29);
            this.resultadopolserie.TabIndex = 24;
            this.resultadopolserie.Text = "0 L0°";
            // 
            // labelpolserie5
            // 
            this.labelpolserie5.AutoSize = true;
            this.labelpolserie5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpolserie5.Location = new System.Drawing.Point(291, 159);
            this.labelpolserie5.Name = "labelpolserie5";
            this.labelpolserie5.Size = new System.Drawing.Size(250, 16);
            this.labelpolserie5.TabIndex = 23;
            this.labelpolserie5.Text = "Digite a parte angular da 2.ª impedância:";
            // 
            // labelpolserie3
            // 
            this.labelpolserie3.AutoSize = true;
            this.labelpolserie3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpolserie3.Location = new System.Drawing.Point(8, 159);
            this.labelpolserie3.Name = "labelpolserie3";
            this.labelpolserie3.Size = new System.Drawing.Size(250, 16);
            this.labelpolserie3.TabIndex = 22;
            this.labelpolserie3.Text = "Digite a parte angular da 1.ª impedância:";
            // 
            // labelpolserie2
            // 
            this.labelpolserie2.AutoSize = true;
            this.labelpolserie2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpolserie2.Location = new System.Drawing.Point(307, 95);
            this.labelpolserie2.Name = "labelpolserie2";
            this.labelpolserie2.Size = new System.Drawing.Size(228, 16);
            this.labelpolserie2.TabIndex = 21;
            this.labelpolserie2.Text = "Digite a parte real da 2.ª impedância:";
            // 
            // labelpolserie1
            // 
            this.labelpolserie1.AutoSize = true;
            this.labelpolserie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpolserie1.Location = new System.Drawing.Point(29, 95);
            this.labelpolserie1.Name = "labelpolserie1";
            this.labelpolserie1.Size = new System.Drawing.Size(228, 16);
            this.labelpolserie1.TabIndex = 20;
            this.labelpolserie1.Text = "Digite a parte real da 1.ª impedância:";
            // 
            // ang2
            // 
            this.ang2.Location = new System.Drawing.Point(350, 178);
            this.ang2.Name = "ang2";
            this.ang2.Size = new System.Drawing.Size(126, 20);
            this.ang2.TabIndex = 19;
            // 
            // real2
            // 
            this.real2.Location = new System.Drawing.Point(350, 119);
            this.real2.Name = "real2";
            this.real2.Size = new System.Drawing.Size(126, 20);
            this.real2.TabIndex = 18;
            // 
            // ang1
            // 
            this.ang1.Location = new System.Drawing.Point(69, 178);
            this.ang1.Name = "ang1";
            this.ang1.Size = new System.Drawing.Size(126, 20);
            this.ang1.TabIndex = 17;
            // 
            // real1
            // 
            this.real1.Location = new System.Drawing.Point(69, 119);
            this.real1.Name = "real1";
            this.real1.Size = new System.Drawing.Size(126, 20);
            this.real1.TabIndex = 16;
            // 
            // serieACpol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(566, 332);
            this.ControlBox = false;
            this.Controls.Add(this.labelpolserie6);
            this.Controls.Add(this.btnQUITAR);
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
            this.Text = "Associador em séire AC polar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelpolserie6;
        private System.Windows.Forms.Button btnQUITAR;
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