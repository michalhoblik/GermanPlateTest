using GermanPlateTest.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GermanPlateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // funxt
            //var formattedPlate = Objects.GermanPlate.ParseFromString("KS-DA 1214");

            //
            //var plate = new GermanPlateTest.LicensePlateHelper.GermanLicensePlate("MTKFX2247").Format(); //F-SH 289
            //var formattedPlate = Objects.GermanPlate.ParseFromString(plate);


            //var helper = new Helpers.GermanPlateHelper();
            //var kennzeichenFinal = hel per.GetFormattedLicenseFromUnformattedString("KSDA1214");

            checkKennzeichen();
        }

        private static void checkKennzeichen()
        {
            int foundKfz = 0;
            var auslandKfz = new List<string>();
            var notSame = new List<string>();

            using (StreamReader reader = new StreamReader(@"C:\Users\Michal\Desktop\ocr_kennzeichen\ocr_kennzeichen.csv"))
            {
                var kfzList = from line in reader.Lines() where (!string.IsNullOrEmpty(line) && !line.Equals("NULL", StringComparison.CurrentCultureIgnoreCase)) select line;
                foreach (var kfz in kfzList)
                {
                    var unformatted = kfz.Replace(" ", "").Replace("-", "").Trim();
                    var plate = new LicensePlateHelper.GermanLicensePlate(unformatted);
                    if (plate.IsValid())
                    {
                        var foundFormatted = plate.Format();
                        //var formattedPlate = Objects.GermanPlate.ParseFromString(foundFormatted);
                        string result = "";
                        if (kfz.Equals(foundFormatted))
                        {
                            result = "gefunden";
                            foundKfz += 1;
                        }
                        else
                        {
                            result = "nicht gefunden";
                            notSame.Add($"OV: {kfz}||FV: {foundFormatted}");
                        }

                        Console.WriteLine($"KFZ Original: {kfz} -> Unformatted: {unformatted} -> Formatted: {foundFormatted}; Result: {result}");
                    }
                    else
                    {
                        auslandKfz.Add(kfz); 
                    } 
                }
            }

            Console.WriteLine("-------Result--------");
            Console.WriteLine($"Found KFZ: {foundKfz}");
            Console.WriteLine($"Not found KFZ: {notSame.Count}");
            Console.WriteLine($"Ausland KFZ: {auslandKfz.Count}");
        }
    }
}
