using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System
{
    public class CEPI
    {
        public int matricula { get; set; }
        public string nome { get; private set; }
        public string epi { get; private set; }
        public int qt { get; private set; }
        public string data { get; private set; }
        public CEPI() { }

        public CEPI(string matricula, string epi, string qt,string data)
        {
            if (string.IsNullOrEmpty(matricula))
            {
                throw new Exception("Produto é obrigatório!");
            }
            this.matricula = int.Parse(matricula);
            this.epi = epi;
            this.qt = int.Parse(qt);
            this.data = data;
        }
    }
}
