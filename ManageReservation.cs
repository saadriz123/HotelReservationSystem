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
    public partial class ManageReservation : Form
    {
        public ManageReservation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReservationForCustomer reservationForCustomer = new ReservationForCustomer();
            reservationForCustomer.Show();
            this.Hide();
        }
    }
}
