using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Web;
using System.Net.Http.Headers;
using System.Data;
using System.Drawing;

namespace Controller
{
    public class Conexao
    {
        //atributos de conexão
        static private string servidor = "localhost";
        static private string db = "testando";
        static private string usuario = "root";
        static private string senha = "";
        public MySqlConnection conn = null;//minha conexão
        //StrCon caminho de conexão
        static private string StrCon = "server=" + servidor + ";database=" + db + ";user id=" + usuario + ";pasword=" + senha;
        //metodo de obter a conexão com o MySql
        public MySqlConnection getConexao()
        {
            MySqlConnection conexao = new MySqlConnection(StrCon);
            return conexao;
        }
        public int cadastrar(string[] campos, object[] valores, string sql, int codigo)
        {
            int registro = 0;
            try
            {
                conn = getConexao();// chamo o metedo obter conexao
                conn.Open();//abro o banco direto
                MySqlCommand command = new MySqlCommand(sql, conn);
                for(int i =0; i < campos.Length; i++)
                {
                    command.Parameters.AddWithValue(campos[i], valores[i]);
                }
                if (codigo > 0)
                {
                    command.Parameters.AddWithValue("id", codigo);
                }
                registro = command.ExecuteNonQuery();
                conn.Close();
                return registro; 
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public DataTable obterDados(string sql)
        {
            //crio uma tabela de dados
            DataTable dt = new DataTable();
            MySqlConnection conn = getConexao();
            conn.Open();//abre o banco de dados
            MySqlCommand sqlCon = new MySqlCommand(sql, conn);
            sqlCon.CommandType = System.Data.CommandType.Text;
            sqlCon.CommandText = sql;
            MySqlDataAdapter dados = new MySqlDataAdapter(sql, conn);
            dados.Fill(dt);// montar a tabela dados
            conn.Close();
            return dt;
        }
        public int atualizar(string[] campos, object[] valores, string sql)
        {
            int registro = 0;
            return registro;
        }
    }
}
