using Microsoft.Win32;
using planning.Models;
using planning.Properties;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace planning.Pages
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            categoriesTextBox.Content = Settings.Default.categoriesFile;
            onetimeFixedEventsTB.Content = Settings.Default.OneFixed;
            recurrentFixedEventsTB.Content = Settings.Default.RecFixed;
            oneTimeFreeEventsTB.Content = Settings.Default.OneFree;
            RecurrentFreeEventsTB.Content = Settings.Default.RecFree;
            outputTB.Content = Settings.Default.outputpdf;
        }

        #region button clicks
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
            trt.addFixedOneEvents(myPlanning, 7, myCategories);
            myPlanning.Sort();
            //add fixed recurrent events for next 7 days
            trt.addFixedRecurrentEvents(myPlanning, 7, myCategories);
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

        /// <summary>
        /// change config file location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_Config_File(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openf = new OpenFileDialog();
            if (openf.ShowDialog() == true) Properties.Settings.Default.categoriesFile = openf.FileName;
            Settings.Default.Save();
            categoriesTextBox.Content = Settings.Default.categoriesFile;
        }
        #endregion
    }
}
