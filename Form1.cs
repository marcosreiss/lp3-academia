
using lp3_academia.instrutorView;
using lp3_academia.Models;


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
        public List<Instrutor> listaInstrutores = new List<Instrutor>();


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

        private void instrutorListarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InstrutorListarForm listarInstrutores = new InstrutorListarForm(listaInstrutores);
            listarInstrutores.MdiParent = this;
            listarInstrutores.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
