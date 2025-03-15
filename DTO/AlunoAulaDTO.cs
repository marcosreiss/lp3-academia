namespace lp3_academia.DTO
{
    public class AlunoAulaDTO
    {
        public int IdAluno { get; set; }
        public int IdAula { get; set; }

        public AlunoAulaDTO() { }

        public AlunoAulaDTO(int idAluno, int idAula)
        {
            IdAluno = idAluno;
            IdAula = idAula;
        }
    }
}
