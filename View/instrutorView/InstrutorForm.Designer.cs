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
            cancelarInstrutorbtt = new Button();
            salvarInstrutorbtt = new Button();
            especialidadeInstrutortxt = new TextBox();
            especInstrutorlbl = new Label();
            cpfInstrutortxt = new TextBox();
            cpfInstrutorlbl = new Label();
            nomeInstrutortxt = new TextBox();
            nomeInstrutorlbl = new Label();
            label1 = new Label();
            contratacaoInstrutordateTime = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cancelarInstrutorbtt
            // 
            cancelarInstrutorbtt.BackColor = Color.MidnightBlue;
            cancelarInstrutorbtt.Font = new Font("Segoe UI", 10F);
            cancelarInstrutorbtt.ForeColor = SystemColors.ButtonHighlight;
            cancelarInstrutorbtt.Location = new Point(347, 410);
            cancelarInstrutorbtt.Name = "cancelarInstrutorbtt";
            cancelarInstrutorbtt.Size = new Size(119, 41);
            cancelarInstrutorbtt.TabIndex = 15;
            cancelarInstrutorbtt.Text = "Cancelar";
            cancelarInstrutorbtt.UseVisualStyleBackColor = false;
            cancelarInstrutorbtt.Click += cancelarInstrutorbtt_Click;
            // 
            // salvarInstrutorbtt
            // 
            salvarInstrutorbtt.BackColor = Color.MidnightBlue;
            salvarInstrutorbtt.Font = new Font("Segoe UI", 10F);
            salvarInstrutorbtt.ForeColor = SystemColors.ButtonHighlight;
            salvarInstrutorbtt.Location = new Point(501, 410);
            salvarInstrutorbtt.Name = "salvarInstrutorbtt";
            salvarInstrutorbtt.Size = new Size(120, 41);
            salvarInstrutorbtt.TabIndex = 14;
            salvarInstrutorbtt.Text = "Salvar";
            salvarInstrutorbtt.UseVisualStyleBackColor = false;
            salvarInstrutorbtt.Click += salvarInstrutorbtt_Click;
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
            groupBox1.Location = new Point(23, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 389);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Instrutor";
            // 
            // InstrutorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(657, 474);
            Controls.Add(groupBox1);
            Controls.Add(cancelarInstrutorbtt);
            Controls.Add(salvarInstrutorbtt);
            Name = "InstrutorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Instrutor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button cancelarInstrutorbtt;
        private Button salvarInstrutorbtt;
        private TextBox especialidadeInstrutortxt;
        private Label especInstrutorlbl;
        private TextBox cpfInstrutortxt;
        private Label cpfInstrutorlbl;
        private TextBox nomeInstrutortxt;
        private Label nomeInstrutorlbl;
        private Label label1;
        private DateTimePicker contratacaoInstrutordateTime;
        private GroupBox groupBox1;
    }
}