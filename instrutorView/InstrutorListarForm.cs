using lp3_academia.Models;

namespace lp3_academia.instrutorView
{
    public partial class InstrutorListarForm : Form
    {
        private List<Instrutor> listaInstrutores;
        public InstrutorListarForm(List<Instrutor> instrutores)
        {
            InitializeComponent();
            this.listaInstrutores = instrutores;
            CarregarInstrutores(instrutores);
        }

        private void CarregarInstrutores(List<Instrutor> listaInstrutores)
        {
            // Configurar as colunas do DataGridView
            if (dataGridViewInstrutor.Columns.Count == 0)
            {
                dataGridViewInstrutor.Columns.Add("Id", "ID");
                dataGridViewInstrutor.Columns.Add("Nome", "Nome");
                dataGridViewInstrutor.Columns.Add("CPF", "CPF");
                dataGridViewInstrutor.Columns.Add("Especialidade", "Especialidade");
                dataGridViewInstrutor.Columns.Add("Contratacao", "Data de Contratação");
            }

            // Limpar antes de adicionar novos dados
            dataGridViewInstrutor.Rows.Clear();

            // Adicionar os instrutores ao DataGridView
            foreach (Instrutor instrutor in listaInstrutores)
            {
                dataGridViewInstrutor.Rows.Add(instrutor.Id, instrutor.Nome, instrutor.CPF, instrutor.Especialidade,
                                                 instrutor.DataContratacao.ToString("dd/MM/yyyy"));
            }
        }

        private void InstrutorListar_Load(object sender, EventArgs e)
        {

        }
    }
}
