using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PracticeSqlConnectionClass
{
    class ConceptClearPool
    {
        //Empties Connection Pool
        public void MethodClearPool()
        {
            ConceptConnection conceptConnection = new ConceptConnection();
            //SqlConnection sqlConnectionObject = new SqlConnection();

            //What is connection Pool
            // SqlConnection sqlConnectionObjectTwo = conceptConnection.Connect();
            //  SqlConnection.ClearPool(conceptConnection.Connect());
            SqlConnection.ClearAllPools();
            int value =(int)conceptConnection.Connect().State;
            Console.WriteLine("Is There Connection With Database {0}",value );
            Console.ReadLine();
           


           
        }
    }
}
