﻿using Modelo;
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
        Conexao con = new Conexao();
        produtoModelo prodModelo = new produtoModelo();
        ProdutoController prodController = new ProdutoController();
        public FormularioProduto()
        {
            InitializeComponent();
        }

        private void FormularioProduto_Load(object? sender, EventArgs e)
        {
            dataValidade.Visible = false;
            label5.Visible = false;
            lblFoto.Visible = false;
            dtProduto.DataSource = con.obterDados("SELECT * from produto");
        }

        private void btnInserir_Click(object? sender, EventArgs e)
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

                if (prodController.cadastrarProduto(prodModelo, 1) == true)
                {
                    MessageBox.Show("Produto cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar produto");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos.");
            }


        }

        private void btnFoto_Click(object? sender, EventArgs e)
        {
            try
            {

                //chamo a caixa de dialgo pra foto
                OpenFileDialog foto = new OpenFileDialog();
                foto.Filter = "Image File(*.jpg;*.png)|*.jpg;*.png";
                if (foto.ShowDialog() == DialogResult.OK)//verifica se apertou no OK no dialogo
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
            }
        }

        private void checkBoxPerecivel_Click(object? sender, EventArgs e)
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

        private void textBoxQuantidade_KeyPress(object? sender, KeyPressEventArgs e)
        {
            char delete = (char)8;//codigo ascii para o backspace
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete;
        }

        private void textBoxPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            char delete = (char)8;//codigo ascii para o backspace
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != delete && e.KeyChar != (char)44;
        }

        private void btnEditar_Click(object? sender, EventArgs e)
        {
            prodModelo.descricao = textBoxDescrição.Text;
            prodModelo.preco = Convert.ToDecimal(textBoxPreco.Text);
            prodModelo.quantidade = Convert.ToInt32(textBoxQuantidade.Text);
            prodModelo.codigo = Convert.ToInt32(textBoxID.Text);
            if (checkBoxPerecivel.Checked)
                prodModelo.perecivel = true;
            else
                prodModelo.perecivel = false;
            prodModelo.validade = dataValidade.Value;
            prodModelo.foto = lblFoto.Text;
            if (prodController.cadastrarProduto(prodModelo, 2) == true)
            {
                MessageBox.Show("Produto atualizado com sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar produto");
            }
        }

        private void btnExcluir_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(prodModelo.codigo.ToString()))
                {
                    MessageBox.Show("Codigo está vazio");
                    textBoxID.Focus();
                }
                //prodModelo.codigo = Convert.ToInt32(textBoxID.Text);
                if (prodModelo.codigo > 0)
                {
                    if (prodController.cadastrarProduto(prodModelo, 3) == true)
                    {
                        MessageBox.Show("Produto excluido com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Favor selecionar um ID existente");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
         }

        private void btnPesquisar_Click(object? sender, EventArgs e)
        {

        }

        private void dtProduto_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            prodModelo.codigo = Convert.ToInt32(dtProduto.Rows[e.RowIndex].Cells[0].Value);
            textBoxID.Text = prodModelo.codigo.ToString();
            textBoxDescrição.Text = dtProduto.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxPreco.Text = dtProduto.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxQuantidade.Text = dtProduto.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (Convert.ToInt32(dtProduto.Rows[e.RowIndex].Cells[4].Value) == 1)
            {
                checkBoxPerecivel.Checked = true;
            }
            else
            {
                checkBoxPerecivel.Checked = false;
            }
            dataValidade.Value = Convert.ToDateTime(dtProduto.Rows[e.RowIndex].Cells[5].Value);
            BoxFoto.Image = Image.FromFile(dtProduto.Rows[e.RowIndex].Cells[6].Value.ToString());

            
            
        }
    }
}
