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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            LoginManager loginmanager = new LoginManager(username, password);

            if (loginmanager.ValidateLogin())
            {
                ManagerDashboard managerDashboard = new ManagerDashboard();
                managerDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();

        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
