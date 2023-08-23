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
using Modelo;
using System.Net.Mail;
using System.Data.SqlTypes;

namespace Controller
{
    public class Conexao
    {
        //atributos de conexão
        static private string servidor = "localhost";
        static private string db = "testando";
        static private string usuario = "root";
        static private string senha = "";
        Random aleatorio = new Random();
        UsuarioModelo usarioModelo = new UsuarioModelo();//chamo o modelo usuario
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
                for (int i = 0; i < campos.Length; i++)
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
            catch (Exception ex)
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
        public string getMD5Hash(string senha)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(senha);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        public string recuperaEmail(string login)
        {
            try
            {
                //criar a tabela de dados
                DataTable dt = new DataTable();
                string msg = null;//validação de informação
                if (login == null)//valido o preenchimento
                {
                    msg = "Login está vazio";
                }
                else
                {

                    conn = getConexao();//abro a conexão
                    conn.Open();//abro o BD
                    //chamo a função obter dados passando o SQL com o login
                    dt = obterDados("select * from usuario where nome=" + login);
                    //verifico se achou algum registro
                    if (dt.Rows.Count > 0)
                    {
                        string email = "gabriel.simm3@gmail.com";
                        String senha = "senha";
                        SmtpClient cliente = new SmtpClient();
                        cliente.Host = "smtp.office365.com";
                        cliente.Port = 587;
                        cliente.EnableSsl = true;
                        cliente.Credentials = new System.Net.NetworkCredential(email, senha);
                        MailMessage mail = new MailMessage();//criar mensagem
                        mail.Sender = new MailAddress(email, "Sistema TDS");//configura o email de envio
                        mail.From = new MailAddress(email, "Recuperar senha");
                        mail.To.Add(new MailAddress(dt.Rows[0][4].ToString(), dt.Rows[0][1].ToString()));
                        mail.Subject = "Lembrar senha";
                        mail.Body = "Ola" + dt.Rows[0][1].ToString() + "sua senha é: " + aleatorio.Next(20);
                        mail.IsBodyHtml = true; // cria um arquivo local
                        mail.Priority = MailPriority.High;//prioridade de envio
                        try
                        {
                            cliente.Send(mail);
                            msg = "E-mail enviado com sucesso!";
                        }catch(Exception ex)
                        {
                            throw new Exception ("Erro ao enviar e-mail: " + ex.Message);
                        }
                    }
                }
                return msg;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro: " + ex.Message);
            }

        }
    }
}
