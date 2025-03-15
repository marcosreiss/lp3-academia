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

            // Primeiro, inserimos a aula na tabela `aula`
            sql = "INSERT INTO aula (nome, descricao, data_horario_inicio, data_horario_fim, idinstrutor) " +
                  "VALUES (@nome, @descricao, @inicio, @fim, (SELECT idinstrutor FROM instrutor WHERE nome = @nameInstrutor LIMIT 1))";

            envelope = new MySqlCommand(sql, con);
            envelope.Parameters.AddWithValue("@nome", aula.Nome);
            envelope.Parameters.AddWithValue("@descricao", aula.Descricao);
            envelope.Parameters.AddWithValue("@inicio", aula.DataHorarioInicio);
            envelope.Parameters.AddWithValue("@fim", aula.DataHorarioFim);
            envelope.Parameters.AddWithValue("@nameInstrutor", aula.NameInstrutor);
            envelope.Prepare();
            envelope.ExecuteNonQuery();

            // Pegamos o ID da aula recém-criada
            sql = "SELECT LAST_INSERT_ID()";
            envelope = new MySqlCommand(sql, con);
            int idAula = Convert.ToInt32(envelope.ExecuteScalar());

            // Agora inserimos os alunos na tabela `aluno_aula`
            foreach (int idAluno in aula.AlunosIds)
            {
                sql = "INSERT INTO aluno_aula (aluno_idaluno, aula_idaula) VALUES (@idAluno, @idAula)";
                envelope = new MySqlCommand(sql, con);
                envelope.Parameters.AddWithValue("@idAluno", idAluno);
                envelope.Parameters.AddWithValue("@idAula", idAula);
                envelope.Prepare();
                envelope.ExecuteNonQuery();
            }

            con.Close();
            return idAula;
        }


        public List<AulaDTO> Listar()
        {
            listaAulas = new List<AulaDTO>();
            con.Open();

            // Consulta para buscar as aulas e seus instrutores
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
                    NameInstrutor = cursor.GetString("nomeInstrutor")
                };

                listaAulas.Add(aula);
            }
            cursor.Close();

            // Agora buscamos os alunos participantes de cada aula
            foreach (var aula in listaAulas)
            {
                sql = "SELECT al.idaluno, al.nome, al.cpf, al.telefone " +
                      "FROM aluno_aula aa " +
                      "INNER JOIN aluno al ON aa.aluno_idaluno = al.idaluno " +
                      "WHERE aa.aula_idaula = @idaula";

                envelope = new MySqlCommand(sql, con);
                envelope.Parameters.AddWithValue("@idaula", aula.IdAula);
                envelope.Prepare();
                cursor = envelope.ExecuteReader();

                while (cursor.Read())
                {
                    AlunoDTO aluno = new AlunoDTO
                    {
                        IdAluno = cursor.GetInt32("idaluno"),
                        Nome = cursor.GetString("nome"),
                        Cpf = cursor.GetString("cpf"),
                        Telefone = cursor.GetString("telefone")
                    };

                    aula.Alunos.Add(aluno);
                }
                cursor.Close();
            }

            con.Close();
            return listaAulas;
        }

    }
}
