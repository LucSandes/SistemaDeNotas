﻿namespace SistemaDeNotas
{
    partial class telaMedia
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
            this.textoNota1 = new System.Windows.Forms.TextBox();
            this.textoNota2 = new System.Windows.Forms.TextBox();
            this.textoNota3 = new System.Windows.Forms.TextBox();
            this.textoNota4 = new System.Windows.Forms.TextBox();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoMedia = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.textoMaior = new System.Windows.Forms.TextBox();
            this.textoMenor = new System.Windows.Forms.TextBox();
            this.textoMedia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoNota1
            // 
            this.textoNota1.ForeColor = System.Drawing.Color.Black;
            this.textoNota1.Location = new System.Drawing.Point(109, 16);
            this.textoNota1.Name = "textoNota1";
            this.textoNota1.Size = new System.Drawing.Size(100, 20);
            this.textoNota1.TabIndex = 0;
            // 
            // textoNota2
            // 
            this.textoNota2.ForeColor = System.Drawing.Color.Black;
            this.textoNota2.Location = new System.Drawing.Point(109, 51);
            this.textoNota2.Name = "textoNota2";
            this.textoNota2.Size = new System.Drawing.Size(100, 20);
            this.textoNota2.TabIndex = 1;
            // 
            // textoNota3
            // 
            this.textoNota3.ForeColor = System.Drawing.Color.Black;
            this.textoNota3.Location = new System.Drawing.Point(109, 88);
            this.textoNota3.Name = "textoNota3";
            this.textoNota3.Size = new System.Drawing.Size(100, 20);
            this.textoNota3.TabIndex = 2;
            // 
            // textoNota4
            // 
            this.textoNota4.ForeColor = System.Drawing.Color.Black;
            this.textoNota4.Location = new System.Drawing.Point(109, 124);
            this.textoNota4.Name = "textoNota4";
            this.textoNota4.Size = new System.Drawing.Size(100, 20);
            this.textoNota4.TabIndex = 3;
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.botaoVoltar.Location = new System.Drawing.Point(198, 12);
=======
            this.botaoVoltar.Location = new System.Drawing.Point(13, 13);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(75, 23);
            this.botaoVoltar.TabIndex = 4;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.BotaoVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prova 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prova 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Atividade 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Atividade 2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textoNota4);
            this.groupBox1.Controls.Add(this.textoNota3);
            this.groupBox1.Controls.Add(this.textoNota2);
            this.groupBox1.Controls.Add(this.textoNota1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.groupBox1.Location = new System.Drawing.Point(198, 54);
=======
            this.groupBox1.Location = new System.Drawing.Point(13, 55);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 159);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notas";
            // 
            // botaoMedia
            // 
            this.botaoMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMedia.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.botaoMedia.Location = new System.Drawing.Point(445, 102);
=======
            this.botaoMedia.Location = new System.Drawing.Point(260, 103);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.botaoMedia.Name = "botaoMedia";
            this.botaoMedia.Size = new System.Drawing.Size(75, 23);
            this.botaoMedia.TabIndex = 10;
            this.botaoMedia.Text = "Calcular";
            this.botaoMedia.UseVisualStyleBackColor = true;
            this.botaoMedia.Click += new System.EventHandler(this.BotaoMedia_Click);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLimpar.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.botaoLimpar.Location = new System.Drawing.Point(445, 139);
=======
            this.botaoLimpar.Location = new System.Drawing.Point(260, 140);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(75, 23);
            this.botaoLimpar.TabIndex = 11;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textoMaior
            // 
            this.textoMaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoMaior.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.textoMaior.Location = new System.Drawing.Point(544, 70);
=======
            this.textoMaior.Location = new System.Drawing.Point(359, 71);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.textoMaior.Name = "textoMaior";
            this.textoMaior.Size = new System.Drawing.Size(100, 20);
            this.textoMaior.TabIndex = 9;
            // 
            // textoMenor
            // 
            this.textoMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoMenor.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.textoMenor.Location = new System.Drawing.Point(544, 119);
=======
            this.textoMenor.Location = new System.Drawing.Point(359, 120);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.textoMenor.Name = "textoMenor";
            this.textoMenor.Size = new System.Drawing.Size(100, 20);
            this.textoMenor.TabIndex = 12;
            // 
            // textoMedia
            // 
            this.textoMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoMedia.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.textoMedia.Location = new System.Drawing.Point(544, 165);
=======
            this.textoMedia.Location = new System.Drawing.Point(359, 166);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.textoMedia.Name = "textoMedia";
            this.textoMedia.Size = new System.Drawing.Size(100, 20);
            this.textoMedia.TabIndex = 13;
            this.textoMedia.TextChanged += new System.EventHandler(this.TextoMedia_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(541, 54);
=======
            this.label3.Location = new System.Drawing.Point(356, 55);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Maior Nota:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.label6.Location = new System.Drawing.Point(541, 102);
=======
            this.label6.Location = new System.Drawing.Point(356, 103);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Menor Nota:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
<<<<<<< HEAD
            this.label7.Location = new System.Drawing.Point(541, 149);
=======
            this.label7.Location = new System.Drawing.Point(356, 150);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Média:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.label8.Location = new System.Drawing.Point(329, 12);
=======
            this.label8.Location = new System.Drawing.Point(144, 13);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Calcule sua nota:";
            // 
            // telaMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(882, 497);
=======
            this.ClientSize = new System.Drawing.Size(471, 238);
>>>>>>> 00974347022be3184679fc2b3cf6a3ff03e7937d
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoMedia);
            this.Controls.Add(this.textoMenor);
            this.Controls.Add(this.textoMaior);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.botaoMedia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botaoVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "telaMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Média";
            this.Load += new System.EventHandler(this.TelaMedia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoNota1;
        private System.Windows.Forms.TextBox textoNota2;
        private System.Windows.Forms.TextBox textoNota3;
        private System.Windows.Forms.TextBox textoNota4;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoMedia;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.TextBox textoMaior;
        private System.Windows.Forms.TextBox textoMenor;
        private System.Windows.Forms.TextBox textoMedia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}