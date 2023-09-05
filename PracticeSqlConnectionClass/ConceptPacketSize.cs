using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace PracticeSqlConnectionClass
{
    class ConceptPacketSize
    {
        public ConceptPacketSize()
        {

        }
        public void PacketSize()
        {
            ConceptConnection conceptConnect = new ConceptConnection();
            SqlConnection sql = conceptConnect.Connect();
            
            int packetsize=sql.PacketSize;
            Console.WriteLine("PacketSize is {0},ServerVersion is {1},State is {2},Client Name is ",packetsize,sql.ServerVersion,sql.State,sql.WorkstationId);
            Console.ReadLine();
            sql.Close();
        }
    }
}
