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
    /// Logique d'interaction pour AddLine.xaml
    /// </summary>
    public partial class AddLine : Window
    {
        public section selectedSection;
        public AddLineVM myVM;
        public AddLine(section sectionpar)
        {
            InitializeComponent();
            selectedSection = sectionpar;
            subsectionscombo.ItemsSource = selectedSection.SubSections;
            myVM = new AddLineVM(sectionpar, (subSection)subsectionscombo.SelectedItem);
            this.DataContext = myVM;
        }

        private void subsectionscombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            myVM.selectedsubsection= (subSection)subsectionscombo.SelectedItem;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
