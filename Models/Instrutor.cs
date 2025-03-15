using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lp3_academia.Models
{
    public class Instrutor
    { 

        
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Especialidade { get; set; }
        public DateTime DataContratacao { get; set; }

        public Instrutor(string nome, string cpf, string especialidade, DateTime dataContratacao)
        {

            this.Nome = nome;
            this.CPF = cpf;
            this.Especialidade = especialidade;
            this.DataContratacao = dataContratacao;
        }
    }

}
