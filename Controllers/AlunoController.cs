using lp3_academia.DAO;
using lp3_academia.DTO;

namespace lp3_academia.Controller
{
    internal class AlunoController
    {
        public int SalvarAluno(string nome, DateTime dataNascimento, string cpf, string telefone, DateTime dataMatricula)
        {
            AlunoDTO alunoDTO = new AlunoDTO
            {
                Nome = nome,
                DataNascimento = dataNascimento,
                Cpf = cpf,
                Telefone = telefone,
                DataMatricula = dataMatricula
            };

            AlunoDAO alunoDAO = new AlunoDAO();
            return alunoDAO.Salvar(alunoDTO);
        }

        public List<AlunoDTO> ListarAlunos()
        {
            AlunoDAO alunoDAO = new AlunoDAO();
            return alunoDAO.Listar();
        }
    }
}
