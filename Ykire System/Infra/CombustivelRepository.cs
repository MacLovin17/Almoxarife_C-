using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System.Infra
{
    public class CombustivelRepository
    {
        // Função para chamar a função veiculo_resumo com as datas e obter dados
        public List<Combustivel> GetResumo(DateTime dataInicio, DateTime dataFim, int? codVeiculo = null, string? posto = null)
        {
            using var conn = new DbConnection();

            string query = @"
                                SELECT * 
                                FROM veiculo_resumo(@data_inicio, @data_fim)
                                WHERE
                                    (@cod_veiculo IS NULL OR cod_veiculo = @cod_veiculo)
                                AND (@posto IS NULL OR LOWER(posto) LIKE LOWER(CONCAT('%', @posto, '%')));
                            ";

            var combustivel = conn.Connection.Query<Combustivel>(
                sql: query,
                param: new
                {
                    data_inicio = dataInicio.ToString("dd/MM/yyyy"),
                    data_fim = dataFim.ToString("dd/MM/yyyy"),
                    cod_veiculo = codVeiculo,
                    posto = posto
                }).ToList();

            return combustivel;
        }


        // Função para obter todos os dados sem filtro de data (caso necessário)
        public List<Combustivel> Get()
        {
            using var conn = new DbConnection();

            string query = @"SELECT * FROM veiculo_resumo('01/01/2024', '30/12/2024');";  // Caso precise de dados sem filtro de data

            var combustivel = conn.Connection.Query<Combustivel>(sql: query).ToList();

            return combustivel;
        }
    }
}
