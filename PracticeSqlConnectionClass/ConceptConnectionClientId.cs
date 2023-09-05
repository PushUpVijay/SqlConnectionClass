using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PracticeSqlConnectionClass
{
   public class ConceptConnectionClientId
    {

        public string connectionString = "Data Source=(local);Initial Catalog=PracticeDatabase;Integrated Security=true";

        public Guid ConnectionClientId()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string cmdText = "Select Id From products";
            SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Guid abc= sqlConnection.ClientConnectionId;
            return abc;
            
            
        }

    }
}
