using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Controller
{
    public class conexao
    {
        //atributos de conexão
        static private string servidor = "localhost";
        static private string db = "testando";
        static private string usuario = "root";
        static private string senha = "";
        //StrCon caminho de conexão
        static private string StrCon = "server=" + servidor + ";database=" + db + ";user id=" + usuario + ";pasword=" + senha;
        //metodo de obter a conexão com o MySql
        public MySqlConnection getConexão()
        {
            MySqlConnection conexao = new MySqlConnection(StrCon);
            return conexao;
        }
    }
}
