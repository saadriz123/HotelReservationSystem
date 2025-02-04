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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessegeFLS Message1 = new MessegeFLS();
            Message1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookRoom booking = new BookRoom();
            booking.Show();
            this.Hide();
        }
    }
}
