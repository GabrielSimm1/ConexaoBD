using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;

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
            string sql = "insert into usuario(nome, senha) values('"+usuario.nome+ "','" +usuario.senha+"')";
            
            //chamando minha conexão
            MySqlConnection sqlCon = con.getConexão();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            if(cmd.ExecuteNonQuery()>=1);//executar o seu sql
            resultado = true;
            sqlCon.Close();//fecho a conexao

            return resultado;//retorna o valor
        }
    }
}
