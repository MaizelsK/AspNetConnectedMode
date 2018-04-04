using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace AdoNetConnectedMode
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = ConnectionHelper.GetConnection())
            {
                connection.Open();

                DbCommand command = connection.CreateCommand();

                command.CommandText = @"create table gruppa(
                                        id int identity not null,
                                        name varchar(255) not null)";
                command.ExecuteNonQuery();

                Console.WriteLine("База успешно создана!");
                Console.ReadLine();
            }
        }
    }
}
