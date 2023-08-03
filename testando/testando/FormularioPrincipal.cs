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
                usuarioToolStripMenuItem.Visible = false;
            }else if (usModelo.id_perfil == 2)
            {
                usuarioToolStripMenuItem.Visible = true;
            }
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 usuario = new Form1();
            usuario.MdiParent = this;
            usuario.Show();
        }
    }
}
