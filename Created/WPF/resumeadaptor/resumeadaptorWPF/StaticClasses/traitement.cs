using resumeadaptorWPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Shapes;
using resumeadaptorWPF.Classes;
using Microsoft.Win32;
using System.IO;

namespace resumeadaptorWPF.StaticClasses
{
    public class traitement
    {
        private cv cvtoprint;
        private List<string> myJobWords;
        public traitement()
        {

        }

        internal List<string> uniquejobwords(List<string> jobwords)
        {
            List<string> result = new List<string>();
            result.Add(jobwords[0]);
            foreach (string word in jobwords)
            {
                if (!string.Equals(result.Last(), word)) { result.Add(word); }
            }
            return result;
        }

        public List<section> usefullSections(List<string> jobwords, cv myCv)
        {
            List<section> result = new List<section>();

            List<section> tempo = new List<section>();
            foreach (section section in myCv.Sections)
            {
                tempo.Add(new section(section.Id, section.Id, section.Text));
            };

            foreach (section section in tempo)
            {
                foreach (string word in jobwords)
                {
                    if (section.Text.Contains(word))
                    {
                        result.Add(section);
                        break;
                    }
                }
                
            }
            return result;
        }

        public List<subSection> usefullSubsections(List<string> jobwords, cv myCv)
        {
            List<subSection> result = new List<subSection>();

            List<subSection> tempo = new List<subSection>();
            foreach (section section in myCv.Sections)
            {
                foreach (subSection subs in section.SubSections)
                {

                    tempo.Add(new subSection(subs.Id,subs.Order,subs.Text,subs.SectionId));
                }
            };

            foreach (subSection subsection in tempo)
            {
                foreach (string word in jobwords)
                {
                    if (subsection.Text.Contains(word)&&!result.Any(x=> x.Id==subsection.Id))
                    {
                        result.Add(subsection);
                        break;
                    }
                }

            }
            return result;
        }

        public List<line> usefullLines(List<string> jobwords, cv myCv)
        {
            List<line> result = new List<line>();

            List<line> tempo = new List<line>();
            foreach (section section in myCv.Sections)
            {
                foreach (subSection subs in section.SubSections)
                {
                    foreach (line line in subs.Lines)
                    {
                        tempo.Add(new line(line.Id, line.Order, line.Text, line.SubSectionId));
                    }
                }
            };

            foreach (line line in tempo)
            {
                foreach (string word in jobwords)
                {
                    if (line.Text.Contains(word))
                    {
                        result.Add(line);
                        break;
                    }
                }

            }
            return result;
        }

        public cv buildcv(List<section> usefullSections, List<subSection> usefulleSubsections, List<line> usefullLines, cv myCv)
        {
            cv result = new cv();

            //ajout des subsections from lines
            foreach (section cvsection in myCv.Sections)
            {
                foreach (subSection cvsubsection in cvsection.SubSections)
                {
                    foreach (line line in usefullLines)
                    {
                        if (!usefulleSubsections.Any(x=>x.Id==line.SubSectionId)&&line.SubSectionId==cvsubsection.Id )
                        {
                            usefulleSubsections.Add(cvsubsection);
                        }
                    }
                }
            }
            //ajout des sections from subsections
            foreach (section cvsection in myCv.Sections)
            {
                foreach (subSection cvsubSection in usefulleSubsections)
                {
                    if (!usefullSections.Any(x=>x.Id==cvsubSection.SectionId)&&cvsection.Id==cvsubSection.SectionId)
                    {
                        usefullSections.Add(cvsection);
                    }
                }
            }

            foreach (section section in usefullSections)
            {
                result.Sections.Add(section);
            }
            
            /*foreach (subSection uss in usefulleSubsections)
            {
                foreach (section rs in result.Sections)
                {
                    if (uss.SectionId==rs.Id&&!result.Sections.Any(x=>x.Id==)
                    {
                        rs.SubSections.Add(uss);
                    }
                }
            }*/

            foreach (line usefullLine in usefullLines)
            {
                foreach (section section in result.Sections)
                {
                    foreach (subSection subSection in section.SubSections)
                    {
                        if (usefullLine.SubSectionId==subSection.Id)
                        {
                            subSection.Lines.Add(usefullLine);
                        }
                    }
                }
            }
            //there are lines and subsections not added


            //there are empty sections and empty subsections
            result.Sections.OrderBy(x=> x.Id).ToList();
            cv orderedResult = new cv();
            orderedResult.Sections=orderCvSection(result.Sections);

            return orderedResult;
        }

        private ObservableCollection<section> orderCvSection(ObservableCollection<section> sections)
        {
            ObservableCollection<section>  result = new ObservableCollection<section>();
            bool continuesort=true;
            while (continuesort)
            {
                continuesort = false;
                for (int i = 0; i < sections.Count - 1; i++)
                {
                    if (sections[i].Id > sections[i + 1].Id)
                    {
                        section tempo = sections[i];
                        sections[i] = sections[i + 1];
                        sections[i + 1] = tempo;
                        continuesort = true;
                    }
                }
            }
            
            return sections;
        }

        internal void printcv(cv pcvtoprint,List<String> pJobWords)
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string file = "cv adapte auto.pdf";
            myJobWords = pJobWords;

            PrintDocument pDoc = new PrintDocument()
            {
                PrinterSettings = new PrinterSettings()
                {
                    PrinterName = "Microsoft Print to PDF",
                    PrintToFile = true,
                    PrintFileName = System.IO.Path.Combine(directory, file),
                }
            };
            cvtoprint = pcvtoprint;
            pDoc.PrintPage += new PrintPageEventHandler(Print_Page);
            pDoc.Print();
            ProcessStartInfo startInfo = new ProcessStartInfo(System.IO.Path.Combine(directory, file));
            startInfo.UseShellExecute = true;
            Process.Start(startInfo);
        }

        void Print_Page(object sender, PrintPageEventArgs e)
        {
            string filePath;
            string fileContent;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "FORBIDDEN WORDS";
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
                throw (new Exception("cant work without forbidden words. even empty"));
            }

            string[] forbiddenWordsArray = System.IO.File.ReadAllLines(filePath);
            List<string> forbiddenWords = forbiddenWordsArray.ToList();



            // Here you can play with the font style 
            // (and much much more, this is just an ultra-basic example)
            Font fnt = new Font("Courier New", 12);
            Font fntU = new Font("Courier New", 12, FontStyle.Underline);
            Font fntSection = new Font("Courier New", 12, FontStyle.Bold);
            Font fntSectionU = new Font("Courier New", 12, FontStyle.Bold | FontStyle.Underline);
            Font fntsub = new Font("Courier New", 12, FontStyle.Bold);
            Font fntsubU = new Font("Courier New", 12, FontStyle.Bold | FontStyle.Underline);
            // Insert the desired text into the PDF file
            string textToPrint = "";
            float lasty = 0;
            float lastx = 0;
            //donc l'alog doit être 
            //in section text identify jobwords
            //decouper en liste (string, jobValue, deltax)
            //for each string, font= font switch value, draw with font, increment x
            foreach (section section in cvtoprint.Sections)
            {
                List<underlineText> underlineTexts=  underlinedText(section.Text, myJobWords,forbiddenWords);
                lastx = 0;
                foreach (underlineText UText in underlineTexts)
                {
                    e.Graphics.DrawString(UText.Text+" ", UText.jobValue?fntSectionU:fntSection, System.Drawing.Brushes.Red, lastx, lasty);
                    lastx = lastx + UText.deltaX;
                }
                lasty = lasty + 20;
                foreach (subSection sub in section.SubSections)
                {
                    underlineTexts = underlinedText(sub.Text, myJobWords, forbiddenWords);
                    lastx = 0;
                    foreach (underlineText UText in underlineTexts)
                    {
                        e.Graphics.DrawString(UText.Text + " ", UText.jobValue ? fntsubU : fntsub, System.Drawing.Brushes.Black, lastx, lasty);
                        lastx = lastx + UText.deltaX;
                    }
                    lasty = lasty + 20;
                    
                    foreach (line line in sub.Lines)
                    {
                        underlineTexts = underlinedText(line.Text, myJobWords,forbiddenWords);
                        lastx = 0;
                        foreach (underlineText UText in underlineTexts)
                        {
                            e.Graphics.DrawString(UText.Text + " ", UText.jobValue ? fntU : fnt, System.Drawing.Brushes.Black, lastx, lasty);
                            lastx = lastx + UText.deltaX;
                        }
                        lasty = lasty + 20;
                    }
                }
            }
            
        }

        private List<underlineText> underlinedText(string text, List<string> myJobWords, List<string> forbiddenWords)
        {
            List<underlineText> result = new List<underlineText>();
            List<string> words = text.Split(new char[] { ' ' }).ToList();
            
            

            foreach (string word in words)
            {
                underlineText resultText = new underlineText();
                resultText.Text = word;
                resultText.jobValue=myJobWords.Contains(word.ToLower())&&!forbiddenWords.Contains(word.ToLower());
                resultText.deltaX = word.Length * 12;
                result.Add(resultText);
            }
            return result;
        }
    }
}
