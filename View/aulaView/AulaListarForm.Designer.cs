﻿namespace lp3_academia.aulaView
{
    partial class AulaListarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AulaListarForm));
            dataGridViewAulas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAulas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAulas
            // 
            dataGridViewAulas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAulas.Location = new Point(12, 12);
            dataGridViewAulas.Margin = new Padding(2);
            dataGridViewAulas.Name = "dataGridViewAulas";
            dataGridViewAulas.ReadOnly = true;
            dataGridViewAulas.RowHeadersWidth = 62;
            dataGridViewAulas.Size = new Size(1380, 622);
            dataGridViewAulas.TabIndex = 0;
            dataGridViewAulas.CellContentClick += dataGridViewAulas_CellContentClick;
            // 
            // AulaListarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(1048, 494);
            Controls.Add(dataGridViewAulas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "AulaListarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Aulas";
            Load += AulaListarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAulas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAulas;
    }
}