using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using maHappDemo.Models;

namespace maHappDemo.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        
        #region INotifyPropertyChanged_implementation
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        public MainViewModel()
        {
            MainModel = new MainModel();
        }


        //private string _content;

        //public string Content
        //{
        //    get { return _content; }
        //    set { 
        //        if(_content == value) return;
        //        _content = value;
        //        OnPropertyChanged(nameof(Content));
                
        //    }
        //}

        private MainModel _mainModel;

        public  MainModel MainModel
        {
            get { return _mainModel; }
            set {
                if (_mainModel == value) return;
                _mainModel = value;
                OnPropertyChanged(nameof(MainModel));
            }
        }


    }
}
