using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSqlConnectionClass
{
    class ConnectionCredentialProperty
    {
        public ConnectionCredentialProperty()
        {

        }
        public void Creditial()
        {
            
            ConceptConnection conceptConnection = new ConceptConnection();
            object obj = conceptConnection.ConnectReturnsOb();
            Console.WriteLine(obj);
            Console.ReadLine();
            
            
        }
    }
}
