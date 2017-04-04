using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingApp.Model;
using HotelBookingApp.ViewModel;
using HotelBookingApp.Persistency;

namespace HotelBookingApp.Handler
{
    class myHotelHandler
    {
        public HotelViewModel HotelViewModel { get; set; }

        public myHotelHandler(HotelViewModel hvm)
        {
            this.HotelViewModel = hvm;
        }

        public void HentGuest()
        {
            //PersistencyService.HentDataAsync();
        }

        public void OpretGuest()
        {
            Guest nyGuest = new Guest(HotelViewModel.GuestNo, HotelViewModel.Name, HotelViewModel.Address);
            HotelSingleton.Instance.Guests.Add(nyGuest);

            //PersistencyService.GemDataAsync();
        }

        public void SletGuest()
        {
            HotelSingleton.Instance.Guests.Remove(HotelViewModel.SelectedGuest);
            //PersistencyService.GemDataAsync();
        }
    }


}
