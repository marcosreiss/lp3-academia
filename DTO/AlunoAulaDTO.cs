namespace lp3_academia.DTO
{
    internal class AlunoAulaDTO
    {
        public int IdAluno { get; set; }
        public int IdAula { get; set; }
        public int IdInstrutor { get; set; }

        public AlunoAulaDTO() { }

        public AlunoAulaDTO(int idAluno, int idAula, int idInstrutor)
        {
            IdAluno = idAluno;
            IdAula = idAula;
            IdInstrutor = idInstrutor;
        }
    }
}
