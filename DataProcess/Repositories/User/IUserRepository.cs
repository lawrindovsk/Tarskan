using Database.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcess.Repositories.User
{
    public interface IUserRepository
    {
        public Task<List<UserModel>> GetAllUsers();
        public Task<UserModel> GetById(int id);
    }
}
