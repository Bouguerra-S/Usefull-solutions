using Microsoft.Win32;
using planning.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planning.Models
{
    internal class traitement
    {
        private List<Event> optimizedSchedule;

        internal void addFixedOneEvents(List<Event> myPlanning, int sprintDays, List<EventCategory> myCategories)
        {
            /*string filePath2;
            string fileContent;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "FIXED ONE EVENTS";
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
                return;
            }*/

            string[] textLines = System.IO.File.ReadAllLines(Settings.Default.OneFixed);
            TimeSpan sprintduration = new TimeSpan(0, 60 * 24 * sprintDays, 0);
            DateTime sprintEnd=DateTime.Now+ sprintduration;
            foreach (string item in textLines)
            {
                Event myEvent = new Event();
                myEvent.Name = item.Split(';')[1];
                DateTime output;
                DateTime.TryParse(item.Split(';')[0], out output);
                myEvent.startTime = output;
                
                int durationMinutes;
                int.TryParse(item.Split(';')[2], out durationMinutes);
                TimeSpan duration = new TimeSpan(0, durationMinutes,0);
                myEvent.endTime = myEvent.startTime+ duration;
                myEvent.liberty = false;
                myEvent.recurrent = false;
                myEvent.Category = findCategory(myCategories, item.Split(';')[3]);
                if (myEvent.endTime<= sprintEnd&&myEvent.endTime>=DateTime.Now)
                {
                    myPlanning.Add(myEvent);

                }
                
            }
        }

        private EventCategory findCategory(List<EventCategory> myCategories, string v)
        {
            foreach (var item in myCategories)
            {
                if (v.ToLower().Contains(item.Name.ToLower()))
                {
                    return item;
                };
            }
            throw   new Exception("category not found");
            
        }

        internal void addFixedRecurrentEvents(List<Event> myPlanning, int sprintDays, List<EventCategory> myCategories)
        {
            /*string filePath2;
            string fileContent;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "FIXED RECURRENT EVENTS";
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
                return;
            }*/

            string[] textLines = System.IO.File.ReadAllLines(Settings.Default.RecFixed);
            foreach (string line in textLines)
            {
                /*premiereOccurence
                generate liste dans notre sprint
                add them to planning*/
                string seriesName = line.Split(';')[1];
                DateTime seriesStartTime;
                DateTime.TryParse(line.Split(';')[0], out seriesStartTime);
                int seriesDuration;
                int.TryParse(line.Split(';')[2], out seriesDuration);
                EventCategory seriesCategory = findCategory(myCategories, line.Split(';')[3]);
                string recurrence = line.Split(';')[4];
                AddEventsFromFixedSeries(myPlanning,myCategories,sprintDays, seriesName,seriesStartTime,seriesDuration,seriesCategory);


            }
        }

        private void AddEventsFromFixedSeries(List<Event> myPlanning, List<EventCategory> myCategories, int sprintDays, string seriesName, DateTime seriesStartTime, int seriesDuration, EventCategory seriesCategory)
        {
            DateTime firstEventStartTime=DateTime.Now;
            for (int i = 0; i < 1000; i++)
            {
                TimeSpan tmspn = new TimeSpan(i * 24, 0, 0);
                if (seriesStartTime+tmspn>=DateTime.Now)
                {
                    firstEventStartTime = seriesStartTime+tmspn;
                    break;
                }
            }
            DateTime lastStartTime = firstEventStartTime;
            TimeSpan activityDuration=new   TimeSpan(0,seriesDuration,0);

            for (int i = 1; i < 8; i++)
            {
                myPlanning.Add(new Event() 
                    { 
                        Category = seriesCategory, 
                        Name = seriesName, 
                        liberty = false, 
                        recurrent = true, 
                        startTime= lastStartTime,
                        endTime= lastStartTime+ activityDuration 
                    });

                TimeSpan tmspn = new TimeSpan(24, 0, 0);
                lastStartTime = lastStartTime + tmspn;
            }
        }

        internal void addFreeOneEvents(List<Event> myPlanning, int v, List<EventCategory> myCategories)
        {
            /*string filePath2;
            string fileContent;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "free onetime EVENTS";
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
                return;
            }*/

            string[] textLines = System.IO.File.ReadAllLines(Settings.Default.OneFree);
            List<Event> foundEvents = new List<Event>();
            foreach (var item in textLines)
            {
                var splt = item.Split(';');
                Event myEvent = new Event();
                myEvent.Name = splt[0];
                myEvent.Category=findCategory(myCategories, splt[1]);
                myEvent.recurrent = false;
                myEvent.liberty = true;
                foundEvents.Add(myEvent);
            }
            PrioriserParCategorie(foundEvents, myCategories);
            addEventsByPriority(foundEvents, myPlanning);
        }

        private void addEventsByPriority(List<Event> foundEvents, List<Event> myPlanning)
        {
            //je trouve une 30 minutes
            //je fais un event
            //foundevents are by priority
            //my planning is by start time
            //je recherche un intervalle de 45 minutes
            //je mets un event de 30 minutes
            TimeSpan fortyfive = new TimeSpan(0, 45, 0);
            TimeSpan thirty = new TimeSpan(0, 15, 0);
            bool firstEvent = true;
            foreach (var item in foundEvents)
            {
                /*if (firstEvent)
                {
                    if (myPlanning[0].startTime-DateTime.Now>fortyfive)
                    {
                        item.startTime = DateTime.Now;
                        item.endTime = item.startTime + thirty;
                        myPlanning.Add(item);
                        myPlanning.Sort();
                        firstEvent = false;
                        continue;
                    }
                }*/
                for (int i = 0; i < myPlanning.Count - 1; i++)
                {
                    if (myPlanning[i + 1].startTime - myPlanning[i].endTime > fortyfive)
                    {
                        item.startTime = myPlanning[i].endTime;
                        item.endTime = item.startTime + thirty;
                        myPlanning.Add(item);
                        myPlanning.Sort();
                        break;
                    }
                }
            }
        }

        private void PrioriserParCategorie(List<Event> foundEvents, List<EventCategory> myCategories)
        {
            bool ordered = false;
            int lastcategorypriority;
            while (!ordered)
            {
                ordered = true;
                for (int i = 0; i < foundEvents.Count-1; i++)
                {
                    if (foundEvents[i].Category.Priority> foundEvents[i+1].Category.Priority)
                    {
                        ordered = false;
                        var tempo = foundEvents[i];
                        foundEvents[i] = foundEvents[i+1];
                        foundEvents[i+1] = tempo;

                    }
                }
                
            }
            
        }

        internal void addFreeRecurrentEvents(List<Event> myPlanning, int v, List<EventCategory> myCategories)
        {
            /*string filePath2;
            string fileContent;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "free recurrent EVENTS";
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
                return;
            }*/

            string[] textLines = System.IO.File.ReadAllLines(Settings.Default.RecFree);
            List<Event> tempoEvents=new List<Event>();
            foreach (var line in textLines)
            {
                string taskSeries = line.Split(';')[0];
                EventCategory category = findCategory(myCategories, line.Split(';')[1]);
                tempoEvents.Add(new Event()
                {
                    Name = taskSeries,
                    liberty = true,
                    recurrent = true,
                    Category = category
                }
                    );

            }//foreach

            //category duration = free time * (number of categories - order/ number of categories) 15 - 12 = 3/ 15 = 1/5
            //event duration category duration / number of tasks in the categor
            foreach (var tempoEvent in tempoEvents)
            {
                int eventMinutes=calculateEventDuration(tempoEvent,myPlanning,myCategories, tempoEvents);
                int howManyMore=0;
                    howManyMore = 1+(eventMinutes) / 30;
                
                    PlanThisOne(tempoEvent,myPlanning, howManyMore);
            }



        }

        private void PlanThisOne(Event myEvent, List<Event> myPlanning, int howManyMore)
        {
            TimeSpan seventyFive = new TimeSpan(0, 40, 0);
            TimeSpan sixty = new TimeSpan(0, 30, 0);
            DateTime lastDone=new DateTime(1900,1,1);
            TimeSpan oneday =new TimeSpan(18,0,0);

            for (int j = 0; j < howManyMore; j++)
            {
                for (int i = 0; i < myPlanning.Count - 1; i++)
                {
                    if (myPlanning[i + 1].startTime - myPlanning[i].endTime >= seventyFive &&
                        lastDone +oneday<= myPlanning[i].endTime // 28/7-25/7> 1 day
                        )
                    {
                        Event tempEvent = new Event()
                        {
                            Name=myEvent.Name,
                            Category=myEvent.Category,
                            liberty=myEvent.liberty,
                            recurrent=myEvent.recurrent,
                            startTime= myPlanning[i].endTime,
                            endTime= myPlanning[i].endTime+sixty,
                        };
                        myPlanning.Add(tempEvent);
                        lastDone = tempEvent.startTime;
                        myPlanning.Sort();
                        break;
                    }
                }
            }
            
        }

        private int calculateEventDuration(Event tempoEvent, List<Event> myPlanning, List<EventCategory> myCategories, List<Event> tempoEvents)
        {
            //category duration = free time * (number of categories - order/ number of categories) 15 - 12 = 3/ 15 = 1/5
            //event duration category duration / number of tasks in the categor


            //free time * (number of used categories-order in used categories)/number of used categories
            List<EventCategory> usedCategories = new List<EventCategory>();
            foreach (var item in tempoEvents)
            {
                if (!usedCategories.Any(x=>x.Name==item.Category.Name))
                {
                    usedCategories.Add(item.Category);
                }
            }
            usedCategories.Sort();
            int usedOrder=0;
            for (int order = 0; order < usedCategories.Count; order++)
            {
                if (usedCategories[order].Name==tempoEvent.Category.Name)
                {
                    usedOrder=order;
                }
            }
            int result = 0;
            int categoryDuration = freeTime(myPlanning)*(usedCategories.Count-usedOrder) / sumFromOneTo(usedCategories.Count);
             result= categoryDuration/tempoEvents.Count(x=>x.Category==tempoEvent.Category);
            return result;
        }

        

        private int freeTime(List<Event> myPlanning)
        {
            int result=0;
            for (int i = 0; i < myPlanning.Count-1; i++)
            {
                result += (int)(myPlanning[i + 1].startTime - myPlanning[i].endTime).TotalMinutes;
            }
            if (result<=0 ||result >=7*24*60)
            {
                throw new ArgumentOutOfRangeException();
            }
            return result;
        }

        private int sumFromOneTo(int x)
        {
            if (x==0)
            {
                return 0;
            }
            else if (x == 1) { return 1; }
            else
            {
                return x+sumFromOneTo(x-1);
            }
        }

        internal void printplan(List<Event> myPlanning)
        {
            optimizedSchedule = myPlanning;
            /*string personalChemin;//here
            SaveFileDialog openFileDialog2 = new SaveFileDialog();
            openFileDialog2.Title = "save plan";
            if (openFileDialog2.ShowDialog() == true)
            {
                //Get the path of specified file
                personalChemin = openFileDialog2.FileName;
            }
            else
            {
                throw (new Exception("cant work without plan location"));
            }*/


            
            PrintDocument pDoc = new PrintDocument()
            {
                PrinterSettings = new PrinterSettings()
                {
                    PrinterName = "Microsoft Print to PDF",
                    PrintToFile = true,
                    PrintFileName = Settings.Default.outputpdf,
                }
            };
            pDoc.PrintPage += new PrintPageEventHandler(Print_Page);
            pDoc.Print();
            ProcessStartInfo startInfo = new ProcessStartInfo(Settings.Default.outputpdf);
            startInfo.UseShellExecute = true;
            Process.Start(startInfo);
        }

        void Print_Page(object sender, PrintPageEventArgs e)
        {

            // Here you can play with the font style 
            // (and much much more, this is just an ultra-basic example)
            Font fnt = new Font("Courier New", 9, FontStyle.Underline);
            Font fntLibre = new Font("Courier New", 9);

            // Insert the desired text into the PDF file
            string textToPrint = "";
            float lasty = 0;
            float lastx = 0;
            List<string> reportLines = createPlanReport(optimizedSchedule);
            int i = 0;
            e.Graphics.DrawString(reportLines[i], fntLibre,Brushes.DarkGreen, lastx, lasty);
            i++;
            lasty = lasty + 20;
            DateTime lastday = DateTime.Now.Date;
            foreach (var item in optimizedSchedule)
            {
                if (item.startTime.Date> lastday&&i< reportLines.Count)
                {
                    lastday = item.startTime.Date;

                    e.Graphics.DrawString(reportLines[i], fntLibre, Brushes.DarkGreen, lastx, lasty);
                    i++;
                    lasty = lasty + 20;

                }
                textToPrint = item.startTime.ToString() + " - " + item.endTime.ToShortTimeString() + " - " + item.Name+" - "+item.Category.Name;
                
                e.Graphics.DrawString(textToPrint, item.liberty?fntLibre:fnt, item.recurrent?Brushes.Black:Brushes.Red, lastx, lasty);
                lasty = lasty + 20;
            }


        }

        private List<string> createPlanReport(List<Event> optimizedSchedule)
        {
            List<string> reportLines = new List<string>();
            List<EventCategory> myCategories = new List<EventCategory>();
            foreach (var item in optimizedSchedule)
            {
                if (!myCategories.Any(x=>x.Name==item.Category.Name))
                {
                    myCategories.Add(item.Category);
                }
            }
            DateOnly startDate = DateOnly.FromDateTime(optimizedSchedule[0].startTime);
            for (int i = 0; i < 7; i++)
            {
                string reportLine = "";
                DateOnly reportLineDate= startDate.AddDays(i);
                List<Event> daySchedule =  myDaySchedule(optimizedSchedule, reportLineDate);
                reportLine+= reportLineDate.ToShortDateString()+" free";
                TimeSpan freeTime = freeTimeInADay(daySchedule, reportLineDate);
                reportLine += freeTime.Hours.ToString()+"H"+ freeTime.Minutes.ToString() + "M";
                myCategories.Sort();
                foreach (var item in myCategories)
                {
                    TimeSpan categoryTime = dayCategoryTime(item, daySchedule);
                    reportLine += " " + item.Name.Substring(0,3) + ":" + ((int)categoryTime.TotalMinutes).ToString()+","+item.Priority;
                }
                reportLines.Add(reportLine);
            }
            return reportLines;
        }

        private TimeSpan dayCategoryTime(EventCategory category, List<Event> daySchedule)
        {
            TimeSpan output =new TimeSpan();
            foreach (var item in daySchedule)
            {
                if (item.Category.Name==category.Name)
                {
                    output += item.endTime - item.startTime;
                }
            }
            return output;
        }

        private TimeSpan freeTimeInADay(List<Event> daySchedule, DateOnly reportLineDate)
        {
            TimeSpan output = new TimeSpan();
            for (int i = 0; i < daySchedule.Count-1; i++)
            {
                output += daySchedule[i+1].startTime-daySchedule[i].endTime;
            };
            return output;
        }

        private List<Event> myDaySchedule(List<Event> optimizedSchedule, DateOnly reportLineDate)
        {
            List<Event> ouput =new List<Event>();
            foreach (var item in optimizedSchedule)
            {
                if (DateOnly.FromDateTime(item.startTime)== reportLineDate&& DateOnly.FromDateTime(item.endTime) == reportLineDate)
                {
                    ouput.Add(item);
                }
                else if (DateOnly.FromDateTime(item.startTime) == reportLineDate && !(DateOnly.FromDateTime(item.endTime) == reportLineDate))
                {
                    ouput.Add(new Event()
                    {
                        Category = item.Category,
                        Id = item.Id,
                        liberty = item.liberty,
                        recurrent = item.recurrent,
                        Name = item.Name,
                        startTime= item.startTime,
                        endTime=new DateTime(item.startTime.Year,item.startTime.Month,item.startTime.Day,23,59,59)
                    });
                }
                else if (DateOnly.FromDateTime(item.endTime) == reportLineDate && !(DateOnly.FromDateTime(item.startTime) == reportLineDate))
                {
                    ouput.Add(new Event()
                    {
                        Category = item.Category,
                        Id = item.Id,
                        liberty = item.liberty,
                        recurrent = item.recurrent,
                        Name = item.Name,
                        startTime = new DateTime(item.endTime.Year, item.endTime.Month, item.endTime.Day, 00, 00, 01),
                        endTime = item.endTime});
                }
            }
            return ouput;
        }
    }
}
