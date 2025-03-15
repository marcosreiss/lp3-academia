using lp3_academia.Controller;
using lp3_academia.DTO;

namespace lp3_academia.instrutorView
{
    public partial class InstrutorListarForm : Form
    {

        private InstrutorController instrutorController;
        private List<InstrutorDTO> listaInstrutores;
        public InstrutorListarForm()
        {
            InitializeComponent();
            instrutorController = new InstrutorController();
            listaInstrutores = new List<InstrutorDTO>();
        }

        private void InstrutorListarForm_Load(object sender, EventArgs e)
        {
            AtualizarListaInstrutores(); // Atualiza a lista ao carregar o formulário
        }

        public void AtualizarListaInstrutores()
        {
            try
            {
                listaInstrutores = instrutorController.ListarInstrutores();
                CarregarInstrutores(listaInstrutores);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar instrutores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarInstrutores(List<InstrutorDTO> listaInstrutores)
        {
            if (listaInstrutores == null || listaInstrutores.Count == 0)
            {
                MessageBox.Show("Nenhum instrutor cadastrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Configurar colunas do DataGridView apenas uma vez
            if (dataGridViewInstrutor.Columns.Count == 0)
            {
                dataGridViewInstrutor.Columns.Add("Id", "ID");
                dataGridViewInstrutor.Columns.Add("Nome", "Nome");
                dataGridViewInstrutor.Columns.Add("CPF", "CPF");
                dataGridViewInstrutor.Columns.Add("Especialidade", "Especialidade");
                dataGridViewInstrutor.Columns.Add("Contratacao", "Data de Contratação");
            }

            // Limpar o DataGridView antes de adicionar novos dados
            dataGridViewInstrutor.Rows.Clear();

            // Adicionar os instrutores ao DataGridView
            foreach (InstrutorDTO instrutor in listaInstrutores)
            {
                dataGridViewInstrutor.Rows.Add(
                    instrutor.IdInstrutor,
                    instrutor.Nome,
                    instrutor.Cpf,
                    instrutor.Especialidade,
                    instrutor.DataContratacao.ToString("dd/MM/yyyy")
                );
            }
        }
    }
}
