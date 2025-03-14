using lp3_academia.DTO;
using lp3_academia.util;
using MySqlConnector;

namespace lp3_academia.DAO
{
    internal class AlunoAulaDAO
    {
        private MySqlConnection? con;
        private MySqlCommand? envelope;
        private string? sql;

        public AlunoAulaDAO()
        {
            ConexaoBD conexaobd = new ConexaoBD();
            con = conexaobd.RetornaConexao();
        }

        public int VincularAlunoAula(AlunoAulaDTO alunoAula)
        {
            con.Open();
            sql = "INSERT INTO aluno_aula (aluno_idaluno, aula_idaula, aula_instrutor_idinstrutor) " +
                  "VALUES (@alunoId, @aulaId, @instrutorId)";

            envelope = new MySqlCommand(sql, con);
            envelope.Parameters.AddWithValue("@alunoId", alunoAula.IdAluno);
            envelope.Parameters.AddWithValue("@aulaId", alunoAula.IdAula);
            envelope.Parameters.AddWithValue("@instrutorId", alunoAula.IdInstrutor);

            envelope.Prepare();
            int resultado = envelope.ExecuteNonQuery();
            con.Close();
            return resultado;
        }
    }
}
