//SqlConnection Class BeginTransaction Method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace PracticeSqlConnectionClass
{
    class BeginTransaction
    {
        public BeginTransaction()
        {

        }
        //Begin Transaction Requires Commands Text Query
        public void BeginTSql()
        {
            //ConnectionString for connecting to Database
            string conString = "Data Source=(local);Initial Catalog=PracticeDatabase;Integrated Security=true";
            //SqlConnection is Object
            SqlConnection sqlConnection = new SqlConnection(conString);
            sqlConnection.Open();
            //BeginTransaction has 2 requirements of commands 1.connection and 2.Transaction


            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            SqlTransaction sqlTransaction;


            sqlTransaction = sqlConnection.BeginTransaction();



            sqlCommand.Connection = sqlConnection;
            sqlCommand.Transaction = sqlTransaction;
            
            sqlCommand.CommandText = "Insert into tblTest2 (Id) Values (2)";
            sqlCommand.ExecuteNonQuery();
            sqlTransaction.Commit();
            Console.WriteLine("Command execute in database");
            Console.ReadLine();
        }
            
    }
        
}
