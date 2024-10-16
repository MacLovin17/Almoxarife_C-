using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System.Infra
{
    public class FuncRepository
    {
        public bool Add(Funcinario funcionario)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.func(
                             matricula, nome, setor, funcao)
                             VALUES (@matricula, @nome, @setor, @funcao);";

            var result = conn.Connection.Execute(sql: query, param: funcionario);
            return result == 1;
        }

        public List<Funcinario> Get()
        {
            using var conn = new DbConnection();

            string query = @"SELECT * FROM func;";

            var funcinarios = conn.Connection.Query<Funcinario>(sql: query);

            return funcinarios.ToList();

        }
    }
}
