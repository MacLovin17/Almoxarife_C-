﻿using System;
using System.Collections.Generic;

namespace Ykire_System
{
    public class Combustivel
    {
        public int cod_veiculo { get; set; }
        public string tag { get; private set; }
        public string combustivel { get; private set; }
        public decimal litragem_total { get; private set; }
        public decimal custo_total { get; private set; }
        public decimal km_total { get; private set; }
        public DateTime data_inicio { get; private set; }
        public DateTime data_fim { get; private set; }
        public decimal combust_km { get; private set; }
        public decimal km_por_dia { get; private set; }
        public string abastecimentos { get; private set; }
        public string posto { get; private set; }
        public Combustivel() { }


        public Combustivel(string cod_veiculo, string tag, string combustivel, string litragem_total, string custo_total, string km_total, string abastecimentos, string posto, string data_inicio, string data_fim, string combust_km, string km_por_dia)
        {
            this.cod_veiculo = int.Parse(cod_veiculo);
            this.tag = tag;
            this.combustivel = combustivel;
            this.litragem_total = decimal.Parse(litragem_total);
            this.custo_total = decimal.Parse(custo_total);
            this.km_total = decimal.Parse(km_total);
            this.data_inicio = DateTime.Parse(data_inicio);
            this.data_fim = DateTime.Parse(data_fim);
            this.combust_km = decimal.Parse(combust_km);
            this.km_por_dia = decimal.Parse(km_por_dia);
            this.posto = posto;
            this.abastecimentos = abastecimentos;
        }
    }
}
