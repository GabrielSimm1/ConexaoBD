using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;
using System.Data;

namespace Controller
{
    public class UsuarioController
    {// instanciei o objeto conexao
        conexao con = new conexao();

        //criando o metodo de cadastrar usuario
        public bool cadastrar(UsuarioModelo usuario)
        {
            //declaro a variavel da resposta da minha query
            bool resultado = false;
            string sql = "insert into usuario(nome, senha) values('" + usuario.nome + "','" + usuario.senha + "')";

            //chamando minha conexão
            MySqlConnection sqlCon = con.getConexão();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            if (cmd.ExecuteNonQuery() >= 1) ;//executar o seu sql
            resultado = true;
            sqlCon.Close();//fecho a conexao

            return resultado;//retorna o valor
        }
        public DataTable obterDados(string sql)
        {
            //crio uma tabela de dados
            DataTable dt = new DataTable();
            MySqlConnection conn = con.getConexão();
            conn.Open();//abre o banco de dados
            MySqlCommand sqlCon = new MySqlCommand(sql, conn);
            sqlCon.CommandType = System.Data.CommandType.Text;
            sqlCon.CommandText = sql;
            MySqlDataAdapter dados = new MySqlDataAdapter(sql, conn);
            dados.Fill(dt);// montar a tabela dados
            conn.Close();
            return dt;
        }
        public bool Excluir(int codigo)
        {
            bool resultado = false;
            MySqlConnection sqlcon = con.getConexão();
            string sql = "delete from usuario where id = " + codigo;
            sqlcon.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, sqlcon);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.CommandText = sql;
            if(mySqlCommand.ExecuteNonQuery() >= 1)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
