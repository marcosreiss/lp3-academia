namespace lp3_academia.DTO
{
    public class AulaDTO
    {
        public int IdAula { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHorarioInicio { get; set; }
        public DateTime DataHorarioFim { get; set; }
        public string NameInstrutor { get; set; }
        public List<AlunoDTO> Alunos { get; set; } = new List<AlunoDTO>(); // Lista populada ao listar
        public List<int> AlunosIds { get; set; } = new List<int>(); // IDs passados ao salvar

        public AulaDTO() { }

        public AulaDTO(string nome, string descricao, DateTime dataHorarioInicio, DateTime dataHorarioFim, string nameInstrutor)
        {
            Nome = nome;
            Descricao = descricao;
            DataHorarioInicio = dataHorarioInicio;
            DataHorarioFim = dataHorarioFim;
            NameInstrutor = nameInstrutor;
        }
    }
}
