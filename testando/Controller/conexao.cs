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
                string novaSenha;
                bool confirmaAtt; //guarda o resultado
                if (login == null)//valido o preenchimento
                {
                    msg = "Login está vazio";
                }
                else
                {

                    conn = getConexao();//abro a conexão
                    conn.Open();//abro o BD
                    //chamo a função obter dados passando o SQL com o login
                    dt = obterDados("select * from usuario where nome='" + login + "'");
                    //verifico se achou algum registro
                    if (dt.Rows.Count > 0)
                    {
                        string email = "gabriel.simm@outlook.com";
                        String senha = "Boleirosou97";
                        SmtpClient cliente = new SmtpClient();
                        cliente.Host = "smtp.office365.com";
                        cliente.Port = 587;
                        cliente.EnableSsl = true;
                        cliente.UseDefaultCredentials = false;
                        cliente.Credentials = new System.Net.NetworkCredential(email, senha);
                        cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                        MailMessage mail = new MailMessage();//criar mensagem
                        mail.Sender = new MailAddress(email, "Sistema TDS");//configura o email de envio
                        mail.From = new MailAddress(email, "Recuperar senha");
                        string emailUsuario = dt.Rows[0][4].ToString();
                        mail.To.Add(new MailAddress(emailUsuario, dt.Rows[0][1].ToString()));
                        mail.Subject = "Lembrar senha";
                        novaSenha = aleatorio.Next(2000).ToString();
                        UsuarioModelo usuarioModelo = new UsuarioModelo();//chamo o modelo usuario
                        UsuarioController usController = new UsuarioController();
                        usuarioModelo.senha = novaSenha;
                        usuarioModelo.nome = dt.Rows[0][1].ToString();
                        usuarioModelo.email = dt.Rows[0][4].ToString();
                        usuarioModelo.id_perfil = Convert.ToInt32(dt.Rows[0][3].ToString());
                        usuarioModelo.id = Convert.ToInt32(dt.Rows[0][0].ToString());
                        confirmaAtt = usController.Editar(usuarioModelo);
                        mail.Body = "Ola " + dt.Rows[0][1].ToString() + " sua senha é: " + novaSenha;
                        mail.IsBodyHtml = true; // cria um arquivo local
                        mail.Priority = MailPriority.High;//prioridade de envio
                        
                        try
                        {
                            if (confirmaAtt)
                            {
                                cliente.SendAsync(email, emailUsuario, mail.Subject, mail.Body, 1);
                                msg = "E-mail enviado com sucesso!" + novaSenha;
                            }
                            else
                            {
                                msg = "Não foi possível atualizar senha";
                            }
                            
                          
                        }catch(Exception ex)
                        {
                            throw new Exception ("Erro ao enviar e-mail: " + ex.Message);
                        }
                        
                    }
                    else
                    {
                        msg = "Usuário não encontrado";
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
