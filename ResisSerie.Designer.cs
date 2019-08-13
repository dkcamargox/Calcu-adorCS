namespace Calculador
{
    partial class ResisSerie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResisSerie));
            this.btSair = new System.Windows.Forms.Button();
            this.entrada_2 = new System.Windows.Forms.TextBox();
            this.entrada_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCalcula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btLimpa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(635, 445);
            this.btSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(148, 55);
            this.btSair.TabIndex = 0;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.Button1_Click);
            // 
            // entrada_2
            // 
            this.entrada_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entrada_2.Location = new System.Drawing.Point(31, 238);
            this.entrada_2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.entrada_2.Name = "entrada_2";
            this.entrada_2.Size = new System.Drawing.Size(340, 26);
            this.entrada_2.TabIndex = 1;
            this.entrada_2.Text = "0Ω";
            this.entrada_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entrada_2.TextChanged += new System.EventHandler(this.Entrada_2_TextChanged);
            // 
            // entrada_1
            // 
            this.entrada_1.Location = new System.Drawing.Point(463, 238);
            this.entrada_1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.entrada_1.Name = "entrada_1";
            this.entrada_1.Size = new System.Drawing.Size(340, 26);
            this.entrada_1.TabIndex = 2;
            this.entrada_1.Text = "0Ω";
            this.entrada_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.entrada_1.TextChanged += new System.EventHandler(this.Entrada_1_TextChanged);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 88);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inisira o valor do Resistor 1 em Ohms";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btCalcula
            // 
            this.btCalcula.Location = new System.Drawing.Point(635, 315);
            this.btCalcula.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCalcula.Name = "btCalcula";
            this.btCalcula.Size = new System.Drawing.Size(148, 55);
            this.btCalcula.TabIndex = 6;
            this.btCalcula.Text = "Calcula";
            this.btCalcula.UseVisualStyleBackColor = true;
            this.btCalcula.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 88);
            this.label2.TabIndex = 7;
            this.label2.Text = "Inisira o valor do Resistor 2 em Ohms";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(74, 401);
            this.lbl_resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(490, 34);
            this.lbl_resultado.TabIndex = 8;
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_resultado.Click += new System.EventHandler(this.Lbl_resultado_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(74, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 57);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado da Associação";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btLimpa
            // 
            this.btLimpa.Location = new System.Drawing.Point(635, 380);
            this.btLimpa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(148, 55);
            this.btLimpa.TabIndex = 10;
            this.btLimpa.Text = "Limpa";
            this.btLimpa.UseVisualStyleBackColor = true;
            this.btLimpa.Click += new System.EventHandler(this.BtLimpa_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("NSimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(819, 74);
            this.label4.TabIndex = 11;
            this.label4.Text = "ASSOCIADOR DE RESISTORES EM SÉRIE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // ResisSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculador.Properties.Resources.peter_pó;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 511);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ResisSerie";
            this.Text = "Associador de Resistores em Série";
            this.Load += new System.EventHandler(this.ResisSerie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.TextBox entrada_2;
        private System.Windows.Forms.TextBox entrada_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCalcula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLimpa;
        private System.Windows.Forms.Label label4;
    }
}