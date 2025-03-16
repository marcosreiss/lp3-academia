using lp3_academia.Controller;
using lp3_academia.DTO;

namespace lp3_academia.aulaView
{
    public partial class CriarAulaForm : Form
    {
        private AulaController aulaController;
        private InstrutorController instrutorController;
        private AlunoController alunoController;
        private List<InstrutorDTO> listaInstrutores;
        private List<AlunoDTO> listaAlunos;

        public CriarAulaForm()
        {
            InitializeComponent();
            aulaController = new AulaController();
            instrutorController = new InstrutorController();
            alunoController = new AlunoController();
            listaInstrutores = new List<InstrutorDTO>();
            listaAlunos = new List<AlunoDTO>();

            CarregarInstrutores();
            CarregarAlunos();
            PreencherHorariosComboBox();
        }

        private void CarregarInstrutores()
        {
            try
            {
                listaInstrutores = instrutorController.ListarInstrutores();
                instrutorcmb.DataSource = listaInstrutores;
                instrutorcmb.DisplayMember = "Nome";   // Exibe o nome
                instrutorcmb.ValueMember = "IdInstrutor";  // Internamente armazena o ID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar instrutores: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarAlunos()
        {
            try
            {
                listaAlunos = alunoController.ListarAlunos();
                participantesclb.DataSource = listaAlunos;
                participantesclb.DisplayMember = "Nome";  // Exibe o nome
                participantesclb.ValueMember = "IdAluno";  // Internamente armazena o ID
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar alunos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherHorariosComboBox()
        {
            dtIniciocmbox.Items.Clear();
            dtFimcmbox.Items.Clear();

            // Adicionar horários de 08:00 às 20:00 de hora em hora
            for (int hora = 8; hora <= 20; hora++)
            {
                string horario = hora.ToString("D2") + ":00"; // Formato HH:MM (Ex: "08:00")
                dtIniciocmbox.Items.Add(horario);
                dtFimcmbox.Items.Add(horario);
            }
        }

        private void cancelarAulaTsp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarAulaTsp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nomeAulatxt.Text) ||
                string.IsNullOrWhiteSpace(descAulatxt.Text) ||
                dtIniciocmbox.SelectedItem == null ||
                dtFimcmbox.SelectedItem == null ||
                instrutorcmb.SelectedItem == null)
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!TimeSpan.TryParse(dtIniciocmbox.SelectedItem.ToString(), out TimeSpan horaInicio) ||
                !TimeSpan.TryParse(dtFimcmbox.SelectedItem.ToString(), out TimeSpan horaFim))
            {
                MessageBox.Show("Horário inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idInstrutorSelecionado = Convert.ToInt32(instrutorcmb.SelectedValue);

            // Captura os IDs dos alunos selecionados
            List<int> alunosSelecionados = new List<int>();
            foreach (AlunoDTO aluno in participantesclb.CheckedItems)
            {
                alunosSelecionados.Add(aluno.IdAluno);
            }

            if (alunosSelecionados.Count == 0)
            {
                MessageBox.Show("Selecione pelo menos um aluno!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Criar a aula com os dados informados
            AulaDTO novaAula = new AulaDTO
            {
                Nome = nomeAulatxt.Text,
                Descricao = descAulatxt.Text,
                DataHorarioInicio = DateTime.Today.Add(horaInicio),
                DataHorarioFim = DateTime.Today.Add(horaFim),
                NameInstrutor = instrutorcmb.Text, // Nome do instrutor
                AlunosIds = alunosSelecionados  // IDs dos alunos selecionados
            };

            // Salvar a aula no banco de dados
            int resultado = aulaController.SalvarAula(novaAula);

            if (resultado > 0)
            {
                MessageBox.Show("Aula cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar os campos após salvar
                nomeAulatxt.Clear();
                descAulatxt.Clear();
                dtIniciocmbox.SelectedIndex = -1;
                dtFimcmbox.SelectedIndex = -1;
                instrutorcmb.SelectedIndex = -1;
                for (int i = 0; i < participantesclb.Items.Count; i++)
                {
                    participantesclb.SetItemChecked(i, false);
                }
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar aula!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
