﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MediaPoint.Subtitles.Logic.SubtitleFormats
{
    class UleadSubtitleFormat : SubtitleFormat
    {
        public override string Extension
        {
            get { return ".txt"; }
        }

        public override string Name
        {
            get { return "Ulead subtitle format"; }
        }

        public override bool HasLineNumber
        {
            get { return true; }
        }

        public override bool IsTimeBased
        {
            get { return true; }
        }

        public override bool IsMine(List<string> lines, string fileName)
        {
            var subtitle = new Subtitle();
            LoadSubtitle(subtitle, lines, fileName);
            return subtitle.Paragraphs.Count > _errorCount;
        }

        public override string ToText(Subtitle subtitle, string title)
        {
            const string Header = @"#Ulead subtitle format

#Subtitle stream attribute begin
#FR:25.00
#Subtitle stream attribute end

#Subtitle text begin";

            const string Footer = @"#Subtitle text end
#Subtitle text attribute begin
#/R:1,{0} /FP:8  /FS:24
#Subtitle text attribute end";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Header);
            int index = 0;
            foreach (Paragraph p in subtitle.Paragraphs)
            {
                //#3 00;04;26;04 00;04;27;05
                //How much in there? -
                //Three...
                sb.AppendLine(string.Format("#{0} {1} {2}", index, EncodeTimeCode(p.StartTime), EncodeTimeCode(p.EndTime)));
                sb.AppendLine(Utilities.RemoveHtmlTags(p.Text));
                index++;
            }
            sb.AppendLine(string.Format(Footer, subtitle.Paragraphs.Count));
            return sb.ToString();
        }

        private string EncodeTimeCode(TimeCode time)
        {
            //00;04;27;05
            int frames = time.Milliseconds / (1000 / 25);
            return string.Format("{0:00};{1:00};{2:00};{3:00}", time.Hours, time.Minutes, time.Seconds, frames);
        }

        public override void LoadSubtitle(Subtitle subtitle, List<string> lines, string fileName)
        {
            //#3 00;04;26;04 00;04;27;05
            //How much in there? -
            //Three...
            Paragraph p = null;
            subtitle.Paragraphs.Clear();
            var regexTimeCodes = new Regex(@"^#\d+ \d\d;\d\d;\d\d;\d\d \d\d;\d\d;\d\d;\d\d", RegexOptions.Compiled);
            foreach (string line in lines)
            {
                if (regexTimeCodes.IsMatch(line))
                {
                    string[] parts = line.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 3)
                    {
                        string start = parts[1];
                        string end = parts[2];
                        try
                        {
                            p = new Paragraph(DecodeTimeCode(start), DecodeTimeCode(end), string.Empty);
                            subtitle.Paragraphs.Add(p);
                        }
                        catch
                        {
                            _errorCount++;
                        }
                    }
                }
                else if (line.Trim().Length == 0 || line.StartsWith("#"))
                {
                    // skip these lines
                }
                else if (line.Trim().Length > 0 && p != null)
                {
                    if (string.IsNullOrEmpty(p.Text))
                        p.Text = line;
                    else
                        p.Text = p.Text + Environment.NewLine + line;
                }
                else
                {
                    _errorCount++;
                }
            }
            subtitle.Renumber(1);
        }

        private TimeCode DecodeTimeCode(string time)
        {
            //00;04;26;04

            string hour = time.Substring(0, 2);
            string minutes = time.Substring(3, 2);
            string seconds = time.Substring(6, 2);
            string frames = time.Substring(9, 2);

            int milliseconds = (int)((1000 / 25.0) * int.Parse(frames));
            if (milliseconds > 999)
                milliseconds = 999;

            TimeCode tc = new TimeCode(int.Parse(hour), int.Parse(minutes), int.Parse(seconds), milliseconds);
            return tc;
        }

    }
}

