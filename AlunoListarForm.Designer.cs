﻿namespace lp3_academia
{
    partial class AlunoListarForm
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
            dataGridViewAlunos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlunos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAlunos
            // 
            dataGridViewAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlunos.Location = new Point(12, 12);
            dataGridViewAlunos.Name = "dataGridViewAlunos";
            dataGridViewAlunos.RowHeadersWidth = 62;
            dataGridViewAlunos.Size = new Size(787, 438);
            dataGridViewAlunos.TabIndex = 0;
            // 
            // AlunoListarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewAlunos);
            Name = "AlunoListarForm";
            Text = "AlunoListarForm";
            Load += AlunoListarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlunos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAlunos;
    }
}