using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;
using System.Windows.Forms;

namespace MultiplataformaDesktop
{
    public class Entrega
    {
        public int id { get; set; }
        public int matricula { get; set; }
        public string nome { get; set; }
        public string epi { get; set; }
        public DateTime entregaData { get; set; }
        public DateTime validade { get; set; }

        private readonly MySqlConnection con;

        public Entrega()
        {
            con = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm");
        }

        public List<Entrega> ListarEntregas()
        {
            List<Entrega> entregas = new List<Entrega>();

            string sql = "SELECT e.id, f.matricula, f.nome AS NomeFuncionario, ep.epi, ep.validade AS ValidadeEpi, e.entrega AS EntregaData " +
                         "FROM entrega e " +
                         "INNER JOIN funcionario f ON e.matricula = f.matricula " +
                         "INNER JOIN epi ep ON e.epi = ep.epi";

            using (MySqlConnection connection = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm"))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Entrega entrega = new Entrega();
                    entrega.id = Convert.ToInt32(dr["id"]);
                    entrega.matricula = Convert.ToInt32(dr["matricula"]);
                    entrega.nome = dr["NomeFuncionario"].ToString();
                    entrega.epi = dr["epi"].ToString();
                    entrega.entregaData = Convert.ToDateTime(dr["EntregaData"]);
                    entrega.validade = Convert.ToDateTime(dr["ValidadeEpi"]);

                    entregas.Add(entrega);
                }
            }

            return entregas;
        }

        public void Inserir(int matricula, string nome, string epi, DateTime entregaData, DateTime validade)
        {
            string sql = "INSERT INTO entrega (matricula, nome, epi, entrega, validade) VALUES (@Matricula, @Nome, @Epi, @EntregaData, @Validade)";

            using (MySqlConnection connection = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm"))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Matricula", matricula);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Epi", epi);
                cmd.Parameters.AddWithValue("@EntregaData", entregaData);
                cmd.Parameters.AddWithValue("@Validade", validade);
                cmd.ExecuteNonQuery();
            }
        }

        public void Atualizar(int id, string nome, int matricula, string epi, DateTime entrega, DateTime validade)
        {
            string sql = "UPDATE entrega SET nome = @Nome, matricula = @Matricula, epi = @Epi, entrega = @EntregaData, validade = @Validade WHERE id = @Id";

            using (MySqlConnection connection = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm"))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@Matricula", matricula);
                cmd.Parameters.AddWithValue("@Epi", epi);
                cmd.Parameters.AddWithValue("@EntregaData", entrega);
                cmd.Parameters.AddWithValue("@Validade", validade);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Excluir(int id)
        {
            string sql = "DELETE FROM entrega WHERE id = @Id";

            using (MySqlConnection connection = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm"))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Localizar(int id)
        {
            string sql = "SELECT e.*, f.nome AS NomeFuncionario FROM entrega e INNER JOIN funcionario f ON e.matricula = f.matricula WHERE e.id = @Id";

            using (MySqlConnection connection = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm"))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    matricula = (int)dr["matricula"];
                    nome = dr["NomeFuncionario"].ToString(); // Verifique se o nome está corretamente obtido
                    epi = dr["epi"].ToString();
                    entregaData = Convert.ToDateTime(dr["entrega"]);
                    validade = Convert.ToDateTime(dr["validade"]);
                }
                dr.Close();
            }
        }

        public bool RegistroRepetido(int matricula, string epi, DateTime entrega)
        {
            string sql = "SELECT COUNT(*) FROM entrega WHERE matricula = @Matricula AND epi = @Epi AND entrega = @EntregaData";

            using (MySqlConnection connection = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm"))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Matricula", matricula);
                cmd.Parameters.AddWithValue("@Epi", epi);
                cmd.Parameters.AddWithValue("@EntregaData", entrega);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        public List<Entrega> ListarPorMatricula(int matricula)
        {
            List<Entrega> entregas = new List<Entrega>();

            string sql = "SELECT * FROM entrega WHERE matricula = @Matricula";

            using (MySqlConnection connection = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm"))
            {
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@Matricula", matricula);

                    connection.Open();

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Entrega entrega = new Entrega();
                            entrega.id = Convert.ToInt32(dr["id"]);
                            entrega.matricula = Convert.ToInt32(dr["matricula"]);
                            entrega.nome = dr["nome"].ToString();
                            entrega.epi = dr["epi"].ToString();
                            entrega.entregaData = Convert.ToDateTime(dr["entrega"]);
                            entrega.validade = Convert.ToDateTime(dr["validade"]);

                            entregas.Add(entrega);
                        }
                    }
                }
            }
            return entregas;
        }

    }
}
