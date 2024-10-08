using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System
{
    public class Total
    {
        public int codigo { get; set; }
        public string produto { get; private set; }
        public string total_entradas { get; private set; }
        public string total_saidas { get; private set; }
        public string total_estoque  { get; private set; }
        public Total() { }

        public Total(string codigo, string produto, string total_entradas, string total_saidas, string total_estoque)
        {
            if (string.IsNullOrEmpty(codigo))
            {
                throw new Exception("Código é obrigatório!");
            }
            this.codigo = int.Parse(codigo);
            this.produto = produto;
            this.total_entradas = total_entradas;
            this.total_saidas = total_saidas;
            this.total_estoque = total_estoque;


        }
        
    }
}
