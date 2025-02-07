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

namespace HotelReservationsSystem
{
    public partial class ManagerFeedback : Form

    {
        private string stringconnection = "Server=localhost;Database=hotelreservationsystem;User ID=root;Password=;";
        public ManagerFeedback()
        {
            InitializeComponent();
            load();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManagerDashboard managerDashboard = new ManagerDashboard();
            managerDashboard.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void load()
        {
            using (MySqlConnection connect = new MySqlConnection(stringconnection))
            {
                connect.Open();
                string queryy = "SELECT * FROM feedback";
                using (MySqlCommand command54 = new MySqlCommand(queryy, connect))
                {
                    MySqlDataAdapter adapter123 = new MySqlDataAdapter(command54);
                    DataTable dataTable = new DataTable();
                    adapter123.Fill(dataTable);

                    dataGridView1.DataSource= dataTable;
                }
            }
        }
    }
}
