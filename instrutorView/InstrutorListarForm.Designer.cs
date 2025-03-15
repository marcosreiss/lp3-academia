namespace lp3_academia.instrutorView
{
    partial class InstrutorListarForm
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
            dataGridViewInstrutor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInstrutor).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInstrutor
            // 
            dataGridViewInstrutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInstrutor.Location = new Point(12, 12);
            dataGridViewInstrutor.Name = "dataGridViewInstrutor";
            dataGridViewInstrutor.RowHeadersWidth = 62;
            dataGridViewInstrutor.Size = new Size(776, 426);
            dataGridViewInstrutor.TabIndex = 0;
            // 
            // InstrutorListarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewInstrutor);
            Name = "InstrutorListarForm";
            Text = "Lista de Instrutores";
            Load += InstrutorListar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInstrutor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewInstrutor;
    }
}