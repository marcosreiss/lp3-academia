using lp3_academia.Controller;
using lp3_academia.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lp3_academia
{
    public partial class AlunoListarForm : Form
    {
        private AlunoController alunoController;
        public List<AlunoDTO> listaAlunos { get; set; }

        public AlunoListarForm()
        {
            InitializeComponent();
            alunoController = new AlunoController();
            listaAlunos = new List<AlunoDTO>();
        }

        private void AlunoListarForm_Load(object sender, EventArgs e)
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
