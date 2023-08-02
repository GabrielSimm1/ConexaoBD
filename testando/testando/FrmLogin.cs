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
            if(usControle.Login(us) == true)
            {
                FormularioPrincipal principal = new FormularioPrincipal();
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario ou senha inválidos");
            }

        }
    }
}
