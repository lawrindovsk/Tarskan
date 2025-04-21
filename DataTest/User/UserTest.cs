using Database.Models.User;
using DataProcess.Repositories.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTest.User
{
    [TestClass]
    public class UserTest
    {
        IUserRepository userRepository;
        public UserTest()
        {
            userRepository  = new UserRepository();
        }

        [TestMethod] 
        public async Task GetAllUsers()
        {
           List <UserModel>users = await userRepository.GetAllUsers();
            
        }
    }
}
