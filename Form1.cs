
using lp3_academia.aulaView;
using lp3_academia.instrutorView;


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

        private void alunoListarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlunoListarForm listarForm = new AlunoListarForm();
            listarForm.MdiParent = this; // Define como MDI
            listarForm.Show();
        }

        private void instrutorListarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InstrutorListarForm listarInstrutores = new InstrutorListarForm();
            listarInstrutores.MdiParent = this;
            listarInstrutores.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void criarAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarAulaForm criarAulaForm = new CriarAulaForm(); // Passando a lista de Form1
            criarAulaForm.MdiParent = this;
            criarAulaForm.Show();
        }

        private void listarAulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AulaListarForm listarAula = new AulaListarForm();
            listarAula.MdiParent = this;
            listarAula.Show();
        }
    }
}
