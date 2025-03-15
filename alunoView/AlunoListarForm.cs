using lp3_academia.Controller;
using lp3_academia.DTO;

namespace lp3_academia
{
    public partial class AlunoListarForm : Form
    {
        private AlunoController alunoController;

        public AlunoListarForm()
        {
            InitializeComponent();
            alunoController = new AlunoController();
        }

        private void AlunoListarForm_Load(object sender, EventArgs e)
        {
            List<AlunoDTO> listaAlunos = alunoController.ListarAlunos();
            CarregarAlunos(listaAlunos);
            
        }

        private void CarregarAlunos(List<AlunoDTO> listaAlunos)
        {
            if (listaAlunos.Count == 0)
            {
                MessageBox.Show("Nenhum aluno cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Configurar as colunas do DataGridView apenas uma vez
            if (dataGridViewAlunos.Columns.Count == 0)
            {
                dataGridViewAlunos.Columns.Add("Nome", "Nome");
                dataGridViewAlunos.Columns.Add("CPF", "CPF");
                dataGridViewAlunos.Columns.Add("Telefone", "Telefone");
                dataGridViewAlunos.Columns.Add("Nascimento", "Data de Nascimento");
                dataGridViewAlunos.Columns.Add("Matricula", "Data de Matrícula");
            }

            // Limpar antes de adicionar novos dados
            dataGridViewAlunos.Rows.Clear();

            // Adicionar os alunos ao DataGridView
            foreach (AlunoDTO aluno in listaAlunos)
            {
                dataGridViewAlunos.Rows.Add(aluno.Nome, aluno.Cpf, aluno.Telefone,
                                            aluno.DataNascimento.ToString("dd/MM/yyyy"),
                                            aluno.DataMatricula.ToString("dd/MM/yyyy"));
            }
        }

        private void dataGridViewAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
