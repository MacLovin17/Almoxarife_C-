using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System.Infra
{
    public class EPIRepository
    {
        public bool Add(CEPI epi)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.epi(
                             matricula, nome, epi, qt, data)
                             VALUES (@matricula, @nome, @epi, @qt, @data);";

            var result = conn.Connection.Execute(sql: query, param: epi);
            return result == 1;
        }

        public List<CEPI> Get()
        {
            using var conn = new DbConnection();

            string query = @"SELECT * FROM epi;";

            var epis = conn.Connection.Query<CEPI>(sql: query);

            return epis.ToList();

        }
        public string ObterNomeProdutoPorCodigo_EPI(int matricula)
        {
            using var conn = new DbConnection();
            string query = @"SELECT nome FROM epi WHERE matricula = @matricula;";
            return conn.Connection.QuerySingleOrDefault<string>(query, new { matricula });
        }
    }
}
