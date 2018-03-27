using System;
using System.Linq;

namespace GermanPlateTest.Objects
{
    public enum KennzeichenType
    {
        Standard,
        Electric,
        Historical
    }

    public class GermanPlate
    {
        private static string[] alternativePrefixes = new[] { "A","AA","AB","ABG","ABI","AC","AE","AD","AF","AIC","AK","ALF","AM","AN","ANA","ANK","AÖ","AP","APD","ARN","ART","AS","ASL","ASZ","AT","AU","AUR","AW","AZ","AZE",
        "B","BB","BA","BAD","BAR","BBG","BC","BCH","BD","BED","BER","BF","BGL","BI","BID","BIN","BIR","BIT","BIW","BK","BKS","BL","BLB","BLK","BM","BN","BNA","BO","BÖ","BOR","BOT","BRA","BRB","BRG","BRL","BRV","BS","BT","BTF","BÜD","BÜS","BÜZ","BW","BZ",
        "C","CA","CAS","CB","CE","CHA","CLP","CLZ","CO","COC","COE","CUX","CW",
        "D","DA","DAH","DAN","DAU","DB","DBR","DD","DE","DEG","DEL","DGF","DH","DI","DIN","DL","DLG","DM","DN","DO","DON","DU","DÜW","DW","DZ",
        "E","EE","EA","EB","EBE","ECK","ED","EF","EH","EI","EIC","EIL","EIN","EIS","EL","EM","EMD","EMS","EN","ER","ERB","ERH","ERZ","ES","ESW","EU","EW",
        "F","FF","FB","FD","FDS","FFB","FG","FI","FL","FLO","FN","FO","FOR","FR","FRG","FRI","FRW","FS","FT","FTL","FÜ",
        "G","GG","GA","GAP","GC","GD","GDB","GE","GER","GEO","GF","GHA","GHC","GI","GL","GLA","GM","GMN","GN","GNT","GÖ","GOA","GP","GR","GRH","GRZ","GS","GT","GTH","GUB","GÜ","GVM","GW","GZ",
        "H","HH","HA","HAL","HAM","HAS","HB","HBN","HBS","HC","HCH","HD","HDH","HDL","HE","HEF","HEI","HER","HET","HF","HG","HGN","HGW","HHM","HI","HIG","HK","HK","HL","HM","HMÜ","HN","HO","HOG","HOL","HOM","HOT","HP","HR","HRO","HS","HSK","HST","HU","HVL","HWI","HX","HY","HZ",
        "IGB","IK","IL","IN","IZ",
        "J","JE","JL","JÜL",
        "K","KA","KB","KC","KE","KEH","KF","KG","KH","KI","KIB","KL","KLE","KLZ","KM","KN","KO","KÖT","KR","KS","KT","KU","KÜN","KUS","KY","KYF",
        "L","LL","LA","LAU","LB","LBS","LBZ","LD","LDK","LDS","LEO","LER","LEV","LG","LI","LIF","LIP","LM","LÖ","LÖB","LOS","LP","LRO","LSZ","LU","LUN","LWL",
        "M","MM","MA","MAB","MB","MC","MD","ME","MEI","MEK","MG","MGN","MH","MHL","MI","MIL","MKK","ML","MK","MN","MO","MOL","MOS","MQ","MR","MS","MSH","MSP","MST","MTK","MTL","MÜ","MÜR","MW","MYK","MZ","MZG",
        "N","NB","ND","NDH","NE","NEA","NEB","NES","NEW","NF","NH","NI","NK","NM","NMB","NMS","NOH","NOL","NOM","NOR","NP","NR","NU","NVP","NW","NWM","NY","NZ",
        "OA","OAL","OB","OBG","OC","OCH","OD","OE","OF","OG","OH","OHA","OHV","OHZ","OK","OL","OPR","OS","OSL","OVL","OVP",
        "P","PA","PAF","PAN","PB","PCH","PE","PF","PI","PIR","PL","PLÖ","PM","PN","PR","PRÜ","PS","PW",
        "QFT","QLB",
        "R","RA","RC","RD","RDG","RE","REG","RG","RH","RI","RIE","RL","RM","RO","ROW","RP","RS","RSL","RT","RÜD","RÜG","RV","RW","RZ",
        "S","SAB","SAW","SB","SBK","SC","SCZ","SDH","SDL","SE","SEB","SEE","SFA","SFB","SFT","SG","SGH","SHA","SHG","SHK","SHL","SI","SIG","SIM","SK","SL","SLF","SLK","SLN","SLS","SLÜ","SLZ","SM","SN","SO","SÖM","SOK","SON","SP","SPN","SR","SRB","SRO","ST","STA","STD","STL","SU","SÜW","SW","SZ","SZB",
        "TBB","TDO","TE","TET","TF","TG","TIR","TO","TÖL","TR","TS","TÜ","TUT",
        "UE","UEM","UER","UH","UL","UM","UN","USI",
        "V","VB","VEC","VER","VG","VIE","VK","VR","VS",
        "W","WW","WAF","WAK","WAN","WAT","WB","WBS","WDA","WE","WEN","WES","WF","WHV","WI","WIL","WIS","WIT","WK","WL","WLG","WM","WMS","WN","WND","WO","WOB","WOH","WR","WSF","WST","WT","WTM","WÜ","WUG","WUN","WUR","WZL",
        "X",
        "Y",
        "Z","ZZ","ZE","ZEL","ZI","ZP","ZR","ZW"};

        private string _kfzStelle;
        private string _alphaNumeric;
        private string _numeric;
        private KennzeichenType _kennzeichenType;

        public GermanPlate(string kfzStelle, string alphanumeric, string numeric, KennzeichenType kennzeichenType)
        {
            _kfzStelle = kfzStelle;
            _alphaNumeric = alphanumeric;
            _numeric = numeric;
            _kennzeichenType = kennzeichenType;
        }

        public override string ToString()
        {
            var suffix = "";
            switch (_kennzeichenType)
            {
                case KennzeichenType.Electric:
                    suffix = "E";
                    break;
                case KennzeichenType.Historical:
                    suffix = "H";
                    break;
                case KennzeichenType.Standard:
                default:
                    suffix = "";
                    break;
            }

            return $"{_kfzStelle}-{_alphaNumeric} {_numeric}{suffix}";
        }

        public static GermanPlate ParseFromString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return null;

            var parseString = value.Trim().ToUpper();
            var isElectricVehicle = false;
            var isHistoric = false;

            if (parseString.EndsWith("E"))
            {
                isElectricVehicle = true;
                parseString = parseString.Substring(0, parseString.Length - 1).Trim();
            }
            else if (parseString.EndsWith("H"))
            {
                isHistoric = true;
                parseString = parseString.Substring(0, parseString.Length - 1).Trim();
            }

            var kfzStelle = "";
            var alphanumeric = "";
            var numeric = "";

            var j = 0;
            for (int i = 0; i < parseString.Length; i++)
            {
                if (j == 0)
                {
                    switch (parseString[i])
                    {
                        case ' ':
                        case '-':
                        case '.':
                            j += 1;
                            continue;
                        default:
                            kfzStelle += parseString[i];
                            continue;
                    }
                }

                if (j == 1)
                {
                    if (char.IsLetter((parseString[i])))
                    {
                        alphanumeric += parseString[i];
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(alphanumeric))
                        {
                            continue;
                        }

                        j = 2;
                    }
                }

                if (j == 2)
                {
                    if (char.IsDigit((parseString[i])))
                    {
                        numeric += parseString[i];
                    }
                    else
                    {
                        switch (parseString[i])
                        {
                            case ' ':
                            case '-':
                            case '.':
                                continue;
                            default:
                                throw new InvalidOperationException("Invalid plate number");
                        }
                    }
                }
            }

            var numericValue = int.Parse(numeric);
            if (string.IsNullOrEmpty(alphanumeric))
            {
                throw new Exception("Invalid plate number");
            }

            if (numericValue == 0 || numericValue > 9999)
            {
                throw new Exception("Invalid plate number");
            }

            if (alternativePrefixes.Contains(kfzStelle))
            {
                kfzStelle = Array.Find(alternativePrefixes, s => s.Equals(kfzStelle));
            }

            var kfzType = KennzeichenType.Standard;
            if (isHistoric)
            {
                kfzType = KennzeichenType.Historical;
            }
            else if (isElectricVehicle)
            {
                kfzType = KennzeichenType.Electric;
            }

            return new GermanPlate(kfzStelle, alphanumeric, numeric, kfzType);
        }
    }
}
