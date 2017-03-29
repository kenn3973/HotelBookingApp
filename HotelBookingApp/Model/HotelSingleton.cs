using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace HotelBookingApp.Model
{
    class HotelSingleton
    {
        private static HotelSingleton _instance;

        public static HotelSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HotelSingleton();
                }
                return _instance;
            }
        }

        public ObservableCollection<Guest> Guests { get; set; }

        private HotelSingleton()
        {
            Guests = new ObservableCollection<Guest>();
        }
    }
}
