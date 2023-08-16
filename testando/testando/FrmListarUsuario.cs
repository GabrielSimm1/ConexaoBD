using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace testando
{
    public partial class FrmListarUsuario : Form
    {
        string sql=" ";
        int valor;
        UsuarioController usController = new UsuarioController();
        Conexao con = new Conexao();  
        public FrmListarUsuario()
        {
            InitializeComponent();
        }

 
        private void FrmListarUsuario_Load_1(object sender, EventArgs e)
        {
            //sql = "SELECT * from usuario";
            //dtUsuario.DataSource = con.obterDados(sql);
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxPesquisa.Text))
            {
                sql = "SELECT * from usuario";
            }
            else
            {
                bool teste = int.TryParse(textBoxPesquisa.Text, out valor);
                if (teste)
                {
                    sql = "select * from usuario where id=" + valor;
                }
                else
                {
                    sql = "SELECT * from usuario where nome like '%" + textBoxPesquisa.Text + "%'";
                }

            }
            dtUsuario.DataSource = con.obterDados(sql);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            usController.gerarPDF(sql);
        }
    }
}
