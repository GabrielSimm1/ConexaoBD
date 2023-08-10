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
using Controller;//chamo o projeto controller

namespace testando
{
    public partial class FormularioProduto : Form
    {
        produtoModelo prodModelo = new produtoModelo();
        public FormularioProduto()
        {
            InitializeComponent();
        }

        private void FormularioProduto_Load(object sender, EventArgs e)
        {
            dataValidade.Visible = false;
            label5.Visible = false;
            lblFoto.Visible = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                
                //instancio o objeto produto
                prodModelo.descricao = textBoxDescrição.Text;
                prodModelo.quantidade = Convert.ToInt32(textBoxQuantidade.Text);
                prodModelo.preco = Convert.ToDecimal(textBoxPreco.Text);
                if (checkBoxPerecivel.Checked)
                    prodModelo.perecivel = true;
                else
                    prodModelo.perecivel = false;
                prodModelo.validade = dataValidade.Value;
                prodModelo.foto = lblFoto.Text;
                ProdutoController prodController = new ProdutoController();
                if (prodController.cadastrarProduto(prodModelo) == true)
                {
                    MessageBox.Show("Produto cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Preencha os campos");
            }
            

        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                
                //chamo a caixa de dialgo pra foto
                OpenFileDialog foto = new OpenFileDialog();
                foto.Filter = "Image File(*.jpg;*.png)|*.jpg;*.png";
                if(foto.ShowDialog() == DialogResult.OK)//verifica se apertou no OK no dialogo
                {
                    lblFoto.Visible = true;
                    lblFoto.Text = foto.FileName;//mostra o nome da foto
                    Image arquivo = Image.FromFile(foto.FileName);//caminho da imagem para ser exibida no form
                    BoxFoto.Image = arquivo;//carrego a foto no picture box
                   
                }
                else
                {
                    MessageBox.Show("Selecione um arquivo");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
            }
        }

        private void checkBoxPerecivel_Click(object sender, EventArgs e)
        {
            if (checkBoxPerecivel.Checked)
            {
                dataValidade.Visible = true;
                label5.Visible = true;
            }
            else
            {
                dataValidade.Visible = false;
                label5.Visible = false;
            }
        }

        private void textBoxQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            char delete = (char)8;//codigo ascii para o backspace
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;
        }

        private void textBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            char delete = (char)8;//codigo ascii para o backspace
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete && e.KeyChar != (char)44;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            prodModelo.descricao = textBoxDescrição.Text;
            prodModelo.preco = Convert.ToDecimal(textBoxPreco.Text);
            prodModelo.quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            prodModelo.codigo = Convert.ToInt32(textBoxID);
            if (checkBoxPerecivel.Checked)
                prodModelo.perecivel = true;
            else
                prodModelo.perecivel = false;
            prodModelo.validade = dataValidade.Value;
        }
    }
}
