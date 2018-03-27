using System.Collections.Generic;
using System.IO;

namespace GermanPlateTest.Helpers
{
    public static class StreamReaderExtensions
    {
        public static IEnumerable<string> Lines(this StreamReader reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
                yield return line;
        }
    }
}
