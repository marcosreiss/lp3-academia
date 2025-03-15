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
            SuspendLayout();
            // 
            // cancelarInstrutorbtt
            // 
            cancelarInstrutorbtt.BackColor = Color.MidnightBlue;
            cancelarInstrutorbtt.Font = new Font("Segoe UI", 10F);
            cancelarInstrutorbtt.ForeColor = SystemColors.ButtonHighlight;
            cancelarInstrutorbtt.Location = new Point(311, 374);
            cancelarInstrutorbtt.Name = "cancelarInstrutorbtt";
            cancelarInstrutorbtt.Size = new Size(119, 41);
            cancelarInstrutorbtt.TabIndex = 15;
            cancelarInstrutorbtt.Text = "Cancelar";
            cancelarInstrutorbtt.UseVisualStyleBackColor = false;
            // 
            // salvarInstrutorbtt
            // 
            salvarInstrutorbtt.BackColor = Color.MidnightBlue;
            salvarInstrutorbtt.Font = new Font("Segoe UI", 10F);
            salvarInstrutorbtt.ForeColor = SystemColors.ButtonHighlight;
            salvarInstrutorbtt.Location = new Point(458, 374);
            salvarInstrutorbtt.Name = "salvarInstrutorbtt";
            salvarInstrutorbtt.Size = new Size(120, 41);
            salvarInstrutorbtt.TabIndex = 14;
            salvarInstrutorbtt.Text = "Salvar";
            salvarInstrutorbtt.UseVisualStyleBackColor = false;
            salvarInstrutorbtt.Click += salvarIntrutorbtt_Click;
            // 
            // especialidadeInstrutortxt
            // 
            especialidadeInstrutortxt.Font = new Font("Segoe UI", 11F);
            especialidadeInstrutortxt.Location = new Point(35, 212);
            especialidadeInstrutortxt.Name = "especialidadeInstrutortxt";
            especialidadeInstrutortxt.Size = new Size(503, 37);
            especialidadeInstrutortxt.TabIndex = 13;
            especialidadeInstrutortxt.TextChanged += especialidadeInstrutortxt_TextChanged;
            // 
            // especInstrutorlbl
            // 
            especInstrutorlbl.AutoSize = true;
            especInstrutorlbl.Font = new Font("Segoe UI", 11F);
            especInstrutorlbl.Location = new Point(35, 166);
            especInstrutorlbl.Name = "especInstrutorlbl";
            especInstrutorlbl.Size = new Size(148, 30);
            especInstrutorlbl.TabIndex = 12;
            especInstrutorlbl.Text = "Especialidade:";
            // 
            // cpfInstrutortxt
            // 
            cpfInstrutortxt.Font = new Font("Segoe UI", 11F);
            cpfInstrutortxt.Location = new Point(119, 107);
            cpfInstrutortxt.Name = "cpfInstrutortxt";
            cpfInstrutortxt.Size = new Size(419, 37);
            cpfInstrutortxt.TabIndex = 11;
            cpfInstrutortxt.TextChanged += cpfInstrutortxt_TextChanged;
            // 
            // cpfInstrutorlbl
            // 
            cpfInstrutorlbl.AutoSize = true;
            cpfInstrutorlbl.Font = new Font("Segoe UI", 11F);
            cpfInstrutorlbl.Location = new Point(35, 110);
            cpfInstrutorlbl.Name = "cpfInstrutorlbl";
            cpfInstrutorlbl.Size = new Size(55, 30);
            cpfInstrutorlbl.TabIndex = 10;
            cpfInstrutorlbl.Text = "CPF:";
            // 
            // nomeInstrutortxt
            // 
            nomeInstrutortxt.Font = new Font("Segoe UI", 11F);
            nomeInstrutortxt.Location = new Point(119, 35);
            nomeInstrutortxt.Name = "nomeInstrutortxt";
            nomeInstrutortxt.Size = new Size(419, 37);
            nomeInstrutortxt.TabIndex = 9;
            nomeInstrutortxt.TextChanged += nomeInstrutortxt_TextChanged;
            // 
            // nomeInstrutorlbl
            // 
            nomeInstrutorlbl.AutoSize = true;
            nomeInstrutorlbl.Font = new Font("Segoe UI", 11F);
            nomeInstrutorlbl.Location = new Point(35, 35);
            nomeInstrutorlbl.Name = "nomeInstrutorlbl";
            nomeInstrutorlbl.Size = new Size(78, 30);
            nomeInstrutorlbl.TabIndex = 8;
            nomeInstrutorlbl.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(35, 287);
            label1.Name = "label1";
            label1.Size = new Size(185, 30);
            label1.TabIndex = 16;
            label1.Text = "Data Contratação:";
            label1.Click += label1_Click;
            // 
            // contratacaoInstrutordateTime
            // 
            contratacaoInstrutordateTime.Location = new Point(238, 287);
            contratacaoInstrutordateTime.Name = "contratacaoInstrutordateTime";
            contratacaoInstrutordateTime.Size = new Size(300, 31);
            contratacaoInstrutordateTime.TabIndex = 17;
            contratacaoInstrutordateTime.ValueChanged += contratacaoInstrutordateTime_ValueChanged;
            // 
            // InstrutorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(621, 450);
            Controls.Add(contratacaoInstrutordateTime);
            Controls.Add(label1);
            Controls.Add(cancelarInstrutorbtt);
            Controls.Add(salvarInstrutorbtt);
            Controls.Add(especialidadeInstrutortxt);
            Controls.Add(especInstrutorlbl);
            Controls.Add(cpfInstrutortxt);
            Controls.Add(cpfInstrutorlbl);
            Controls.Add(nomeInstrutortxt);
            Controls.Add(nomeInstrutorlbl);
            Name = "InstrutorForm";
            Text = "Cadastro Instrutor";
            ResumeLayout(false);
            PerformLayout();
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
    }
}