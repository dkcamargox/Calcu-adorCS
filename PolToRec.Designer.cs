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
            this.SuspendLayout();
            // 
            // partereal
            // 
            this.partereal.Location = new System.Drawing.Point(180, 121);
            this.partereal.Name = "partereal";
            this.partereal.Size = new System.Drawing.Size(154, 20);
            this.partereal.TabIndex = 0;
            // 
            // parteangular
            // 
            this.parteangular.Location = new System.Drawing.Point(201, 170);
            this.parteangular.Name = "parteangular";
            this.parteangular.Size = new System.Drawing.Size(154, 20);
            this.parteangular.TabIndex = 1;
            this.parteangular.TextChanged += new System.EventHandler(this.Parteangular_TextChanged);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(452, 117);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(154, 52);
            this.btn.TabIndex = 2;
            this.btn.Text = "Converter para a forma retangular";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite a parte real:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Digite a parte angular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(259, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parte Real:";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parte Imaginária:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // resultadoreal
            // 
            this.resultadoreal.AutoSize = true;
            this.resultadoreal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoreal.Location = new System.Drawing.Point(275, 251);
            this.resultadoreal.Name = "resultadoreal";
            this.resultadoreal.Size = new System.Drawing.Size(26, 29);
            this.resultadoreal.TabIndex = 7;
            this.resultadoreal.Text = "0";
            this.resultadoreal.Click += new System.EventHandler(this.Resultadoreal_Click);
            // 
            // resultadoimaginario
            // 
            this.resultadoimaginario.AutoSize = true;
            this.resultadoimaginario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoimaginario.Location = new System.Drawing.Point(383, 251);
            this.resultadoimaginario.Name = "resultadoimaginario";
            this.resultadoimaginario.Size = new System.Drawing.Size(32, 29);
            this.resultadoimaginario.TabIndex = 8;
            this.resultadoimaginario.Text = "j0";
            this.resultadoimaginario.Click += new System.EventHandler(this.Resultadoimaginario_Click);
            // 
            // titlePolToRec
            // 
            this.titlePolToRec.AutoSize = true;
            this.titlePolToRec.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePolToRec.Location = new System.Drawing.Point(135, 21);
            this.titlePolToRec.Name = "titlePolToRec";
            this.titlePolToRec.Size = new System.Drawing.Size(421, 36);
            this.titlePolToRec.TabIndex = 9;
            this.titlePolToRec.Text = "POLAR PARA RETANGULAR";
            // 
            // PolToRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(697, 350);
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
    }
}

