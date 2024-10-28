using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System
{
    public class Produto
    {
        public int codigo { get; set; }
        public string nome { get; private set; }
        public string fornecedor { get; private set; }
        public string cnpj { get; private set; }
        public string obs { get; private set; }
        public string endereco { get; private set; }
        public Produto() { }

        public Produto(  string nome, string fornecedor, string cnpj, string obs, string endereco)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Produto é obrigatório!");
            }
            if (string.IsNullOrEmpty(fornecedor))
            {
                throw new Exception("Fornecedor é obrigatório!");
            }
            if (string.IsNullOrEmpty(cnpj))
            {
                throw new Exception("CNPJ é obrigatório!");
            }
            if (string.IsNullOrEmpty(endereco))
            {
                throw new Exception("Prateleira é obrigatório!");
            }


            this.nome = nome;
            this.fornecedor = fornecedor;
            this.cnpj = cnpj;
            this.obs = obs;
            this.endereco = endereco;
        }    
    }
}
