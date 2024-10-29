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
                             matricula, nome, codigo, epi, ca, qt, data)
                             VALUES (@matricula, @nome, @codigo, @epi, @ca,  @qt, @data);";

            var result = conn.Connection.Execute(sql: query, param: epi);
            return result == 1;
        }

        public List<CEPI> Get(string pesquisa_epi = null)
        {
            using var conn = new DbConnection();

            // Query base
            string query = @"SELECT * FROM epi";

            // Adiciona a cláusula WHERE somente se houver um valor de pesquisa
            if (!string.IsNullOrWhiteSpace(pesquisa_epi))
            {
                query += " WHERE LOWER(nome) LIKE @Pesquisa";
                pesquisa_epi = $"%{pesquisa_epi.ToLower()}%";
            }

            // Executa a query
            var epis = conn.Connection.Query<CEPI>(query, new { Pesquisa = pesquisa_epi });

            return epis.ToList();
        }

        public string ObterNomeProdutoPorCodigo_EPI(int matricula)
        {
            using var conn = new DbConnection();
            string query = @"SELECT nome FROM func WHERE matricula = @matricula;";
            return conn.Connection.QuerySingleOrDefault<string>(query, new { matricula });
        }
        public string ObterNomeEPIPorCodigo_EPI(int codigo)
        {
            using var conn = new DbConnection();
            string query = @"SELECT nome FROM cad_prod WHERE codigo = @codigo;";
            return conn.Connection.QuerySingleOrDefault<string>(query, new { codigo });
        }
    }
}
