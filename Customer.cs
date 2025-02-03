using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationsSystem
{
    internal class Customer
    {
        private string Name;
        private int ContactNumber;
        private string ID;

        public string name
        {
            get; set;
        }
         public string contactnumber
         {
            get; set;
         }
        private string id
        {
            get; set;
        }
        public Customer(string name, int contactnumber,string id) 
        {
            this.name = name;
            this.ContactNumber = contactnumber;
            this.ID = id;
        }
    }
}
