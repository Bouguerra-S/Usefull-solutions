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
using resumeadaptorWPF.Structs;

namespace resumeadaptorWPF.StaticClasses
{
    public class traitement
    {
        private cv cvtoprint;
        private List<string> myJobWords;
        private List<string> forbiddenWords;
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
                    List<String> sectionWords = section.Text.ToLower().Split(' ').ToList();
                    if (sectionWords.Any(x => x == word))
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
                    List<String> subWords = subsection.Text.ToLower().Split(' ').ToList();
                    if (subWords.Any(x => x == word) && !result.Any(x => x.Id == subsection.Id))
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
                    List<String> lineWords = line.Text.ToLower().Split(' ').ToList();
                    if (lineWords.Any(x=> x==word))
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

            foreach (line line in usefullLines)
            {
                //usefullsubsections might have empty subsections or not
                //i might assume that empty subsections
                if (!isThisLineInTheseSubsections(line, usefulleSubsections))
                {
                    subSection mysub = linesSubsectionWithoutLines(line, myCv);
                    usefulleSubsections.Add(mysub);
                }
            }
            foreach (subSection subsection in usefulleSubsections)
            {
                if (!isThisSubInTheseSections(subsection, usefullSections))
                {
                    section section = subsSectionWithoutSubs(subsection, myCv);
                    usefullSections.Add(section);
                }
            }

            if (usefullSections.Count == 0)
            {
                throw new Exception("no usefull sections");
            }
            //here i have the full list of usefull lines, subsections and sections
            // build the cv
            //for each subsection add the lines
            foreach (subSection sub in usefulleSubsections)
            {
                foreach (line line in usefullLines)
                {
                    if (line.SubSectionId==sub.Id)
                    {
                        sub.Lines.Add(line);
                    }
                }
            }

            //foreach section add the subsections
            foreach (section section1 in usefullSections)
            {
                foreach (subSection subitem in usefulleSubsections)
                {
                    if (subitem.SectionId==section1.Id&&subitem.Lines.Count()>0)
                    {
                        section1.SubSections.Add(subitem);
                    }
                }
                if (section1.SubSections.Count()>0)
                {
                    result.Sections.Add(section1);
                }
            }

            // add section to result.sections



            cv orderedResult = new cv();
            orderedResult.Sections=orderCvSection(result.Sections);

            return orderedResult;
        }

        private section subsSectionWithoutSubs(subSection subsection, cv myCv)
        {
            section result = new section();
            foreach (section section in myCv.Sections)
            {
                if (section.Id==subsection.SectionId)
                {
                    result.Id = section.Id;
                    result.Text = section.Text;
                    result.Order = section.Order;
                    break;
                }
            }

            return result;
        }

        private bool isThisSubInTheseSections(subSection subsection, List<section> usefullSections)
        {
            bool found =false;

            foreach (section section in usefullSections)
            {
                if (subsection.SectionId==section.Id)
                {
                    found = true;
                    break;
                }
            }
            return found;
        }

        private subSection linesSubsectionWithoutLines(line line, cv myCv)
        {
            subSection subsection = new subSection();
            foreach (section sec in myCv.Sections)
            {
                foreach (subSection sub in sec.SubSections)
                {
                    if (line.SubSectionId==sub.Id)
                    {
                        subsection.Id=sub.Id;
                        subsection.Text=sub.Text;
                        subsection.Order=sub.Order;
                        subsection.SectionId=sub.SectionId;
                        break;
                    }
                }
            }
            return subsection;
        }

        private bool isThisLineInTheseSubsections(line line, List<subSection> usefulleSubsections)
        {
            bool found = false;

            foreach (subSection subs in usefulleSubsections)
            {
                if (line.SubSectionId==subs.Id)
                {
                    found = true;
                }
            }
            return found;
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

        internal void printcv(cv pcvtoprint,List<String> pJobWords, List<String> pforbiddenWords)
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string file = "cv adapte auto.pdf";
            string personalChemin;//here
            SaveFileDialog openFileDialog2 = new SaveFileDialog();
            openFileDialog2.Title = "save short cv";
            if (openFileDialog2.ShowDialog() == true)
            {
                //Get the path of specified file
                personalChemin = openFileDialog2.FileName;
            }
            else
            {
                throw (new Exception("cant work without short cv location"));
            }


            myJobWords = pJobWords;
            forbiddenWords = pforbiddenWords;
            PrintDocument pDoc = new PrintDocument()
            {
                PrinterSettings = new PrinterSettings()
                {
                    PrinterName = "Microsoft Print to PDF",
                    PrintToFile = true,
                    PrintFileName = personalChemin,
                }
            };
            cvtoprint = pcvtoprint;
            pDoc.PrintPage += new PrintPageEventHandler(Print_Page);
            pDoc.Print();
            ProcessStartInfo startInfo = new ProcessStartInfo(personalChemin);
            startInfo.UseShellExecute = true;
            Process.Start(startInfo);
        }

        void Print_Page(object sender, PrintPageEventArgs e)
        {
           
            // Here you can play with the font style 
            // (and much much more, this is just an ultra-basic example)
            Font fnt = new Font("Courier New", 9);
            Font fntU = new Font("Courier New", 9, FontStyle.Underline);
            Font fntSection = new Font("Courier New", 11, FontStyle.Bold);
            Font fntSectionU = new Font("Courier New", 11, FontStyle.Bold | FontStyle.Underline);
            Font fntsub = new Font("Courier New", 11, FontStyle.Bold);
            Font fntsubU = new Font("Courier New", 11, FontStyle.Bold | FontStyle.Underline);
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
                int sectionColumn = calculateSectionColumn(section, 300);
                List<underlineText> underlineTexts=  underlinedText(section.Text, myJobWords,forbiddenWords);
                lastx = 300* sectionColumn;
                foreach (underlineText UText in underlineTexts)
                {
                    e.Graphics.DrawString(UText.Text+" ", UText.jobValue?fntSectionU:fntSection, System.Drawing.Brushes.Red, lastx, lasty);
                    lastx = lastx + UText.deltaX* 0.9f;
                }
                lasty = lasty + 30;
                foreach (subSection sub in section.SubSections)
                {
                    underlineTexts = underlinedText(sub.Text, myJobWords, forbiddenWords);
                    lastx = 300 * sectionColumn; ;
                    foreach (underlineText UText in underlineTexts)
                    {
                        e.Graphics.DrawString(UText.Text + " ", UText.jobValue ? fntsubU : fntsub, System.Drawing.Brushes.Black, lastx, lasty);
                        lastx = lastx + UText.deltaX* 0.85f;
                    }
                    lasty = lasty + 25;
                    
                    foreach (line line in sub.Lines)
                    {
                        underlineTexts = underlinedText(line.Text, myJobWords,forbiddenWords);
                        lastx = 300 * sectionColumn; ;
                        foreach (underlineText UText in underlineTexts)
                        {
                            e.Graphics.DrawString(UText.Text + " ", UText.jobValue ? fntU : fnt, System.Drawing.Brushes.Black, lastx, lasty);
                            lastx = lastx + UText.deltaX*0.7f;
                        }
                        lasty = lasty + 20;
                    }
                }
            }
            
        }

        private int calculateSectionColumn(section section, int column1WidthMm)//300
        {
            int result = 0;
            if (section.Text.Length*9>=column1WidthMm)
            {
                result = 1;
                return result;
            }
            foreach (subSection sub in section.SubSections)
            {
                if (sub.Text.Length*7>=column1WidthMm)
                {
                    result = 1;
                    return result;
                }
                foreach (line line in sub.Lines)
                {
                    if (line.Text.Length*7>=column1WidthMm)
                    {
                        result=1;
                        return 1;
                    }
                }
            }

            return result;
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

        internal void createReport(cv shortcv, List<string> jobwords, List<string> forbiddenWords, List<string> uniqueJobWords)
        {
            List<reportItem> reportItems = new List<reportItem>();
            foreach (string joboword in uniqueJobWords)
            {
                int countWordOffer = jobwords.Count(x=>x==joboword.ToLower());
                int countWordCV = 0;
                foreach (section sec in shortcv.Sections)
                {
                    countWordCV += sec.Text.ToLower().Split(' ').Count(x=> x==joboword.ToLower());
                    foreach (subSection sub in sec.SubSections)
                    {
                        countWordCV += sub.Text.ToLower().Split(' ').Count(x => x == joboword.ToLower());
                        foreach (line line in sub.Lines)
                        {
                            countWordCV += line.Text.ToLower().Split(' ').Count(x => x == joboword.ToLower());
                        }
                    }
                }
                //count

                reportItems.Add(new reportItem(joboword.ToLower(), countWordOffer,countWordCV));
            }

            savereport(reportItems);
        }

        private void savereport(List<reportItem> reportItems)
        {
            //here
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string file = "short cv report.csv";
            string mystring="word;offerCount;CVcount;\n";
            foreach (reportItem item in reportItems)
            {
                mystring = mystring + item.word + ";" + item.offerCount + ";" + item.CVcount + ";\n";
            }
            File.WriteAllTextAsync(System.IO.Path.Combine(directory, file), mystring);
            
            ProcessStartInfo startInfo = new ProcessStartInfo(System.IO.Path.Combine(directory, file));
            startInfo.UseShellExecute = true;
            Process.Start(startInfo);
        }
    }
}
