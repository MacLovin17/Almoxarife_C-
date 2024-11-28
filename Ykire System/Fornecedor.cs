using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System
{
    public class Fornecedor
    {
        public int codigo { get; set; }
        public string nome { get; private set; }
        public string cnpj { get; private set; }
        public string ramo { get; private set; }

        public Fornecedor() { }

        public Fornecedor(string nome, string cnpj, string ramo)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome é obrigatório!");
            }
            if (string.IsNullOrEmpty(cnpj))
            {
                throw new Exception("CNPJ é obrigatório!");
            }
            if (string.IsNullOrEmpty(ramo))
            {
                throw new Exception("Ramo é obrigatório!");
            }

            this.nome = nome;
            this.cnpj = cnpj;
            this.ramo = ramo;
        }
    }
}
