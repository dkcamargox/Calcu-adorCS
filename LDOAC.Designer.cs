namespace Calculador
{
    partial class LDOAC
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
            this.label1 = new System.Windows.Forms.Label();
            this.btRec = new System.Windows.Forms.Button();
            this.btPol = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 128);
            this.label1.TabIndex = 11;
            this.label1.Text = "CALCULADOR DA LEI DE OHM PARA SINAIS ALTERNADOS\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btRec
            // 
            this.btRec.Location = new System.Drawing.Point(107, 152);
            this.btRec.Name = "btRec";
            this.btRec.Size = new System.Drawing.Size(75, 38);
            this.btRec.TabIndex = 12;
            this.btRec.Text = "formato retangular";
            this.btRec.UseVisualStyleBackColor = true;
            this.btRec.Click += new System.EventHandler(this.BtRec_Click);
            // 
            // btPol
            // 
            this.btPol.Location = new System.Drawing.Point(107, 218);
            this.btPol.Name = "btPol";
            this.btPol.Size = new System.Drawing.Size(75, 37);
            this.btPol.TabIndex = 13;
            this.btPol.Text = "formato polar";
            this.btPol.UseVisualStyleBackColor = true;
            this.btPol.Click += new System.EventHandler(this.BtPol_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(107, 281);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 14;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // LDOAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackgroundImage = global::Calculador.Properties.Resources.peter_pó;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(293, 347);

            this.ControlBox = false;
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btPol);
            this.Controls.Add(this.btRec);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LDOAC";
            this.Text = "LDO AC";
            this.Load += new System.EventHandler(this.LDOAC_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRec;
        private System.Windows.Forms.Button btPol;
        private System.Windows.Forms.Button btSair;
    }
}