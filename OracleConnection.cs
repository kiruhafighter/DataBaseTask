using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DB_Task
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString , TimeSpan timeout) 
            : base(connectionString, timeout)
        {

        }

        public override void Open() => Console.WriteLine("Database is open.");
        public override void Close() => Console.WriteLine("Database is closed.");
        
    }
}
