using lp3_academia.DAO;
using lp3_academia.DTO;

namespace lp3_academia.Controller
{
    internal class AlunoAulaController
    {
        public int VincularAlunoAula(int idAluno, int idAula)
        {
            AlunoAulaDTO alunoAulaDTO = new AlunoAulaDTO
            {
                IdAluno = idAluno,
                IdAula = idAula,
            };

            AlunoAulaDAO alunoAulaDAO = new AlunoAulaDAO();
            return alunoAulaDAO.VincularAlunoAula(alunoAulaDTO);
        }
    }
}
