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
            //instanciar o meu controleusuario
            UsuarioController usControle = new UsuarioController();
            dtUsuario.DataSource = usControle.obterDados("select *from usuario");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioModelo usModelo = new UsuarioModelo();
            usModelo.nome= textBoxNome.Text;
            usModelo.senha= textBoxSenha.Text;
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
            conexao conexao = new conexao();
            if (conexao.getConexão() == null)
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
           
            int codigo = Convert.ToInt32(dtUsuario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                                                //converte o inteiro para string
            MessageBox.Show("Usuario selecionado: " + codigo.ToString());
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}