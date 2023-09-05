using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PracticeSqlConnectionClass
{
    public class ConceptConnectionTimeout
    {
        public ConceptConnectionTimeout()
        {
           
            
        }
        public void Connect()
        {
            ConceptStoredConnectionString connectionString = new ConceptStoredConnectionString();
            string contxt = connectionString.conString;
            SqlConnection sqlConnection = new SqlConnection(contxt);
            sqlConnection.Open();
            Console.WriteLine("Gets the time to wait {0} seconds while trying to establish a connection before terminating the attempt",sqlConnection.ConnectionTimeout);
            Console.ReadLine();
            sqlConnection.Close();
        }

    }
}
