﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ykire_System.Infra
{
    public class CarsRepository
    {
        public bool Add(Cars cars)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.cars(
                             codigo, tag, descricao, placa, ano, crlv, chassi, renavam)
                             VALUES (@codigo, @tag, @descricao, @placa, @ano, @crlv, @chassi, @renavam);";

            var result = conn.Connection.Execute(sql: query, param: cars);
            return result == 1;
        }

        public List<Cars> Get(string pesquisa = null)
        {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM cars";

            if (!string.IsNullOrWhiteSpace(pesquisa))
            {
                query += " WHERE LOWER(placa) LIKE @Pesquisa";
                pesquisa = $"%{pesquisa.ToLower()}%"; // Adiciona os símbolos de busca parcial
            }

            return conn.Connection.Query<Cars>(query, new { Pesquisa = pesquisa }).ToList();
        }

        public string ObterNomeProdutoPorCodigo_Cars(int codigo)
        {
            using var conn = new DbConnection();
            string query = @"SELECT tag FROM cars WHERE codigo = @codigo;";
            return conn.Connection.QuerySingleOrDefault<string>(query, new { codigo });
        }
    }
}