using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PracticeSqlConnectionClass
{
    class ConceptDataSourceProperty
    {
        public ConceptDataSourceProperty()
        {

        }
        public void DataSourceName()
        {
            ConceptConnection conceptConnection = new ConceptConnection();
            SqlConnection sql=conceptConnection.Connect();
            string dataSourceName = sql.DataSource;
            Console.WriteLine(dataSourceName);
            Console.ReadLine();
        }

    }
}
