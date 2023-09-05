using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PracticeSqlConnectionClass
{
    class ConceptGetDatabaseNameProperty
    {
        public ConceptGetDatabaseNameProperty()
        {

        }
        public void DatabaseName() 
        {
            ConceptConnection conceptConnect = new ConceptConnection();
            SqlConnection sql = conceptConnect.Connect();
            string db=sql.Database;
            Console.WriteLine("Db Name is {0}", db);
            Console.ReadLine();
          
            
        }
        
        
    }
}
