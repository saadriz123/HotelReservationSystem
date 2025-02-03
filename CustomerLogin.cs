﻿using System;
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
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;

            LoginCustomer logincustomer = new LoginCustomer(username, password);

            if (logincustomer.ValidateLogin())
            {
                ReservationForCustomer reservation1 = new ReservationForCustomer();
                reservation1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
