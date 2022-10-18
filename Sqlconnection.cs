using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Task
{
    public class Sqlconnection : DbConnection
    {
        public Sqlconnection(string connectionString , TimeSpan timeout)
            : base(connectionString , timeout)
        {

        }

        public override void Open() => Console.WriteLine("Database is open");
        public override void Close() => Console.WriteLine("Database is closed");
        

    }
}
