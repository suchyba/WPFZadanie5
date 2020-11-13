using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFZadanie5
{
    public class User : INotifyPropertyChanged
    {

        private string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                onPropertyChanged("Display");
            }
        }
        private string surname;
        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
                onPropertyChanged("Display");
            }
        }
        private string email;
        public string Email
        {
            get => email;
            set
            {
                email = value;
                onPropertyChanged("Display");
            }
        }
        public decimal? Value { get; set; } = null;
        public string Region { get; set; } = null;
        public int? Level { get; set; } = null;

        public string Display => $"{Name} {Surname} ({Email ?? "brak"})";


        public event PropertyChangedEventHandler PropertyChanged;
        public User()
        {
            Name = null;
        }

        public void onPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
