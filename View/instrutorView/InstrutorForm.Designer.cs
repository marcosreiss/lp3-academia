namespace lp3_academia
{
    partial class InstrutorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstrutorForm));
            especialidadeInstrutortxt = new TextBox();
            especInstrutorlbl = new Label();
            cpfInstrutortxt = new TextBox();
            cpfInstrutorlbl = new Label();
            nomeInstrutortxt = new TextBox();
            nomeInstrutorlbl = new Label();
            label1 = new Label();
            contratacaoInstrutordateTime = new DateTimePicker();
            groupBox1 = new GroupBox();
            toolStrip1 = new ToolStrip();
            salvarInstrutorTsp = new ToolStripButton();
            cancelarInstrutorTsp = new ToolStripButton();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // especialidadeInstrutortxt
            // 
            especialidadeInstrutortxt.Font = new Font("Segoe UI", 11F);
            especialidadeInstrutortxt.Location = new Point(30, 214);
            especialidadeInstrutortxt.Name = "especialidadeInstrutortxt";
            especialidadeInstrutortxt.Size = new Size(540, 37);
            especialidadeInstrutortxt.TabIndex = 13;
            // 
            // especInstrutorlbl
            // 
            especInstrutorlbl.AutoSize = true;
            especInstrutorlbl.Font = new Font("Segoe UI", 11F);
            especInstrutorlbl.Location = new Point(23, 168);
            especInstrutorlbl.Name = "especInstrutorlbl";
            especInstrutorlbl.Size = new Size(148, 30);
            especInstrutorlbl.TabIndex = 12;
            especInstrutorlbl.Text = "Especialidade:";
            // 
            // cpfInstrutortxt
            // 
            cpfInstrutortxt.Font = new Font("Segoe UI", 11F);
            cpfInstrutortxt.Location = new Point(124, 112);
            cpfInstrutortxt.Name = "cpfInstrutortxt";
            cpfInstrutortxt.Size = new Size(446, 37);
            cpfInstrutortxt.TabIndex = 11;
            // 
            // cpfInstrutorlbl
            // 
            cpfInstrutorlbl.AutoSize = true;
            cpfInstrutorlbl.Font = new Font("Segoe UI", 11F);
            cpfInstrutorlbl.Location = new Point(23, 112);
            cpfInstrutorlbl.Name = "cpfInstrutorlbl";
            cpfInstrutorlbl.Size = new Size(55, 30);
            cpfInstrutorlbl.TabIndex = 10;
            cpfInstrutorlbl.Text = "CPF:";
            // 
            // nomeInstrutortxt
            // 
            nomeInstrutortxt.Font = new Font("Segoe UI", 11F);
            nomeInstrutortxt.Location = new Point(124, 51);
            nomeInstrutortxt.Name = "nomeInstrutortxt";
            nomeInstrutortxt.Size = new Size(446, 37);
            nomeInstrutortxt.TabIndex = 9;
            // 
            // nomeInstrutorlbl
            // 
            nomeInstrutorlbl.AutoSize = true;
            nomeInstrutorlbl.Font = new Font("Segoe UI", 11F);
            nomeInstrutorlbl.Location = new Point(23, 51);
            nomeInstrutorlbl.Name = "nomeInstrutorlbl";
            nomeInstrutorlbl.Size = new Size(78, 30);
            nomeInstrutorlbl.TabIndex = 8;
            nomeInstrutorlbl.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(23, 285);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 16;
            label1.Text = "Data Contratação:";
            // 
            // contratacaoInstrutordateTime
            // 
            contratacaoInstrutordateTime.Location = new Point(242, 284);
            contratacaoInstrutordateTime.Name = "contratacaoInstrutordateTime";
            contratacaoInstrutordateTime.Size = new Size(300, 31);
            contratacaoInstrutordateTime.TabIndex = 17;
            contratacaoInstrutordateTime.ValueChanged += contratacaoInstrutordateTime_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nomeInstrutortxt);
            groupBox1.Controls.Add(contratacaoInstrutordateTime);
            groupBox1.Controls.Add(nomeInstrutorlbl);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cpfInstrutorlbl);
            groupBox1.Controls.Add(cpfInstrutortxt);
            groupBox1.Controls.Add(especInstrutorlbl);
            groupBox1.Controls.Add(especialidadeInstrutortxt);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 389);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Instrutor";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.DarkBlue;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { salvarInstrutorTsp, cancelarInstrutorTsp });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(657, 37);
            toolStrip1.TabIndex = 19;
            toolStrip1.Text = "toolStrip1";
            // 
            // salvarInstrutorTsp
            // 
            salvarInstrutorTsp.Alignment = ToolStripItemAlignment.Right;
            salvarInstrutorTsp.Font = new Font("Segoe UI", 10F);
            salvarInstrutorTsp.ForeColor = SystemColors.ButtonHighlight;
            salvarInstrutorTsp.Image = (Image)resources.GetObject("salvarInstrutorTsp.Image");
            salvarInstrutorTsp.ImageTransparentColor = Color.Magenta;
            salvarInstrutorTsp.Name = "salvarInstrutorTsp";
            salvarInstrutorTsp.Size = new Size(93, 32);
            salvarInstrutorTsp.Text = "Salvar";
            salvarInstrutorTsp.ToolTipText = "Salvar";
            salvarInstrutorTsp.Click += salvarInstrutorTsp_Click;
            // 
            // cancelarInstrutorTsp
            // 
            cancelarInstrutorTsp.Alignment = ToolStripItemAlignment.Right;
            cancelarInstrutorTsp.Font = new Font("Segoe UI", 10F);
            cancelarInstrutorTsp.ForeColor = SystemColors.ButtonHighlight;
            cancelarInstrutorTsp.Image = (Image)resources.GetObject("cancelarInstrutorTsp.Image");
            cancelarInstrutorTsp.ImageTransparentColor = Color.Magenta;
            cancelarInstrutorTsp.Name = "cancelarInstrutorTsp";
            cancelarInstrutorTsp.Size = new Size(114, 32);
            cancelarInstrutorTsp.Text = "Cancelar";
            cancelarInstrutorTsp.Click += cancelarInstrutorTsp_Click;
            // 
            // InstrutorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(657, 474);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Name = "InstrutorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Instrutor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox especialidadeInstrutortxt;
        private Label especInstrutorlbl;
        private TextBox cpfInstrutortxt;
        private Label cpfInstrutorlbl;
        private TextBox nomeInstrutortxt;
        private Label nomeInstrutorlbl;
        private Label label1;
        private DateTimePicker contratacaoInstrutordateTime;
        private GroupBox groupBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton cancelarInstrutorTsp;
        private ToolStripButton salvarInstrutorTsp;
    }
}