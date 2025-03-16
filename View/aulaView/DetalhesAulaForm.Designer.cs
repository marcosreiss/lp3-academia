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
            aulaNomelbl.Location = new Point(80, 60);
            aulaNomelbl.Margin = new Padding(2, 0, 2, 0);
            aulaNomelbl.Name = "aulaNomelbl";
            aulaNomelbl.Size = new Size(84, 30);
            aulaNomelbl.TabIndex = 1;
            aulaNomelbl.Text = "Nome: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(80, 196);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 2;
            label1.Text = "Descrição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(561, 130);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 30);
            label2.TabIndex = 3;
            label2.Text = "Horário de Fim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(80, 130);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 30);
            label3.TabIndex = 4;
            label3.Text = "Horário de Início:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(561, 60);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(204, 30);
            label4.TabIndex = 5;
            label4.Text = "Nome do Instrutor: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(80, 336);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(210, 30);
            label5.TabIndex = 6;
            label5.Text = "Alunos Participantes:";
            // 
            // participantesDataGridView
            // 
            participantesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            participantesDataGridView.Location = new Point(80, 399);
            participantesDataGridView.Margin = new Padding(4, 4, 4, 4);
            participantesDataGridView.Name = "participantesDataGridView";
            participantesDataGridView.RowHeadersWidth = 51;
            participantesDataGridView.Size = new Size(1165, 341);
            participantesDataGridView.TabIndex = 7;
            // 
            // fecharDetalhesbtt
            // 
            fecharDetalhesbtt.BackColor = Color.MidnightBlue;
            fecharDetalhesbtt.Font = new Font("Segoe UI", 10F);
            fecharDetalhesbtt.ForeColor = SystemColors.ButtonHighlight;
            fecharDetalhesbtt.Location = new Point(1125, 790);
            fecharDetalhesbtt.Margin = new Padding(2);
            fecharDetalhesbtt.Name = "fecharDetalhesbtt";
            fecharDetalhesbtt.Size = new Size(120, 42);
            fecharDetalhesbtt.TabIndex = 10;
            fecharDetalhesbtt.Text = "Fechar";
            fecharDetalhesbtt.UseVisualStyleBackColor = false;
            fecharDetalhesbtt.Click += fecharDetalhesbtt_Click;
            // 
            // descricaoAulaTxt
            // 
            descricaoAulaTxt.Location = new Point(209, 198);
            descricaoAulaTxt.Margin = new Padding(4, 4, 4, 4);
            descricaoAulaTxt.Name = "descricaoAulaTxt";
            descricaoAulaTxt.ReadOnly = true;
            descricaoAulaTxt.Size = new Size(288, 103);
            descricaoAulaTxt.TabIndex = 11;
            descricaoAulaTxt.Text = "";
            // 
            // nomeAulaTxt
            // 
            nomeAulaTxt.Location = new Point(176, 61);
            nomeAulaTxt.Margin = new Padding(4, 4, 4, 4);
            nomeAulaTxt.Name = "nomeAulaTxt";
            nomeAulaTxt.ReadOnly = true;
            nomeAulaTxt.Size = new Size(320, 31);
            nomeAulaTxt.TabIndex = 12;
            // 
            // dataFimTxt
            // 
            dataFimTxt.Location = new Point(788, 128);
            dataFimTxt.Margin = new Padding(4, 4, 4, 4);
            dataFimTxt.Name = "dataFimTxt";
            dataFimTxt.ReadOnly = true;
            dataFimTxt.Size = new Size(206, 31);
            dataFimTxt.TabIndex = 14;
            // 
            // dataInicioTxt
            // 
            dataInicioTxt.Location = new Point(282, 128);
            dataInicioTxt.Margin = new Padding(4, 4, 4, 4);
            dataInicioTxt.Name = "dataInicioTxt";
            dataInicioTxt.ReadOnly = true;
            dataInicioTxt.Size = new Size(214, 31);
            dataInicioTxt.TabIndex = 15;
            // 
            // instrutorTxt
            // 
            instrutorTxt.Location = new Point(788, 61);
            instrutorTxt.Margin = new Padding(4, 4, 4, 4);
            instrutorTxt.Name = "instrutorTxt";
            instrutorTxt.ReadOnly = true;
            instrutorTxt.Size = new Size(202, 31);
            instrutorTxt.TabIndex = 16;
            // 
            // DetalhesAulaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1298, 891);
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "DetalhesAulaForm";
            StartPosition = FormStartPosition.CenterScreen;
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