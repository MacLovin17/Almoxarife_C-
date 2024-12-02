using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System.Infra
{
    public class ManutRepository
    {
        public bool Add(Manutencao manutencao)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.manutencao(
                             cod_matricula, cod_veiculo, tag, cod_fornecedor, fornecedor, cidade, tipo, servico, valor, data)
                             VALUES (@cod_matricula, @cod_veiculo, @tag, @cod_fornecedor, @fornecedor, @cidade, @tipo, @servico, @valor, @data);";

            var result = conn.Connection.Execute(sql: query, param: manutencao);
            return result == 1;
        }
        
        public List<Manutencao> Get()
        {
            using var conn = new DbConnection();

            string query = @"SELECT * FROM manutencao;";

            var manutencao = conn.Connection.Query<Manutencao>(sql: query);

            return manutencao.ToList();

        }
    }
}
