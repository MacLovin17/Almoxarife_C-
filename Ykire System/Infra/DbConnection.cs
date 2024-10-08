using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ykire_System.Infra
{
    public class DbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }
        public DbConnection() { 
            Connection = new NpgsqlConnection("Server=localhost; port= 5432; Database= postgres; User ID= postgres; Password=@tec.; ");
            Connection.Open();
        }

        public void Dispose()
        {
           Connection.Dispose();
        }
    }
}
