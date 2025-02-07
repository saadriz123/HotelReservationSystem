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
        public Room() 
        { 
        }
        public Room(string type, decimal price, bool isavailable)
        {
            this.Type = type;
            this.price = price;
            this.isAvailable = isavailable;
        }
        public Room(string type, bool availability)
        {
            this.type = type;
            this.isAvailable = availability;
        }

        public void AddRoom(string connectionString)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            {
                connection.Open();
                string query = "INSERT INTO rooms (Type,Price, Availability) VALUES (@Type, @Price, @Availability)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Type", Type);
                    command.Parameters.AddWithValue("@Price", Price);
                    command.Parameters.AddWithValue("@Availability", IsAvailable);
                    command.ExecuteNonQuery();
                }
            }

        }
        public void UpdateRoomAvailability()
        {
            string connectionString = "Server=localhost;Database=hotelreservationsystem;User ID=root;Password=";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "UPDATE rooms SET availability = @availability WHERE type = @type";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Availability", isAvailable);
                    command.Parameters.AddWithValue("@Type", Type);

                    command.ExecuteNonQuery();
                }
            }
        }
        public static Room GetRoomByType(string roomType)
        {
            string connectionString = "Server=localhost;Database=hotelreservationsystem;User ID=root;Password=";
            Room room = null;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Type, Price, Availability FROM rooms WHERE Type = @Type";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Type", roomType);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            room = new Room(
                                reader.GetString("Type"),
                                reader.GetDecimal("Price"),
                                reader.GetBoolean("Availability")
                            );
                        }
                    }
                }
            }

            return room;
        }

    }
}
