using System;
using Controller;
using Modelo;


namespace testando

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioModelo usModelo = new UsuarioModelo();
            usModelo.nome= textBoxNome.Text;
            usModelo.senha= textBoxSenha.Text;
            UsuarioController usControle = new UsuarioController();
            if (usControle.cadastrar(usModelo) == true)
            {
                MessageBox.Show("Usu�rio cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Usu�rio n�o encontrado");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexao conexao = new conexao();
            if (conexao.getConex�o() == null)
            {
                MessageBox.Show("Erro na conexao");
            }
            else
            {
                MessageBox.Show("Acessando servidor");
            }
        }
    }
}