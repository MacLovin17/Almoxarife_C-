﻿using System;
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
        public int codigo { get; private set; }
        public string epi { get; private set; }
        public string ca { get; private set;}
        public int qt { get; private set; }
        public string data { get; private set; }
        public CEPI() { }

        public CEPI(string matricula, string codigo, string epi, string ca, string qt,string data)
        {
            if (string.IsNullOrEmpty(matricula))
            {
                throw new Exception("Matrícula é obrigatório!");
            }
            if (string.IsNullOrEmpty(epi))
            {
                throw new Exception("EPI é obrigatório!");
            }
            if (string.IsNullOrEmpty(ca))
            {
                throw new Exception("CA é obrigatório!");
            }
            if (string.IsNullOrEmpty(qt))
            {
                throw new Exception("Quantidade é obrigatório!");
            }
            this.matricula = int.Parse(matricula);
            this.codigo = int.Parse(codigo);
            this.epi = epi;
            this.ca = ca;
            this.qt = int.Parse(qt);
            this.data = data;
        }
    }
}
