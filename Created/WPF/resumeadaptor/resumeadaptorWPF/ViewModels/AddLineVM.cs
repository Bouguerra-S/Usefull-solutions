using resumeadaptorWPF.Commands;
using resumeadaptorWPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resumeadaptorWPF.ViewModels
{
    public class AddLineVM : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged_implementation
        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        private line newLine;

        public line NewLine
        {
            get { return newLine; }
            set { newLine = value; OnPropertyChanged("NewLine"); }
        }

        public section selectedsection;
        public subSection selectedsubsection;
        public AddLineVM( section sectionvar, subSection subsectionvar)
        {
            selectedsection = new section();
            selectedsubsection = new subSection();
            selectedsection = sectionvar;
            selectedsubsection = subsectionvar;
            addLineCommand = new RelayCommand(AddLineSubsection);
            NewLine = new line();

        }
        private RelayCommand addLineCommand;

        public RelayCommand AddLineCommand
        {
            get { return addLineCommand; }
        }
        public void AddLineSubsection()
        {
            int secindex = App.myCv.Sections.IndexOf(selectedsection);

            int subsecindex = App.myCv.Sections[secindex].SubSections.IndexOf(selectedsubsection);

            //App.myCv.Sections[secindex].SubSections[subsecindex].Lines.Add(NewLine);
            //App.myCv.Sections[secindex].SubSections[subsecindex].Lines.Insert();

            section replacementsection = new section();
            replacementsection = App.myCv.Sections[secindex];
            replacementsection.SubSections[subsecindex].Lines.Add(NewLine);

            App.myCv.Sections.RemoveAt(secindex);
            App.myCv.Sections.Insert(secindex, replacementsection);
        }

    }
}
