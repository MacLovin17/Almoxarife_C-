using Dapper;
using System.Collections.Generic;
using System.Linq;

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

        public List<Baixa> Get(string pesquisa = null)
        {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM prod_saida";

            if (!string.IsNullOrWhiteSpace(pesquisa))
            {
                if (int.TryParse(pesquisa, out int codigoPesquisa))
                {
                    // Se a pesquisa for um número, faça uma comparação direta com o campo código.
                    query += " WHERE codigo = @CodigoPesquisa";
                    return conn.Connection.Query<Baixa>(query, new { CodigoPesquisa = codigoPesquisa }).ToList();
                }
                else
                {
                    // Se a pesquisa for textual, compare com outros campos relevantes.
                    query += " WHERE LOWER(algum_campo_texto) LIKE @Pesquisa"; // Trocar 'algum_campo_texto' por um campo de texto real
                    pesquisa = $"%{pesquisa.ToLower()}%";
                    return conn.Connection.Query<Baixa>(query, new { Pesquisa = pesquisa }).ToList();
                }
            }

            var baixas = conn.Connection.Query<Baixa>(query).ToList();
            return baixas;
        }




        public string ObterNomeProdutoPorCodigo(int codigo)
        {
            using var conn = new DbConnection();
            string query = @"SELECT nome FROM cad_prod WHERE codigo = @codigo;";
            return conn.Connection.QuerySingleOrDefault<string>(query, new { codigo });
        }
    }
}
