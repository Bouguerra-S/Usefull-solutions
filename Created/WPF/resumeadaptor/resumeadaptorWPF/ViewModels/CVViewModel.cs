using resumeadaptorWPF.Commands;
using resumeadaptorWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resumeadaptorWPF.ViewModels
{
    public class CVViewModel
    {
        //VM M relationship
        public cv myCV=new cv();

        //VM Command relationship
        public CVViewModel()
        {

            addSectionCommand = new RelayCommand(AddSection);
            NewSection = new section();

        }
        private section  newSection;

        public section NewSection
        {
            get { return newSection; }
            set { newSection = value; }
        }

        #region saveoperation
        private RelayCommand addSectionCommand;

        public RelayCommand AddSectionCommand

        {
            get { return addSectionCommand; }
        }
        public void AddSection()
        {
            //NewSection.Text=
            NewSection.Id = App.myCv.Sections.Count();
            App.myCv.Sections.Add(NewSection) ;
            
        }
        #endregion

    }
}
