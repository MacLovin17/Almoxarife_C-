using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ykire_System
{
    public class Frota
    {
        public int matricula { get; set; }
        public string nome { get; private set; }
        public int cod_veiculo { get; private set; }
        public string tag { get; private set; }
        public string combustivel { get; private set; }
        public string cidade { get; private set; }
        public float litragem { get; private set; }
        public float custo { get; private set; }
        public float km { get; private set; }
        public string data { get; private set; }
        public Frota() { }

        public Frota(string matricula, string nome, string cod_veiculo, string tag, string combustivel, string cidade, string litragem, string custo, string km, string data)
        {
            if (string.IsNullOrEmpty(matricula))
            {
                throw new Exception("Matricula é obrigatório!");
            }
            if (string.IsNullOrEmpty(cod_veiculo))
            {
                throw new Exception("Cod. Veiculo é obrigatório!");
            }
            if (string.IsNullOrEmpty(combustivel))
            {
                throw new Exception("Combustivel é obrigatório!");
            }
            if (string.IsNullOrEmpty(cidade))
            {
                throw new Exception("Cidade é obrigatório!");
            }
            if (string.IsNullOrEmpty(custo))
            {
                throw new Exception("Custo é obrigatório!");
            }
            if (string.IsNullOrEmpty(km))
            {
                throw new Exception("Km é obrigatório!");
            }

            this.matricula = int.Parse(matricula);
            this.nome = nome;
            this.cod_veiculo= int.Parse(cod_veiculo);
            this.tag = tag;
            this.combustivel = combustivel;
            this.cidade = cidade;
            this.litragem = float.Parse(litragem);
            this.custo = float.Parse(custo);
            this.km = float.Parse(km);
            this.data = data;
        }
    }
}
