using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resumeadaptorWPF.Models
{
    public class line:INotifyPropertyChanged
    {
        #region INotifyPropertyChanged_implementation
        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged("Id"); }
        }

        private int order;

        public int Order
        {
            get { return order; }
            set { order = value; OnPropertyChanged("Order"); }
        }

        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; OnPropertyChanged("Text"); }
        }

        private int subSectionId;

        public int SubSectionId
        {
            get { return subSectionId; }
            set { subSectionId = value; OnPropertyChanged("SubSectionId"); }
        }


        public line()
        {

        }
        public line(int i, int o, string t, int ssi)
        {
            Id = i;
            Order = o;
            Text = t;
            subSectionId = ssi;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
