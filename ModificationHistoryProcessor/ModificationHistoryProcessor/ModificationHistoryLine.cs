using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace ModificationHistoryProcessor
{
    public class ModificationHistoryLine
    {
        public string Get(ModificationHistorySettings settings, string input)
        {
            var output = settings.OutputPattern;

            if ((settings != null) && !String.IsNullOrEmpty(input))
            {
                foreach (Match match in Regex.Matches(input, settings.InputPattern, RegexOptions.IgnoreCase))
                {
                    output = output.Replace("DATE", DateTime.Today.ToString(settings.DateFormat));
                    output = output.Replace("NAME", settings.Name);
                    output = output.Replace("ID", match.Groups[1]?.Value ?? String.Empty);
                    output = output.Replace("TEXT", match.Groups[2]?.Value ?? String.Empty);
                }

                output = RemoveDiacritics(output);
            }

            return output;
        }

        private string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
