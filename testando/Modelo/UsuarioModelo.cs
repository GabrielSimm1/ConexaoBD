using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{   
        //obejto usuario
    public class UsuarioModelo
    {
         public int id;
         public string nome;
         public string senha;
        //constructor da classe modelo
        public UsuarioModelo()
        {
            nome = null;
            senha = null;
        }
    }
}
