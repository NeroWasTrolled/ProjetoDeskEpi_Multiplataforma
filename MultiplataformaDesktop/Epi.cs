using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplataformaDesktop
{
    public class Epi
    {
        public int id { get; set; }
        public string epi { get; set; }
        public DateTime validade { get; set; }

        MySqlConnection con = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm");
        public List<Epi> listaepi()
        {
            List<Epi> li = new List<Epi>();
            string sql = "SELECT * FROM epi";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Epi p = new Epi();
                p.id = (int)dr["id"];
                p.epi = dr["epi"].ToString();
                if (!dr.IsDBNull(dr.GetOrdinal("validade")))
                {
                    DateTime dataHora = dr.GetDateTime(dr.GetOrdinal("validade"));
                    DateTime data = dataHora.Date;
                    p.validade = data;
                }
                else
                {
                    p.validade = DateTime.MinValue;
                }
                li.Add(p);
            }
            dr.Close();
            con.Close();
            return li;
        }
        public List<Epi> ListaEpiVencidos()
        {
            List<Epi> listaVencidos = new List<Epi>();
            string dataAtual = DateTime.Now.ToString("yyyy-MM-dd");
            string sql = "SELECT * FROM epi WHERE validade < '" + dataAtual + "'";

            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Epi epi = new Epi();
                    epi.id = (int)dr["id"];
                    epi.epi = dr["epi"].ToString();
                    epi.validade = dr.GetDateTime(dr.GetOrdinal("validade"));
                    listaVencidos.Add(epi);
                }

                dr.Close();
            }

            return listaVencidos;
        }

        public List<Epi> ListaEpiAlertaVencimento()
        {
            List<Epi> listaAlertaVencimento = new List<Epi>();
            DateTime dataAtual = DateTime.Now;
            DateTime dataLimite = dataAtual.AddDays(3);
            string dataLimiteFormatada = dataLimite.ToString("yyyy-MM-dd");
            string sql = "SELECT * FROM epi WHERE validade BETWEEN '" + dataAtual.ToString("yyyy-MM-dd") + "' AND '" + dataLimiteFormatada + "'";

            using (MySqlConnection con = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Epi epi = new Epi();
                    epi.id = (int)dr["id"];
                    epi.epi = dr["epi"].ToString();
                    epi.validade = dr.GetDateTime(dr.GetOrdinal("validade"));
                    listaAlertaVencimento.Add(epi);
                }

                dr.Close();
            }

            return listaAlertaVencimento;
        }

        public void LocalizarPorNome(string nome)
        {
            string sql = "SELECT * FROM epi WHERE epi = @Epi";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Epi", nome);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = (int)dr["id"];
                this.epi = dr["epi"].ToString();
                if (!dr.IsDBNull(dr.GetOrdinal("validade")))
                {
                    DateTime dataHora = dr.GetDateTime(dr.GetOrdinal("validade"));
                    DateTime data = dataHora.Date;
                    validade = data;
                }
                else
                {
                    validade = DateTime.MinValue;
                }
            }
            dr.Close();
            con.Close();
        }

        public void Inserir(string epi, DateTime validade)
        {
            string sql = "INSERT INTO epi (epi, validade) VALUES (@epi, @validade)";

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@epi", epi);
            cmd.Parameters.AddWithValue("@validade", validade.ToString("yyyy-MM-dd"));
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Atualizar(int id, string epi, DateTime validade)
        {
            string sql = "UPDATE epi SET epi = @epi, validade = @validade WHERE id = @id";

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@epi", epi);
            cmd.Parameters.AddWithValue("@validade", validade);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void Excluir(int id)
        {
            string sql = "DELETE FROM epi WHERE id = @id";

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            con.Close();
        }


        public void Localizar(int id)
        {
            string sql = "SELECT * FROM epi WHERE id='" + id + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                epi = dr["epi"].ToString();
                // Atribui a data de validade recuperada do banco de dados à propriedade "validade"
                if (!dr.IsDBNull(dr.GetOrdinal("validade")))
                {
                    DateTime dataHora = dr.GetDateTime(dr.GetOrdinal("validade"));
                    DateTime data = dataHora.Date;
                    validade = data;
                }
                else
                {
                    validade = DateTime.MinValue;
                }
            }
            dr.Close();
            con.Close();
        }


        public bool RegistroRepetido(string epi, DateTime validade)
        {
            string sql = "SELECT COUNT(*) FROM epi WHERE epi = @epi AND validade = @validade";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@epi", epi);
            cmd.Parameters.AddWithValue("@validade", validade.ToString("yyyy-MM-dd"));
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count > 0;
        }

    }
}

