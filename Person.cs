using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationsSystem
{
    public class Person
    {
        private string username;
        private string password;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Person(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public virtual void Login()
        {
            Console.WriteLine($"Logging in as {Username}");
        }
    }

}
