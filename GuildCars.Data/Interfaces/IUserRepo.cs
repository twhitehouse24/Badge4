using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildCars.Data.Interfaces
{
    public interface IUserRepo
    {
        List<Users> GetUsers();
        
        void UpdateUser(Users users);
        Users GetUserById(string id);
        void AddNewUser(Users users);
    }
}
