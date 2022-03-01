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
    /// Logique d'interaction pour AddSubSection.xaml
    /// </summary>
    public partial class AddSubSection : Window
    {
        public int sectionIndex;
        public SubSectionVM mySubSectionVM;
        public AddSubSection(int myIndex)
        {
            InitializeComponent();
            mySubSectionVM = new SubSectionVM();

            mySubSectionVM.sectionIndextoAdd = myIndex;//sectionIndex;
            this.DataContext = mySubSectionVM;
        }

        private void InsertSubSectionButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
