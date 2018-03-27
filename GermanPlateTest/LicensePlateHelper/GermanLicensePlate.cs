using GermanPlateTest.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GermanPlateTest.LicensePlateHelper
{
    public class GermanLicensePlate : LicensePlateBase, ILicensePlate
    {
        private const string SIDE_CODE_POLITICAL_HEADS = "P";
        private const string SIDE_CODE_CORPS_DIPLOMATIC = "CD";
        private const string SIDE_CODE_AMERICAN_FORCES = "AF";
        private const string SIDE_CODE_SPECIAL_TRANSPORT = "AG";
        private const string SIDE_CODE_FEDERAL_POLICE = "BG";
        private const string SIDE_CODE_TECHNICAL_RELIEF = "THW";
        private const string SIDE_CODE_NATO = "X";
        private const string SIDE_CODE_ARMY = "Y";
        private const string SIDE_CODE_HISTORICAL = "H";
        private const string SIDE_CODE_ELECTRICAL = "E";
        private const string SIDE_CODE_STATE = "S";
        private const string SIDE_CODE_DEFAULT = "1";

        private string[] _districts = new[] { "A","AA","AB","ABG","ABI","AC","AE","AD","AF","AIC","AK","ALF","AM","AN","ANA","ANK","AÖ","AP","APD","ARN","ART","AS","ASL", "ALZ","ASZ","AT","AU","AUR","AW","AZ","AZE",
        "B","BB","BA","BAD","BAR","BBG","BC","BCH","BD","BED","BER","BF","BGL","BI","BID","BIN","BIR","BIT","BIW","BK","BKS","BL","BLB","BLK","BM","BN","BNA","BO","BÖ","BOR","BOT","BRA","BRB","BRG","BRL","BRV","BS","BT","BTF","BÜD","BÜS","BÜZ","BW","BZ",
        "C","CA","CAS","CB","CE","CHA","CLP","CLZ","CO","COC","COE","CUX","CW",
        "D","DA","DAH","DAN","DAU","DB","DBR","DD","DE","DEG","DEL","DGF","DH","DI", "DIL" ,"DIN","DL","DLG","DM","DN","DO","DON","DU","DÜW","DW","DZ",
        "E","EE","EA","EB","EBE","ECK","ED","EF","EH","EI","EIC","EIL","EIN","EIS","EL","EM","EMD","EMS","EN","ER","ERB","ERH", "ERK" ,"ERZ","ES","ESW","EU","EW",
        "F","FF","FB","FD","FDS","FFB","FG","FI","FL","FLO","FN","FO","FOR","FR","FRG","FRI","FRW","FS","FT","FTL","FÜ",
        "G","GG","GA","GAP","GC","GD","GDB","GE","GER","GEO","GF","GHA","GHC","GI","GL","GLA","GM","GMN","GN","GNT","GÖ","GOA","GP","GR","GRH","GRZ","GS","GT","GTH","GUB","GÜ","GVM","GW","GZ",
        "H","HH","HA","HAL","HAM","HAS","HB","HBN","HBS","HC","HCH","HD","HDH","HDL","HE","HEF","HEI","HER","HET","HF","HG","HGN","HGW","HHM","HI","HIG","HK","HK","HL","HM","HMÜ","HN","HO","HOG","HOL","HOM","HOT","HP","HR","HRO","HS","HSK","HST","HU","HVL","HWI","HX","HY","HZ",
        "IGB","IK","IL","IN","IZ",
        "J","JE","JL","JÜL",
        "K","KA","KB","KC","KE","KEH","KF","KG","KH","KI","KIB","KL","KLE","KLZ","KM","KN","KO","KÖT","KR","KS","KT","KU","KÜN","KUS","KY","KYF",
        "L","LL","LA","LAU","LB","LBS","LBZ","LD","LDK","LDS","LEO","LER","LEV","LG","LI","LIF","LIP","LM","LÖ","LÖB","LOS","LP","LRO","LSZ","LU","LUN","LWL",
        "M","MM","MA","MAB","MB","MC","MD","ME","MEG","MEI","MEK","MG","MGN","MH","MHL","MI","MIL","MKK","ML","MK","MN","MO","MOL","MOS","MQ","MR","MS","MSH","MSP","MST","MTK","MTL","MÜ","MÜR","MW","MYK","MZ","MZG",
        "N","NB","ND","NDH","NE","NEA","NEB","NES","NEW","NF","NH","NI","NK","NM","NMB","NMS","NOH","NOL","NOM","NOR","NP","NR","NU","NVP","NW","NWM","NY","NZ",
        "OA","OAL","OB","OBG","OC","OCH","OD","OE","OF","OG","OH","OHA","OHV","OHZ","OK","OL","OPR","OS","OSL","OVL","OVP",
        "P","PA","PAF","PAN","PB","PCH","PE","PF","PI","PIR","PL","PLÖ","PM","PN","PR","PRÜ","PS","PW",
        "QFT","QLB",
        "R","RA","RC","RD","RDG","RE","REG","RG","RH","RI","RIE","RL","RM","RO", "ROD", "ROF", "ROW","RP","RS","RSL","RT", "RU","RÜD","RÜG","RV","RW","RZ",
        "S","SAB","SAW","SB","SBK","SC","SCZ","SDH","SDL","SE","SEB","SEE","SFA","SFB","SFT","SG","SGH","SHA","SHG","SHK","SHL","SI","SIG","SIM","SK","SL","SLF","SLK","SLN","SLS","SLÜ","SLZ","SM","SN","SO","SÖM","SOK","SON","SP","SPN","SR","SRB","SRO","ST","STA","STD","STL","SU","SÜW","SW", "SWA" ,"SZ","SZB",
        "TBB","TDO","TE","TET","TF","TG","TIR","TO","TÖL","TR","TS","TÜ","TUT",
        "UE","UEM","UER","UH","UL","UM","UN","USI",
        "V","VB","VEC","VER","VG","VIE","VK","VR","VS",
        "W", "WA", "WW","WAF","WAK","WAN","WAT","WB","WBS","WDA","WE","WEN","WES", "WEL", "WF","WHV","WI","WIL","WIS","WIT", "WIZ" ,"WK","WL","WLG","WM","WMS","WN","WND","WO","WOB","WOH","WR","WSF","WST","WT","WTM","WÜ","WUG","WUN","WUR", "WZ","WZL",
        "X",
        "Y",
        "Z","ZZ","ZE","ZEL","ZI","ZP","ZR","ZW"};

        private string[] _bigCities = new[] { "A", "B" , "D", "E", "G", "H", "J", "K", "L", "M", "N", "P", "R", "S", "V", "X", "Y", "Z" };

        private string _district_regex;
        private string _big_Cities_Regex;
        private string _core_default_plate_regex;
        private string _default_plate_regex;
        private string _default_complete_plate_regex;
        private string _original_licenseplate;

        public GermanLicensePlate(string licenseplate) : base(licenseplate)
        {
            _district_regex = getAreasRegex(_districts);
            _big_Cities_Regex = getAreasRegex(_bigCities);
            _core_default_plate_regex = @"[a-zA-Z]{1,2}[\d]{1,4}";
            _default_plate_regex = _core_default_plate_regex + "$";
            _default_complete_plate_regex = _district_regex + _default_plate_regex;
            _original_licenseplate = licenseplate.Trim();
        }

        public string Format()
        {
            var sidecode = getSidecode();
            if (!sidecode.Item1)
            {
                return "";
            }

            var original_transformed_licenseplate = _original_licenseplate.ToUpper();
            var licenseplate = original_transformed_licenseplate.Replace("-", "").Replace(" ", "");

            switch (sidecode.Item2)
            {
                case SIDE_CODE_DEFAULT:
                    return formatDefaultLicensePlate(original_transformed_licenseplate, licenseplate);
                case SIDE_CODE_ELECTRICAL:
                    var formatted_license_plate_e = formatDefaultLicensePlate(original_transformed_licenseplate.Substring(0, original_transformed_licenseplate.Length - 1), licenseplate.Substring(0, licenseplate .Length - 1) + "E");
                    return formatted_license_plate_e;
                case SIDE_CODE_HISTORICAL:
                    var formatted_license_plate_h = formatDefaultLicensePlate(original_transformed_licenseplate.Substring(0, original_transformed_licenseplate.Length - 1), licenseplate.Substring(0, licenseplate.Length - 1) + "H");
                    return formatted_license_plate_h;
                case SIDE_CODE_TECHNICAL_RELIEF:
                    return $"{licenseplate.Substring(0, 3)} {licenseplate.Substring(3)}";
                case SIDE_CODE_FEDERAL_POLICE:
                    return $"{licenseplate.Substring(0, 2)} {licenseplate.Substring(2, 2)}-{licenseplate.Substring(4)}";
                case SIDE_CODE_ARMY:
                    if (licenseplate.Length == 6)
                    {
                        return $"Y-{licenseplate.Substring(1, 2)} {licenseplate.Substring(3)}";
                    }

                    return $"Y-{licenseplate.Substring(1, 3)} {licenseplate.Substring(4)}";
                case SIDE_CODE_NATO:
                    return $"X-{licenseplate.Substring(1)}";
                case SIDE_CODE_STATE:
                    var state = licenseplate.ToCharArray().Where(obj => char.IsLetter(obj)).ToArray();
                    return $"{state.ToString()} {licenseplate.Substring(state.Length, 1)}-{licenseplate.Substring(state.Length + 1)}";
                default:
                    return licenseplate;
            }
        }

        public string GetThreeLetterISO() => "DEU";

        public string GetTwoLetterISO() => "DE";

        public bool IsValid()
        {
            return getSidecode().Item1 != false;
        }

        private string getAreasRegex(string[] data)
        {
            var joined = string.Join("|", data);
            var regexString = $"^({joined})";
            return regexString;
        }

        private Tuple<bool, string> getSidecode()
        {
            var licenseplate = _licenseplate.Trim().ToUpper().Replace("-", "").Replace(" ", "");
            if (licenseplate.Length > 9)
            {
                return Tuple.Create(false, "");
            }

            var sidecodes = new Dictionary<string, string>
            {
                [SIDE_CODE_POLITICAL_HEADS] = "^(0[0-4]{1,1}|1{2,2})$",
                [SIDE_CODE_CORPS_DIPLOMATIC] = @"^0[\d]{3,6}$",
                [SIDE_CODE_AMERICAN_FORCES] = "^(AD|AF|HK|IF)" + _default_plate_regex,
                [SIDE_CODE_SPECIAL_TRANSPORT] = "^AG" + _default_plate_regex,
                [SIDE_CODE_FEDERAL_POLICE] = @"^(BG|BP)[\d]{3,6}$",
                [SIDE_CODE_TECHNICAL_RELIEF] = @"^THW(8|9)[\d]{3,4}$",
                [SIDE_CODE_STATE] = @"^(BBL|BWL|BYL|HEL|LSA|LSN|MVL|NL|NRW|RPL|RWL|SAL|SH|THL)[\d]{2,5}$", // BWL 1-1214
                [SIDE_CODE_NATO] = @"^X[\d]{4,4}$",
                [SIDE_CODE_ARMY] = @"^Y[\d]{5,6}$",
                [SIDE_CODE_HISTORICAL] = _district_regex + _core_default_plate_regex + "H$",
                [SIDE_CODE_ELECTRICAL] = _district_regex + _core_default_plate_regex + "E$",
                [SIDE_CODE_DEFAULT] = _default_complete_plate_regex
            };

            var result = checkPatterns(sidecodes, licenseplate);
            return result;
        }

        private string formatDefaultLicensePlate(string original_transformed_licenseplate, string licenseplate)
        {
            var delimiter_position = getDelimiterPositionFromLicensePlate(original_transformed_licenseplate);
            if (delimiter_position > 0)
            {
                var formatted_license_plate = getFormattedLicensePlateForLicensePlateWithFormat(original_transformed_licenseplate, licenseplate, delimiter_position);
                if (!string.IsNullOrEmpty(formatted_license_plate))
                {
                    return formatted_license_plate;
                }
            }

            return getFormattedLicensePlateForLicensePlateWithoutFormat(licenseplate);
        }

        private string getFormattedLicensePlateForLicensePlateWithFormat(string original_transformed_licenseplate, string licenseplate, int delimiter_position)
        {
            return "";
        }

        private int getDelimiterPositionFromLicensePlate(string original_transformed_licenseplate, int start = 0, int length = 4)
        {
            return 0;
            //var dash_position = 
        }

        public string getFormattedLicensePlateForLicensePlateWithoutFormat(string licensePlate)
        {
            string[] possible_districts = new string[] { };
            var letters_only = RegexExtensions.Preg_replace(licensePlate, new[] { "[0-9]{2,}" }, new[] { "" });
            var letters_only_length = letters_only.Length;
            var start = 0;
            if (letters_only_length > 2)
            {
                start = letters_only_length - 2;
            }

            for (int i = start; i < letters_only_length; i++)
            {
                var district = letters_only.Substring(0, i);
                if (RegexExtensions.Preg_match(new Regex(getAreasRegex(_districts) + "$"), district, out List<string> matches))
                {
                    if (district.Length >= letters_only_length - 2)
                    {
                        possible_districts = possible_districts.Concat(matches.ToArray()).ToArray();
                    }

                    if (possible_districts.Count() > 2)
                    {
                        var reindexed = new ArrayReindexer(possible_districts);
                        reindexed.Reindex(1, 1);
                    }
                }
            }

            // if not found search the big cities with one zeichen
            //if (possible_districts.Length == 0)
            //{
            //    if (RegexExtensions.Preg_match(new Regex(getAreasRegex(_districts) + "$"), letters_only.Substring(0, 1), out List<string> matches))
            //    {
            //        possible_districts = matches.ToArray();
            //    }
            //}

            // fallback
            if (possible_districts.Length == 0)
            {
                return licensePlate;
            }

            var finalDistrict = possible_districts[0];
            var final_district_length = finalDistrict.Length;

            //RegexExtensions.Preg_match_Special(new Regex(@"\D+"), licensePlate, out int number_matches);
            var number_matches = licensePlate.Count(x => Char.IsDigit(x));

            var middle_part_length = licensePlate.Length - number_matches - final_district_length;

            return $"{finalDistrict}-{licensePlate.Substring(final_district_length, middle_part_length)} {licensePlate.Substring(middle_part_length + final_district_length)}";
        }
    }
}
