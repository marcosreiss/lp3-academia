using lp3_academia.DAO;
using lp3_academia.DTO;

namespace lp3_academia.Controller
{
    internal class AulaController
    {
        public int SalvarAula(string nome, string descricao, DateTime dataHorarioInicio, DateTime dataHorarioFim, int idInstrutor)
        {
            AulaDTO aulaDTO = new AulaDTO
            {
                Nome = nome,
                Descricao = descricao,
                DataHorarioInicio = dataHorarioInicio,
                DataHorarioFim = dataHorarioFim,
            };

            AulaDAO aulaDAO = new AulaDAO();
            return aulaDAO.Salvar(aulaDTO);
        }

        public List<AulaDTO> ListarAulas()
        {
            AulaDAO aulaDAO = new AulaDAO();
            return aulaDAO.Listar();
        }
    }
}
