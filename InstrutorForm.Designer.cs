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
            salvarIntrutorbtt = new Button();
            telAlunotxt = new TextBox();
            especInstrutorlbl = new Label();
            cpfInstrutortxt = new TextBox();
            cpfInstrutorlbl = new Label();
            nomeInstrutortxt = new TextBox();
            nomeInstrutorlbl = new Label();
            SuspendLayout();
            // 
            // cancelarInstrutorbtt
            // 
            cancelarInstrutorbtt.BackColor = Color.MidnightBlue;
            cancelarInstrutorbtt.Font = new Font("Segoe UI", 10F);
            cancelarInstrutorbtt.ForeColor = SystemColors.ButtonHighlight;
            cancelarInstrutorbtt.Location = new Point(80, 343);
            cancelarInstrutorbtt.Name = "cancelarInstrutorbtt";
            cancelarInstrutorbtt.Size = new Size(119, 41);
            cancelarInstrutorbtt.TabIndex = 15;
            cancelarInstrutorbtt.Text = "Cancelar";
            cancelarInstrutorbtt.UseVisualStyleBackColor = false;
            // 
            // salvarIntrutorbtt
            // 
            salvarIntrutorbtt.BackColor = Color.MidnightBlue;
            salvarIntrutorbtt.Font = new Font("Segoe UI", 10F);
            salvarIntrutorbtt.ForeColor = SystemColors.ButtonHighlight;
            salvarIntrutorbtt.Location = new Point(246, 343);
            salvarIntrutorbtt.Name = "salvarIntrutorbtt";
            salvarIntrutorbtt.Size = new Size(120, 41);
            salvarIntrutorbtt.TabIndex = 14;
            salvarIntrutorbtt.Text = "Salvar";
            salvarIntrutorbtt.UseVisualStyleBackColor = false;
            // 
            // telAlunotxt
            // 
            telAlunotxt.Font = new Font("Segoe UI", 11F);
            telAlunotxt.Location = new Point(35, 233);
            telAlunotxt.Name = "telAlunotxt";
            telAlunotxt.Size = new Size(288, 37);
            telAlunotxt.TabIndex = 13;
            // 
            // especInstrutorlbl
            // 
            especInstrutorlbl.AutoSize = true;
            especInstrutorlbl.Font = new Font("Segoe UI", 11F);
            especInstrutorlbl.Location = new Point(35, 182);
            especInstrutorlbl.Name = "especInstrutorlbl";
            especInstrutorlbl.Size = new Size(148, 30);
            especInstrutorlbl.TabIndex = 12;
            especInstrutorlbl.Text = "Especialidade:";
            // 
            // cpfInstrutortxt
            // 
            cpfInstrutortxt.Font = new Font("Segoe UI", 11F);
            cpfInstrutortxt.Location = new Point(119, 110);
            cpfInstrutortxt.Name = "cpfInstrutortxt";
            cpfInstrutortxt.Size = new Size(327, 37);
            cpfInstrutortxt.TabIndex = 11;
            // 
            // cpfInstrutorlbl
            // 
            cpfInstrutorlbl.AutoSize = true;
            cpfInstrutorlbl.Font = new Font("Segoe UI", 11F);
            cpfInstrutorlbl.Location = new Point(35, 113);
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
            nomeInstrutortxt.Size = new Size(327, 37);
            nomeInstrutortxt.TabIndex = 9;
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
            // InstrutorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(621, 450);
            Controls.Add(cancelarInstrutorbtt);
            Controls.Add(salvarIntrutorbtt);
            Controls.Add(telAlunotxt);
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
        private Button salvarIntrutorbtt;
        private TextBox telAlunotxt;
        private Label especInstrutorlbl;
        private TextBox cpfInstrutortxt;
        private Label cpfInstrutorlbl;
        private TextBox nomeInstrutortxt;
        private Label nomeInstrutorlbl;
    }
}