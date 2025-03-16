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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarAulaForm));
            groupBox1 = new GroupBox();
            participantesclb = new CheckedListBox();
            label1 = new Label();
            instrutorcmb = new ComboBox();
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
            toolStrip1 = new ToolStrip();
            salvarAulaTsp = new ToolStripButton();
            cancelarAulaTsp = new ToolStripButton();
            groupBox1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(participantesclb);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(instrutorcmb);
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
            groupBox1.Location = new Point(37, 60);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(676, 537);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aula";
            // 
            // participantesclb
            // 
            participantesclb.FormattingEnabled = true;
            participantesclb.Location = new Point(282, 360);
            participantesclb.Margin = new Padding(4);
            participantesclb.Name = "participantesclb";
            participantesclb.Size = new Size(230, 144);
            participantesclb.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(28, 360);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 30);
            label1.TabIndex = 12;
            label1.Text = "Alunos Participantes:";
            // 
            // instrutorcmb
            // 
            instrutorcmb.FormattingEnabled = true;
            instrutorcmb.Location = new Point(190, 281);
            instrutorcmb.Margin = new Padding(4);
            instrutorcmb.Name = "instrutorcmb";
            instrutorcmb.Size = new Size(188, 33);
            instrutorcmb.TabIndex = 11;
            // 
            // idInstrutorlbl
            // 
            idInstrutorlbl.AutoSize = true;
            idInstrutorlbl.Font = new Font("Segoe UI", 11F);
            idInstrutorlbl.Location = new Point(28, 280);
            idInstrutorlbl.Margin = new Padding(2, 0, 2, 0);
            idInstrutorlbl.Name = "idInstrutorlbl";
            idInstrutorlbl.Size = new Size(100, 30);
            idInstrutorlbl.TabIndex = 10;
            idInstrutorlbl.Text = "Instrutor:";
            // 
            // dtFimcmbox
            // 
            dtFimcmbox.FormattingEnabled = true;
            dtFimcmbox.Location = new Point(352, 222);
            dtFimcmbox.Margin = new Padding(2);
            dtFimcmbox.Name = "dtFimcmbox";
            dtFimcmbox.Size = new Size(286, 33);
            dtFimcmbox.TabIndex = 9;
            // 
            // dtFimlbl
            // 
            dtFimlbl.AutoSize = true;
            dtFimlbl.Font = new Font("Segoe UI", 11F);
            dtFimlbl.Location = new Point(352, 189);
            dtFimlbl.Margin = new Padding(2, 0, 2, 0);
            dtFimlbl.Name = "dtFimlbl";
            dtFimlbl.Size = new Size(135, 30);
            dtFimlbl.TabIndex = 8;
            dtFimlbl.Text = "Horário fim: ";
            // 
            // dtIniciocmbox
            // 
            dtIniciocmbox.FormattingEnabled = true;
            dtIniciocmbox.Location = new Point(28, 222);
            dtIniciocmbox.Margin = new Padding(2);
            dtIniciocmbox.Name = "dtIniciocmbox";
            dtIniciocmbox.Size = new Size(272, 33);
            dtIniciocmbox.TabIndex = 7;
            // 
            // dtIniciolbl
            // 
            dtIniciolbl.AutoSize = true;
            dtIniciolbl.Font = new Font("Segoe UI", 11F);
            dtIniciolbl.Location = new Point(28, 189);
            dtIniciolbl.Margin = new Padding(2, 0, 2, 0);
            dtIniciolbl.Name = "dtIniciolbl";
            dtIniciolbl.Size = new Size(154, 30);
            dtIniciolbl.TabIndex = 6;
            dtIniciolbl.Text = "Horário início: ";
            // 
            // descAulatxt
            // 
            descAulatxt.Font = new Font("Segoe UI", 11F);
            descAulatxt.Location = new Point(142, 134);
            descAulatxt.Margin = new Padding(2);
            descAulatxt.Name = "descAulatxt";
            descAulatxt.Size = new Size(496, 37);
            descAulatxt.TabIndex = 5;
            // 
            // aulaTipolbl
            // 
            aulaTipolbl.AutoSize = true;
            aulaTipolbl.Font = new Font("Segoe UI", 11F);
            aulaTipolbl.Location = new Point(28, 134);
            aulaTipolbl.Margin = new Padding(2, 0, 2, 0);
            aulaTipolbl.Name = "aulaTipolbl";
            aulaTipolbl.Size = new Size(0, 30);
            aulaTipolbl.TabIndex = 4;
            // 
            // descAulalbl
            // 
            descAulalbl.AutoSize = true;
            descAulalbl.Font = new Font("Segoe UI", 11F);
            descAulalbl.Location = new Point(28, 134);
            descAulalbl.Margin = new Padding(2, 0, 2, 0);
            descAulalbl.Name = "descAulalbl";
            descAulalbl.Size = new Size(117, 30);
            descAulalbl.TabIndex = 2;
            descAulalbl.Text = "Descrição: ";
            // 
            // nomeAulatxt
            // 
            nomeAulatxt.Font = new Font("Segoe UI", 11F);
            nomeAulatxt.Location = new Point(142, 61);
            nomeAulatxt.Margin = new Padding(2);
            nomeAulatxt.Name = "nomeAulatxt";
            nomeAulatxt.Size = new Size(496, 37);
            nomeAulatxt.TabIndex = 1;
            // 
            // aulaNomelbl
            // 
            aulaNomelbl.AutoSize = true;
            aulaNomelbl.Font = new Font("Segoe UI", 11F);
            aulaNomelbl.Location = new Point(28, 61);
            aulaNomelbl.Margin = new Padding(2, 0, 2, 0);
            aulaNomelbl.Name = "aulaNomelbl";
            aulaNomelbl.Size = new Size(84, 30);
            aulaNomelbl.TabIndex = 0;
            aulaNomelbl.Text = "Nome: ";
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.DarkBlue;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { salvarAulaTsp, cancelarAulaTsp });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(758, 37);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip1";
            // 
            // salvarAulaTsp
            // 
            salvarAulaTsp.Alignment = ToolStripItemAlignment.Right;
            salvarAulaTsp.Font = new Font("Segoe UI", 10F);
            salvarAulaTsp.ForeColor = SystemColors.ButtonHighlight;
            salvarAulaTsp.Image = (Image)resources.GetObject("salvarAulaTsp.Image");
            salvarAulaTsp.ImageTransparentColor = Color.Magenta;
            salvarAulaTsp.Name = "salvarAulaTsp";
            salvarAulaTsp.Size = new Size(93, 32);
            salvarAulaTsp.Text = "Salvar";
            salvarAulaTsp.Click += salvarAulaTsp_Click;
            // 
            // cancelarAulaTsp
            // 
            cancelarAulaTsp.Alignment = ToolStripItemAlignment.Right;
            cancelarAulaTsp.Font = new Font("Segoe UI", 10F);
            cancelarAulaTsp.ForeColor = SystemColors.ButtonHighlight;
            cancelarAulaTsp.Image = (Image)resources.GetObject("cancelarAulaTsp.Image");
            cancelarAulaTsp.ImageTransparentColor = Color.Magenta;
            cancelarAulaTsp.Name = "cancelarAulaTsp";
            cancelarAulaTsp.RightToLeft = RightToLeft.No;
            cancelarAulaTsp.Size = new Size(114, 32);
            cancelarAulaTsp.Text = "Cancelar";
            cancelarAulaTsp.Click += cancelarAulaTsp_Click;
            // 
            // CriarAulaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(758, 648);
            Controls.Add(toolStrip1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "CriarAulaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Criar Aula";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label idInstrutorlbl;
        private CheckedListBox participantesclb;
        private Label label1;
        private ComboBox instrutorcmb;
        private ToolStrip toolStrip1;
        private ToolStripButton salvarAulaTsp;
        private ToolStripButton cancelarAulaTsp;
    }
}