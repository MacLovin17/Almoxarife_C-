using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System
{
    public class Funcinario
    {
        public int matricula { get; set; }
        public string nome { get; private set; }
        public string setor { get; private set; }
        public string funcao { get; private set; }
        public Funcinario() { }

        public Funcinario(string matricula, string nome, string setor, string funcao)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new Exception("Nome é obrigatório!");
            }
            if (string.IsNullOrEmpty(setor))
            {
                throw new Exception("Setor é obrigatório!");
            }
            if (string.IsNullOrEmpty(matricula))
            {
                throw new Exception("Matrícula é obrigatório!");
            }
            if (string.IsNullOrEmpty(funcao))
            {
                throw new Exception("Função é obrigatório!");
            }

            this.nome = nome;
            this.matricula = int.Parse(matricula);
            this.setor = setor;
            this.funcao = funcao;
        }
    }
}
