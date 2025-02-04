using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationsSystem
{
    internal class Reservation : Customer
    {
        private DateTime CheckinDate;
        private DateTime CheckOutDate;
        private int NumberofAdults;
        private int NumberofChildren;
        private string RoomType;
        private int Cardnumber;
        private DateTime ExpiryDate;
        private int CVC;

        public DateTime checkindate
        {
            get { return CheckinDate; }
            set { CheckinDate = value; }
        }

        public DateTime checkoutdate
        {
            get { return CheckOutDate; }
            set { CheckOutDate = value; }
        }

        public int numberofAdults
        {
            get { return NumberofAdults; }
            set { NumberofAdults = value; }
        }
        public int numberofChildren
        {
            get { return NumberofChildren; }
            set { NumberofChildren = value; }
        }
        private string roomtype
        {
            get { return RoomType; }
            set { RoomType = value; }
        }
        public Reservation (string name,int contactnumber,string id,DateTime checkindate,DateTime checkoutdate,int numberofadults,int numberofchildren,string roomtype) : base(name, contactnumber, id)
        {
            this.checkindate = checkindate;
            this.checkoutdate = checkoutdate;
            this.numberofAdults= numberofadults;
            this.numberofChildren= numberofchildren;
            this.roomtype = roomtype;
        }
        public void AddReservation()
        {
            using ( MySqlConnection connection3 = new MySqlConnection("Server=localhost;Database=hotelreservationsystem;User ID=root;Password=;"))
            {
                connection3.Open();

                using (MySqlCommand command3 = new MySqlCommand("INSERT INTO reservation (fullname, conttactnumber, id, checkindate, checkoutdate, numberofadults, numberofchildren, roomtype) VALUES (@fullname, @contactnumber, @id, @checkindate, @checkoutdate, @numberofadults,@numberofchildren, @roomtype"))
                {
                    command3.Parameters.AddWithValue("@fullname",name);
                    command3.Parameters.AddWithValue("@contactnumber",contactnumber);
                    command3.Parameters.AddWithValue("@id", id);
                    command3.Parameters.AddWithValue("@checkindate",checkindate);
                    command3.Parameters.AddWithValue("@checkoutdate",checkoutdate);
                    command3.Parameters.AddWithValue("@numberofadults",numberofAdults);
                    command3.Parameters.AddWithValue("numberofchildren",numberofChildren);
                    command3.Parameters.AddWithValue("@roomtype",RoomType);
                    command3.ExecuteNonQuery();

                }
            }
        }
    }
}
