using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resumeadaptorWPF.Models
{
    public class section:INotifyPropertyChanged
    {
        #region INotifyPropertyChanged_implementation
        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region  attributes and properties
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
        private ObservableCollection<subSection> subSections;

        public ObservableCollection<subSection> SubSections
        {
            get { return subSections; }
            set { subSections = value; OnPropertyChanged("SubSections"); }
        }
        #endregion

        #region constructors
        public section()
        {
            SubSections = new ObservableCollection<subSection>();
        }
        public section(int i, int o, string t)
        {
            Id = i;
            Order = o;
            Text = t;
            SubSections = new ObservableCollection<subSection>();
        }
        #endregion

        #region overrides
        public override string ToString()
        {
            string result = "\n-------------------------------------------------\n";
            result += "Section " + Id.ToString() + " : ";
            result += Text;
            if (SubSections.Any())
            {
                foreach (subSection ssitem in SubSections)
                {
                    result += "\n-------------------------------------------------\n-" + ssitem.Text;
                    if (ssitem.Lines is not null)
                    {
                        foreach (line litem in ssitem.Lines)
                        {
                            result += "\n" + litem.Text;
                        }
                    }

                }
            }

            return result;
        }
        #endregion



    }
}
