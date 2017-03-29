using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingApp.Model
{
    class Room
    {
        public int Room_No { get; set; }
        public int Hotel_No { get; set; }
        public string Types { get; set; }
        public double? Price { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
