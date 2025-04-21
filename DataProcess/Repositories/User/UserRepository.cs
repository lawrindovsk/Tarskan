using Database;
using Database.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProcess.Repositories.User
{
    public class UserRepository : IUserRepository
    {
        DContext context = new();
        public Task<List<UserModel>> GetAllUsers()
        {
            try
            {
                List<UserModel> UsuarioCadastrados = context.User.ToList();
                return Task.FromResult(UsuarioCadastrados);
            }
            catch  (Exception Ex)
            { 
                throw;
            }
        }

        public Task<UserModel> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
