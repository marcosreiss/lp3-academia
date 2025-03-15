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
    public partial class CriarAulaForm : Form
    {
        private List<Aula> listaAulas;

        public CriarAulaForm(List<Aula> aulas)
        {
            InitializeComponent();
            this.listaAulas = aulas;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nomeAulatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void descAulatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtIniciocmbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtFimcmbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idInstrutortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CriarAulaForm_Load(object sender, EventArgs e)
        {
            PreencherHorariosComboBox();

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

        private void salvarAulabtt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nomeAulatxt.Text) ||
                string.IsNullOrWhiteSpace(descAulatxt.Text) ||
                dtIniciocmbox.SelectedItem == null ||
                dtFimcmbox.SelectedItem == null ||
                string.IsNullOrWhiteSpace(idInstrutortxt.Text))
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

            if (!int.TryParse(idInstrutortxt.Text, out int idInstrutor))
            {
                MessageBox.Show("ID do instrutor inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Aula novaAula = new Aula
            {
                Id = listaAulas.Count + 1,
                Nome = nomeAulatxt.Text,
                Descricao = descAulatxt.Text,
                DataInicio = DateTime.Today.Add(horaInicio),
                DataFim = DateTime.Today.Add(horaFim),
                IdInstrutor = idInstrutor
            };

            listaAulas.Add(novaAula);
            MessageBox.Show("Aula cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nomeAulatxt.Clear();
            descAulatxt.Clear();
            idInstrutortxt.Clear();
            dtIniciocmbox.SelectedIndex = -1;
            dtFimcmbox.SelectedIndex = -1;
        }

    }
}
