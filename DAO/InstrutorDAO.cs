using lp3_academia.DTO;
using lp3_academia.util;
using MySqlConnector;

namespace lp3_academia.DAO
{
    internal class InstrutorDAO
    {
        private MySqlConnection? con;
        private MySqlCommand? envelope;
        private MySqlDataReader? cursor;
        private List<InstrutorDTO> listaInstrutores;
        private string? sql;

        public InstrutorDAO()
        {
            ConexaoBD conexaobd = new ConexaoBD();
            con = conexaobd.RetornaConexao();
        }

        public int Salvar(InstrutorDTO instrutor)
        {
            con.Open();
            sql = "INSERT INTO instrutor (nome, cpf, especialiade, data_contratacao) " +
                  "VALUES (@nome, @cpf, @especialidade, @data_contratacao)";

            envelope = new MySqlCommand(sql, con);
            envelope.Parameters.AddWithValue("@nome", instrutor.Nome);
            envelope.Parameters.AddWithValue("@cpf", instrutor.Cpf);
            envelope.Parameters.AddWithValue("@especialidade", instrutor.Especialidade);
            envelope.Parameters.AddWithValue("@data_contratacao", instrutor.DataContratacao);

            envelope.Prepare();
            int resultado = envelope.ExecuteNonQuery();
            con.Close();
            return resultado;
        }

        public List<InstrutorDTO> Listar()
        {
            listaInstrutores = new List<InstrutorDTO>();
            con.Open();
            sql = "SELECT * FROM instrutor";

            envelope = new MySqlCommand(sql, con);
            envelope.Prepare();
            cursor = envelope.ExecuteReader();

            while (cursor.Read())
            {
                InstrutorDTO instrutor = new InstrutorDTO
                {
                    IdInstrutor = cursor.GetInt32("idinstrutor"),
                    Nome = cursor.GetString("nome"),
                    Cpf = cursor.GetString("cpf"),
                    Especialidade = cursor.GetString("especialiade"),
                    DataContratacao = cursor.GetDateTime("data_contratacao")
                };
                listaInstrutores.Add(instrutor);
            }

            con.Close();
            return listaInstrutores;
        }
    }
}
