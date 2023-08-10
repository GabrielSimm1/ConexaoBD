using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Modelo;//importar objeto

namespace Controller
{

   public class ProdutoController
    {
        string sql;//estrutura sql
        bool resultado = false;//verificar o resultado
        Conexao com = new Conexao();//chamo o metodo conexao
        public bool cadastrarProduto(produtoModelo prod)
        {
            try
            {
                sql = "insert into produto(descricao, preco, quantidade, perecivel, validade, foto)" +
                    "values(@nome, @preco, @qtde, @perecivel, @data, @foto)";
                string[] campos = { "@nome", "@preco", "@qtde", "@perecivel", "@data", "@foto" };
                object[] valores = { prod.descricao, prod.preco, prod.quantidade, prod.perecivel, prod.validade, prod.foto };
                if (com.cadastrar(campos, valores, sql) >= 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
