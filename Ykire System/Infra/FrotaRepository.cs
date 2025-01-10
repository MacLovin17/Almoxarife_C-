using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System.Infra
{
    internal class FrotaRepository
    {
        public bool Add(Frota frota)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.frota(
                             matricula, nome, cod_veiculo, tag, combustivel, cidade, litragem, posto, custo, km, data)
                             VALUES (@matricula, @nome, @cod_veiculo, @tag, @combustivel, @cidade, @litragem, @posto, @custo, @km, @data);";

            var result = conn.Connection.Execute(sql: query, param: frota);
            return result == 1;
        }

        public List<Frota> Get()
        {
            using var conn = new DbConnection();

            string query = @"SELECT * FROM frota;";

            var frota = conn.Connection.Query<Frota>(sql: query);

            return frota.ToList();

        }
        public string ObterNomeFornecedor(int cnpj)
        {
            using var conn = new DbConnection();
            string query = @"SELECT nome FROM frota WHERE matricula = @cnpj;";
            return conn.Connection.QuerySingleOrDefault<string>(query, new { cnpj });
        }
    }
}
