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
    /// Logique d'interaction pour deleteSubSectionView.xaml
    /// </summary>
    public partial class deleteSubSectionView : Window
    {
        public section selectedsection;
        public DeleteSubSectionVM myVM;
        public deleteSubSectionView(section sectionvar)
        {
            
            InitializeComponent();
            selectedsection = new section();
            selectedsection = sectionvar;
            SubSectionCombo.ItemsSource = selectedsection.SubSections;
            myVM = new DeleteSubSectionVM(selectedsection, (subSection)SubSectionCombo.SelectedItem);
            DataContext = myVM;
        }

        private void DeleteSubSectionButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SubSectionCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            myVM.selectedsubsection = (subSection)SubSectionCombo.SelectedItem;
        }
    }
}
