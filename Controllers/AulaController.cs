using lp3_academia.DAO;
using lp3_academia.DTO;

namespace lp3_academia.Controller
{
    internal class AulaController
    {
        public int SalvarAula(AulaDTO aulaDTO)
        {
            

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
