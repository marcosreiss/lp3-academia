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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlunoListarForm));
            dataGridViewAlunos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlunos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAlunos
            // 
            dataGridViewAlunos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAlunos.BackgroundColor = Color.Beige;
            dataGridViewAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlunos.Location = new Point(9, 17);
            dataGridViewAlunos.Margin = new Padding(2);
            dataGridViewAlunos.Name = "dataGridViewAlunos";
            dataGridViewAlunos.RowHeadersWidth = 62;
            dataGridViewAlunos.Size = new Size(860, 400);
            dataGridViewAlunos.TabIndex = 0;
            // 
            // AlunoListarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(882, 433);
            Controls.Add(dataGridViewAlunos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "AlunoListarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Alunos";
            Load += AlunoListarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlunos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAlunos;
    }
}