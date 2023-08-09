using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    
    //objeto produto
    public class produtoModelo
    {
        private int id_produto;
        private string descricao_prod;
        private int quant_prod;
        private decimal preco_prod;
        private bool perecivel_prod;
        private DateTime validade_prod;
        private string foto_prod;

        //construtor da classe

        public produtoModelo()
        {
            this.id_produto = 0;
            this.descricao_prod = "";
            this.quant_prod = 0;
            this.preco_prod = 0;
            this.perecivel_prod = false;
            this.validade_prod = DateTime.Now;
            this.foto_prod = "";
        }

        public int codigo
        {
            get { return id_produto; }
            set { id_produto = value; }
        }
        public string descricao
        {
            get { return descricao_prod; }
            set { descricao_prod = value; }   
        }
        public int quantidade
        {
            get { return quant_prod; }
            set { quant_prod = value; }
        }
        public decimal preco
        {
            get { return preco_prod; }
            set { preco_prod = value; }     
        }
        public bool perecivel
        {
            get { return perecivel_prod; }
            set { perecivel_prod = value; }     
        }
        public DateTime validade
        {
            get { return validade_prod; }   
            set { validade_prod = value; }
        }
        public string foto
        {
            get { return foto_prod; }
            set { foto_prod = value; }
        }
    }

    
}
