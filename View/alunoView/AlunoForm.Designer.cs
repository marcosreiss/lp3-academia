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
            nascAlunolbl = new Label();
            nascAlunoDataTime = new DateTimePicker();
            label1 = new Label();
            matrículaAlunoDataTime = new DateTimePicker();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nomeAlunolbl
            // 
            nomeAlunolbl.AutoSize = true;
            nomeAlunolbl.Font = new Font("Segoe UI", 11F);
            nomeAlunolbl.Location = new Point(6, 50);
            nomeAlunolbl.Name = "nomeAlunolbl";
            nomeAlunolbl.Size = new Size(78, 30);
            nomeAlunolbl.TabIndex = 0;
            nomeAlunolbl.Text = "Nome:";
            // 
            // nomeAlunotxt
            // 
            nomeAlunotxt.Font = new Font("Segoe UI", 11F);
            nomeAlunotxt.Location = new Point(90, 47);
            nomeAlunotxt.Name = "nomeAlunotxt";
            nomeAlunotxt.Size = new Size(506, 37);
            nomeAlunotxt.TabIndex = 1;
            // 
            // cpfAlunotxt
            // 
            cpfAlunotxt.Font = new Font("Segoe UI", 11F);
            cpfAlunotxt.Location = new Point(6, 204);
            cpfAlunotxt.Name = "cpfAlunotxt";
            cpfAlunotxt.Size = new Size(262, 37);
            cpfAlunotxt.TabIndex = 3;
            // 
            // cpfAlunolbl
            // 
            cpfAlunolbl.AutoSize = true;
            cpfAlunolbl.Font = new Font("Segoe UI", 11F);
            cpfAlunolbl.Location = new Point(6, 171);
            cpfAlunolbl.Name = "cpfAlunolbl";
            cpfAlunolbl.Size = new Size(55, 30);
            cpfAlunolbl.TabIndex = 2;
            cpfAlunolbl.Text = "CPF:";
            // 
            // telAlunolbl
            // 
            telAlunolbl.AutoSize = true;
            telAlunolbl.Font = new Font("Segoe UI", 11F);
            telAlunolbl.Location = new Point(300, 171);
            telAlunolbl.Name = "telAlunolbl";
            telAlunolbl.Size = new Size(101, 30);
            telAlunolbl.TabIndex = 4;
            telAlunolbl.Text = "Telefone:";
            // 
            // telAlunotxt
            // 
            telAlunotxt.Font = new Font("Segoe UI", 11F);
            telAlunotxt.Location = new Point(300, 204);
            telAlunotxt.Name = "telAlunotxt";
            telAlunotxt.Size = new Size(296, 37);
            telAlunotxt.TabIndex = 5;
            // 
            // salvarAlunobtt
            // 
            salvarAlunobtt.BackColor = Color.MidnightBlue;
            salvarAlunobtt.Font = new Font("Segoe UI", 10F);
            salvarAlunobtt.ForeColor = SystemColors.ButtonHighlight;
            salvarAlunobtt.Location = new Point(491, 395);
            salvarAlunobtt.Name = "salvarAlunobtt";
            salvarAlunobtt.Size = new Size(120, 42);
            salvarAlunobtt.TabIndex = 6;
            salvarAlunobtt.Text = "Salvar";
            salvarAlunobtt.UseVisualStyleBackColor = false;
            salvarAlunobtt.Click += salvarAlunobtt_Click;
            // 
            // cancelarAlunobtt
            // 
            cancelarAlunobtt.BackColor = Color.MidnightBlue;
            cancelarAlunobtt.Font = new Font("Segoe UI", 10F);
            cancelarAlunobtt.ForeColor = SystemColors.ButtonHighlight;
            cancelarAlunobtt.Location = new Point(350, 395);
            cancelarAlunobtt.Name = "cancelarAlunobtt";
            cancelarAlunobtt.Size = new Size(120, 42);
            cancelarAlunobtt.TabIndex = 7;
            cancelarAlunobtt.Text = "Cancelar";
            cancelarAlunobtt.UseVisualStyleBackColor = false;
            cancelarAlunobtt.Click += cancelarAlunobtt_Click;
            // 
            // nascAlunolbl
            // 
            nascAlunolbl.AutoSize = true;
            nascAlunolbl.Font = new Font("Segoe UI", 11F);
            nascAlunolbl.Location = new Point(6, 113);
            nascAlunolbl.Name = "nascAlunolbl";
            nascAlunolbl.Size = new Size(182, 30);
            nascAlunolbl.TabIndex = 8;
            nascAlunolbl.Text = "Data Nascimento:";
            // 
            // nascAlunoDataTime
            // 
            nascAlunoDataTime.Location = new Point(213, 112);
            nascAlunoDataTime.Name = "nascAlunoDataTime";
            nascAlunoDataTime.Size = new Size(300, 31);
            nascAlunoDataTime.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(6, 271);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 10;
            label1.Text = "Data Matrícula:";
            // 
            // matrículaAlunoDataTime
            // 
            matrículaAlunoDataTime.Location = new Point(213, 270);
            matrículaAlunoDataTime.Name = "matrículaAlunoDataTime";
            matrículaAlunoDataTime.Size = new Size(300, 31);
            matrículaAlunoDataTime.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nomeAlunolbl);
            groupBox1.Controls.Add(matrículaAlunoDataTime);
            groupBox1.Controls.Add(nomeAlunotxt);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nascAlunolbl);
            groupBox1.Controls.Add(nascAlunoDataTime);
            groupBox1.Controls.Add(cpfAlunolbl);
            groupBox1.Controls.Add(telAlunotxt);
            groupBox1.Controls.Add(cpfAlunotxt);
            groupBox1.Controls.Add(telAlunolbl);
            groupBox1.Location = new Point(29, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(602, 351);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aluno";
            // 
            // AlunoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(657, 474);
            Controls.Add(groupBox1);
            Controls.Add(cancelarAlunobtt);
            Controls.Add(salvarAlunobtt);
            Name = "AlunoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Aluno";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private Label nascAlunolbl;
        private DateTimePicker nascAlunoDataTime;
        private Label label1;
        private DateTimePicker matrículaAlunoDataTime;
        private GroupBox groupBox1;
    }
}