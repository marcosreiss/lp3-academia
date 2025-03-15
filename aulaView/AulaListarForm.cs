using lp3_academia.Controller;
using lp3_academia.DTO;

namespace lp3_academia.aulaView
{
    public partial class AulaListarForm : Form
    {
        private AulaController aulaController;
        private List<AulaDTO> listaAulas;

        public AulaListarForm()
        {
            InitializeComponent();
            aulaController = new AulaController();
            listaAulas = new List<AulaDTO>();
        }

        private void AulaListarForm_Load(object sender, EventArgs e)
        {
            AtualizarListaAulas(); // Carrega a lista ao iniciar
        }

        public void AtualizarListaAulas()
        {
            try
            {
                listaAulas = aulaController.ListarAulas();
                CarregarAulas(listaAulas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar aulas: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarAulas(List<AulaDTO> listaAulas)
        {
            if (listaAulas == null || listaAulas.Count == 0)
            {
                MessageBox.Show("Nenhuma aula cadastrada!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Configurar colunas do DataGridView apenas uma vez
            if (dataGridViewAulas.Columns.Count == 0)
            {
                dataGridViewAulas.Columns.Add("Id", "ID");
                dataGridViewAulas.Columns.Add("Nome", "Nome");
                dataGridViewAulas.Columns.Add("Descricao", "Descrição");
                dataGridViewAulas.Columns.Add("DataInicio", "Data de Início");
                dataGridViewAulas.Columns.Add("DataFim", "Hora de Fim");
                dataGridViewAulas.Columns.Add("Instrutor", "Instrutor");
            }

            // Limpar o DataGridView antes de adicionar novos dados
            dataGridViewAulas.Rows.Clear();

            // Adicionar as aulas ao DataGridView
            foreach (AulaDTO aula in listaAulas)
            {
                dataGridViewAulas.Rows.Add(
                    aula.IdAula,
                    aula.Nome,
                    aula.Descricao,
                    aula.DataHorarioInicio.ToString("dd/MM/yyyy HH:mm"),
                    aula.DataHorarioFim.ToString("HH:mm"),
                    aula.NameInstrutor
                );
            }
        }

        private void dataGridViewAulas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se o clique foi em uma linha válida
            if (e.RowIndex >= 0 && e.RowIndex < listaAulas.Count)
            {
                AulaDTO aulaSelecionada = listaAulas[e.RowIndex];

                // Abrir o formulário de detalhes passando a aula selecionada
                DetalhesAulaForm detalhesForm = new DetalhesAulaForm(aulaSelecionada);
                detalhesForm.ShowDialog();
            }
        }
    }
}
