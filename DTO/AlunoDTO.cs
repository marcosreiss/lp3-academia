namespace lp3_academia.DTO
{
    public class AlunoDTO
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime DataMatricula { get; set; }
        public List<AulaDTO> Aulas { get; set; } = new List<AulaDTO>();

        public AlunoDTO() { }

        public AlunoDTO( string nome, DateTime dataNascimento, string cpf, string telefone, DateTime dataMatricula)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
            Telefone = telefone;
            DataMatricula = dataMatricula;
        }
    }
}
