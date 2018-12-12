using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListviewSample
{
    public class Contacts : INotifyPropertyChanged
    {
        private string contactName;
        private int contactNumber;
        private bool favorite;

        public Contacts(string name, int number)
        {
            contactName = name;
            contactNumber = number;
        }

        public Contacts()
        {

        }

        public bool Favorite
        {
            get { return favorite; }
            set
            {
                if (favorite != value)
                {
                    favorite = value;
                    this.RaisedOnPropertyChanged("Favorite");
                }
            }
        }
        public string ContactName
        {
            get { return contactName; }
            set
            {
                if (contactName != value)
                {
                    contactName = value;
                    this.RaisedOnPropertyChanged("ContactName");
                }
            }
        }

        public Int32 ContactNumber
        {
            get { return contactNumber; }
            set
            {
                if (contactNumber != value)
                {
                    contactNumber = value;
                    this.RaisedOnPropertyChanged("ContactNumber");
                }
            }
        }

      
        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
    }
}
