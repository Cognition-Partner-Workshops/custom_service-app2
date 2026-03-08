using System;
using MyAppTests.Services;

namespace MyAppTests.Tests
{
    public class LoginTests
    {
        public void Run()
        {
            var authService = new AuthService();
            authService.Register("testUser", "password123");

            Console.WriteLine("Login Test 1 (Valid): " + 
                (authService.Login("testUser", "password123") ? "Passed" : "Failed"));

            Console.WriteLine("Login Test 2 (Invalid): " + 
                (authService.Login("testUser", "wrongpass") ? "Failed" : "Passed"));
        }
    }
}
