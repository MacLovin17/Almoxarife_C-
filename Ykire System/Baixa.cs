using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System
{
    public class Baixa
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public int qt { get; private set; }
        public int cgo { get; private set; }
        public string data { get; private set; }
        public Baixa() { }
        
        public Baixa(string codigo,string qt,string cgo, string data)
        {
            if (string.IsNullOrEmpty(codigo))
            {
                throw new Exception("Código é obrigatório!");
            }
            if (string.IsNullOrEmpty(qt))
            {
                throw new Exception("Quantidade é obrigatório!");
            }
            if (string.IsNullOrEmpty(cgo))
            {
                throw new Exception("CGO é obrigatório!");
            }



            this.codigo = int.Parse(codigo);
            this.qt = int.Parse(qt);
            this.cgo = int.Parse(cgo);
            this.data = data;
        }
    }
}