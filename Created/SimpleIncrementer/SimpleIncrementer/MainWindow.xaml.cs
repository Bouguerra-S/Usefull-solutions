using MahApps.Metro.Controls;
using System.Windows;

namespace SimpleIncrementer
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
        
    {
        public int myVariable;
        public MainWindow()
        {
            myVariable = 0;
            InitializeComponent();
            myButton.Content = myVariable.ToString();

        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myVariable += 1;
            myButton.Content = myVariable.ToString();
        }

        private void RAZ_Click(object sender, RoutedEventArgs e)
        {
            myVariable = 0;

            myButton.Content = myVariable.ToString();
        }
    }
}
