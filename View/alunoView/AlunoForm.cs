using lp3_academia.Controller;

namespace lp3_academia
{
    public partial class AlunoForm : Form
    {
        private AlunoController alunoController;

        public AlunoForm()
        {
            InitializeComponent();
            alunoController = new AlunoController();
        }

        private void salvarAlunobtt_Click(object sender, EventArgs e)
        {
            string nome = nomeAlunotxt.Text.Trim();
            string cpf = cpfAlunotxt.Text.Trim();
            string telefone = telAlunotxt.Text.Trim();
            DateTime dataNascimento = nascAlunoDataTime.Value;
            DateTime dataMatricula = matrículaAlunoDataTime.Value;

            // Verificar se todos os campos estão preenchidos
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Criar e salvar aluno no banco
            int resultado = alunoController.SalvarAluno(nome, dataNascimento, cpf, telefone, dataMatricula);

            if (resultado > 0)
            {
                MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualizar lista no AlunoListarForm se estiver aberto
                var formListar = Application.OpenForms.OfType<AlunoListarForm>().FirstOrDefault();
                formListar?.AtualizarListaAlunos();

                // Limpar os campos após salvar
                nomeAlunotxt.Clear();
                cpfAlunotxt.Clear();
                telAlunotxt.Clear();
                nascAlunoDataTime.Value = DateTime.Today;
                matrículaAlunoDataTime.Value = DateTime.Today;
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar aluno!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarAlunobtt_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário sem salvar
        }
    }
}
