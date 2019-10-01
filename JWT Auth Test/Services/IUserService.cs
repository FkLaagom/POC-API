using System.Collections.Generic;

namespace JWT_Auth_Test.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }
}
