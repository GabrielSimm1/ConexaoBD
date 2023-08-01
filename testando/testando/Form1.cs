using System;
using Controller;
using Modelo;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;

namespace testando

{
    public partial class Form1 : Form
    {
        int codigo;
        int id_perfil;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instanciar o meu controleusuario
            UsuarioController usControle = new UsuarioController();
            dtUsuario.DataSource = usControle.obterDados("select usuario.id, usuario.nome,usuario.senha, perfil.perfil from usuario inner join perfil on usuario.id_perfil=perfil.id_perfil;");
            cboPerfil.DataSource = usControle.obterDados("select *from perfil");
            cboPerfil.DisplayMember = "perfil";
            cboPerfil.ValueMember = "id_perfil";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioModelo usModelo = new UsuarioModelo();
            usModelo.nome= textBoxNome.Text;
            usModelo.senha= textBoxSenha.Text;
            usModelo.id_perfil = id_perfil;
            UsuarioController usControle = new UsuarioController();
            if (usModelo.nome != "" && usModelo.senha != "")
            {
                if (usControle.cadastrar(usModelo) == true)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                }
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            if (conexao.getConexao() == null)
            {
                MessageBox.Show("Erro na conexao");
            }
            else
            {
                MessageBox.Show("Acessando servidor");
            }
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
           codigo = Convert.ToInt32(dtUsuario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                                                //converte o inteiro para string
            MessageBox.Show("Usuario selecionado: " + codigo.ToString());
            textBoxNome.Text = dtUsuario.Rows[e.RowIndex].Cells["nome"].Value.ToString();
            textBoxSenha.Text = dtUsuario.Rows[e.RowIndex].Cells["senha"].Value.ToString();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            UsuarioController usController = new UsuarioController();
            if(usController.Excluir(codigo) == true)
            {
                MessageBox.Show("Usuário " + codigo + " excluido com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir o usuário!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            UsuarioController usController = new UsuarioController();
            UsuarioModelo usModelo = new UsuarioModelo();
            usModelo.nome = textBoxNome.Text;
            usModelo.senha = textBoxSenha.Text;
            usModelo.id = codigo;
            if(usController.Editar(usModelo) == true)
            {
                MessageBox.Show("Usuário atualizado com sucesso!!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar usuário!!");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmListarUsuario frmListar = new FrmListarUsuario();
            frmListar.ShowDialog();
        }

        private void cboPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            //variavel perfil convert para inteiro
            id_perfil = Convert.ToInt32(((DataRowView)cboPerfil.SelectedItem)["id_perfil"]);
        }
    }
}