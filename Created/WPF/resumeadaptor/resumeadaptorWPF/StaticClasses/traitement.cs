using resumeadaptorWPF.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Shapes;

namespace resumeadaptorWPF.StaticClasses
{
    public class traitement
    {
        private cv cvtoprint;
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
                    if (subsection.Text.Contains(word))
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
            
            foreach (subSection subSection in usefulleSubsections)
            {
                foreach (section section in result.Sections)
                {
                    if (subSection.SectionId==section.Id)
                    {
                        section.SubSections.Add(subSection);
                    }
                }
            }

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
            List<section> orderedResult = new List<section>();
            orderedResult=result.Sections.OrderBy(x=>x.Id).ToList();

            return result;
        }

        internal void printcv(cv pcvtoprint)
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string file = "cv adapte auto.pdf";

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
            // Here you can play with the font style 
            // (and much much more, this is just an ultra-basic example)
            Font fnt = new Font("Courier New", 12);
            Font fntSection = new Font("Courier New", 12, FontStyle.Bold);
            Font fntsub = new Font("Courier New", 12, FontStyle.Bold);
            // Insert the desired text into the PDF file
            string textToPrint = "";
            float lasty = 0;
            foreach (section section in cvtoprint.Sections)
            {
                e.Graphics.DrawString (section.Text, fntSection, System.Drawing.Brushes.Red, 0, lasty);
                lasty = lasty + 20;
                foreach (subSection sub in section.SubSections)
                {
                    e.Graphics.DrawString (sub.Text, fntsub, System.Drawing.Brushes.Black, 0, lasty);
                    lasty = lasty + 20;
                    foreach (line line in sub.Lines)
                    {
                        e.Graphics.DrawString (line.Text, fnt, System.Drawing.Brushes.Black, 0, lasty);
                        lasty = lasty + 20;
                    }
                }
            }
            
        }
    }
}
