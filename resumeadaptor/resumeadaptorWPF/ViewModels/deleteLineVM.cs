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
    public class deleteLineVM : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged_implementation
        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public section selectedsection;
        public subSection selectedsubsection;
        public line selecteline;
        public deleteLineVM(section sectionvar,subSection subSectionvar,line linevar)
        {
            selectedsection = sectionvar;
            selectedsubsection = subSectionvar;
            selecteline = linevar;
            deleteCommand = new RelayCommand(DeleteLine);
        }
        private RelayCommand deleteCommand;

        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
        }

        public void DeleteLine()
        {
            int secindex = App.myCv.Sections.IndexOf(selectedsection);

            int subsecindex = App.myCv.Sections[secindex].SubSections.IndexOf(selectedsubsection);

            int lineindex = App.myCv.Sections[secindex].SubSections[subsecindex].Lines.IndexOf(selecteline);

            section replacementsection = new section();
            replacementsection = App.myCv.Sections[secindex];
            replacementsection.SubSections[subsecindex].Lines.RemoveAt(lineindex);

            App.myCv.Sections.RemoveAt(secindex);
            App.myCv.Sections.Insert(secindex, replacementsection);
        }
    }
}
