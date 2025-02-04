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
    public partial class BookRoom : Form
    {
        public BookRoom()
        {
            InitializeComponent();
        }

        private void BookRoom_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReservationForCustomer reservationForCustomer = new ReservationForCustomer();
            reservationForCustomer.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int contactnumber=int.Parse(textBox2.Text);
            string id = textBox3.Text;
            DateTime checkindate= dateTimePicker1.Value;
            DateTime checkoutdate = dateTimePicker2.Value;
            int numberofadults= (int)numericUpDown1.Value;
            int numberofchildren = (int)numericUpDown2.Value;
            string roomtype = comboBox1.SelectedItem.ToString();

            Reservation reservation1 = new Reservation(name,contactnumber,id,checkindate,checkoutdate,numberofadults,numberofchildren,roomtype);
            reservation1.AddReservation();
        }
    }
}
