using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GermanPlateTest.LicensePlateHelper
{
    public class LicensePlateBase
    {
        protected string _licenseplate;

        public LicensePlateBase(string licenseplate)
        {
            _licenseplate = licenseplate.Replace(" ", "");
        }

        protected Tuple<bool, string> checkPatterns(Dictionary<string, string> patterns, string licenseplate)
        {
            foreach (var pattern in patterns)
            {
                if (Helpers.RegexExtensions.Preg_match(new Regex(pattern.Value), licenseplate, out List<string> matches))
                {
                    return Tuple.Create(true, pattern.Key);
                }
            }

            return Tuple.Create(false, "");
        }
    }
}
