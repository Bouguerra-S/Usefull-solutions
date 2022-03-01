﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo.Models
{
    public class Employee:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertName)
        {
            if (PropertyChanged != null )
                PropertyChanged(this, new PropertyChangedEventArgs(propertName));
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged("Name"); }
        }
        private int age;

        public int Age
        {
            get { return age;  }
            set { age = value; OnPropertyChanged("Age"); }
        }

    }
}
