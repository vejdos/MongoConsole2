using MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace MongoConsole
{
    class Program
    {
        private DependencyProvider _dependencyProvider;

        static void Main(string[] args)
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            GetDatabaseNames(client).GetAwaiter().GetResult();
            //  GetDatabaseNames(client);
            //  IMongoDatabase database = client.GetDatabase("test");

        }
        private static async Task GetDatabaseNames(MongoClient client)
        {
            using (var cursor = await client.ListDatabasesAsync())
            {
                var databaseDocuments = await cursor.ToListAsync();
                foreach (var databaseDocument in databaseDocuments)
                {
                    // if (databaseDocument["name"] == "local")
                    client.DropDatabase("Delete");
                    client.


                        DropDatabase

                    Console.WriteLine(databaseDocument["name"]);



                }
            }
        }





    }
}
