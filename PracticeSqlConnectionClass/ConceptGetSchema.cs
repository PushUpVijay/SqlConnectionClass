using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PracticeSqlConnectionClass
{
    class ConceptGetSchema
    {
       public void MethodGetSchema() 
        {
            ConceptConnection conceptConnection = new ConceptConnection();
            SqlConnection sqlconnection=conceptConnection.Connect();
            var collectionTables = new List<DataTable>();
            string tbl = "Tables";
            DataTable dataTable=sqlconnection.GetSchema(tbl);
            
            Console.WriteLine("Table name is",dataTable);
            Console.ReadLine();
        }
    }
}
