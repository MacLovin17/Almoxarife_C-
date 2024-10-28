using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System
{
    public class Estoque
    {
        public int codigo { get; set; }
        public string nome { get; private set; }
        public int qt { get; private set; }
        public string obs { get; private set; }
        public Estoque() { }

        public Estoque( string codigo, string qt, string obs)
        {
            if (string.IsNullOrEmpty(codigo))
            {
                throw new Exception("Código é obrigatório!");
            }
            if (string.IsNullOrEmpty(qt))
            {
                throw new Exception("Quantidade é obrigatório!");
            }



            this.codigo = int.Parse(codigo);
            this.qt = int.Parse(qt);
            this.obs = obs;
        }
    }
}