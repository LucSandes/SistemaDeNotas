﻿namespace SistemaDeNotas.Aluno
{
    partial class telaMenuAluno
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
            this.botaoMedia = new System.Windows.Forms.Button();
            this.comboCursos = new System.Windows.Forms.ComboBox();
            this.botaoPesquisarCurso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoPesquisarProfessor = new System.Windows.Forms.Button();
            this.comboProfessores = new System.Windows.Forms.ComboBox();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoMedia
            // 
            this.botaoMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMedia.Location = new System.Drawing.Point(461, 5);
            this.botaoMedia.Name = "botaoMedia";
            this.botaoMedia.Size = new System.Drawing.Size(75, 51);
            this.botaoMedia.TabIndex = 2;
            this.botaoMedia.Text = "Calcular Média";
            this.botaoMedia.UseVisualStyleBackColor = true;
            this.botaoMedia.Click += new System.EventHandler(this.BotaoMedia_Click);
            // 
            // comboCursos
            // 
            this.comboCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCursos.ForeColor = System.Drawing.Color.Black;
            this.comboCursos.FormattingEnabled = true;
            this.comboCursos.Location = new System.Drawing.Point(63, 61);
            this.comboCursos.Name = "comboCursos";
            this.comboCursos.Size = new System.Drawing.Size(307, 21);
            this.comboCursos.TabIndex = 3;
            this.comboCursos.SelectedIndexChanged += new System.EventHandler(this.ComboCursos_SelectedIndexChanged);
            // 
            // botaoPesquisarCurso
            // 
            this.botaoPesquisarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisarCurso.Location = new System.Drawing.Point(376, 61);
            this.botaoPesquisarCurso.Name = "botaoPesquisarCurso";
            this.botaoPesquisarCurso.Size = new System.Drawing.Size(75, 23);
            this.botaoPesquisarCurso.TabIndex = 4;
            this.botaoPesquisarCurso.Text = "Pesquisar Curso";
            this.botaoPesquisarCurso.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cursos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Professores:";
            // 
            // botaoPesquisarProfessor
            // 
            this.botaoPesquisarProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisarProfessor.Location = new System.Drawing.Point(376, 107);
            this.botaoPesquisarProfessor.Name = "botaoPesquisarProfessor";
            this.botaoPesquisarProfessor.Size = new System.Drawing.Size(75, 23);
            this.botaoPesquisarProfessor.TabIndex = 7;
            this.botaoPesquisarProfessor.Text = "Pesquisar Curso";
            this.botaoPesquisarProfessor.UseVisualStyleBackColor = true;
            // 
            // comboProfessores
            // 
            this.comboProfessores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProfessores.ForeColor = System.Drawing.Color.Black;
            this.comboProfessores.FormattingEnabled = true;
            this.comboProfessores.Location = new System.Drawing.Point(94, 107);
            this.comboProfessores.Name = "comboProfessores";
            this.comboProfessores.Size = new System.Drawing.Size(276, 21);
            this.comboProfessores.TabIndex = 6;
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.Location = new System.Drawing.Point(14, 156);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(75, 23);
            this.botaoVoltar.TabIndex = 63;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 24);
            this.label3.TabIndex = 64;
            this.label3.Text = "Pesquisar Curso ou Professor:";
            // 
            // telaMenuAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(541, 191);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botaoPesquisarProfessor);
            this.Controls.Add(this.comboProfessores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoPesquisarCurso);
            this.Controls.Add(this.comboCursos);
            this.Controls.Add(this.botaoMedia);
            this.Name = "telaMenuAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaMenuAluno";
            this.Load += new System.EventHandler(this.TelaMenuAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoMedia;
        private System.Windows.Forms.ComboBox comboCursos;
        private System.Windows.Forms.Button botaoPesquisarCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoPesquisarProfessor;
        private System.Windows.Forms.ComboBox comboProfessores;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Label label3;
    }
}