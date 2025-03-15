using lp3_academia.Controller;
using lp3_academia.DTO;

namespace lp3_academia
{
    public partial class AlunoListarForm : Form
    {
        private AlunoController alunoController;
        private List<AlunoDTO> listaAlunos; // Agora é privada

        public AlunoListarForm()
        {
            InitializeComponent();
            alunoController = new AlunoController();
            listaAlunos = new List<AlunoDTO>();
        }

        private void AlunoListarForm_Load(object sender, EventArgs e)
        {
            AtualizarListaAlunos(); // Atualiza os alunos ao carregar a tela
        }

        public void AtualizarListaAlunos()
        {
            try
            {
                listaAlunos = alunoController.ListarAlunos();
                CarregarAlunos(listaAlunos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar alunos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarAlunos(List<AlunoDTO> listaAlunos)
        {
            if (listaAlunos == null || listaAlunos.Count == 0)
            {
                MessageBox.Show("Nenhum aluno cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Configurar colunas do DataGridView apenas uma vez
            if (dataGridViewAlunos.Columns.Count == 0)
            {
                dataGridViewAlunos.Columns.Add("ID", "ID");
                dataGridViewAlunos.Columns.Add("Nome", "Nome");
                dataGridViewAlunos.Columns.Add("CPF", "CPF");
                dataGridViewAlunos.Columns.Add("Telefone", "Telefone");
                dataGridViewAlunos.Columns.Add("Nascimento", "Data de Nascimento");
                dataGridViewAlunos.Columns.Add("Matricula", "Data de Matrícula");
            }

            // Limpar o DataGridView antes de adicionar novos dados
            dataGridViewAlunos.Rows.Clear();

            // Adicionar os alunos ao DataGridView
            foreach (AlunoDTO aluno in listaAlunos)
            {
                dataGridViewAlunos.Rows.Add(
                    aluno.IdAluno,
                    aluno.Nome,
                    aluno.Cpf,
                    aluno.Telefone,
                    aluno.DataNascimento.ToString("dd/MM/yyyy"),
                    aluno.DataMatricula.ToString("dd/MM/yyyy")
                );
            }
        }
    }
}
