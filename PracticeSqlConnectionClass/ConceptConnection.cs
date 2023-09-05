using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PracticeSqlConnectionClass
{
    public class ConceptConnection
    {
        public ConceptConnection()
        {

        }
        public  SqlConnection Connect() 
        {
            ConceptStoredConnectionString storedConnectionString = new ConceptStoredConnectionString();
            SqlConnection sqlconnection = new SqlConnection(storedConnectionString.conString);
            
            sqlconnection.Open();
            
            //object ob = sqlconnection.Credential;
            return sqlconnection;

            
        }
        
        public object ConnectReturnsOb()
        {
            ConceptStoredConnectionString storedConnectionString = new ConceptStoredConnectionString();
            SqlConnection sqlconnection = new SqlConnection(storedConnectionString.conString);
            sqlconnection.Open();
            object ob = sqlconnection.Credential;
            return ob;

        }
        public void Close()
        {
                   
        }
    }
}
