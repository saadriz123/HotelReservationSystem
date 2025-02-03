using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationsSystem
{
    public class LoginCustomer : Person
    {
        public LoginCustomer(string username, string password) : base(username, password)
        {
        }
        public override void Login()
        {
            if (Username == "customer" && Password == "customer")
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
            return Username == "customer" && Password == "customer";
        }
    }
}
