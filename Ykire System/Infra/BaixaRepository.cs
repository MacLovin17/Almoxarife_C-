using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System.Infra
{
    public class BaixaRepository
    {
        public bool Add(Baixa baixa)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.prod_saida(
                            codigo, qt, cgo, data)
                             VALUES (@codigo, @qt, @cgo, @data);";

            var result = conn.Connection.Execute(sql: query, param: baixa);
            return result == 1;
        }

        public List<Baixa> Get()
        {
            using var conn = new DbConnection();

            string query = @"SELECT * FROM prod_saida;";

            var baixas = conn.Connection.Query<Baixa>(sql: query);

            return baixas.ToList();

        }
    }
}
