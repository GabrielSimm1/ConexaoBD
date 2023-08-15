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

        private void FormularioListarProduto_Load(object sender, EventArgs e)
        {
            //tabela de dados
            DataTable dt = new DataTable();
            dt = con.obterDados("select * from produto");//buscando e populando a datatable
            int registros = 0;//ler a quantidade de dados
            for(registros = 0; registros < dt.Rows.Count; registros++)//varrer os registros da tabela produto
            {
                //criando manualmente
                Panel produto = new Panel();//criando o painel de produto
                produto.Location = new Point(0,0);//defino o local
                Label idProduto = new Label();//crio uma label
                idProduto.Name = "id_produto";
                idProduto.Text = dt.Rows[registros][0].ToString();//mostra o registro
                PictureBox foto = new PictureBox();//crio a area de foto
                foto.Location = new Point(10, 0);
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
                foto.Name = "foto";
                foto.Image = Image.FromFile(dt.Rows[registros][6].ToString());
                Label preco = new Label();
                preco.Name = "preço";
                preco.Text = dt.Rows[registros][2].ToString();
                preco.Location = new Point(20, 0);

                //adicionando os componentes ao painel
                produto.Controls.Add(preco);
                produto.Controls.Add(foto);
                produto.Controls.Add(idProduto);
                panel1.Controls.Add(produto);//adiciono cada produto da consulta ao painel

            }
        }
    }
}
