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
    public partial class FormularioPrincipal : Form
    {

        int idUsu;
        UsuarioController usController = new UsuarioController();
        UsuarioModelo usModelo = new UsuarioModelo();   
        public FormularioPrincipal(int codigo)
        {
            idUsu = codigo;
            MessageBox.Show("Seja bem-vindo ID: " + codigo);
            InitializeComponent();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            //carrego no usuario as informaçoes
            usModelo = usController.carregaDados(idUsu);
            label1.Text = usModelo.nome;
            
            if(usModelo.id_perfil == 1)
            {
                //deixar o menu invisivel
                usuarioToolStripMenuItem.Visible = true;
            }else if (usModelo.id_perfil == 2)
            {
                usuarioToolStripMenuItem.Visible = false;
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 usuario = new Form1();
            usuario.MdiParent = this;
            usuario.Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListarUsuario frmListar = new FrmListarUsuario();
            frmListar.MdiParent = this;
            frmListar.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            FrmLogin login = new FrmLogin();
            var result = MessageBox.Show("Deseja sair do sistema?", "Sair do sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioProduto produto = new FormularioProduto();
            produto.MdiParent = this;
            produto.Show();
        }
    }
}
