using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Controller
{
    public class UsuarioController
    {// instanciei o objeto conexao
        Conexao con = new Conexao();

        //criando o metodo de cadastrar usuario
        public bool cadastrar(UsuarioModelo usuario)
        {
            //declaro a variavel da resposta da minha query
            bool resultado = false;
            string sql = "insert into usuario(nome, senha, id_perfil) values('" + usuario.nome + "','" + usuario.senha + "', "+usuario.id_perfil+")";

            //chamando minha conexão
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            if (cmd.ExecuteNonQuery() >= 1)//executar o seu sql
            resultado = true;
            sqlCon.Close();//fecho a conexao

            return resultado;//retorna o valor
        }
        public DataTable obterDados(string sql)
        {
            //crio uma tabela de dados
            DataTable dt = new DataTable();
            MySqlConnection conn = con.getConexao();
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
            MySqlConnection sqlcon = con.getConexao();
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
        public bool Editar(UsuarioModelo us)
        {
            bool resultado = false;
            string sql = "update usuario set nome=@nome, senha=@senha, id_perfil=@perfil where id=@id";
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlcon);
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            command.Parameters.AddWithValue("@nome", us.nome);
            command.Parameters.AddWithValue("@senha", us.senha);
            command.Parameters.AddWithValue("@id", us.id);
            command.Parameters.AddWithValue("@perfil", us.id_perfil);
            if (command.ExecuteNonQuery() >= 1)
                resultado = true;
            sqlcon.Close();
            return resultado;
        }
        public UsuarioModelo carregaDados(int codigo)
        {
            UsuarioModelo us = new UsuarioModelo();
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            string sql = "SELECT * from usuario where id=@id";
            MySqlCommand command = new MySqlCommand(sql, sqlcon);
            command.Parameters.AddWithValue("@id", codigo);//substitua o valor do codigo
            MySqlDataReader registro = command.ExecuteReader();//leia os dados da consulta
            if (registro.HasRows)//existe linha de registro
            {
                registro.Read();//leia o registro
                //gravando as informaçoes no modelo usuario
                us.nome = registro["nome"].ToString();
                us.senha = registro["senha"].ToString();
                us.id = Convert.ToInt32(registro["id"]);
                us.id_perfil = Convert.ToInt32(registro["id_perfil"]);
            }
            sqlcon.Close();
            return us;

        }
        public int Login(UsuarioModelo us)
        {
           
            int registro;
            string sql = "SELECT id from usuario where nome=@usuario and senha=@senha";
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlcon);
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Parameters.AddWithValue("@usuario", us.nome);
            command.Parameters.AddWithValue("@senha", us.senha);
            registro = Convert.ToInt32(command.ExecuteScalar());

            return registro;
        }
    }
}
