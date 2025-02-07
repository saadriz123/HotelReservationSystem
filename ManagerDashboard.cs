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
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManagerLogin managerLogin = new ManagerLogin();
            managerLogin.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ManagerManageRooms managerManageRooms = new ManagerManageRooms();
            managerManageRooms.Show();
            this.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ManagerFeedback managerFeedback = new ManagerFeedback();
            managerFeedback.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
