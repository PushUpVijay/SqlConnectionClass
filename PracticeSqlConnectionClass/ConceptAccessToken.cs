using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace PracticeSqlConnectionClass
{
   public class ConceptAccessToken
    {
        //Data Source=Host,Initial Catalog=Database Name,Integrated Source?
        
        public string connectionString = "Data Source=(local);Initial Catalog=PracticeDatabase;Integrated Security=true";
        public string AccessToken()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            return sqlConnection.AccessToken;
            //SqlConnection Object Accesstoken return empty string
        }
    }
}
