﻿using System;
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
        public Produto() { }

        public Produto(  string nome, string fornecedor, string cnpj, string obs)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Produto é obrigatório!");
            }

            
            this.nome = nome;
            this.fornecedor = fornecedor;
            this.cnpj = cnpj;
            this.obs = obs;
        }    
    }
}
