using System;
using System.Collections.Generic;
using System.Linq;
using static System.Environment;
using static System.String;

namespace SmartfeedSanitizer
{
    class Functions
    {
        public static string SanitizeString(string inp)
        {
            string input = inp;
            string outp = Empty;
            try
            {
                input =
                    input.Replace(" ", Empty)
                        .Replace(NewLine, ",")
                        .Replace("\"", Empty)
                        .Replace("'", Empty)
                        .Replace(":", ",");
                List<string> sets = input.Split(',').ToList();
                sets = sets.Distinct().ToList();
                foreach (string set in sets)
                {
                    int temp;
                    if (Int32.TryParse(set, out temp))
                    {
                        outp += set + ",";
                    }
                }
                outp = outp.TrimEnd(',');
            }
            catch (Exception e)
            {
                outp = $"Error parsing input: {e.Message}";
            }
            return outp;
        }
    }
}
