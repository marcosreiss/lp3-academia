using lp3_academia.DAO;
using lp3_academia.DTO;

namespace lp3_academia.Controller
{
    internal class InstrutorController
    {
        public int SalvarInstrutor(string nome, string cpf, string especialidade, DateTime dataContratacao)
        {
            InstrutorDTO instrutorDTO = new InstrutorDTO
            {
                Nome = nome,
                Cpf = cpf,
                Especialidade = especialidade,
                DataContratacao = dataContratacao
            };

            InstrutorDAO instrutorDAO = new InstrutorDAO();
            return instrutorDAO.Salvar(instrutorDTO);
        }

        public List<InstrutorDTO> ListarInstrutores()
        {
            InstrutorDAO instrutorDAO = new InstrutorDAO();
            return instrutorDAO.Listar();
        }
    }
}
