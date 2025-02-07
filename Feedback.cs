using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelReservationsSystem
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReservationForCustomer reservationForCustomer = new ReservationForCustomer();
            reservationForCustomer.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateFormFields())
            {
                return;
            }
            string roomType = textBox1.Text;
            int rating = (int) numericUpDown1.Value;
            string comment = richTextBox1.Text;
            FeedBackClass feedback = new FeedBackClass(roomType, rating, comment);
            feedback.InsertFeedback();
            ShowMessageForm();

        }
        private void ShowMessageForm()
        {
            MessegeFLS messageForm = new MessegeFLS();
            messageForm.Show();
            this.Hide();
        }

        private bool ValidateFormFields()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a room type.");
                return false;
            }

            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Please select a rating.");
                return false;
            }

            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                MessageBox.Show("Please enter a comment.");
                return false;
            }

            return true;
        }
    }
}
