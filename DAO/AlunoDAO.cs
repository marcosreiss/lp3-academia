using lp3_academia.DTO;
using MySqlConnector;
using lp3_academia.util;

namespace lp3_academia.DAO
{
    internal class AlunoDAO
    {
        private MySqlConnection? con;
        private MySqlCommand? envelope;
        private MySqlDataReader? cursor;
        private List<AlunoDTO> listaAlunos;
        private string? sql;

        public AlunoDAO()
        {
            ConexaoBD conexaobd = new ConexaoBD();
            con = conexaobd.RetornaConexao();
        }

        public int Salvar(AlunoDTO aluno)
        {
            con.Open();
            sql = "INSERT INTO aluno (nome, data_nascimento, cpf, telefone, data_matricula) " +
                  "VALUES (@nome, @data_nascimento, @cpf, @telefone, @data_matricula)";

            envelope = new MySqlCommand(sql, con);
            envelope.Parameters.AddWithValue("@nome", aluno.Nome);
            envelope.Parameters.AddWithValue("@data_nascimento", aluno.DataNascimento);
            envelope.Parameters.AddWithValue("@cpf", aluno.Cpf);
            envelope.Parameters.AddWithValue("@telefone", aluno.Telefone);
            envelope.Parameters.AddWithValue("@data_matricula", aluno.DataMatricula);

            envelope.Prepare();
            int resultado = envelope.ExecuteNonQuery();
            con.Close();
            return resultado;
        }

        public List<AlunoDTO> Listar()
        {
            listaAlunos = new List<AlunoDTO>();
            con.Open();
            sql = "SELECT * FROM aluno";

            envelope = new MySqlCommand(sql, con);
            envelope.Prepare();
            cursor = envelope.ExecuteReader();

            while (cursor.Read())
            {
                AlunoDTO aluno = new AlunoDTO
                {
                    IdAluno = cursor.GetInt32("idaluno"),
                    Nome = cursor.GetString("nome"),
                    DataNascimento = cursor.GetDateTime("data_nascimento"),
                    Cpf = cursor.GetString("cpf"),
                    Telefone = cursor.GetString("telefone"),
                    DataMatricula = cursor.GetDateTime("data_matricula")
                };
                listaAlunos.Add(aluno);
            }

            con.Close();
            return listaAlunos;
        }
    }
}
