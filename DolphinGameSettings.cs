using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ShadowSXLauncher
{
    public class DolphinGameSettings
    {
        public Dictionary<string, List<string>> Sections;

        private string dataSingleString
        {
            get
            {
                var singleString = string.Empty;

                foreach (var key in Sections.Keys)
                {
                    singleString += "[" + key + "]" + Environment.NewLine;
                    Sections[key].ForEach(line => singleString += line + Environment.NewLine);
                }

                return singleString.TrimEnd(Environment.NewLine.ToCharArray());
            }
        }
        
        public DolphinGameSettings(string fileContents)
        {
            Sections = new Dictionary<string, List<string>>();
            var matchString = @"^\[\w*\]";
            var matches = Regex.Matches(fileContents, matchString, RegexOptions.Multiline);
            var sectionHeaders = new List<string>();

            for (int i = 0; i < matches.Count; i++)
            {
                sectionHeaders.Add(matches[i].Value);
            }
            
            var fileContentsMultiLine = fileContents.Split(new string[] { Environment.NewLine },StringSplitOptions.None);

            var currentKey = "";
            foreach (var line in fileContentsMultiLine)
            {
                if (sectionHeaders.Contains(line))
                {
                    var key = line.Remove(line.Length - 1).Remove(0, 1);
                    Sections.Add(key, new List<string>());
                    currentKey = key;
                }
                else if(!string.IsNullOrEmpty(currentKey))
                {
                    Sections[currentKey].Add(line);
                }
                else
                {
                    throw new Exception("Attempted to add a line without preparing the Dictionary Key.");
                }
            }
        }

        public void SaveSettings(string gameSettingsFilePath)
        {
            File.WriteAllText(gameSettingsFilePath, dataSingleString);
        }
    }
}