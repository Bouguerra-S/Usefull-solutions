using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resumeadaptorWPF.Models
{
    public class subSection:INotifyPropertyChanged
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

        private int sectionId;

        public int SectionId
        {
            get { return sectionId; }
            set { sectionId = value; OnPropertyChanged("SectionId"); }
        }


        public subSection()
        {
            Lines = new ObservableCollection<line>();
        }
        public subSection(int i, int o, string t, int si)
        {
            Id = i;
            Order = o;
            Text = t;
            SectionId = si;
            Lines = new ObservableCollection<line>();
        }

        private ObservableCollection<line> lines;

        public ObservableCollection<line> Lines
        {
            get { return lines; }
            set { lines = value; OnPropertyChanged("Lines"); }
        }
        public override string ToString()
        {
            return Text;
        }

    }
}
