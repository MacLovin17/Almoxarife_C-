using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System.Infra
{
    public class EstoqueRepository
    {
        public bool Add(Estoque estoque)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.prod_entr(
                             codigo, qt, obs)
                             VALUES (@codigo, @qt, @obs);";

            var result = conn.Connection.Execute(sql: query, param: estoque);
            return result == 1;
        }

        public List<Estoque> Get()
        {
            using var conn = new DbConnection();

            string query = @"SELECT * FROM prod_entr;";

            var estoques = conn.Connection.Query<Estoque>(sql: query);

            return estoques.ToList();

        }
    }
}
