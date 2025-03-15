namespace lp3_academia.DTO
{
    public class InstrutorDTO
    {
        public int IdInstrutor { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Especialidade { get; set; }
        public DateTime DataContratacao { get; set; }

        public InstrutorDTO() { }

        public InstrutorDTO(int idInstrutor, string nome, string cpf, string especialidade, DateTime dataContratacao)
        {
            IdInstrutor = idInstrutor;
            Nome = nome;
            Cpf = cpf;
            Especialidade = especialidade;
            DataContratacao = dataContratacao;
        }
    }
}
