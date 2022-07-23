using Microsoft.Win32;
using planning.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using planning.Properties;

namespace planning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            categoriesTextBox.Text = Settings.Default.categoriesFile;
            onetimeFixedEventsTB.Text = Settings.Default.OneFixed;
            recurrentFixedEventsTB.Text = Settings.Default.RecFixed;
                oneTimeFreeEventsTB.Text=Settings.Default.OneFree;
            RecurrentFreeEventsTB.Text = Settings.Default.RecFree;
            outputTB.Text = Settings.Default.outputpdf;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            #region read categories
            //read categories and priorities
            List<EventCategory> myCategories = new List<EventCategory>();
            /*string filePath2;
            string fileContent;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "categories";
            if (openFileDialog.ShowDialog() == true)
            {
                //Get the path of specified file
                filePath2 = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream2 = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream2))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            else
            {
                throw (new Exception("cant work without categories"));
            }*/

            string[] textLines = System.IO.File.ReadAllLines(Settings.Default.categoriesFile);
            int id = 0;
            foreach (string item in textLines)
            {
                string categname = item.Split(' ')[0];
                int categprio = int.Parse(item.Split(' ')[1]);
                myCategories.Add(new EventCategory() { Id = id, Name = categname, Priority = categprio });
                id++;
            }
            #endregion

            List<Event> myPlanning = new List<Event>();
            traitement trt = new traitement();

            //add fixed 1 events for next 7 days
            trt.addFixedOneEvents(myPlanning,7, myCategories);
            myPlanning.Sort();
            //add fixed recurrent events for next 7 days
            trt.addFixedRecurrentEvents(myPlanning, 7,myCategories);
            myPlanning.Sort();
            //add free 1 events for next 7 day

            trt.addFreeOneEvents(myPlanning, 7, myCategories);

            //add free recurrent events for next 7 day
            trt.addFreeRecurrentEvents(myPlanning, 7, myCategories);

            //read calculate min time and max time and sprint duration

            //generate planning

            //print planning
            trt.printplan(myPlanning);
            }
    }
}
