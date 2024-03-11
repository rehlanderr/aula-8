using MySql.Data.MySqlClient;//bibiotleca do mysql
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    public class conexao
    {
        // vvariaveis de conexao com o banco de dados 
        static private string servidor = "localhost"; //nome
        static private string bd = "projeto"; //nome do banco 
        static private string usuario = "root"; // administrador do banco
        static private string senha = ""; //senha do mysql
        public MySqlConnection conn = null;
        static private string StrConn = "server="+servidor+";database="+bd+";user id="+usuario+";senha="+senha;
        //metodo de conectar o c# com o mysql
        public MySqlConnection GetConnection() 
        { 
        conn = new MySqlConnection(StrConn);
            return conn;
        }
        public int cadastrar(string nome, string email, string senha)
        {
            int cadastro = 0;
            try
            {
                conn =  GetConnection();
                conn.Open();
                string sql = "insert into usuario(nome, email,senha) values ('" + nome + "' ,' " + email + "' ,' " + senha + "')";
                MySqlCommand smd = new MySqlCommand(sql, conn);
                cadastro = smd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);

            }
            return cadastro;

        }
        public DataTable obterdados(string sql) 
        {
          DataTable dt = new DataTable();   
            conn= GetConnection();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt; 
        }
           
    }
}
