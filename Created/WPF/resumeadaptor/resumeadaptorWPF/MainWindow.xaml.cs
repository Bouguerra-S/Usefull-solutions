using MahApps.Metro.Controls;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using resumeadaptorWPF.Models;
using resumeadaptorWPF.Views;
using System.Diagnostics;
using System.Text.RegularExpressions;
using resumeadaptorWPF.StaticClasses;
using Microsoft.Win32;
using System.IO;

namespace resumeadaptorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        public MainWindow()
        {

            InitializeComponent();
            lvDataBinding.ItemsSource = App.myCv.Sections;
            choiceCombo.ItemsSource = new List<string> { "section", "subsection", "line" };
            //this.DataContext = ;
        }
        //public void AddSection()
        //{
        //    // myCv.Sections.Add(new section() { Id = 3, Text = "AddSectionCommand" });


        //}

        private void insertbutton_Click(object sender, RoutedEventArgs e)
        {
            if (choiceCombo.SelectedItem == "section")
            {
                AddSectionView myAddSection = new AddSectionView();
                myAddSection.Show();
            }
            else if (choiceCombo.SelectedItem == "subsection")
            {
                int dbgselected;
                dbgselected = ((section)lvDataBinding.SelectedItem).Id;
                AddSubSection myAddSubSection = new AddSubSection(((section)lvDataBinding.SelectedItem).Id);
                Trace.WriteLine(App.myCv);
                myAddSubSection.Show();
            }
            else if (choiceCombo.SelectedItem == "line")
            {
                section selectedSection = ((section)lvDataBinding.SelectedItem);
                AddLine myAddline = new AddLine(selectedSection);
                myAddline.Show();
            }

        }

        private void choiceCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //delete : string dbgstring = lvDataBinding.SelectedItem.ToString();
            //delete : bool containslines = Regex.Matches(lvDataBinding.SelectedItem.ToString(), "\n").Count>1;
            if (choiceCombo.SelectedItem is null)
            {
                return;
            }
            else if (choiceCombo.SelectedItem == "section" || choiceCombo.SelectedItem == "subsection" && lvDataBinding.SelectedItem is not null)
            {
                insertbutton.IsEnabled = true;
                deletebutton.IsEnabled = true;
                updatebutton.IsEnabled = true;
                reorderbutton.IsEnabled = true;
            }
            else if (choiceCombo.SelectedItem == "line" && lvDataBinding.SelectedItem is not null)
            {
                if (Regex.Matches(lvDataBinding.SelectedItem.ToString(), "\n").Count > 0)
                {
                    insertbutton.IsEnabled = true;
                    deletebutton.IsEnabled = true;
                    updatebutton.IsEnabled = true;
                    reorderbutton.IsEnabled = true;
                }
                else
                {
                    insertbutton.IsEnabled = false;
                    deletebutton.IsEnabled = false;
                    updatebutton.IsEnabled = false;
                    reorderbutton.IsEnabled = false;
                }
            }
            else
            {
                insertbutton.IsEnabled = false;
                deletebutton.IsEnabled = false;
                updatebutton.IsEnabled = false;
                reorderbutton.IsEnabled = false;
            }

        }

        private void deletebutton_Click(object sender, RoutedEventArgs e)
        {

            if (choiceCombo.SelectedItem is null)
            {
                return;
            }
            else if (choiceCombo.SelectedItem == "section")
            {
                int secindex = App.myCv.Sections.IndexOf((section)lvDataBinding.SelectedItem);
                App.myCv.Sections.RemoveAt(secindex);

            }
            else if (choiceCombo.SelectedItem == "subsection")
            {
                deleteSubSectionView myDelSSectionView = new deleteSubSectionView((section)lvDataBinding.SelectedItem);

                myDelSSectionView.Show();
            }
            else
            {
                deleteLine deleteLine = new deleteLine((section)lvDataBinding.SelectedItem);//complete view to select subsection, line
                deleteLine.Show();
            }

        }

        private void savebutton_Click(object sender, RoutedEventArgs e)
        {
            WriteClass myWC = new WriteClass();
            string cvtext = "";
            foreach (section secitem in App.myCv.Sections)
            {
                cvtext += "section " + secitem.Text + "\n";
                foreach (subSection subitem in secitem.SubSections)
                {
                    cvtext += "sub " + subitem.Text + "\n";
                    foreach (line linitem in subitem.Lines)
                    {
                        cvtext += "line " + linitem.Text + "\n";
                    }
                }
            }
            myWC.WriteString(cvtext);
        }

        private void loadbutton_Click(object sender, RoutedEventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == true)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            else
            {
                return;
            }

            string[] cvlines = System.IO.File.ReadAllLines(filePath);

            //re init app cv
            int sectionsnumber = App.myCv.Sections.Count();
            for (int i = 0; i < sectionsnumber; i++)
            {
                App.myCv.Sections.RemoveAt(0);
            }
            int currentsectionId = -1;
            int currentsubid = -1;
            int lineid = -1;
            section thissection = new section();
            subSection thissub = new subSection();
            line thisline = new line();
            foreach (string cvline in cvlines)
            {
                int positionofspace = cvline.IndexOf(" ");
                string typeofinput = cvline.Substring(0, positionofspace);
                string Text = cvline.Substring(positionofspace + 1);
                
                switch (typeofinput)
                {
                    case "section":
                        //update current section
                        currentsectionId = currentsectionId + 1;
                        //currentsubid += 1;
                        //lineid +=1;
                        thissection = new section(currentsectionId, 0, Text);
                        App.myCv.Sections.Add(thissection);
                        break;
                    case "sub":
                        currentsubid = currentsubid + 1;
                        //lineid = -1;
                        thissub = new subSection(currentsubid, 0, Text, currentsectionId);
                        thissection.SubSections.Add(thissub);
                        break;
                    case "line":
                        lineid = lineid + 1;
                        thisline = new line(lineid, 0, Text, currentsubid);
                        thissub.Lines.Add(thisline);
                        break;
                    default:
                        break;
                }
            }
        }

        private void reorderbutton_Click(object sender, RoutedEventArgs e)
        {
            if (choiceCombo.SelectedItem is null)
            {
                return;
            }
            else if (choiceCombo.SelectedItem == "section")
            {
                //int secindex = App.myCv.Sections.IndexOf((section)lvDataBinding.SelectedItem);
                //App.myCv.Sections.RemoveAt(secindex);

                //move section up or down or annuler
                reorderSection myreorderSection = new reorderSection((section)lvDataBinding.SelectedItem);
                myreorderSection.Show();
                return;
            }
            else if (choiceCombo.SelectedItem == "subsection")
            {
                //deleteSubSectionView myDelSSectionView = new deleteSubSectionView((section)lvDataBinding.SelectedItem);

                //myDelSSectionView.Show();

                //choose subsection up or down or annuler
                reorderSubsection mrss = new reorderSubsection();
                mrss.Show();
                return;
            }
            else
            {
                //deleteLine deleteLine = new deleteLine((section)lvDataBinding.SelectedItem);//complete view to select subsection, line
                //deleteLine.Show();

                //choose subsection, choose line up, or down or annuler
                reorderline mrl = new reorderline();
                mrl.Show();
                return;
            }

        }

        private void newjobbutton_Click(object sender, RoutedEventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            else
            {
                return;
            }

            string[] joblines = System.IO.File.ReadAllLines(filePath);
            List<string> jobwords = new List<string>();
            foreach (string jobline in joblines)
            {

                if (string.IsNullOrEmpty(jobline))
                {
                    continue;
                }
                else
                {
                    string[] wordsarray = jobline.Split(' ', '.', ',', ':', ';', '(', ')', '\'', '’', '/');
                    foreach (string word in wordsarray)
                    {
                        if (!string.IsNullOrEmpty(word) && word.Length > 2)
                        {
                            if (!jobwords.Contains(word))
                            {
                                jobwords.Add(word.ToLower());
                            }
                        }
                    }
                }
            }
            string v_dbg = "bdg";
            jobwords.Sort();
            traitement trt = new traitement();
            jobwords=trt.uniquejobwords(jobwords);

            List<section> usefullSections = trt.usefullSections(jobwords, App.myCv);
            List<subSection> usefulleSubsections = trt.usefullSubsections(jobwords, App.myCv);
            List<line> usefullLines = trt.usefullLines(jobwords, App.myCv);

            //imaginons i have all the usefulle lines, subs, section
            // i have to contract a cv
            cv shortcv = trt.buildcv(usefullSections, usefulleSubsections, usefullLines, App.myCv);

            //export to pdf

            trt.printcv(shortcv);
        }
    }
}
    

