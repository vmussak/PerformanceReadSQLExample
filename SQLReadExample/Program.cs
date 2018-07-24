using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLReadExample
{
    class Program
    {
        

        static void Main(string[] args)
        {

            var db = new DatabaseConnection();

            var clientes1 = db.BuscarClientes();

            var clientes2 = db.BuscarClientes2();

            Console.ReadKey();
        }
    }
}
