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

namespace lp3_academia
{
    public partial class InstrutorForm : Form
    {
        public InstrutorForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nomeInstrutortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpfInstrutortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void especialidadeInstrutortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void contratacaoInstrutordateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void salvarIntrutorbtt_Click(object sender, EventArgs e)
        {
            string nome = nomeInstrutortxt.Text.Trim();
            string cpf = cpfInstrutortxt.Text.Trim();
            string especialidade = especialidadeInstrutortxt.Text.Trim();
            DateTime dataContratacao = contratacaoInstrutordateTime.Value;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(especialidade))
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Instrutor novoInstrutor = new Instrutor(nome, cpf, especialidade, dataContratacao);

            // Adiciona à lista do Form1
            Form1 formPrincipal = (Form1)Application.OpenForms["Form1"];
            formPrincipal.listaInstrutores.Add(novoInstrutor);

            MessageBox.Show("Instrutor cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpa os campos após salvar
            nomeInstrutortxt.Clear();
            cpfInstrutortxt.Clear();
            especialidadeInstrutortxt.Clear();
        }

        private void InstrutorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
