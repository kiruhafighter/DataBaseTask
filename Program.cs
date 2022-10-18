using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2018, 11, 4, 12, 30, 1);
            TimeSpan tmsp = DateTime.Today - date;
            Sqlconnection sq = new Sqlconnection("Wetfgfe2313",tmsp );
            sq.Open();
            sq.Close();
        }
    }
}
