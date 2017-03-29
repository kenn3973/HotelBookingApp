using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Model
{
    class Guest
    {
        public int Guest_No { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }

        public Guest(int Guest_no, string Name, string Address)
        {
            this.Guest_No = Guest_No;
            this.Name = Name;
            this.Address = Address;
        }

        public override string ToString()
        {
            return $"Guest: {Guest_No}, Name: {Name}, Address: {Address}";
        }
    }
}
