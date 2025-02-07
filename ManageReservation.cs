using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HotelReservationsSystem
{
    public partial class ManageReservation : Form
    {
        private string reservation = "Server=localhost;Database=hotelreservationsystem;User ID=root;Password=;";

        public ManageReservation()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string customerName = textBox1.Text;
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Please enter a customer name.");
                return;
            }
            List<string> reservationTypes = GetReservationByCustomerName(customerName);
            GetReservationByCustomerName(customerName);
            UpdateRadioButtons(reservationTypes);

            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Please select a reservation type.");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReservationForCustomer reservationForCustomer = new ReservationForCustomer();
            reservationForCustomer.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateRadioButtons(List<string> reservationTypes)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

            foreach (string reservationType in reservationTypes)
            {
                switch (reservationType)
                {
                    case "Confirmed":
                        radioButton1.Checked = true;
                        break;
                    case "Pending":
                        radioButton2.Checked = true;
                        break;
                    case "Canceled":
                        radioButton3.Checked = true;
                        break;
                    case "Completed":
                        radioButton4.Checked = true;
                        break;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                UpdateReservationType(textBox1.Text, "Confirmed");
            }
        }

        private List<string> GetReservationByCustomerName(string customerName)
        {
            string sqlQuery = "SELECT reservationtype FROM reservation WHERE fullname = @customerName";
            List<string> reservationTypes = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(reservation))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@customerName", customerName);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string reservationType = reader.GetString("reservationtype");
                            reservationTypes.Add(reservationType);
                        }
                    }
                }
            }

            return reservationTypes;
        }


        private void UpdateReservationType(string customerName, string newType)
        {
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Unable to update reservation type. Please enter a valid customer name.");
                return;
            }
            string sqlQuery = "UPDATE reservation SET reservationtype = @NewType WHERE fullname = @customerName";
            using (MySqlConnection connection = new MySqlConnection(reservation))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@NewType", newType);
                    command.Parameters.AddWithValue("@customerName", customerName);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Reservation type updated to '{newType}' for customer '{customerName}'.");
                    }
                    else
                    {
                        MessageBox.Show($"No reservation found for customer '{customerName}'.");
                    }
                }
            }
        }
        private void UpdateRoomAvailability(string reservationType)
        {
            string customerName = textBox1.Text;
            List<string> reservationTypes = GetReservationByCustomerName(customerName);

            foreach (string type in reservationTypes)
            {
                if (type == "Canceled" || type == "Completed")
                {
                    string roomType = GetRoomTypeFromReservation(customerName, type);
                    UpdateRoomAvailability(roomType, true);
                }
            }
        }

        private string GetRoomTypeFromReservation(string customerName, string reservationType)
        {
            string sqlQuery = "SELECT roomtype FROM reservation WHERE fullname = @customerName AND reservationtype = @reservationType";
            string roomType = "";

            using (MySqlConnection connection = new MySqlConnection(reservation))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@customerName", customerName);
                    command.Parameters.AddWithValue("@reservationType", reservationType);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            roomType = reader.GetString("roomtype");
                        }
                    }
                }
            }

            return roomType;
        }

        private void UpdateRoomAvailability(string roomType, bool isAvailable)
        {
            string sqlQuery = "UPDATE rooms SET Availability = @Availability WHERE Type = @RoomType";

            using (MySqlConnection connection = new MySqlConnection(reservation))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@Availability", isAvailable ? 1 : 0);
                    command.Parameters.AddWithValue("@RoomType", roomType);
                    command.ExecuteNonQuery();
                }
            }
        }


        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                UpdateReservationType(textBox1.Text, "Pending");
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                UpdateReservationType(textBox1.Text, "Completed");
                UpdateRoomAvailability("Completed");
            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                UpdateReservationType(textBox1.Text, "Cancelled");
                UpdateRoomAvailability("Cancelled");
            }
        }
    }
}