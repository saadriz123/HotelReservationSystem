using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotelReservationsSystem
{
    internal class Room
    {
        private string Type;
        private decimal Price;
        private bool IsAvailable;

        public string type
        {
            get { return type; }
            set { type = value; }
        }

        public decimal price
        {
            get { return Price; }
            set { Price = value; }
        }
        public bool isAvailable
        {
            get { return IsAvailable; }
            set { IsAvailable = value; }
        }
        public Room(string type, decimal price, bool isavailable)
        {
            this.Type = type;
            this.price = price;
            this.isAvailable = isavailable;
        }
        public void AddRoom(string connectionString)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            {
                connection.Open();
                string query = "INSERT INTO Rooms (Type,Price, Availability) VALUES (@Type, @Price, @Availability)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Type", Type);
                    command.Parameters.AddWithValue("@Price", Price);
                    command.Parameters.AddWithValue("@Availability", IsAvailable);
                    command.ExecuteNonQuery();
                }
            }

        }
    }
}
