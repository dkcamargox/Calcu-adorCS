namespace Calculador
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDC = new System.Windows.Forms.Button();
            this.btRserie = new System.Windows.Forms.Button();
            this.btRparalelo = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btPolRec = new System.Windows.Forms.Button();
            this.btnRecToPol = new System.Windows.Forms.Button();
            this.btnSerieACrec = new System.Windows.Forms.Button();
            this.btnParaleloACrec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(615, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADOR DA LEI DE OHM\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(201, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "MENU PRINCIPAL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDC
            // 
            this.btDC.Location = new System.Drawing.Point(142, 204);
            this.btDC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDC.Name = "btDC";
            this.btDC.Size = new System.Drawing.Size(148, 55);
            this.btDC.TabIndex = 2;
            this.btDC.Text = "Lei de Ohm";
            this.btDC.UseVisualStyleBackColor = true;
            this.btDC.Click += new System.EventHandler(this.BtDC_Click);
            // 
            // btRserie
            // 
            this.btRserie.Location = new System.Drawing.Point(326, 204);
            this.btRserie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRserie.Name = "btRserie";
            this.btRserie.Size = new System.Drawing.Size(148, 55);
            this.btRserie.TabIndex = 5;
            this.btRserie.Text = "Série DC";
            this.btRserie.UseVisualStyleBackColor = true;
            this.btRserie.Click += new System.EventHandler(this.BtRserie_Click);
            // 
            // btRparalelo
            // 
            this.btRparalelo.Location = new System.Drawing.Point(521, 204);
            this.btRparalelo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRparalelo.Name = "btRparalelo";
            this.btRparalelo.Size = new System.Drawing.Size(148, 55);
            this.btRparalelo.TabIndex = 6;
            this.btRparalelo.Text = "Paralelo DC";
            this.btRparalelo.UseVisualStyleBackColor = true;
            this.btRparalelo.Click += new System.EventHandler(this.BtRparalelo_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(628, 388);
            this.btSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(148, 55);
            this.btSair.TabIndex = 13;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // btPolRec
            // 
            this.btPolRec.Location = new System.Drawing.Point(326, 285);
            this.btPolRec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPolRec.Name = "btPolRec";
            this.btPolRec.Size = new System.Drawing.Size(148, 55);
            this.btPolRec.TabIndex = 15;
            this.btPolRec.Text = "Polar para Retangular";
            this.btPolRec.UseVisualStyleBackColor = true;
            this.btPolRec.Click += new System.EventHandler(this.BtPolRec_Click);
            // 
            // btnRecToPol
            // 
            this.btnRecToPol.Location = new System.Drawing.Point(142, 285);
            this.btnRecToPol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRecToPol.Name = "btnRecToPol";
            this.btnRecToPol.Size = new System.Drawing.Size(148, 55);
            this.btnRecToPol.TabIndex = 17;
            this.btnRecToPol.Text = "Retangular para Polar";
            this.btnRecToPol.UseVisualStyleBackColor = true;
            this.btnRecToPol.Click += new System.EventHandler(this.BtnRecToPol_Click);
            // 
            // btnSerieACrec
            // 
            this.btnSerieACrec.Location = new System.Drawing.Point(142, 372);
            this.btnSerieACrec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSerieACrec.Name = "btnSerieACrec";
            this.btnSerieACrec.Size = new System.Drawing.Size(148, 55);
            this.btnSerieACrec.TabIndex = 19;
            this.btnSerieACrec.Text = "Série AC Ret.";
            this.btnSerieACrec.UseVisualStyleBackColor = true;
            this.btnSerieACrec.Click += new System.EventHandler(this.BtnSerieACrec_Click);
            // 
            // btnParaleloACrec
            // 
            this.btnParaleloACrec.Location = new System.Drawing.Point(326, 372);
            this.btnParaleloACrec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParaleloACrec.Name = "btnParaleloACrec";
            this.btnParaleloACrec.Size = new System.Drawing.Size(148, 55);
            this.btnParaleloACrec.TabIndex = 21;
            this.btnParaleloACrec.Text = "Paralelo AC Ret.";
            this.btnParaleloACrec.UseVisualStyleBackColor = true;
            this.btnParaleloACrec.Click += new System.EventHandler(this.BtnParaleloACrec_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 511);
            this.Controls.Add(this.btnParaleloACrec);
            this.Controls.Add(this.btnSerieACrec);
            this.Controls.Add(this.btnRecToPol);
            this.Controls.Add(this.btPolRec);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btRparalelo);
            this.Controls.Add(this.btRserie);
            this.Controls.Add(this.btDC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador da Lei de Ohm";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDC;
        private System.Windows.Forms.Button btRserie;
        private System.Windows.Forms.Button btRparalelo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btPolRec;
        private System.Windows.Forms.Button btnRecToPol;
        private System.Windows.Forms.Button btnSerieACrec;
        private System.Windows.Forms.Button btnParaleloACrec;
    }
}

