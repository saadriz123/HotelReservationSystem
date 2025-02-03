using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationsSystem
{
    public class LoginManager : Person
    {
        public LoginManager(string username, string password) : base(username, password)
        {
        }
        public override void Login()
        {
            if (Username == "manager" && Password == "manager")
            {
                Console.WriteLine("Login successful.");
            }
            else
            {
                Console.WriteLine("Login failed. Invalid username or password.");
            }
        }

        public bool ValidateLogin()
        {
            // Validation logic inside the class (OOP)
            return Username == "manager" && Password == "manager";
        }
    }
}