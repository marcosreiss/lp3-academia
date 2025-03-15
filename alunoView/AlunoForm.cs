namespace lp3_academia
{
    public partial class AlunoForm : Form
    {
        public AlunoForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nomeAlunotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpfAlunotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void telAlunotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelarAlunobtt_Click(object sender, EventArgs e)
        {

        }

        private void salvarAlunobtt_Click(object sender, EventArgs e)
        {
            string nome = nomeAlunotxt.Text.Trim();
            string cpf = cpfAlunotxt.Text.Trim();
            string telefone = telAlunotxt.Text.Trim();
            DateTime dataNascimento = nascAlunoDataTime.Value;
            DateTime dataMatricula = matrículaAlunoDataTime.Value;

            // verificar se todos os campos estão preenchidos
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Aluno novoAluno = new Aluno(nome, cpf, telefone, dataNascimento, dataMatricula);

            // adicionar aluno na lista do Form1
            Form1 formPrincipal = (Form1)Application.OpenForms["Form1"];
            //AlunoListarForm.listaAlunos.Add(novoAluno);

            MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // limpar os campos após salvar
            nomeAlunotxt.Clear();
            cpfAlunotxt.Clear();
            telAlunotxt.Clear();
            nascAlunoDataTime.Value = DateTime.Today;
            matrículaAlunoDataTime.Value = DateTime.Today;

        }

        private void telAlunolbl_Click(object sender, EventArgs e)
        {

        }

        private void nascAlunoDataTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void matrículaAlunoDataTime_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
