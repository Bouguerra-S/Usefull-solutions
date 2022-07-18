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
        #region properties and attributes
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
        private ObservableCollection<line> lines;

        public ObservableCollection<line> Lines
        {
            get { return lines; }
            set { lines = value; OnPropertyChanged("Lines"); }
        }
        #endregion
        #region constructos
        public subSection()
        {
            Lines = new ObservableCollection<line>();
        }/// <summary>
        ///  creates a subsection with full data
        /// </summary>
        /// <param name="i">Id</param>
        /// <param name="o">Order</param>
        /// <param name="t">Text</param>
        /// <param name="si">section Id</param>
        public subSection(int i, int o, string t, int si)
        {
            Id = i;
            Order = o;
            Text = t;
            SectionId = si;
            Lines = new ObservableCollection<line>();
        }
        #endregion
        #region overrides
        public override string ToString()
        {
            return Text;
        }
        #endregion

    }
}
