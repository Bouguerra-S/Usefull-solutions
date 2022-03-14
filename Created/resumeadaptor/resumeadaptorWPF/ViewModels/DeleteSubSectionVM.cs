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
    public class DeleteSubSectionVM : INotifyPropertyChanged
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

        public DeleteSubSectionVM(section sectionvar, subSection subsectionvar)
        {
            selectedsection = new section();
            selectedsubsection = new subSection();
            selectedsection = sectionvar;
            selectedsubsection = subsectionvar;

            deleteCommand = new RelayCommand(DeleteSubSection);

        }
        private RelayCommand deleteCommand;

        public RelayCommand DeleteCommand
        {
            get { return deleteCommand; }
        }
        private subSection subsectiontodelete;

        public subSection Subsectiontodelete
        {
            get { return subsectiontodelete; }
            set { subsectiontodelete = value;OnPropertyChanged("Subsectiontodelete"); }
        }
        
        public void DeleteSubSection()
        {
            int secindex = App.myCv.Sections.IndexOf(selectedsection);

            int subsecindex = App.myCv.Sections[secindex].SubSections.IndexOf(selectedsubsection);

            //App.myCv.Sections[secindex].SubSections[subsecindex].Lines.Add(NewLine);
            //App.myCv.Sections[secindex].SubSections[subsecindex].Lines.Insert();

            section replacementsection = new section();
            replacementsection = App.myCv.Sections[secindex];
            replacementsection.SubSections.RemoveAt(subsecindex);

            App.myCv.Sections.RemoveAt(secindex);
            App.myCv.Sections.Insert(secindex, replacementsection);
        }






    }
}
