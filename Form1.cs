
namespace lp3_academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlunoForm alunoForm = new AlunoForm();
            alunoForm.MdiParent = this;
            alunoForm.Show();
        }

        private void instrutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstrutorForm instrutorForm = new InstrutorForm();
            instrutorForm.MdiParent = this;
            instrutorForm.Show();
        }

        public List<Aluno> listaAlunos = new List<Aluno>();

        private void alunoListarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listaAlunos.Count == 0)
            {
                MessageBox.Show("Nenhum aluno cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AlunoListarForm listarForm = new AlunoListarForm(listaAlunos);
            listarForm.MdiParent = this; // Define como MDI
            listarForm.Show();
        }
    }
}
