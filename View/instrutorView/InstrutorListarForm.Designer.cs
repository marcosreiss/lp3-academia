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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstrutorListarForm));
            dataGridViewInstrutor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInstrutor).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInstrutor
            // 
            dataGridViewInstrutor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewInstrutor.BackgroundColor = Color.Beige;
            dataGridViewInstrutor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInstrutor.Location = new Point(17, 21);
            dataGridViewInstrutor.Margin = new Padding(2);
            dataGridViewInstrutor.Name = "dataGridViewInstrutor";
            dataGridViewInstrutor.RowHeadersWidth = 62;
            dataGridViewInstrutor.Size = new Size(860, 400);
            dataGridViewInstrutor.TabIndex = 0;
            // 
            // InstrutorListarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(882, 433);
            Controls.Add(dataGridViewInstrutor);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "InstrutorListarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista de Instrutores";
            Load += InstrutorListarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewInstrutor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewInstrutor;
    }
}