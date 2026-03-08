using System.Collections.Generic;
using MyAppTests.Models;

namespace MyAppTests.Services
{
    public class UserService
    {
        private readonly List<User> _users = new List<User>();

        public void CreateUser(User user)
        {
            _users.Add(user);
        }

        public User GetUserByMail(string mailID)
        {
            return _users.Find(u => u.MailID == mailID);
        }
    }
}
