using lp3_academia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lp3_academia.aulaView
{
    public partial class AulaListarForm : Form
    {
        public AulaListarForm(List<Aula> listaAulas)
        {
            InitializeComponent();
            CarregarAulas(listaAulas);
        }

        private void CarregarAulas(List<Aula> listaAulas)
        {
            // Configurar as colunas do DataGridView
            if (dataGridViewAulas.Columns.Count == 0)
            {
                dataGridViewAulas.Columns.Add("Id", "ID");
                dataGridViewAulas.Columns.Add("Nome", "Nome");
                dataGridViewAulas.Columns.Add("Descricao", "Descrição");
                dataGridViewAulas.Columns.Add("DataInicio", "Data de Início");
                dataGridViewAulas.Columns.Add("DataFim", "Data de Fim");
                dataGridViewAulas.Columns.Add("IdInstrutor", "ID do Instrutor");
            }

            // Limpar antes de adicionar novos dados
            dataGridViewAulas.Rows.Clear();

            // Adicionar as aulas ao DataGridView
            foreach (Aula aula in listaAulas)
            {
                dataGridViewAulas.Rows.Add(aula.Id, aula.Nome, aula.Descricao,
                                           aula.DataInicio.ToString("dd/MM/yyyy HH:mm"),
                                           aula.DataFim.ToString("dd/MM/yyyy HH:mm"),
                                           aula.IdInstrutor);
            }
        }
        private void AulaListarForm_Load(object sender, EventArgs e)
        {
          
        }
    }
}
