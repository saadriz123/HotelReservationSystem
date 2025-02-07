using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationsSystem
{
    internal class Paymentp
    {
        private string Nameoncard;
        private long CardNumber;
        private string ExpiryDate;
        private string Cvc;

        public string nameoncard
        {
            get { return Nameoncard; }
            set { Nameoncard = value; }
        }
        public long cardnumber
        {
            get { return CardNumber; }
            set { CardNumber = value; }
        }
        public string expirydate
        {
            get { return ExpiryDate; }
            set { ExpiryDate = value; }
        }
        public string cvc
        {
            get { return Cvc; }
            set { Cvc = value; }
        }
        public Paymentp(string nameoncard, long cardnumber, string expirydate,string cvc)
        {
            this.Nameoncard = nameoncard;
            this.CardNumber = cardnumber;
            this.ExpiryDate = expirydate;
            this.Cvc = cvc;
        }
        public void SavePaymment()
        {
            string paymentstring = "Server=localhost;Database=hotelreservationsystem;User ID=root;Password=;";
            using (MySqlConnection connection6 = new MySqlConnection(paymentstring)) 
            {
                connection6.Open();
                string query = "INSERT INTO reservation (nameoncard,cardnumber, expirydate, cvc) VALUES (@nameoncard, @cardnumber, @expirydate, @cvc)";
                using (MySqlCommand command6 = new MySqlCommand(query, connection6)) 
                {
                    command6.Parameters.AddWithValue("@nameoncard",nameoncard);
                    command6.Parameters.AddWithValue("@cardnumber",cardnumber);
                    command6.Parameters.AddWithValue("@expirydate",expirydate);
                    command6.Parameters.AddWithValue("@cvc",cvc);
                    command6.ExecuteNonQuery();
                }
            }
        }
       

    }
}

