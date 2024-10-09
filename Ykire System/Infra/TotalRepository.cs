using Dapper;
using System.Collections.Generic;
using System.Linq;

namespace Ykire_System.Infra
{
    public class TotalRepository
    {
        public List<Total> Get(string pesquisa = null)
        {
            using var conn = new DbConnection();

            string query = @"SELECT * FROM estoque_resumo";

            // Verifica se foi passado um texto para pesquisa e adiciona a cláusula WHERE se necessário
            if (!string.IsNullOrWhiteSpace(pesquisa))
            {
                query += " WHERE LOWER(produto) LIKE @Pesquisa";
                pesquisa = $"%{pesquisa.ToLower()}%";
            }

            var totais = conn.Connection.Query<Total>(query, new { Pesquisa = pesquisa });
            return totais.ToList();
        }
    }
}
