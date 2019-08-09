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

            this.btnSerieACpol = new System.Windows.Forms.Button();
            this.btnParaleloACpol = new System.Windows.Forms.Button();

            this.btLDOAC = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 33);
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
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "MENU PRINCIPAL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btDC
            // 
            this.btDC.Location = new System.Drawing.Point(45, 149);
            this.btDC.Name = "btDC";
            this.btDC.Size = new System.Drawing.Size(75, 23);
            this.btDC.TabIndex = 2;
            this.btDC.Text = "Lei de Ohm";
            this.btDC.UseVisualStyleBackColor = true;
            this.btDC.Click += new System.EventHandler(this.BtDC_Click);
            // 
            // btRserie
            // 
            this.btRserie.Location = new System.Drawing.Point(45, 249);
            this.btRserie.Name = "btRserie";
            this.btRserie.Size = new System.Drawing.Size(75, 23);
            this.btRserie.TabIndex = 5;
            this.btRserie.Text = "Série DC";
            this.btRserie.UseVisualStyleBackColor = true;
            this.btRserie.Click += new System.EventHandler(this.BtRserie_Click);
            // 
            // btRparalelo
            // 
            this.btRparalelo.Location = new System.Drawing.Point(45, 200);
            this.btRparalelo.Name = "btRparalelo";
            this.btRparalelo.Size = new System.Drawing.Size(75, 23);
            this.btRparalelo.TabIndex = 6;
            this.btRparalelo.Text = "Paralelo DC";
            this.btRparalelo.UseVisualStyleBackColor = true;
            this.btRparalelo.Click += new System.EventHandler(this.BtRparalelo_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(479, 297);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 13;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // btPolRec
            // 
            this.btPolRec.Location = new System.Drawing.Point(159, 149);
            this.btPolRec.Name = "btPolRec";
            this.btPolRec.Size = new System.Drawing.Size(121, 23);
            this.btPolRec.TabIndex = 15;
            this.btPolRec.Text = "Polar para Retangular";
            this.btPolRec.UseVisualStyleBackColor = true;
            this.btPolRec.Click += new System.EventHandler(this.BtPolRec_Click);
            // 
            // btnRecToPol
            // 
            this.btnRecToPol.Location = new System.Drawing.Point(312, 149);
            this.btnRecToPol.Name = "btnRecToPol";
            this.btnRecToPol.Size = new System.Drawing.Size(121, 23);
            this.btnRecToPol.TabIndex = 17;
            this.btnRecToPol.Text = "Retangular para Polar";
            this.btnRecToPol.UseVisualStyleBackColor = true;
            this.btnRecToPol.Click += new System.EventHandler(this.BtnRecToPol_Click);
            // 
            // btnSerieACrec
            // 
            this.btnSerieACrec.Location = new System.Drawing.Point(159, 249);
            this.btnSerieACrec.Name = "btnSerieACrec";
            this.btnSerieACrec.Size = new System.Drawing.Size(121, 23);
            this.btnSerieACrec.TabIndex = 19;
            this.btnSerieACrec.Text = "Série AC Ret.";
            this.btnSerieACrec.UseVisualStyleBackColor = true;
            this.btnSerieACrec.Click += new System.EventHandler(this.BtnSerieACrec_Click);
            // 
            // btnParaleloACrec
            // 
            this.btnParaleloACrec.Location = new System.Drawing.Point(159, 200);
            this.btnParaleloACrec.Name = "btnParaleloACrec";
            this.btnParaleloACrec.Size = new System.Drawing.Size(121, 23);
            this.btnParaleloACrec.TabIndex = 21;
            this.btnParaleloACrec.Text = "Paralelo AC Ret.";
            this.btnParaleloACrec.UseVisualStyleBackColor = true;
            this.btnParaleloACrec.Click += new System.EventHandler(this.BtnParaleloACrec_Click);
            // 

            // btnSerieACpol
            // 
            this.btnSerieACpol.Location = new System.Drawing.Point(312, 249);
            this.btnSerieACpol.Name = "btnSerieACpol";
            this.btnSerieACpol.Size = new System.Drawing.Size(121, 23);
            this.btnSerieACpol.TabIndex = 23;
            this.btnSerieACpol.Text = "Série AC Pol.";
            this.btnSerieACpol.UseVisualStyleBackColor = true;
            this.btnSerieACpol.Click += new System.EventHandler(this.BtnSerieACpol_Click);
            // 
            // btnParaleloACpol
            // 
            this.btnParaleloACpol.Location = new System.Drawing.Point(312, 200);
            this.btnParaleloACpol.Name = "btnParaleloACpol";
            this.btnParaleloACpol.Size = new System.Drawing.Size(121, 23);
            this.btnParaleloACpol.TabIndex = 25;
            this.btnParaleloACpol.Text = "Paralelo AC Pol.";
            this.btnParaleloACpol.UseVisualStyleBackColor = true;
            this.btnParaleloACpol.Click += new System.EventHandler(this.BtnParaleloACpol_Click);

            // btLDOAC
            // 
            this.btLDOAC.Location = new System.Drawing.Point(419, 152);
            this.btLDOAC.Name = "btLDOAC";
            this.btLDOAC.Size = new System.Drawing.Size(75, 23);
            this.btLDOAC.TabIndex = 23;
            this.btLDOAC.Text = "LDO AC";
            this.btLDOAC.UseVisualStyleBackColor = true;
            this.btLDOAC.Click += new System.EventHandler(this.BtLDOAC_Click);

            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackgroundImage = global::Calculador.Properties.Resources.foto_foda6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 332);

            this.Controls.Add(this.btnParaleloACpol);
            this.Controls.Add(this.btnSerieACpol);

            this.Controls.Add(this.btLDOAC);

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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
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
        private System.Windows.Forms.Button btnSerieACpol;
        private System.Windows.Forms.Button btnParaleloACpol;
        private System.Windows.Forms.Button btLDOAC;

    }
}

