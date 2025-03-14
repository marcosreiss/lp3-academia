using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp3_academia
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataMatricula { get; set; }

        public Aluno(string nome, string cpf, string telefone, DateTime dataNascimento, DateTime dataMatricula)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            DataMatricula = dataMatricula;
        }
    }
}

