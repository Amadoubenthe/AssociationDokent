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
        public async Task<List<UserSimplify>> GetSimplifyAsync(string gender = null)
        {
            
            var filter = Builders<User>.Filter.Empty;

            if (gender != null)
            {
                filter = Builders<User>.Filter.Eq(u => u.Gender, gender);
            }

            var filteredUsers = await _usersCollection
                .Find(filter)
                .Project(u => new UserSimplify
                {
                    Id = u.Id,
                    Nom = u.Name.First,
                    Prenom = u.Name.Last,
                    Email = u.Email,
                    Telephone = u.Phone,
                    Genre = u.Gender,
                    Civilite = u.Name.Title,
                    DateDeNaissance = u.Registered.Date
                })
                .ToListAsync();

            return filteredUsers;
        }


    }
}
