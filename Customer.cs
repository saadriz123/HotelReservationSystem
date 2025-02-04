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
            get { return Name; }
            set { Name = value; }
        }
         public int contactnumber
         {
            get { return ContactNumber;}
            set { ContactNumber = value; }
         }
        public string id
        {
            get { return ID;}
            set { ID = value; }
        }
        public Customer(string name)
        {
            this.name = name;
        }
        public Customer(string name, int contactnumber,string id) 
        {
            this.name = name;
            this.ContactNumber = contactnumber;
            this.ID = id;
        }
    }
}
