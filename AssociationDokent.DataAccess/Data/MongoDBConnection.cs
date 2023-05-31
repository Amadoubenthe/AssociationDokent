using AssociationDokent.DataAccess.Models;
using MongoDB.Driver;
using Microsoft.Extensions.Options;


namespace AssociationDokent.DataAccess.Data
{
    public class MongoDBConnection
    {
        private readonly IMongoDatabase _database;

        public MongoDBConnection(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            _database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        }

        public IMongoCollection<User> UsersCollection => _database.GetCollection<User>("users");
    }
}
