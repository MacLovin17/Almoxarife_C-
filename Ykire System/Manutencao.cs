using System;

namespace Ykire_System
{
    public class Manutencao
    {
        public int cod_matricula { get; set; }
        public int cod_veiculo { get; private set; }
        public string  tag { get; private set; }
        public int cod_fornecedor { get; private set; }
        public string fornecedor { get; private set; }
        public string cidade { get; private set; }
        public string tipo { get; private set; }
        public string servico { get; private set; }
        public string data { get; private set; }
        public float valor { get; private set; }
       



        public Manutencao() { }

        
        public Manutencao(string cod_matricula, string cod_veiculo, string tag, string cod_fornecedor, string fornecedor, string cidade, string tipo, string servico, string valor, string data)
        {
            if (string.IsNullOrEmpty(cod_matricula))
            {
                throw new Exception("Cod. da Matricula é obrigatório!");
            }
            if (string.IsNullOrEmpty(cod_veiculo))
            {
                throw new Exception("Cod. de Veiculo é obrigatório!");
            }
            if (string.IsNullOrEmpty(cod_fornecedor))
            {
                throw new Exception("Fornecedor é obrigatório!");
            }
            if (string.IsNullOrEmpty(valor))
            {
                throw new Exception("Valor é obrigatório!");
            }

            this.cidade = cidade;
            this.cod_matricula = int.Parse(cod_matricula);
            this.cod_veiculo = int.Parse(cod_veiculo);
            this.cod_fornecedor = int.Parse(cod_fornecedor);
            this.tipo = tipo;
            this.servico = servico;
            this.valor = float.Parse(valor);
            this.data = data;
            this.tag = tag;
            this.fornecedor = fornecedor;
            
        }
    }
}
