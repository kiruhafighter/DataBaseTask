using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DB_Task
{
    public class DbCommand
    {
        private readonly DbConnection _dbconnection;
        public DbConnection Dbconnection => _dbconnection;
        private readonly string _instruction;

        internal DbCommand( string instruction , DbConnection dbconnection)
        {
            if (string.IsNullOrEmpty(_instruction))
            {
                throw new ArgumentNullException();
            }

            _instruction = instruction;
            _dbconnection = dbconnection;
        }

        public void Execute()
        {

            Dbconnection.Open();
            Console.WriteLine("Running the instruction");
            Dbconnection.Close();

        }
    }
}
