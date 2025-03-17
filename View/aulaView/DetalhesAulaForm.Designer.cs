namespace lp3_academia.aulaView
{
    partial class DetalhesAulaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalhesAulaForm));
            aulaNomelbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            participantesDataGridView = new DataGridView();
            fecharDetalhesbtt = new Button();
            descricaoAulaTxt = new RichTextBox();
            nomeAulaTxt = new TextBox();
            dataFimTxt = new TextBox();
            dataInicioTxt = new TextBox();
            instrutorTxt = new TextBox();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripButton1 = new ToolStripButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)participantesDataGridView).BeginInit();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // aulaNomelbl
            // 
            aulaNomelbl.AutoSize = true;
            aulaNomelbl.Font = new Font("Segoe UI", 11F);
            aulaNomelbl.Location = new Point(22, 49);
            aulaNomelbl.Margin = new Padding(2, 0, 2, 0);
            aulaNomelbl.Name = "aulaNomelbl";
            aulaNomelbl.Size = new Size(72, 25);
            aulaNomelbl.TabIndex = 1;
            aulaNomelbl.Text = "Nome: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(22, 158);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 2;
            label1.Text = "Descrição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(364, 102);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 3;
            label2.Text = "Horário de Fim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(22, 101);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 25);
            label3.TabIndex = 4;
            label3.Text = "Horário de Início:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(364, 49);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(176, 25);
            label4.TabIndex = 5;
            label4.Text = "Nome do Instrutor: ";
            // 
            // participantesDataGridView
            // 
            participantesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            participantesDataGridView.BackgroundColor = Color.Beige;
            participantesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            participantesDataGridView.GridColor = Color.Beige;
            participantesDataGridView.Location = new Point(81, 58);
            participantesDataGridView.Name = "participantesDataGridView";
            participantesDataGridView.ReadOnly = true;
            participantesDataGridView.RowHeadersWidth = 51;
            participantesDataGridView.Size = new Size(488, 174);
            participantesDataGridView.TabIndex = 7;
            participantesDataGridView.CellContentClick += participantesDataGridView_CellContentClick;
            // 
            // fecharDetalhesbtt
            // 
            fecharDetalhesbtt.BackColor = Color.MidnightBlue;
            fecharDetalhesbtt.Font = new Font("Segoe UI", 10F);
            fecharDetalhesbtt.ForeColor = SystemColors.ButtonHighlight;
            fecharDetalhesbtt.Location = new Point(545, 570);
            fecharDetalhesbtt.Margin = new Padding(2);
            fecharDetalhesbtt.Name = "fecharDetalhesbtt";
            fecharDetalhesbtt.Size = new Size(96, 34);
            fecharDetalhesbtt.TabIndex = 10;
            fecharDetalhesbtt.Text = "Fechar";
            fecharDetalhesbtt.UseVisualStyleBackColor = false;
            fecharDetalhesbtt.Click += fecharDetalhesbtt_Click;
            // 
            // descricaoAulaTxt
            // 
            descricaoAulaTxt.Location = new Point(120, 158);
            descricaoAulaTxt.Name = "descricaoAulaTxt";
            descricaoAulaTxt.ReadOnly = true;
            descricaoAulaTxt.Size = new Size(231, 83);
            descricaoAulaTxt.TabIndex = 11;
            descricaoAulaTxt.Text = "";
            // 
            // nomeAulaTxt
            // 
            nomeAulaTxt.Location = new Point(94, 49);
            nomeAulaTxt.Name = "nomeAulaTxt";
            nomeAulaTxt.ReadOnly = true;
            nomeAulaTxt.Size = new Size(257, 27);
            nomeAulaTxt.TabIndex = 12;
            // 
            // dataFimTxt
            // 
            dataFimTxt.Location = new Point(529, 102);
            dataFimTxt.Name = "dataFimTxt";
            dataFimTxt.ReadOnly = true;
            dataFimTxt.Size = new Size(166, 27);
            dataFimTxt.TabIndex = 14;
            // 
            // dataInicioTxt
            // 
            dataInicioTxt.Location = new Point(179, 102);
            dataInicioTxt.Name = "dataInicioTxt";
            dataInicioTxt.ReadOnly = true;
            dataInicioTxt.Size = new Size(172, 27);
            dataInicioTxt.TabIndex = 15;
            // 
            // instrutorTxt
            // 
            instrutorTxt.Location = new Point(529, 50);
            instrutorTxt.Name = "instrutorTxt";
            instrutorTxt.ReadOnly = true;
            instrutorTxt.Size = new Size(166, 27);
            instrutorTxt.TabIndex = 16;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(716, 27);
            toolStrip1.TabIndex = 17;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(122, 24);
            toolStripLabel1.Text = "Detalhes da Aula";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(607, 24);
            toolStripButton1.Text = "---------------------------------------------------------------------------------------------------";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(participantesDataGridView);
            groupBox1.Font = new Font("Segoe UI", 11F);
            groupBox1.Location = new Point(66, 266);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(600, 300);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alunos Participantes:";
            // 
            // DetalhesAulaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(716, 625);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Controls.Add(instrutorTxt);
            Controls.Add(dataInicioTxt);
            Controls.Add(dataFimTxt);
            Controls.Add(nomeAulaTxt);
            Controls.Add(descricaoAulaTxt);
            Controls.Add(fecharDetalhesbtt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(aulaNomelbl);
            Name = "DetalhesAulaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalhesAulaForm";
            ((System.ComponentModel.ISupportInitialize)participantesDataGridView).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label aulaNomelbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView participantesDataGridView;
        private Button fecharDetalhesbtt;
        private RichTextBox descricaoAulaTxt;
        private TextBox nomeAulaTxt;
        private TextBox dataFimTxt;
        private TextBox dataInicioTxt;
        private TextBox instrutorTxt;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolStripLabel1;
        private GroupBox groupBox1;
    }
}