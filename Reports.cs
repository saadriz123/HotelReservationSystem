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
    public partial class Reports : Form
    {
        private string connectionstring = "Server=localhost;Database=hotelreservationsystem;User ID=root;Password=;";
        public Reports()
        {
            InitializeComponent();
            LoadReservationData();
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
        private void LoadReservationData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionstring))
            {
                connection.Open();

                string query = "SELECT * FROM reservation";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;

                    }
                }
            }
        }
    }
}
