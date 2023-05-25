using AssociationDokent.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationDokent.BusinesLogic.Interfaces
{
    public interface IUser
    {
        Task CreateAsync(User user);
        Task<List<User>> GetAsync();
    }
}
