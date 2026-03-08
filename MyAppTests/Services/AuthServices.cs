using System.Collections.Generic;

namespace MyAppTests.Services
{
    public class AuthService
    {
        private readonly Dictionary<string, string> _users = new Dictionary<string, string>();

        public void Register(string username, string password)
        {
            if (!_users.ContainsKey(username))
            {
                _users.Add(username, password);
            }
        }

        public bool Login(string username, string password)
        {
            return _users.ContainsKey(username) && _users[username] == password;
        }
    }
}
