namespace lp3_academia.aulaView
{
    partial class CriarAulaForm
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
            groupBox1 = new GroupBox();
            idInstrutortxt = new TextBox();
            idInstrutorlbl = new Label();
            dtFimcmbox = new ComboBox();
            dtFimlbl = new Label();
            dtIniciocmbox = new ComboBox();
            dtIniciolbl = new Label();
            descAulatxt = new TextBox();
            aulaTipolbl = new Label();
            descAulalbl = new Label();
            nomeAulatxt = new TextBox();
            aulaNomelbl = new Label();
            cancelarAulabtt = new Button();
            salvarAulabtt = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(idInstrutortxt);
            groupBox1.Controls.Add(idInstrutorlbl);
            groupBox1.Controls.Add(dtFimcmbox);
            groupBox1.Controls.Add(dtFimlbl);
            groupBox1.Controls.Add(dtIniciocmbox);
            groupBox1.Controls.Add(dtIniciolbl);
            groupBox1.Controls.Add(descAulatxt);
            groupBox1.Controls.Add(aulaTipolbl);
            groupBox1.Controls.Add(descAulalbl);
            groupBox1.Controls.Add(nomeAulatxt);
            groupBox1.Controls.Add(aulaNomelbl);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aula";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // idInstrutortxt
            // 
            idInstrutortxt.Font = new Font("Segoe UI", 11F);
            idInstrutortxt.Location = new Point(173, 277);
            idInstrutortxt.Name = "idInstrutortxt";
            idInstrutortxt.Size = new Size(465, 37);
            idInstrutortxt.TabIndex = 11;
            idInstrutortxt.TextChanged += idInstrutortxt_TextChanged;
            // 
            // idInstrutorlbl
            // 
            idInstrutorlbl.AutoSize = true;
            idInstrutorlbl.Font = new Font("Segoe UI", 11F);
            idInstrutorlbl.Location = new Point(28, 280);
            idInstrutorlbl.Name = "idInstrutorlbl";
            idInstrutorlbl.Size = new Size(125, 30);
            idInstrutorlbl.TabIndex = 10;
            idInstrutorlbl.Text = "Id Instrutor:";
            // 
            // dtFimcmbox
            // 
            dtFimcmbox.FormattingEnabled = true;
            dtFimcmbox.Location = new Point(352, 222);
            dtFimcmbox.Name = "dtFimcmbox";
            dtFimcmbox.Size = new Size(286, 33);
            dtFimcmbox.TabIndex = 9;
            dtFimcmbox.SelectedIndexChanged += dtFimcmbox_SelectedIndexChanged;
            // 
            // dtFimlbl
            // 
            dtFimlbl.AutoSize = true;
            dtFimlbl.Font = new Font("Segoe UI", 11F);
            dtFimlbl.Location = new Point(352, 189);
            dtFimlbl.Name = "dtFimlbl";
            dtFimlbl.Size = new Size(135, 30);
            dtFimlbl.TabIndex = 8;
            dtFimlbl.Text = "Horário fim: ";
            // 
            // dtIniciocmbox
            // 
            dtIniciocmbox.FormattingEnabled = true;
            dtIniciocmbox.Location = new Point(28, 222);
            dtIniciocmbox.Name = "dtIniciocmbox";
            dtIniciocmbox.Size = new Size(272, 33);
            dtIniciocmbox.TabIndex = 7;
            dtIniciocmbox.SelectedIndexChanged += dtIniciocmbox_SelectedIndexChanged;
            // 
            // dtIniciolbl
            // 
            dtIniciolbl.AutoSize = true;
            dtIniciolbl.Font = new Font("Segoe UI", 11F);
            dtIniciolbl.Location = new Point(28, 189);
            dtIniciolbl.Name = "dtIniciolbl";
            dtIniciolbl.Size = new Size(154, 30);
            dtIniciolbl.TabIndex = 6;
            dtIniciolbl.Text = "Horário início: ";
            // 
            // descAulatxt
            // 
            descAulatxt.Font = new Font("Segoe UI", 11F);
            descAulatxt.Location = new Point(142, 134);
            descAulatxt.Name = "descAulatxt";
            descAulatxt.Size = new Size(496, 37);
            descAulatxt.TabIndex = 5;
            descAulatxt.TextChanged += descAulatxt_TextChanged;
            // 
            // aulaTipolbl
            // 
            aulaTipolbl.AutoSize = true;
            aulaTipolbl.Font = new Font("Segoe UI", 11F);
            aulaTipolbl.Location = new Point(28, 134);
            aulaTipolbl.Name = "aulaTipolbl";
            aulaTipolbl.Size = new Size(0, 30);
            aulaTipolbl.TabIndex = 4;
            // 
            // descAulalbl
            // 
            descAulalbl.AutoSize = true;
            descAulalbl.Font = new Font("Segoe UI", 11F);
            descAulalbl.Location = new Point(28, 134);
            descAulalbl.Name = "descAulalbl";
            descAulalbl.Size = new Size(117, 30);
            descAulalbl.TabIndex = 2;
            descAulalbl.Text = "Descrição: ";
            // 
            // nomeAulatxt
            // 
            nomeAulatxt.Font = new Font("Segoe UI", 11F);
            nomeAulatxt.Location = new Point(142, 61);
            nomeAulatxt.Name = "nomeAulatxt";
            nomeAulatxt.Size = new Size(496, 37);
            nomeAulatxt.TabIndex = 1;
            nomeAulatxt.TextChanged += nomeAulatxt_TextChanged;
            // 
            // aulaNomelbl
            // 
            aulaNomelbl.AutoSize = true;
            aulaNomelbl.Font = new Font("Segoe UI", 11F);
            aulaNomelbl.Location = new Point(28, 61);
            aulaNomelbl.Name = "aulaNomelbl";
            aulaNomelbl.Size = new Size(84, 30);
            aulaNomelbl.TabIndex = 0;
            aulaNomelbl.Text = "Nome: ";
            // 
            // cancelarAulabtt
            // 
            cancelarAulabtt.BackColor = Color.MidnightBlue;
            cancelarAulabtt.Font = new Font("Segoe UI", 10F);
            cancelarAulabtt.ForeColor = SystemColors.ButtonHighlight;
            cancelarAulabtt.Location = new Point(477, 380);
            cancelarAulabtt.Name = "cancelarAulabtt";
            cancelarAulabtt.Size = new Size(120, 42);
            cancelarAulabtt.TabIndex = 8;
            cancelarAulabtt.Text = "Cancelar";
            cancelarAulabtt.UseVisualStyleBackColor = false;
            // 
            // salvarAulabtt
            // 
            salvarAulabtt.BackColor = Color.MidnightBlue;
            salvarAulabtt.Font = new Font("Segoe UI", 10F);
            salvarAulabtt.ForeColor = SystemColors.ButtonHighlight;
            salvarAulabtt.Location = new Point(620, 380);
            salvarAulabtt.Name = "salvarAulabtt";
            salvarAulabtt.Size = new Size(120, 42);
            salvarAulabtt.TabIndex = 9;
            salvarAulabtt.Text = "Salvar";
            salvarAulabtt.UseVisualStyleBackColor = false;
            salvarAulabtt.Click += salvarAulabtt_Click;
            // 
            // CriarAulaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(783, 450);
            Controls.Add(salvarAulabtt);
            Controls.Add(cancelarAulabtt);
            Controls.Add(groupBox1);
            Name = "CriarAulaForm";
            Text = "Criar Aula";
            Load += CriarAulaForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label descAulalbl;
        private TextBox nomeAulatxt;
        private Label aulaNomelbl;
        private TextBox descAulatxt;
        private Label aulaTipolbl;
        private ComboBox dtFimcmbox;
        private Label dtFimlbl;
        private ComboBox dtIniciocmbox;
        private Label dtIniciolbl;
        private TextBox idInstrutortxt;
        private Label idInstrutorlbl;
        private Button cancelarAulabtt;
        private Button salvarAulabtt;
    }
}