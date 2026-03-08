using System;
using MyAppTests.Models;
using MyAppTests.Services;

namespace MyAppTests.Tests
{
    public class UserCreationTests
    {
        public void Run()
        {
            var userService = new UserService();
            var user = new User
            {
                Name = "Alice",
                Age = 28,
                MailID = "alice@example.com",
                Occupation = "Engineer",
                Gender = "Female"
            };

            userService.CreateUser(user);

            var retrievedUser = userService.GetUserByMail("alice@example.com");
            Console.WriteLine("User Creation Test: " + 
                (retrievedUser != null && retrievedUser.Name == "Alice" ? "Passed" : "Failed"));
        }
    }
}
