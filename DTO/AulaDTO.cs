namespace lp3_academia.DTO
{
    internal class AulaDTO
    {
        public int IdAula { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataHorarioInicio { get; set; }
        public DateTime DataHorarioFim { get; set; }
        public int IdInstrutor { get; set; }
        public List<AlunoDTO> Alunos { get; set; } = new List<AlunoDTO>();

        public AulaDTO() { }

        public AulaDTO(int idAula, string nome, string descricao, DateTime dataHorarioInicio, DateTime dataHorarioFim, int idInstrutor)
        {
            IdAula = idAula;
            Nome = nome;
            Descricao = descricao;
            DataHorarioInicio = dataHorarioInicio;
            DataHorarioFim = dataHorarioFim;
            IdInstrutor = idInstrutor;
        }
    }
}
