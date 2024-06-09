﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySqlConnector;

namespace MultiplataformaDesktop
{
    public class Funcionario
    {
        public int id { get; set; }
        public int matricula { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string celular { get; set; }

        MySqlConnection con = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm");

        public List<Funcionario> listafuncionario()
        {
            List<Funcionario> li = new List<Funcionario>();
            string sql = "SELECT * FROM funcionario";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Funcionario p = new Funcionario();
                p.id = (int)dr["id"];
                p.matricula = (int)dr["matricula"];
                p.nome = dr["nome"].ToString();
                p.cpf = dr["cpf"].ToString();
                p.celular = dr["celular"].ToString();
                li.Add(p);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void LocalizarPorNome(string nome)
        {
            string sql = "SELECT * FROM funcionario WHERE nome = @Nome";

            using (MySqlConnection connection = new MySqlConnection("server=sql.freedb.tech;port=3306;database=freedb_Cristiano_Ronaldo;user=freedb_Bellingham;password=Bjy6P%Yr3p9??rm"))
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@Nome", nome);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    matricula = (int)dr["matricula"];
                    this.nome = dr["nome"].ToString(); // Corrigido para this.nome
                    cpf = dr["cpf"].ToString();
                    celular = dr["celular"].ToString();
                }
                dr.Close();
            }
        }


        public void Inserir(int matricula, string nome, string cpf, string celular)
        {
            string sql = "INSERT INTO funcionario(matricula, nome, cpf, celular) VALUES ('" + matricula + "','" + nome + "','" + cpf + "','" + celular + "')";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Atualizar(int id, int matricula, string nome, string cpf, string celular)
        {
            string sql = "UPDATE funcionario SET matricula='" + matricula + "', nome='" + nome + "', cpf='" + cpf + "', celular='" + celular + "' WHERE id='" + id + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Excluir(int id)
        {
            string sql = "DELETE FROM entrega WHERE id = @Id";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void Localizar(int id)
        {
            string sql = "SELECT * FROM funcionario WHERE id='" + id + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                matricula = (int)dr["matricula"];
                nome = dr["nome"].ToString();
                cpf = dr["cpf"].ToString();
                celular = dr["celular"].ToString();
            }
            dr.Close();
            con.Close();
        }

        public bool RegistroRepetido(int matricula, string nome, string cpf, string celular)
        {
            string sql = "SELECT * FROM funcionario WHERE matricula='" + matricula + "' AND nome='" + nome + "' AND cpf='" + cpf + "' AND celular='" + celular + "'";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteNonQuery();
            if (result != null)
            {
                return (int)result > 0;
            }
            con.Close();
            return false;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
