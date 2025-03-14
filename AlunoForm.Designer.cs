namespace lp3_academia
{
    partial class AlunoForm
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
            nomeAlunolbl = new Label();
            nomeAlunotxt = new TextBox();
            cpfAlunotxt = new TextBox();
            cpfAlunolbl = new Label();
            telAlunolbl = new Label();
            telAlunotxt = new TextBox();
            salvarAlunobtt = new Button();
            cancelarAlunobtt = new Button();
            SuspendLayout();
            // 
            // nomeAlunolbl
            // 
            nomeAlunolbl.AutoSize = true;
            nomeAlunolbl.Font = new Font("Segoe UI", 11F);
            nomeAlunolbl.Location = new Point(29, 43);
            nomeAlunolbl.Name = "nomeAlunolbl";
            nomeAlunolbl.Size = new Size(78, 30);
            nomeAlunolbl.TabIndex = 0;
            nomeAlunolbl.Text = "Nome:";
            // 
            // nomeAlunotxt
            // 
            nomeAlunotxt.Font = new Font("Segoe UI", 11F);
            nomeAlunotxt.Location = new Point(113, 43);
            nomeAlunotxt.Name = "nomeAlunotxt";
            nomeAlunotxt.Size = new Size(327, 37);
            nomeAlunotxt.TabIndex = 1;
            // 
            // cpfAlunotxt
            // 
            cpfAlunotxt.Font = new Font("Segoe UI", 11F);
            cpfAlunotxt.Location = new Point(113, 118);
            cpfAlunotxt.Name = "cpfAlunotxt";
            cpfAlunotxt.Size = new Size(327, 37);
            cpfAlunotxt.TabIndex = 3;
            // 
            // cpfAlunolbl
            // 
            cpfAlunolbl.AutoSize = true;
            cpfAlunolbl.Font = new Font("Segoe UI", 11F);
            cpfAlunolbl.Location = new Point(29, 121);
            cpfAlunolbl.Name = "cpfAlunolbl";
            cpfAlunolbl.Size = new Size(55, 30);
            cpfAlunolbl.TabIndex = 2;
            cpfAlunolbl.Text = "CPF:";
            cpfAlunolbl.Click += label2_Click;
            // 
            // telAlunolbl
            // 
            telAlunolbl.AutoSize = true;
            telAlunolbl.Font = new Font("Segoe UI", 11F);
            telAlunolbl.Location = new Point(29, 193);
            telAlunolbl.Name = "telAlunolbl";
            telAlunolbl.Size = new Size(101, 30);
            telAlunolbl.TabIndex = 4;
            telAlunolbl.Text = "Telefone:";
            // 
            // telAlunotxt
            // 
            telAlunotxt.Font = new Font("Segoe UI", 11F);
            telAlunotxt.Location = new Point(152, 193);
            telAlunotxt.Name = "telAlunotxt";
            telAlunotxt.Size = new Size(288, 37);
            telAlunotxt.TabIndex = 5;
            // 
            // salvarAlunobtt
            // 
            salvarAlunobtt.BackColor = Color.MidnightBlue;
            salvarAlunobtt.Font = new Font("Segoe UI", 10F);
            salvarAlunobtt.ForeColor = SystemColors.ButtonHighlight;
            salvarAlunobtt.Location = new Point(499, 403);
            salvarAlunobtt.Name = "salvarAlunobtt";
            salvarAlunobtt.Size = new Size(112, 34);
            salvarAlunobtt.TabIndex = 6;
            salvarAlunobtt.Text = "Salvar";
            salvarAlunobtt.UseVisualStyleBackColor = false;
            // 
            // cancelarAlunobtt
            // 
            cancelarAlunobtt.BackColor = Color.MidnightBlue;
            cancelarAlunobtt.Font = new Font("Segoe UI", 10F);
            cancelarAlunobtt.ForeColor = SystemColors.ButtonHighlight;
            cancelarAlunobtt.Location = new Point(381, 403);
            cancelarAlunobtt.Name = "cancelarAlunobtt";
            cancelarAlunobtt.Size = new Size(112, 34);
            cancelarAlunobtt.TabIndex = 7;
            cancelarAlunobtt.Text = "Cancelar";
            cancelarAlunobtt.UseVisualStyleBackColor = false;
            // 
            // AlunoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(657, 474);
            Controls.Add(cancelarAlunobtt);
            Controls.Add(salvarAlunobtt);
            Controls.Add(telAlunotxt);
            Controls.Add(telAlunolbl);
            Controls.Add(cpfAlunotxt);
            Controls.Add(cpfAlunolbl);
            Controls.Add(nomeAlunotxt);
            Controls.Add(nomeAlunolbl);
            Name = "AlunoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Aluno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nomeAlunolbl;
        private TextBox nomeAlunotxt;
        private TextBox cpfAlunotxt;
        private Label cpfAlunolbl;
        private Label telAlunolbl;
        private TextBox telAlunotxt;
        private Button salvarAlunobtt;
        private Button cancelarAlunobtt;
    }
}