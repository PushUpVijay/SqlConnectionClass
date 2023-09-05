using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PracticeSqlConnectionClass
{
    public class ConceptCreateCommand
    {
        public void TestCreateCommand()
        {
            ConceptConnection conceptConnection = new ConceptConnection();
            
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection= conceptConnection.Connect();
            sqlCommand.CommandText = "Select Id,UnitPrice,ProductName From products";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Console.WriteLine("\tId\tUnit\tProductName");
            while (sqlDataReader.Read())
            {
                Console.WriteLine("\t{0}\t{1}\t{2}", sqlDataReader[0], sqlDataReader[1], sqlDataReader[2]);
            }
            Console.ReadLine();
        }   
    }
}
