using Microsoft.Extensions.DependencyInjection;


namespace MongoDB
{
    public class DependencyProvider
    {
        public IServiceCollection ServiceCollection;

        public DependencyProvider()
        {
            CreateServiceCollection();
        }

        private void CreateServiceCollection()
        {
            ServiceCollection = new ServiceCollection();
            ServiceCollection.AddTransient(typeof(IMongoDatabaseSettings), (obj) => { return new MongoDatabaseSettings()
            {
                DatabaseName = "gpnoid_test",
                ConnectionString = "mongodb://localhost:27017"
            }; });
            ServiceCollection.AddTransient<IMongoDataContextFactory, MongoDataContextFactory>();
        }
    }
}
