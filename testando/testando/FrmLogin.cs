using Controller;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testando
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int codigoUsuario;
            UsuarioModelo us = new UsuarioModelo();
            UsuarioController usControle = new UsuarioController();
            us.nome = textBoxLogin.Text;
            us.senha = textBoxSenha.Text;
            if (string.IsNullOrEmpty(us.nome))
            {
                MessageBox.Show("Preencha os campos");
                textBoxLogin.Focus();
            }
            if (string.IsNullOrEmpty(us.senha))
            {
                MessageBox.Show("Preencha os campos");
                textBoxSenha.Focus();
            }
            codigoUsuario = usControle.Login(us);
            if(usControle.Login(us)>=1)
            {
                this.Hide();
                FormularioPrincipal principal = new FormularioPrincipal(codigoUsuario);
                principal.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Usuario ou senha inválidos");
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void textBoxSenha_MouseHover(object sender, EventArgs e)
        {

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
            this.Dispose();
        }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            Conexao con = new Conexao();
            con.recuperaEmail(textBoxLogin.Text);
            lblMessage.Text = con.recuperaEmail(textBoxLogin.Text);
        }
    }
}
