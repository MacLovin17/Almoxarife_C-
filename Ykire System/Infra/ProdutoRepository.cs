using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System.Infra
{
    public class ProdutoRepository
    {
        public bool Add( Produto produto)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.cad_prod(
                             nome, fornecedor, cnpj, obs, endereco)
                             VALUES (@nome, @fornecedor, @cnpj, @obs, @endereco);";

            var result = conn.Connection.Execute(sql:  query, param: produto);
            return result == 1;
        }

        public List<Produto> Get()
        {
            using var conn = new DbConnection();

            string query = @"SELECT * FROM cad_prod;";

            var produtos = conn.Connection.Query<Produto>(sql: query);

            return produtos.ToList();

        }
    }
}
