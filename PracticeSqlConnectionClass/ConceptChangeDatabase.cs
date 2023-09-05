using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PracticeSqlConnectionClass
{
    class ConceptChangeDatabase
    {
        public void changeDatabase()
        {
            ConceptConnection conceptConnection = new ConceptConnection();
            SqlConnection sqlConnectionObject=conceptConnection.Connect();
            Console.WriteLine("Database is {0}",sqlConnectionObject.Database);
            
            sqlConnectionObject.ChangeDatabase("PracticeTwo");
            Console.WriteLine("Now Database Is Changed To {0}", sqlConnectionObject.Database);
            Console.ReadLine();
            sqlConnectionObject.Close();
        }
    }
}
