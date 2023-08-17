using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using System.Diagnostics;

namespace testando
{
    public partial class FormularioListarProduto : Form
    {
        Conexao con = new Conexao();

        public FormularioListarProduto()
        {
            InitializeComponent();
        }

        private void FormularioListarProduto_Load(object? sender, EventArgs e)
        {
            int y = 0;
            int x = 0;
            int quantProd;//guardar a quantidade de produtos
            //tabela de dados
            DataTable dt = new DataTable();
            dt = con.obterDados("select * from produto");//buscando e populando a datatable
            int registros = 0;//ler a quantidade de dados
            for (registros = 0; registros < dt.Rows.Count; registros++)//varrer os registros da tabela produto
            {
                //criando manualmente
                Panel produto = new Panel();//criando o painel de produto
                produto.Location = new Point(x, y);//defino o local
                Label idProduto = new Label();//crio uma label
                idProduto.Name = "id_produto";
                idProduto.Text = dt.Rows[registros][0].ToString();//mostra o registro
                //idProduto.Location = new Point(5, 55);
                PictureBox foto = new PictureBox();//crio a area de foto
                foto.Location = new Point(20, 0);
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Name = "foto";
                foto.Image = Image.FromFile(dt.Rows[registros][6].ToString());
                Label preco = new Label();
                preco.Name = "preco";
                preco.Text = dt.Rows[registros][2].ToString();
                preco.Location = new Point(20, 80);
                Label descProduto = new Label();
                descProduto.Name = "descricao";
                descProduto.Text = dt.Rows[registros][1].ToString();
                descProduto.Location = new Point(20, 60);
                produto.Height = 200;
                produto.Width = 200;
                produto.BorderStyle = BorderStyle.FixedSingle;
                TextBox quant = new TextBox();
                quant.Name = "qtde";
                quant.Location = new Point(20, 110);
                quantProd = Convert.ToInt32(dt.Rows[registros][3].ToString());
                quant.Leave += new EventHandler((sender1, e1) => quantLeave(sender1, e1, quant.Text, quantProd));
                if (!string.IsNullOrEmpty(quant.Text))
                {
                    if(Convert.ToInt32(quant) <= quantProd)
                    {
                        MessageBox.Show("Quantidade indisponível", "Alerta");                    }      
                }
                
                if (quantProd > 0)
                {
                    quant.Enabled = true;
                }
                else
                {
                    quant.Enabled = false;
                }


                //adicionando os componentes ao painel
                Button registrar = new Button();
                registrar.Name = "Selecionar";
                registrar.Text = "Selecionar";
                registrar.Font = new Font("Arial", 8, FontStyle.Bold);
                registrar.Location = new Point(20, 140);

                registrar.Click += new EventHandler((sender1, e1) => selecionarClick(sender1, e1, idProduto.Text));

                produto.Controls.Add(preco);
                produto.Controls.Add(foto);
                produto.Controls.Add(idProduto);
                produto.Controls.Add(descProduto);
                produto.Controls.Add(registrar);
                produto.Controls.Add(quant);
                flowLayoutPanel1.Controls.Add(produto);//adiciono cada produto da consulta ao painel
                y += 100;
                x = 0;
            }
        }
        private void selecionarClick(object? sender, EventArgs e, string? id)
        {
            MessageBox.Show("Produto selecionado: " + id);
        }
        private void quantLeave(object? sender, EventArgs e, string? qtde, int qtdeProd)
        {
            if (!string.IsNullOrEmpty(qtde))
            {
                if(Convert.ToInt32(qtde) > qtdeProd || Convert.ToInt32(qtde) <= 0)
                {
                    MessageBox.Show("Quantidade indisponível", "Alerta");
                }
            }
        }
    }
}
