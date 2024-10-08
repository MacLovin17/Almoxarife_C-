using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System.Infra
{
    public class TotalRepository
    {


        public List<Total> Get()
        {
            using var conn = new DbConnection();

            string query = @"SELECT * FROM estoque_resumo;";
           

            var totais = conn.Connection.Query<Total>(sql: query);

            return totais.ToList();

        }
    }
}