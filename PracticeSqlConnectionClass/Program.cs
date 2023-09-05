using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSqlConnectionClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //Program program = new Program();
            //ConnnectionClient Id
            /**
            Guid guid= program.ConnectionClientId();
            Console.WriteLine(guid);
            Console.ReadLine();
            **/
            ///Guid Connection Client Id didn't get
            ///Connection Timeout 
            /**
            ConceptConnectionTimeout conceptConnectionTimeout = new ConceptConnectionTimeout();
            conceptConnectionTimeout.Connect();
            **/
            /**
            ConnectionCredentialProperty connectionCredentialProperty = new ConnectionCredentialProperty();
            connectionCredentialProperty.Creditial();
                        **/
            /**
            ConceptGetDatabaseNameProperty conceptGetDatabaseNameProperty=new ConceptGetDatabaseNameProperty();
            conceptGetDatabaseNameProperty.DatabaseName();
            **/
            //SqlConnecton Class DataSource Property
            /**
            ConceptDataSourceProperty conceptDataSourceProperty = new ConceptDataSourceProperty();
            conceptDataSourceProperty.DataSourceName();
            **/
            //Concept Packet Size
            /**
            ConceptPacketSize conceptPacketSize = new ConceptPacketSize();
            conceptPacketSize.PacketSize();
            **/
            //BeginTransaction Method Code
            /**
            BeginTransaction beginTransaction = new BeginTransaction();
            beginTransaction.BeginTSql();
            **/
            //ConceptChangeDatabase
            /**
            ConceptChangeDatabase conceptChangeDatabase = new ConceptChangeDatabase();
            conceptChangeDatabase.changeDatabase();
            **/
            //Concepts ClearPool & ClearAllPools()
            /**
            ConceptClearPool conceptClearPool = new ConceptClearPool();
            conceptClearPool.MethodClearPool();
            **/
            /**Closing Database connection
            ConceptClose conceptClose = new ConceptClose();
            conceptClose.ConClose();
            **/
            //Concept CreateCommand
            /**
            ConceptCreateCommand conceptCreateCommand = new ConceptCreateCommand();
            conceptCreateCommand.TestCreateCommand();
            **/
            //SqlConnection.EnlistDistributedTransaction(ITransaction) Method Pending
            //EnlistTransaction Method is pending
            /**
             * 
             * **/
            //ConceptGetSchema
            /**Pending GetSchema
            ConceptGetSchema conceptGetSchema = new ConceptGetSchema();
            conceptGetSchema.MethodGetSchema();
            **/

            //Pending Concepts
            // (OpenAsync,RegisterColumnEncryptionKeyStoreProviders,ResetStatistics,RetrieveStatistics)


        }
    }

}
