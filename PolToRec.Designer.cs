namespace Calculador
{
    partial class PolToRec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolToRec));
            this.partereal = new System.Windows.Forms.TextBox();
            this.parteangular = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultadoreal = new System.Windows.Forms.Label();
            this.resultadoimaginario = new System.Windows.Forms.Label();
            this.titlePolToRec = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // partereal
            // 
            this.partereal.Location = new System.Drawing.Point(335, 181);
            this.partereal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.partereal.Name = "partereal";
            this.partereal.Size = new System.Drawing.Size(396, 26);
            this.partereal.TabIndex = 0;
            // 
            // parteangular
            // 
            this.parteangular.Location = new System.Drawing.Point(335, 276);
            this.parteangular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parteangular.Name = "parteangular";
            this.parteangular.Size = new System.Drawing.Size(396, 26);
            this.parteangular.TabIndex = 1;
            this.parteangular.TextChanged += new System.EventHandler(this.Parteangular_TextChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(651, 352);
            this.btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(148, 55);
            this.btn.TabIndex = 2;
            this.btn.Text = "Converter ";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(18, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite a parte real:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(13, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite a parte angular:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(60, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 47);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parte Real:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(61, 430);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 47);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parte Imaginária:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // resultadoreal
            // 
            this.resultadoreal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoreal.Location = new System.Drawing.Point(328, 339);
            this.resultadoreal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultadoreal.Name = "resultadoreal";
            this.resultadoreal.Size = new System.Drawing.Size(164, 47);
            this.resultadoreal.TabIndex = 7;
            this.resultadoreal.Text = "0";
            this.resultadoreal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultadoreal.Click += new System.EventHandler(this.Resultadoreal_Click);
            // 
            // resultadoimaginario
            // 
            this.resultadoimaginario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoimaginario.Location = new System.Drawing.Point(328, 426);
            this.resultadoimaginario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultadoimaginario.Name = "resultadoimaginario";
            this.resultadoimaginario.Size = new System.Drawing.Size(164, 47);
            this.resultadoimaginario.TabIndex = 8;
            this.resultadoimaginario.Text = "j0";
            this.resultadoimaginario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resultadoimaginario.Click += new System.EventHandler(this.Resultadoimaginario_Click);
            // 
            // titlePolToRec
            // 
            this.titlePolToRec.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.titlePolToRec.Location = new System.Drawing.Point(174, 18);
            this.titlePolToRec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titlePolToRec.Name = "titlePolToRec";
            this.titlePolToRec.Size = new System.Drawing.Size(557, 100);
            this.titlePolToRec.TabIndex = 9;
            this.titlePolToRec.Text = "TRANSFORMAÇÃO DE POLAR PARA RETANGULAR";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(651, 417);
            this.btSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(148, 55);
            this.btSair.TabIndex = 10;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // PolToRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 511);
            this.ControlBox = false;
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.titlePolToRec);
            this.Controls.Add(this.resultadoimaginario);
            this.Controls.Add(this.resultadoreal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.parteangular);
            this.Controls.Add(this.partereal);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PolToRec";
            this.Text = "Polar para Retangular";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox partereal;
        private System.Windows.Forms.TextBox parteangular;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultadoreal;
        private System.Windows.Forms.Label resultadoimaginario;
        private System.Windows.Forms.Label titlePolToRec;
        private System.Windows.Forms.Button btSair;
    }
}

