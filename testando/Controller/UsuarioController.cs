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
using PdfSharp;//biblioteca geral
using PdfSharp.Drawing;//para desenho
using PdfSharp.Pdf;//conversao
using System.Diagnostics;

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
            string sql = "insert into usuario(nome, senha, id_perfil, email) values('" + usuario.nome + "','" + con.getMD5Hash(usuario.senha) + "', " + usuario.id_perfil + ", '" + usuario.email + "')";

            //chamando minha conexão
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            if (cmd.ExecuteNonQuery() >= 1)//executar o seu sql
                resultado = true;
            sqlCon.Close();//fecho a conexao

            return resultado;//retorna o valor
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
            if (mySqlCommand.ExecuteNonQuery() >= 1)
            {
                resultado = true;
            }
            return resultado;
        }
        public bool Editar(UsuarioModelo us)
        {
            bool resultado = false;
            string sql = "update usuario set nome=@nome, senha=@senha, id_perfil=@perfil,email=@email where id=@id";
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlcon);
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            command.Parameters.AddWithValue("@nome", us.nome);
            command.Parameters.AddWithValue("@senha",con.getMD5Hash(us.senha));
            command.Parameters.AddWithValue("@id", us.id);
            command.Parameters.AddWithValue("@perfil", us.id_perfil);
            command.Parameters.AddWithValue("email", us.email);
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
                us.email = registro["email"].ToString();    
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
            command.Parameters.AddWithValue("@senha", con.getMD5Hash(us.senha));
            registro = Convert.ToInt32(command.ExecuteScalar());

            return registro;
        }
        //public DataTable obterDados(string sql)
        //{
        //    //crio uma tabela de dados
        //    sqlCon.CommandType = System.Data.CommandType.Text;
        //    sqlCon.CommandText = sql;
        //    MySqlDataAdapter dados = new MySqlDataAdapter(sql, conn);
        //    dados.Fill(dt);// montar a tabela dados
        //    conn.Close();
        //    return dt;
        //}
        public void gerarPDF(string sql)
        {
            UsuarioModelo us = new UsuarioModelo();
            //chamo minha conexão MySql
            MySqlConnection sqlcon = con.getConexao();
            //preparo o comando sql
            MySqlCommand command = new MySqlCommand(sql, sqlcon);
            MySqlDataAdapter dados;// preparar os dados
            DataSet ds = new DataSet();
            try //teste de comandos
            {
                int i = 0; // resgistro
                int ypoint = 0;//espaço do conteudo
                sqlcon.Open();//abro a conexão
                dados = new MySqlDataAdapter(command);// recuperando as informações
                dados.Fill(ds);//carrego as informações geradas
                PdfDocument pdf = new PdfDocument();//chamo a instancia do pdf
                pdf.Info.Title = "Listar usuário";
                PdfPage page = pdf.AddPage();//gera uma nova pagina
                XGraphics grafic = XGraphics.FromPdfPage(page);
                XFont font = new XFont("arial", 12, XFontStyle.Regular);//defino a fonte e o tamanho
                ypoint = ypoint + 75;
                grafic.DrawString(ds.Tables[0].Columns[0].ColumnName, font, XBrushes.Black, new XRect(20, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                grafic.DrawString(ds.Tables[0].Columns[1].ColumnName, font, XBrushes.Black, new XRect(120, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                grafic.DrawString(ds.Tables[0].Columns[3].ColumnName, font, XBrushes.Black, new XRect(220, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                ypoint = ypoint + 75; //gera uma nova posição

                for (i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    //guarde no objeto nome o resultado da coluna
                    us.id = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0].ToString());
                    us.nome = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    us.id_perfil = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[3].ToString());
                    grafic.DrawString(us.id.ToString(), font, XBrushes.Black, new XRect(20, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    grafic.DrawString(us.nome, font, XBrushes.Black, new XRect(120, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    grafic.DrawString(us.id_perfil.ToString(), font, XBrushes.Black, new XRect(220, ypoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    ypoint = ypoint + 30;
                }//defino o nome do arquivo pdf
                string pdffilename = "ListarUsuario.pdf";
                pdf.Save(pdffilename);//salvo o arquivo em pdf
                Process.Start(pdffilename);// abro o arquivo salvo

            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }

        }
    }
}
