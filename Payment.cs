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
        private bool areTermsAndConditionsAccepted = false;
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateFormFields())
            {
                return;
            }
            string nameoncard = textBox1.Text;
            long cardnumber = long.Parse(textBox2.Text);
            string expirydate = textBox3.Text;
            string cvc = maskedTextBox1.Text;
            Paymentp pay = new Paymentp(nameoncard, cardnumber, expirydate, cvc);
            pay.SavePaymment();


            MessegeFLS messege = new MessegeFLS();
            messege.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            BookRoom booking = new BookRoom();
            booking.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                areTermsAndConditionsAccepted = true;
            }
            else
            {
                areTermsAndConditionsAccepted = false;
            }
        }
        private bool ValidateFormFields()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter the name on the card.");
                return false;
            }

            if (string.IsNullOrEmpty(textBox2.Text) || !long.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Please enter a valid card number.");
                return false;
            }

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please enter the expiry date.");
                return false;
            }

            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                MessageBox.Show("Please enter the CVC.");
                return false;
            }
            if (!areTermsAndConditionsAccepted)
            {
                MessageBox.Show("Please agree to the terms and conditions.");
                return false;
            }

            return true;
        }

    }
}
