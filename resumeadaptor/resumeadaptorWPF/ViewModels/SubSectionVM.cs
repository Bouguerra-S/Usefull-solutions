using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resumeadaptorWPF.Commands;
using resumeadaptorWPF.Models;

namespace resumeadaptorWPF.ViewModels
{
    public class SubSectionVM : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged_implementation
        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public int sectionIndextoAdd;
        public SubSectionVM()
        {
            NewSubSection = new subSection();
            addSubSectionCommand = new RelayCommand(AddSubSection);
        }
        private subSection newSubSection;

        public subSection NewSubSection
        {
            get { return newSubSection; }
            set { newSubSection = value; OnPropertyChanged("NewSubSection"); }
        }
        #region saveoperation
        private RelayCommand addSubSectionCommand;

        public RelayCommand AddSubSectionCommand

        {
            get { return addSubSectionCommand; }
        }
        public void AddSubSection()
        {
            NewSubSection.SectionId = sectionIndextoAdd-1;
            section replacementsection = new section();
            replacementsection = App.myCv.Sections[sectionIndextoAdd];
            replacementsection.SubSections.Add(NewSubSection);
            
            App.myCv.Sections.RemoveAt(sectionIndextoAdd);
            App.myCv.Sections.Insert(sectionIndextoAdd, replacementsection);
        }
        #endregion

    }
}
