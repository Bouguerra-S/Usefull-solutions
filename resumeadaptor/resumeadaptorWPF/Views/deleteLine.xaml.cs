using resumeadaptorWPF.Models;
using resumeadaptorWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace resumeadaptorWPF.Views
{
    /// <summary>
    /// Logique d'interaction pour deleteLine.xaml
    /// </summary>
    public partial class deleteLine : Window
    {
        public section mysection;
        public subSection mysubsection;
        public line myline;

        public deleteLineVM myVM;
        public deleteLine( section sectionvar)
        {
            InitializeComponent();
            subsectionCombo.ItemsSource = sectionvar.SubSections;
            mysection = sectionvar;
            myVM = new deleteLineVM(mysection, mysubsection, myline);
            DataContext = myVM;
        }

        private void subsectionCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mysubsection = (subSection)subsectionCombo.SelectedItem;
            lineCombo.ItemsSource = mysubsection.Lines;
            myVM.selectedsubsection = mysubsection;
        }

        private void lineCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            myline = (line)lineCombo.SelectedItem;
            myVM.selecteline = myline;
        }

        private void deletelinebutton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
