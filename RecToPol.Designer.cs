namespace Calculador
{
    partial class RecToPol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecToPol));
            this.titleRecToPol = new System.Windows.Forms.Label();
            this.resultado1RecToPol = new System.Windows.Forms.Label();
            this.labelRecToPol4 = new System.Windows.Forms.Label();
            this.labelRecToPol3 = new System.Windows.Forms.Label();
            this.labelRecToPol2 = new System.Windows.Forms.Label();
            this.labelRecToPol1 = new System.Windows.Forms.Label();
            this.btnRecToPol = new System.Windows.Forms.Button();
            this.parteIMAGINARIA1 = new System.Windows.Forms.TextBox();
            this.parteREAL1 = new System.Windows.Forms.TextBox();
            this.btSair = new System.Windows.Forms.Button();
            this.resultado2RecToPol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleRecToPol
            // 
            this.titleRecToPol.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.titleRecToPol.Location = new System.Drawing.Point(174, 18);
            this.titleRecToPol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleRecToPol.Name = "titleRecToPol";
            this.titleRecToPol.Size = new System.Drawing.Size(557, 100);
            this.titleRecToPol.TabIndex = 10;
            this.titleRecToPol.Text = "TRANSFORMAÇÃO DE RETANGULAR PARA POLAR";
            // 
            // resultado1RecToPol
            // 
            this.resultado1RecToPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado1RecToPol.Location = new System.Drawing.Point(335, 343);
            this.resultado1RecToPol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultado1RecToPol.Name = "resultado1RecToPol";
            this.resultado1RecToPol.Size = new System.Drawing.Size(164, 47);
            this.resultado1RecToPol.TabIndex = 18;
            this.resultado1RecToPol.Text = "0";
            this.resultado1RecToPol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRecToPol4
            // 
            this.labelRecToPol4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelRecToPol4.Location = new System.Drawing.Point(61, 430);
            this.labelRecToPol4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecToPol4.Name = "labelRecToPol4";
            this.labelRecToPol4.Size = new System.Drawing.Size(207, 47);
            this.labelRecToPol4.TabIndex = 17;
            this.labelRecToPol4.Text = "Parte Angular:";
            // 
            // labelRecToPol3
            // 
            this.labelRecToPol3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelRecToPol3.Location = new System.Drawing.Point(60, 343);
            this.labelRecToPol3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecToPol3.Name = "labelRecToPol3";
            this.labelRecToPol3.Size = new System.Drawing.Size(207, 47);
            this.labelRecToPol3.TabIndex = 16;
            this.labelRecToPol3.Text = "Parte Real:";
            // 
            // labelRecToPol2
            // 
            this.labelRecToPol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRecToPol2.Location = new System.Drawing.Point(13, 260);
            this.labelRecToPol2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecToPol2.Name = "labelRecToPol2";
            this.labelRecToPol2.Size = new System.Drawing.Size(290, 38);
            this.labelRecToPol2.TabIndex = 15;
            this.labelRecToPol2.Text = "Digite a parte imaginária:";
            // 
            // labelRecToPol1
            // 
            this.labelRecToPol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRecToPol1.Location = new System.Drawing.Point(18, 169);
            this.labelRecToPol1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecToPol1.Name = "labelRecToPol1";
            this.labelRecToPol1.Size = new System.Drawing.Size(290, 38);
            this.labelRecToPol1.TabIndex = 14;
            this.labelRecToPol1.Text = "Digite a parte real:";
            // 
            // btnRecToPol
            // 
            this.btnRecToPol.Location = new System.Drawing.Point(651, 352);
            this.btnRecToPol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecToPol.Name = "btnRecToPol";
            this.btnRecToPol.Size = new System.Drawing.Size(148, 55);
            this.btnRecToPol.TabIndex = 13;
            this.btnRecToPol.Text = "Converter";
            this.btnRecToPol.UseVisualStyleBackColor = true;
            this.btnRecToPol.Click += new System.EventHandler(this.BtnRecToPol_Click);
            // 
            // parteIMAGINARIA1
            // 
            this.parteIMAGINARIA1.Location = new System.Drawing.Point(333, 272);
            this.parteIMAGINARIA1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parteIMAGINARIA1.Name = "parteIMAGINARIA1";
            this.parteIMAGINARIA1.Size = new System.Drawing.Size(398, 26);
            this.parteIMAGINARIA1.TabIndex = 12;
            this.parteIMAGINARIA1.TextChanged += new System.EventHandler(this.ParteIMAGINARIA1_TextChanged);
            // 
            // parteREAL1
            // 
            this.parteREAL1.Location = new System.Drawing.Point(333, 183);
            this.parteREAL1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parteREAL1.Name = "parteREAL1";
            this.parteREAL1.Size = new System.Drawing.Size(398, 26);
            this.parteREAL1.TabIndex = 11;
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(651, 417);
            this.btSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(148, 55);
            this.btSair.TabIndex = 20;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // resultado2RecToPol
            // 
            this.resultado2RecToPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado2RecToPol.Location = new System.Drawing.Point(335, 430);
            this.resultado2RecToPol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultado2RecToPol.Name = "resultado2RecToPol";
            this.resultado2RecToPol.Size = new System.Drawing.Size(164, 47);
            this.resultado2RecToPol.TabIndex = 19;
            this.resultado2RecToPol.Text = "0°";
            this.resultado2RecToPol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultado2RecToPol.Click += new System.EventHandler(this.Resultado2RecToPol_Click);
            // 
            // RecToPol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 511);
            this.ControlBox = false;
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.resultado2RecToPol);
            this.Controls.Add(this.resultado1RecToPol);
            this.Controls.Add(this.labelRecToPol4);
            this.Controls.Add(this.labelRecToPol3);
            this.Controls.Add(this.labelRecToPol2);
            this.Controls.Add(this.labelRecToPol1);
            this.Controls.Add(this.btnRecToPol);
            this.Controls.Add(this.parteIMAGINARIA1);
            this.Controls.Add(this.parteREAL1);
            this.Controls.Add(this.titleRecToPol);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RecToPol";
            this.Text = "Retangular para Polar";
            this.Load += new System.EventHandler(this.RecToPol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleRecToPol;
        private System.Windows.Forms.Label resultado1RecToPol;
        private System.Windows.Forms.Label labelRecToPol4;
        private System.Windows.Forms.Label labelRecToPol3;
        private System.Windows.Forms.Label labelRecToPol2;
        private System.Windows.Forms.Label labelRecToPol1;
        private System.Windows.Forms.Button btnRecToPol;
        private System.Windows.Forms.TextBox parteIMAGINARIA1;
        private System.Windows.Forms.TextBox parteREAL1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label resultado2RecToPol;
    }
}