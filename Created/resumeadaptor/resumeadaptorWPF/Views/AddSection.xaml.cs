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
using resumeadaptorWPF;
using resumeadaptorWPF.ViewModels;

namespace resumeadaptorWPF.Views
{
    /// <summary>
    /// Logique d'interaction pour AddSection.xaml
    /// </summary>
    public partial class AddSectionView : Window
    {

        CVViewModel myCVViewModel;
        public AddSectionView()
        {
            InitializeComponent();
            //DataContext = CVViewModel;
            myCVViewModel = new CVViewModel();
            this.DataContext = myCVViewModel;

        }
private void InsertSectionButton_Click(object sender, RoutedEventArgs e)
        {

            this.Close();
        }
    }
}
