using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelReservationsSystem
{
    internal class FeedBackClass
    {
        private string RoomType;
        private int Rating;
        private string Feedback;

        public string roomType
        {
            get { return RoomType; }
            set{ RoomType = value; }
        }
        public int rating
        {
            get { return Rating; }
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("Rating must be between 1 and 5.");
                }
                Rating = value;
            }
        }
        public string feedback
        {
            get { return Feedback; }
            set { Feedback = value; }
        }
        public FeedBackClass(string roomType, int rating, string feeedback)
        {
            RoomType = roomType;
            Rating = rating; 
            Feedback = feeedback;
        }
        public void InsertFeedback()
        {
            string connectionString2 = "Server=localhost;Database=hotelreservationsystem;User ID=root;Password=;";

            using (MySqlConnection connection12 = new MySqlConnection(connectionString2))
            {
                connection12.Open();

                string query = "INSERT INTO feedback (roomtype, rating, feedback) VALUES (@roomtype, @rating, @feedback)";

                using (MySqlCommand command = new MySqlCommand(query, connection12))
                {
                    command.Parameters.AddWithValue("@roomtype", roomType);
                    command.Parameters.AddWithValue("@rating", rating);
                    command.Parameters.AddWithValue("@feedback", feedback);

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
