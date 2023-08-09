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
        public FormularioProduto()
        {
            InitializeComponent();
        }

        private void FormularioProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            produtoModelo prodModelo = new produtoModelo();//instancio o objeto produto
            prodModelo.descricao = textBoxDescrição.Text;
            prodModelo.quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            prodModelo.preco = Convert.ToDecimal(textBoxPreco.Text);
            if (checkBoxPerecivel.Checked)
                prodModelo.perecivel = true;
            else
                prodModelo.perecivel = false;
            prodModelo.validade = dataValidade.Value;
            ProdutoController prodController = new ProdutoController();
            if (prodController.cadastrarProduto(prodModelo) == true)
            {
                MessageBox.Show("Produto cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar produto");
            }

        }
    }
}
