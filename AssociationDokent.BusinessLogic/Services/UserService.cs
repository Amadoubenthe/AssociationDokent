using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssociationDokent.DataAccess.Models;

namespace AssociationDokent.BusinessLogic.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;
    }
}
