using lp3_academia.DTO;

namespace lp3_academia.aulaView
{
    public partial class DetalhesAulaForm : Form
    {
        private AulaDTO aula;

        public DetalhesAulaForm(AulaDTO aula)
        {
            InitializeComponent();
            this.aula = aula;
            ExibirDetalhesAula();
        }

        private void ExibirDetalhesAula()
        {
            nomeAulaTxt.Text = aula.Nome;
            descricaoAulaTxt.Text = aula.Descricao;
            dataInicioTxt.Text = aula.DataHorarioInicio.ToString("dd/MM/yyyy HH:mm");
            dataFimTxt.Text = aula.DataHorarioFim.ToString("HH:mm");
            instrutorTxt.Text = aula.NameInstrutor;

            if (participantesDataGridView.Columns.Count == 0)
            {
                participantesDataGridView.Columns.Add("Nome", "Nome");
                participantesDataGridView.Columns.Add("CPF", "CPF");
                participantesDataGridView.Columns.Add("Telefone", "Telefone");
            }

            // Preencher a lista de alunos no DataGridView (participantes)
            participantesDataGridView.Rows.Clear();
            foreach (AlunoDTO aluno in aula.Alunos)
            {
                participantesDataGridView.Rows.Add(aluno.Nome, aluno.Cpf, aluno.Telefone);
            }
        }

        private void fecharDetalhesbtt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
