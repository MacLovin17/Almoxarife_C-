using Npgsql;
using System;
using System.Data;

namespace Ykire_System.Infra
{
    public class DbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; private set; }

        public DbConnection()
        {
            Connection = new NpgsqlConnection("Server=192.168.1.126; port=5432; Database=postgres; User ID=postgres; Password=@tec.;");
            Connection.Open();
        }

        // Método para retornar a conexão como IDbConnection
        public IDbConnection GetDbConnection()
        {
            return Connection;
        }

        public void Dispose()
        {
            Connection?.Dispose();
        }
    }
}
