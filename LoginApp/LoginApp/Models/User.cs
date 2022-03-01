using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Models
{
    class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertName));
        }
        private string username;
        public string Username { get { return username; } set { username = value; } }
        private string password;



        public string Password { get { return password; } set { password = value; } }
    }
}
