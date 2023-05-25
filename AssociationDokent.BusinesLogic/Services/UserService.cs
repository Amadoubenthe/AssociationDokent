using AssociationDokent.BusinesLogic.Interfaces;
using AssociationDokent.DataAccess.Data;
using AssociationDokent.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using MongoDB.Bson;

namespace AssociationDokent.BusinesLogic.Services
{
    public class UserService : IUser
    {
        private readonly IMongoCollection<User> _usersCollection;

        public UserService(MongoDBConnection mongoDBConnection)
        {
            _usersCollection = mongoDBConnection.UsersCollection;
        }

        public async Task CreateAsync(User user)
        {
            await _usersCollection.InsertOneAsync(user);
        }

        public async Task<List<User>> GetAsync()
        {
            return await _usersCollection.Find(_ => true).ToListAsync();
        }

    }
}
