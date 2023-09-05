using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PracticeSqlConnectionClass
{
    class ConceptClose
    {
        public void ConClose()
        {
            ConceptConnection conceptConnect = new ConceptConnection();
            conceptConnect.Close();
            Console.WriteLine("Connection State is{0}", (int)conceptConnect.Connect().State);
            Console.ReadLine();
        }
        
        
    }
}
