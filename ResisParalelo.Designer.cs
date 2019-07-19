namespace Calculador
{
    partial class ResisParalelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResisParalelo));
            this.label4 = new System.Windows.Forms.Label();
            this.btLimpa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCalcula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.entrada_1 = new System.Windows.Forms.TextBox();
            this.entrada_2 = new System.Windows.Forms.TextBox();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(53, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 60);
            this.label4.TabIndex = 21;
            this.label4.Text = "ASSOCIADOR DE RESISTORES EM PARALELO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // btLimpa
            // 
            this.btLimpa.Location = new System.Drawing.Point(422, 148);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(75, 23);
            this.btLimpa.TabIndex = 20;
            this.btLimpa.Text = "Limpa";
            this.btLimpa.UseVisualStyleBackColor = true;
            this.btLimpa.Click += new System.EventHandler(this.BtLimpa_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Resultado da Associação";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(96, 250);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(244, 23);
            this.lbl_resultado.TabIndex = 18;
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Inisira o valor do Resistor 2 em Ohms";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCalcula
            // 
            this.btCalcula.Location = new System.Drawing.Point(422, 112);
            this.btCalcula.Name = "btCalcula";
            this.btCalcula.Size = new System.Drawing.Size(75, 23);
            this.btCalcula.TabIndex = 16;
            this.btCalcula.Text = "Calcula";
            this.btCalcula.UseVisualStyleBackColor = true;
            this.btCalcula.Click += new System.EventHandler(this.BtCalcula_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Inisira o valor do Resistor 1 em Ohms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entrada_1
            // 
            this.entrada_1.Location = new System.Drawing.Point(96, 174);
            this.entrada_1.Name = "entrada_1";
            this.entrada_1.Size = new System.Drawing.Size(244, 20);
            this.entrada_1.TabIndex = 14;
            this.entrada_1.Text = "0Ω";
            this.entrada_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entrada_1.TextChanged += new System.EventHandler(this.Entrada_1_TextChanged);
            // 
            // entrada_2
            // 
            this.entrada_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entrada_2.Location = new System.Drawing.Point(96, 112);
            this.entrada_2.Name = "entrada_2";
            this.entrada_2.Size = new System.Drawing.Size(244, 20);
            this.entrada_2.TabIndex = 13;
            this.entrada_2.Text = "0Ω";
            this.entrada_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entrada_2.TextChanged += new System.EventHandler(this.Entrada_2_TextChanged);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(422, 250);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 12;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.BtSair_Click);
            // 
            // ResisParalelo
            // 
            this.BackgroundImage = global::Calculador.Properties.Resources.peter_pó;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(566, 332);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btLimpa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCalcula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.entrada_1);
            this.Controls.Add(this.entrada_2);
            this.Controls.Add(this.btSair);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResisParalelo";
            this.Text = "Associador de Resistores em Paralelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btLimpa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCalcula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entrada_1;
        private System.Windows.Forms.TextBox entrada_2;
        private System.Windows.Forms.Button btSair;
    }
}
