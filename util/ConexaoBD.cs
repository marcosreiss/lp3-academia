using MySqlConnector;

namespace ProjetoAcademico.util
{
    internal class ConexaoBD
    {
        private MySqlConnection con;

        public ConexaoBD()
        {
            string strconexao = "server=localhost;userid=root;password=root;database=academiadb";
            con = new MySqlConnection(strconexao);
        }

        public MySqlConnection RetornaConexao()
        {
            return this.con;
        }

        public void AbrirConexao()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                    Console.WriteLine("Conexão aberta com sucesso.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao abrir conexão: " + ex.Message);
            }
        }

        public void FecharConexao()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                    Console.WriteLine("Conexão fechada com sucesso.");
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Erro ao fechar conexão: " + ex.Message);
            }
        }
    }
}
