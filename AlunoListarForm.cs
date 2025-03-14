using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lp3_academia
{
    public partial class AlunoListarForm : Form
    {
        public AlunoListarForm(List<Aluno> listaAlunos)
        {
            InitializeComponent();
            CarregarAlunos(listaAlunos);
        }

        private void CarregarAlunos(List<Aluno> listaAlunos)
        {
            // Configurar as colunas do DataGridView
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
            foreach (Aluno aluno in listaAlunos)
            {
                dataGridViewAlunos.Rows.Add(aluno.Nome, aluno.CPF, aluno.Telefone,
                                            aluno.DataNascimento.ToString("dd/MM/yyyy"),
                                            aluno.DataMatricula.ToString("dd/MM/yyyy"));
            }
        }

        private void AlunoListarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
