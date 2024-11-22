using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System
{
    public class Cars
    {
        public int codigo { get; set; }
        public string tag { get; set; }
        public string descricao { get; set; }
        public string placa { get; set; }
        public string ano { get; set; }
        public string crlv { get; set; }
        public string chassi { get; set; }
        public string renavam { get; set; }
        
        public Cars() { }

        public Cars(string codigo, string tag, string descricao, string placa, string ano, string crlv, string chassi, string renavam)
        {
            if (string.IsNullOrEmpty(codigo))
            {
                throw new Exception("Código é obrigatório!");
            }
            if (string.IsNullOrEmpty(descricao))
            {
                throw new Exception("Descrição é obrigatório!");
            }
            if (string.IsNullOrEmpty(placa))
            {
                throw new Exception("Placa é obrigatório!");
            }



            this.codigo = int.Parse(codigo);
            this.tag = tag;
            this.descricao = descricao;
            this.placa = placa;
            this.ano = ano;
            this.crlv = crlv;
            this.chassi = chassi;
            this.renavam = renavam; 
        }
    }
}
