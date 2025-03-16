using lp3_academia.Controller;
using lp3_academia.instrutorView;

namespace lp3_academia
{
    public partial class InstrutorForm : Form
    {
        private InstrutorController instrutorController;

        public InstrutorForm()
        {
            InitializeComponent();
            instrutorController = new InstrutorController();
        }

        private void contratacaoInstrutordateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cancelarInstrutorTsp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarInstrutorTsp_Click(object sender, EventArgs e)
        {
            string nome = nomeInstrutortxt.Text.Trim();
            string cpf = cpfInstrutortxt.Text.Trim();
            string especialidade = especialidadeInstrutortxt.Text.Trim();
            DateTime dataContratacao = contratacaoInstrutordateTime.Value;

            // Verificar se os campos obrigatórios foram preenchidos
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(especialidade))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Criar e salvar o instrutor no banco
            int resultado = instrutorController.SalvarInstrutor(nome, cpf, especialidade, dataContratacao);

            if (resultado > 0)
            {
                MessageBox.Show("Instrutor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualizar lista no InstrutorListarForm se estiver aberto
                var formListar = Application.OpenForms.OfType<InstrutorListarForm>().FirstOrDefault();
                formListar?.AtualizarListaInstrutores();

                // Limpar os campos após salvar
                nomeInstrutortxt.Clear();
                cpfInstrutortxt.Clear();
                especialidadeInstrutortxt.Clear();
                contratacaoInstrutordateTime.Value = DateTime.Today;
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar instrutor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
