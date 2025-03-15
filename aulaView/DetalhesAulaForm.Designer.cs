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
            aulaNomelbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            participantesDataGridView = new DataGridView();
            fecharDetalhesbtt = new Button();
            descricaoAulaTxt = new RichTextBox();
            nomeAulaTxt = new TextBox();
            dataFimTxt = new TextBox();
            dataInicioTxt = new TextBox();
            instrutorTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)participantesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // aulaNomelbl
            // 
            aulaNomelbl.AutoSize = true;
            aulaNomelbl.Font = new Font("Segoe UI", 11F);
            aulaNomelbl.Location = new Point(64, 48);
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
            label1.Location = new Point(64, 157);
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
            label2.Location = new Point(449, 104);
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
            label3.Location = new Point(64, 104);
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
            label4.Location = new Point(449, 48);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(176, 25);
            label4.TabIndex = 5;
            label4.Text = "Nome do Instrutor: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(64, 269);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(187, 25);
            label5.TabIndex = 6;
            label5.Text = "Alunos Participantes:";
            // 
            // participantesDataGridView
            // 
            participantesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            participantesDataGridView.Location = new Point(64, 319);
            participantesDataGridView.Name = "participantesDataGridView";
            participantesDataGridView.RowHeadersWidth = 51;
            participantesDataGridView.Size = new Size(932, 273);
            participantesDataGridView.TabIndex = 7;
            // 
            // fecharDetalhesbtt
            // 
            fecharDetalhesbtt.BackColor = Color.MidnightBlue;
            fecharDetalhesbtt.Font = new Font("Segoe UI", 10F);
            fecharDetalhesbtt.ForeColor = SystemColors.ButtonHighlight;
            fecharDetalhesbtt.Location = new Point(900, 632);
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
            descricaoAulaTxt.Location = new Point(167, 158);
            descricaoAulaTxt.Name = "descricaoAulaTxt";
            descricaoAulaTxt.ReadOnly = true;
            descricaoAulaTxt.Size = new Size(231, 83);
            descricaoAulaTxt.TabIndex = 11;
            descricaoAulaTxt.Text = "";
            // 
            // nomeAulaTxt
            // 
            nomeAulaTxt.Location = new Point(141, 49);
            nomeAulaTxt.Name = "nomeAulaTxt";
            nomeAulaTxt.ReadOnly = true;
            nomeAulaTxt.Size = new Size(257, 27);
            nomeAulaTxt.TabIndex = 12;
            // 
            // dataFimTxt
            // 
            dataFimTxt.Location = new Point(630, 102);
            dataFimTxt.Name = "dataFimTxt";
            dataFimTxt.ReadOnly = true;
            dataFimTxt.Size = new Size(166, 27);
            dataFimTxt.TabIndex = 14;
            // 
            // dataInicioTxt
            // 
            dataInicioTxt.Location = new Point(226, 102);
            dataInicioTxt.Name = "dataInicioTxt";
            dataInicioTxt.ReadOnly = true;
            dataInicioTxt.Size = new Size(172, 27);
            dataInicioTxt.TabIndex = 15;
            // 
            // instrutorTxt
            // 
            instrutorTxt.Location = new Point(630, 49);
            instrutorTxt.Name = "instrutorTxt";
            instrutorTxt.ReadOnly = true;
            instrutorTxt.Size = new Size(162, 27);
            instrutorTxt.TabIndex = 16;
            // 
            // DetalhesAulaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1038, 713);
            Controls.Add(instrutorTxt);
            Controls.Add(dataInicioTxt);
            Controls.Add(dataFimTxt);
            Controls.Add(nomeAulaTxt);
            Controls.Add(descricaoAulaTxt);
            Controls.Add(fecharDetalhesbtt);
            Controls.Add(participantesDataGridView);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(aulaNomelbl);
            Name = "DetalhesAulaForm";
            Text = "DetalhesAulaForm";
            ((System.ComponentModel.ISupportInitialize)participantesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label aulaNomelbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView participantesDataGridView;
        private Button fecharDetalhesbtt;
        private RichTextBox descricaoAulaTxt;
        private TextBox nomeAulaTxt;
        private TextBox dataFimTxt;
        private TextBox dataInicioTxt;
        private TextBox instrutorTxt;
    }
}