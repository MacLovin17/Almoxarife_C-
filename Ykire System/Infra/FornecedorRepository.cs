using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System.Infra
{
    public class FornecedorRepository
    {
        public bool Add(Fornecedor fornecedores)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.fornecedor(
                             nome, cnpj,ramo)
                             VALUES (@nome, @cnpj, @ramo);";

            var result = conn.Connection.Execute(sql: query, param: fornecedores);
            return result == 1;
        }
        public List<Fornecedor> Get(string pesquisa = null)
        {
            using var conn = new DbConnection();

            string query = @"SELECT * FROM fornecedor";

            // Verifica se foi passado um texto para pesquisa e adiciona a cláusula WHERE se necessário
            if (!string.IsNullOrWhiteSpace(pesquisa))
            {
                query += " WHERE LOWER(nome) LIKE @Pesquisa";
                pesquisa = $"%{pesquisa.ToLower()}%";
            }

            var fornecedores = conn.Connection.Query<Fornecedor>(query, new { Pesquisa = pesquisa });
            return fornecedores.ToList();
        }
        public string ObterNomeProdutoPorCodigo_Fornc(int codigo)
        {
            using var conn = new DbConnection();
            string query = @"SELECT nome FROM fornecedor WHERE codigo = @codigo;";
            return conn.Connection.QuerySingleOrDefault<string>(query, new { codigo });
        }
    }
}
