using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GermanPlateTest.Helpers
{
    public static class RegexExtensions
    {
        public static bool Preg_match(this Regex regex, string input, out List<string> matches)
        {
            var match = regex.Match(input);
            var groups = (from object g in match.Groups select g.ToString()).ToList();

            matches = groups;
            return match.Success;
        }

        public static bool Preg_match_Special(this Regex regex, string input, out int matches)
        {
            //var match = (from t in input where char.IsDigit(t) select t.ToString()).ToList();
            var match = regex.Split(input);
            var groups = (from object g in match select g.ToString()).ToList();

            matches = groups.Count;
            return match.Length > 0;
        }

        public static string Preg_replace(this string input, string[] pattern, string[] replacements)
        {
            if (replacements.Length != pattern.Length)
                throw new ArgumentException("Replacement and Pattern Arrays must be balanced");

            for (var i = 0; i < pattern.Length; i++)
            {
                input = Regex.Replace(input, pattern[i], replacements[i]);
            }

            return input;
        }
    }
}
