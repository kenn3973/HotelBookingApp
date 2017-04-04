using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingApp.Handler;
using HotelBookingApp.Common;
using HotelBookingApp.Persistency;
using HotelBookingApp.Model;
using System.Windows.Input;
using System.ComponentModel;

namespace HotelBookingApp.ViewModel
{
    class HotelViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private HotelSingleton _hotelSingleton;

        public HotelSingleton HotelSingleton
        {
            get { return _hotelSingleton; }
            set { _hotelSingleton = value; }
        }

        public int GuestNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public myHotelHandler hotelHandler { get; set; }

        private Guest _selectedGuest;

        public Guest SelectedGuest
        {
            get { return _selectedGuest; }
            set { _selectedGuest = value;
                OnPropertyChanged(nameof(SelectedGuest));
            }
        }

        //public ICommand HentGuestCommand { get; set; }
        public ICommand OpretGuestCommand { get; set; }
        public ICommand SletGuestCommand { get; set; }

        public HotelViewModel()
        {
            HotelSingleton = HotelSingleton.Instance;

            hotelHandler = new myHotelHandler(this);

            //HentGuestCommand = new RelayCommand(hotelHandler.HentGuest, null);
            OpretGuestCommand = new RelayCommand(hotelHandler.OpretGuest, null);
            SletGuestCommand = new RelayCommand(hotelHandler.SletGuest, checkOmListenErEmpty);
            //PersistencyService.HentDataAsync();
        }

        public bool checkOmListenErEmpty()
        {
            if (HotelSingleton.Instance.Guests.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
    }


}
