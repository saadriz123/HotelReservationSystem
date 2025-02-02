using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservationsSystem
{
    public partial class ManagerManageRooms : Form

    {
        private string connection = "Server=localhost;Database=hotelreservationsystem;User ID=root;Password=;";
        public ManagerManageRooms()
        {
           InitializeComponent();
           LoadRoomsToGrid();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ManagerDashboard managerDashboard = new ManagerDashboard();
            managerDashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type = textBox1.Text;
            decimal price = decimal.Parse(textBox2.Text);
            bool availability = true;

            Room room1 = new Room(type, price, availability);
            room1.AddRoom(connection);
            LoadRoomsToGrid();

        }
        private void LoadRoomsToGrid()
        {
            string gridquery = "SELECT * FROM rooms";
            using (MySqlConnection connection2 = new MySqlConnection(connection))
            {
                connection2.Open();
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(gridquery, connection2))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedType = dataGridView1.SelectedRows[0].Cells["Type"].Value.ToString();
                decimal selectedprice = decimal.Parse(dataGridView1.SelectedRows[0].Cells["Price"].Value.ToString());

                DeleteRoom(selectedType, selectedprice);
                LoadRoomsToGrid();
            }
            else
            {
                MessageBox.Show("Please select a room to delete");
            }
        }

        private void DeleteRoom(string type, decimal price)
        {
            string sqlquery = "DELETE FROM rooms WHERE Type = @Type AND Price = @Price";
            using (MySqlConnection connection2 = new MySqlConnection (connection))
            { 
                connection2.Open();
                using (MySqlCommand command2 = new MySqlCommand(sqlquery, connection2)) 
                {
                    command2.Parameters.AddWithValue("Type", type);
                    command2.Parameters.AddWithValue("Price",price);
                    command2.ExecuteNonQuery();
                }
            }

        }
    }
}
