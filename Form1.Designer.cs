namespace lp3_academia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            alunoToolStripMenuItem = new ToolStripMenuItem();
            instrutorToolStripMenuItem = new ToolStripMenuItem();
            aulasToolStripMenuItem = new ToolStripMenuItem();
            lIstarToolStripMenuItem = new ToolStripMenuItem();
            alunoListarToolStripMenuItem1 = new ToolStripMenuItem();
            instrutorListarToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Khaki;
            menuStrip1.Font = new Font("Segoe UI", 11F);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, aulasToolStripMenuItem, lIstarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(830, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alunoToolStripMenuItem, instrutorToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(115, 34);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // alunoToolStripMenuItem
            // 
            alunoToolStripMenuItem.BackColor = Color.Beige;
            alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            alunoToolStripMenuItem.Size = new Size(270, 38);
            alunoToolStripMenuItem.Text = "Aluno";
            alunoToolStripMenuItem.Click += alunoToolStripMenuItem_Click;
            // 
            // instrutorToolStripMenuItem
            // 
            instrutorToolStripMenuItem.BackColor = Color.Beige;
            instrutorToolStripMenuItem.Name = "instrutorToolStripMenuItem";
            instrutorToolStripMenuItem.Size = new Size(270, 38);
            instrutorToolStripMenuItem.Text = "Instrutor";
            instrutorToolStripMenuItem.Click += instrutorToolStripMenuItem_Click;
            // 
            // aulasToolStripMenuItem
            // 
            aulasToolStripMenuItem.Name = "aulasToolStripMenuItem";
            aulasToolStripMenuItem.Size = new Size(80, 34);
            aulasToolStripMenuItem.Text = "Aulas";
            // 
            // lIstarToolStripMenuItem
            // 
            lIstarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alunoListarToolStripMenuItem1, instrutorListarToolStripMenuItem1 });
            lIstarToolStripMenuItem.Name = "lIstarToolStripMenuItem";
            lIstarToolStripMenuItem.Size = new Size(79, 34);
            lIstarToolStripMenuItem.Text = "Listar";
            // 
            // alunoListarToolStripMenuItem1
            // 
            alunoListarToolStripMenuItem1.BackColor = Color.Beige;
            alunoListarToolStripMenuItem1.Name = "alunoListarToolStripMenuItem1";
            alunoListarToolStripMenuItem1.Size = new Size(270, 38);
            alunoListarToolStripMenuItem1.Text = "Aluno";
            alunoListarToolStripMenuItem1.Click += alunoListarToolStripMenuItem1_Click;
            // 
            // instrutorListarToolStripMenuItem1
            // 
            instrutorListarToolStripMenuItem1.BackColor = Color.Beige;
            instrutorListarToolStripMenuItem1.Name = "instrutorListarToolStripMenuItem1";
            instrutorListarToolStripMenuItem1.Size = new Size(270, 38);
            instrutorListarToolStripMenuItem1.Text = "Instrutor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(830, 474);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Academia";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem alunoToolStripMenuItem;
        private ToolStripMenuItem instrutorToolStripMenuItem;
        private ToolStripMenuItem aulasToolStripMenuItem;
        private ToolStripMenuItem lIstarToolStripMenuItem;
        private ToolStripMenuItem alunoListarToolStripMenuItem1;
        private ToolStripMenuItem instrutorListarToolStripMenuItem1;
    }
}
