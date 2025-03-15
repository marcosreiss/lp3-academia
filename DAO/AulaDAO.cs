using lp3_academia.DTO;
using lp3_academia.util;
using MySqlConnector;

namespace lp3_academia.DAO
{
    internal class AulaDAO
    {
        private MySqlConnection? con;
        private MySqlCommand? envelope;
        private MySqlDataReader? cursor;
        private List<AulaDTO> listaAulas;
        private string? sql;

        public AulaDAO()
        {
            ConexaoBD conexaobd = new ConexaoBD();
            con = conexaobd.RetornaConexao();
        }

        public int Salvar(AulaDTO aula)
        {
            con.Open();
            sql = "INSERT INTO aula (nome, descricao, data_horario_inicio, data_horario_fim, idinstrutor) " +
                  "VALUES (@nome, @descricao, @inicio, @fim, (SELECT idinstrutor FROM instrutor WHERE nome = @nameInstrutor LIMIT 1))";

            envelope = new MySqlCommand(sql, con);
            envelope.Parameters.AddWithValue("@nome", aula.Nome);
            envelope.Parameters.AddWithValue("@descricao", aula.Descricao);
            envelope.Parameters.AddWithValue("@inicio", aula.DataHorarioInicio);
            envelope.Parameters.AddWithValue("@fim", aula.DataHorarioFim);
            envelope.Parameters.AddWithValue("@nameInstrutor", aula.NameInstrutor);

            envelope.Prepare();
            int resultado = envelope.ExecuteNonQuery();
            con.Close();
            return resultado;
        }

        public List<AulaDTO> Listar()
        {
            listaAulas = new List<AulaDTO>();
            con.Open();

            // Ajustamos a query para trazer o nome do instrutor em vez do ID
            sql = "SELECT a.idaula, a.nome, a.descricao, a.data_horario_inicio, a.data_horario_fim, i.nome AS nomeInstrutor " +
                  "FROM aula a " +
                  "INNER JOIN instrutor i ON a.idinstrutor = i.idinstrutor";

            envelope = new MySqlCommand(sql, con);
            envelope.Prepare();
            cursor = envelope.ExecuteReader();

            while (cursor.Read())
            {
                AulaDTO aula = new AulaDTO
                {
                    IdAula = cursor.GetInt32("idaula"),
                    Nome = cursor.GetString("nome"),
                    Descricao = cursor.GetString("descricao"),
                    DataHorarioInicio = cursor.GetDateTime("data_horario_inicio"),
                    DataHorarioFim = cursor.GetDateTime("data_horario_fim"),
                    NameInstrutor = cursor.GetString("nomeInstrutor") // Agora pega o nome do instrutor corretamente
                };
                listaAulas.Add(aula);
            }

            con.Close();
            return listaAulas;
        }
    }
}
