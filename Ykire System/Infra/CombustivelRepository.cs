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
        public List<Combustivel> GetResumo(DateTime dataInicio, DateTime dataFim)
        {
            using var conn = new DbConnection();  // Criando a conexão com o banco de dados

            // Formatando as datas para o formato dd/MM/yyyy que é esperado na consulta SQL
            string query = $@"
                            SELECT * 
                            FROM veiculo_resumo('{dataInicio:dd/MM/yyyy}', '{dataFim:dd/MM/yyyy}');
                        ";

            // Exibindo o query para depuração (se necessário)
            Console.WriteLine(query);  // Use para depuração

            // Executando a consulta e mapeando para a lista de combustíveis
            var combustivel = conn.Connection.Query<Combustivel>(sql: query).ToList();

            return combustivel;  // Retorna a lista de combustíveis obtidos
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
