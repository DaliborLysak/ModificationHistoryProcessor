// 10.10.2018 [DaliborLysak] wrong last history line detection #3

using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ModificationHistoryProcessor
{
    public class ModificationHistoryFile
    {
        private ModificationHistorySettings Settings;
        private string Path = String.Empty;
        private string ModificationHistory = String.Empty;
        private bool HasHeader = false;

        public ModificationHistoryFile(ModificationHistorySettings settings, string path, string modificationHistory)
        {
            Settings = settings;
            Path = path;
            ModificationHistory = modificationHistory;
        }

        public void WriteToFile()
        {
            if (!String.IsNullOrEmpty(Path) && File.Exists(Path) && (Settings != null) && !String.IsNullOrEmpty(ModificationHistory))
            {
                var lines = File.ReadAllLines(Path, Encoding.UTF8);
                var lineNumber = 0;

                while (lineNumber < lines.Count())
                {
                    var line = lines[lineNumber];

                    if (!String.IsNullOrEmpty(line) || line.Equals(Environment.NewLine))
                    {
                        TestHeaderExistance(line);// todo header writing if missing

                        if ((lineNumber + 1 < lines.Count()) && IsLastHistoryLine(line, lines[lineNumber + 1]))
                        {
                            lines[lineNumber] = $"{line}{Environment.NewLine}{ModificationHistory}";
                            lineNumber = lines.Count();// done
                        }
                    }

                    lineNumber++;
                }

                File.WriteAllLines(Path, lines, Encoding.UTF8);
            }
        }

        private void TestHeaderExistance(string line)
        {
            if (String.IsNullOrEmpty(Settings.HeaderSearchPattern) && !HasHeader && !line.Contains(Settings.HeaderSearchPattern))
            {
                HasHeader = true;
            }
        }

        private bool IsLastHistoryLine(string line, string nextLine)
        {
            return IsHistoryLine(line) && String.IsNullOrEmpty(nextLine);
        }

        private bool IsHistoryLine(string line)
        {
            var isHistoryLine = false;
            foreach (Match match in Regex.Matches(line, Settings.SearchPatternStart, RegexOptions.IgnoreCase))
            {
                isHistoryLine = match.Success; // should by only one
            }

            return isHistoryLine;
        }
    }
}
