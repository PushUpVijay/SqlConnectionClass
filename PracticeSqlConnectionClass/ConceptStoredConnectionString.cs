using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PracticeSqlConnectionClass
{
    public class ConceptStoredConnectionString
    {
         public string  conString ;

        public  ConceptStoredConnectionString()
        {
            conString = "Data Source=(local);Initial Catalog=PracticeDatabase;Integrated Security=true";
        }
    }
}
