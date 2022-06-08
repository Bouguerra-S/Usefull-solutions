using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resumeadaptorWPF.Models
{
    public class cv:INotifyPropertyChanged
    {
        #region INotifyPropertyChanged_implementation
        public event PropertyChangedEventHandler PropertyChanged;


        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        private ObservableCollection<section> sections;
        /*public List<subSection> subsections;
        public List<line> lines;*/

        
        public ObservableCollection<section> Sections
        {
            get { return sections; }
            set { sections = value; OnPropertyChanged("Sections"); }
        }


        public cv()
        {
            sections = new ObservableCollection<section>();
        }

    }
}
