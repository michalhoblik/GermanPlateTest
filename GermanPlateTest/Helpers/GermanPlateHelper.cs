using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GermanPlateTest.Helpers
{
    public class GermanPlateHelper
    {
        //private Regex _germanPlateRegex = new Regex(@"[/^ (A | AA | AB | ABG | ABI | AC | AE | AD | AF | AIC | AK | ALF | AM | AN | ANA | ANK | AÖ | AP | APD | ARN | ART | AS | ASL | ASZ | AT | AU | AUR | AW | AZ | AZE | B | BA | BAD | BAR | BB | BBG | BC | BCH | BD | BED | BER | BF | BGL | BI | BID | BIN | BIR | BIT | BIW | BK | BKS | BL | BLB | BLK | BM | BN | BNA | BO | BÖ | BOR | BOT | BRA | BRB | BRG | BRL | BRV | BS | BT | BTF | BÜD | BÜS | BÜZ | BW | BWL | BYL | BZ | C | CA | CAS | CB | CE | CHA | CLP | CLZ | CO | COC | COE | CUX | CW | D | DA | DAH | DAN | DAU | DB | DBR | DD | DE | DEG | DEL | DGF | DH | DI | DIN | DL | DLG | DM | DN | DO | DON | DU | DÜW | DW | DZ | E | EA | EB | EBE | ECK | ED | EE | EF | EH | EI | EIC | EIL | EIN | EIS | EL | EM | EMD | EMS | EN | ER | ERB | ERH | ERZ | ES | ESW | EU | EW | F | FB | FD | FDS | FF | FFB | FG | FI | FL | FLO | FN | FO | FOR | FR | FRG | FRI | FRW | FS | FT | FTL | FÜ | G | GA | GAP | GC | GD | GDB | GE | GER | GEO | GF | GG | GHA | GHC | GI | GL | GLA | GM | GMN | GN | GNT | GÖ | GOA | GP | GR | GRH | GRZ | GS | GT | GTH | GUB | GÜ | GVM | GW | GZ | H | HA | HAL | HAM | HAS | HB | HBN | HBS | HC | HCH | HD | HDH | HDL | HE | HEF | HEI | HER | HET | HF | HG | HGN | HGW | HH | HHM | HI | HIG | HK | HK | HL | HM | HMÜ | HN | HO | HOG | HOL | HOM | HOT | HP | HR | HRO | HS | HSK | HST | HU | HVL | HWI | HX | HY | HZ | IGB | IK | IL | IN | IZ | J | JE | JL | JÜL | K | KA | KB | KC | KE | KEH | KF | KG | KH | KI | KIB | KL | KLE | KLZ | KM | KN | KO | KÖT | KR | KS | KT | KU | KÜN | KUS | KY | KYF | L | LA | LAU | LB | LBS | LBZ | LD | LDK | LDS | LEO | LER | LEV | LG | LI | LIF | LIP | LL | LM | LÖ | LÖB | LOS | LP | LRO | LSA | LSZ | LU | LUN | LWL | M | MA | MAB | MB | MC | MD | ME | MEI | MEK | MG | MGN | MH | MHL | MI | MIL | MKK | ML | MK | MM | MN | MO | MOL | MOS | MQ | MR | MS | MSH | MSP | MST | MTK | MTL | MÜ | MÜR | MW | MW | MYK | MZ | MZG | N | NB | ND | NDH | NE | NEA | NEB | NES | NEW | NF | NH | NI | NK | NM | NMB | NMS | NOH | NOL | NOM | NOR | NP | NR | NU | NVP | NW | NWM | NY | NZ | OA | OAL | OB | OBG | OC | OCH | OD | OE | OF | OG | OH | OHA | OHV | OHZ | OK | OL | OPR | OS | OSL | OVL | OVP | P | PA | PAF | PAN | PB | PCH | PE | PF | PI | PIR | PL | PLÖ | PM | PN | PR | PRÜ | PS | PW | QFT | QLB | R | RA | RC | RD | RDG | RE | REG | RG | RH | RI | RIE | RL | RM | RO | ROW | RP | RS | RSL | RT | RÜD | RÜG | RV | RW | RZ | S | SAB | SAD | SAW | SB | SBK | SC | SCZ | SDH | SDL | SE | SEB | SEE | SFA | SFB | SFT | SG | SGH | SHA | SHG | SHK | SHL | SI | SIG | SIM | SK | SL | SLF | SLK | SLN | SLS | SLÜ | SLZ | SM | SN | SO | SÖM | SOK | SON | SP | SPN | SR | SRB | SRO | ST | STA | STD | STL | SU | SÜW | SW | SZ | SZB | TBB | TDO | TE | TET | TF | TG | TIR | TO | TÖL | TR | TS | TÜ | TUT | UE | UEM | UER | UH | UL | UM | UN | USI | V | VB | VEC | VER | VG | VIE | VK | VR | VS | W | WAF | WAK | WAN | WAT | WB | WBS | WDA | WE | WEN | WES | WF | WHV | WI | WIL | WIS | WIT | WK | WL | WLG | WM | WMS | WN | WND | WO | WOB | WOH | WR | WSF | WST | WT | WTM | WÜ | WUG | WUN | WUR | WW | WZL | X | Y | Z | ZE | ZEL | ZI | ZP | ZR | ZW | ZZ)[\- ]((?:[a - z]{1, 2} [\- ]*\d{1,4}H?)|(9\d{3})|(\d{2,3}\-\d{1,3})[a-z]?)$/i,)/^0[\- ]\d{1,3}[\- ]\d{1,3}\w?$/i]");
        private Regex _germanRegex = new Regex(@"^[A-ZÄÖÜ]{1,3}\-[ ]{0,1}[A-Z]{0,2}[0-9]{1,4}[H]{0,1}");


        private string[] possibleAreasDE = "A|AA|AB|ABG|ABI|AC|AE|AD|AF|AIC|AK|ALF|AM|AN|ANA|ANK|AÖ|AP|APD|ARN|ART|AS|ASL|ASZ|AT|AU|AUR|AW|AZ|AZE|B|BA|BAD|BAR|BB|BBG|BC|BCH|BD|BED|BER|BF|BGL|BI|BID|BIN|BIR|BIT|BIW|BK|BKS|BL|BLB|BLK|BM|BN|BNA|BO|BÖ|BOR|BOT|BRA|BRB|BRG|BRL|BRV|BS|BT|BTF|BÜD|BÜS|BÜZ|BW|BWL|BYL|BZ|C|CA|CAS|CB|CE|CHA|CLP|CLZ|CO|COC|COE|CUX|CW|D|DA|DAH|DAN|DAU|DB|DBR|DD|DE|DEG|DEL|DGF|DH|DI|DIN|DL|DLG|DM|DN|DO|DON|DU|DÜW|DW|DZ|E|EA|EB|EBE|ECK|ED|EE|EF|EH|EI|EIC|EIL|EIN|EIS|EL|EM|EMD|EMS|EN|ER|ERB|ERH|ERZ|ES|ESW|EU|EW|F|FB|FD|FDS|FF|FFB|FG|FI|FL|FLO|FN|FO|FOR|FR|FRG|FRI|FRW|FS|FT|FTL|FÜ|G|GA|GAP|GC|GD|GDB|GE|GER|GEO|GF|GG|GHA|GHC|GI|GL|GLA|GM|GMN|GN|GNT|GÖ|GOA|GP|GR|GRH|GRZ|GS|GT|GTH|GUB|GÜ|GVM|GW|GZ|H|HA|HAL|HAM|HAS|HB|HBN|HBS|HC|HCH|HD|HDH|HDL|HE|HEF|HEI|HER|HET|HF|HG|HGN|HGW|HH|HHM|HI|HIG|HK|HK|HL|HM|HMÜ|HN|HO|HOG|HOL|HOM|HOT|HP|HR|HRO|HS|HSK|HST|HU|HVL|HWI|HX|HY|HZ|IGB|IK|IL|IN|IZ|J|JE|JL|JÜL|K|KA|KB|KC|KE|KEH|KF|KG|KH|KI|KIB|KL|KLE|KLZ|KM|KN|KO|KÖT|KR|KS|KT|KU|KÜN|KUS|KY|KYF|L|LA|LAU|LB|LBS|LBZ|LD|LDK|LDS|LEO|LER|LEV|LG|LI|LIF|LIP|LL|LM|LÖ|LÖB|LOS|LP|LRO|LSA|LSZ|LU|LUN|LWL|M|MA|MAB|MB|MC|MD|ME|MEI|MEK|MG|MGN|MH|MHL|MI|MIL|MKK|ML|MK|MM|MN|MO|MOL|MOS|MQ|MR|MS|MSH|MSP|MST|MTK|MTL|MÜ|MÜR|MW|MW|MYK|MZ|MZG|N|NB|ND|NDH|NE|NEA|NEB|NES|NEW|NF|NH|NI|NK|NM|NMB|NMS|NOH|NOL|NOM|NOR|NP|NR|NU|NVP|NW|NWM|NY|NZ|OA|OAL|OB|OBG|OC|OCH|OD|OE|OF|OG|OH|OHA|OHV|OHZ|OK|OL|OPR|OS|OSL|OVL|OVP|P|PA|PAF|PAN|PB|PCH|PE|PF|PI|PIR|PL|PLÖ|PM|PN|PR|PRÜ|PS|PW|QFT|QLB|R|RA|RC|RD|RDG|RE|REG|RG|RH|RI|RIE|RL|RM|RO|ROW|RP|RS|RSL|RT|RÜD|RÜG|RV|RW|RZ|S|SAB|SAD|SAW|SB|SBK|SC|SCZ|SDH|SDL|SE|SEB|SEE|SFA|SFB|SFT|SG|SGH|SHA|SHG|SHK|SHL|SI|SIG|SIM|SK|SL|SLF|SLK|SLN|SLS|SLÜ|SLZ|SM|SN|SO|SÖM|SOK|SON|SP|SPN|SR|SRB|SRO|ST|STA|STD|STL|SU|SÜW|SW|SZ|SZB|TBB|TDO|TE|TET|TF|TG|TIR|TO|TÖL|TR|TS|TÜ|TUT|UE|UEM|UER|UH|UL|UM|UN|USI|V|VB|VEC|VER|VG|VIE|VK|VR|VS|W|WAF|WAK|WAN|WAT|WB|WBS|WDA|WE|WEN|WES|WF|WHV|WI|WIL|WIS|WIT|WK|WL|WLG|WM|WMS|WN|WND|WO|WOB|WOH|WR|WSF|WST|WT|WTM|WÜ|WUG|WUN|WUR|WW|WZL|X|Y|Z|ZE|ZEL|ZI|ZP|ZR|ZW|ZZ".Split('|');

        private Regex districtRegex = new Regex(@"[/^(A|AA|AB|ABG|ABI|AC|AE|AD|AF|AIC|AK|ALF|AM|AN|ANA|ANK|AÖ|AP|APD|ARN|ART|AS|ASL|ASZ|AT|AU|AUR|AW|AZ|AZE|B|BA|BAD|BAR|BB|BBG|BC|BCH|BD|BED|BER|BF|BGL|BI|BID|BIN|BIR|BIT|BIW|BK|BKS|BL|BLB|BLK|BM|BN|BNA|BO|BÖ|BOR|BOT|BRA|BRB|BRG|BRL|BRV|BS|BT|BTF|BÜD|BÜS|BÜZ|BW|BWL|BYL|BZ|C|CA|CAS|CB|CE|CHA|CLP|CLZ|CO|COC|COE|CUX|CW|D|DA|DAH|DAN|DAU|DB|DBR|DD|DE|DEG|DEL|DGF|DH|DI|DIN|DL|DLG|DM|DN|DO|DON|DU|DÜW|DW|DZ|E|EA|EB|EBE|ECK|ED|EE|EF|EH|EI|EIC|EIL|EIN|EIS|EL|EM|EMD|EMS|EN|ER|ERB|ERH|ERZ|ES|ESW|EU|EW|F|FB|FD|FDS|FF|FFB|FG|FI|FL|FLO|FN|FO|FOR|FR|FRG|FRI|FRW|FS|FT|FTL|FÜ|G|GA|GAP|GC|GD|GDB|GE|GER|GEO|GF|GG|GHA|GHC|GI|GL|GLA|GM|GMN|GN|GNT|GÖ|GOA|GP|GR|GRH|GRZ|GS|GT|GTH|GUB|GÜ|GVM|GW|GZ|H|HA|HAL|HAM|HAS|HB|HBN|HBS|HC|HCH|HD|HDH|HDL|HE|HEF|HEI|HER|HET|HF|HG|HGN|HGW|HH|HHM|HI|HIG|HK|HK|HL|HM|HMÜ|HN|HO|HOG|HOL|HOM|HOT|HP|HR|HRO|HS|HSK|HST|HU|HVL|HWI|HX|HY|HZ|IGB|IK|IL|IN|IZ|J|JE|JL|JÜL|K|KA|KB|KC|KE|KEH|KF|KG|KH|KI|KIB|KL|KLE|KLZ|KM|KN|KO|KÖT|KR|KS|KT|KU|KÜN|KUS|KY|KYF|L|LA|LAU|LB|LBS|LBZ|LD|LDK|LDS|LEO|LER|LEV|LG|LI|LIF|LIP|LL|LM|LÖ|LÖB|LOS|LP|LRO|LSA|LSZ|LU|LUN|LWL|M|MA|MAB|MB|MC|MD|ME|MEI|MEK|MG|MGN|MH|MHL|MI|MIL|MKK|ML|MK|MM|MN|MO|MOL|MOS|MQ|MR|MS|MSH|MSP|MST|MTK|MTL|MÜ|MÜR|MW|MW|MYK|MZ|MZG|N|NB|ND|NDH|NE|NEA|NEB|NES|NEW|NF|NH|NI|NK|NM|NMB|NMS|NOH|NOL|NOM|NOR|NP|NR|NU|NVP|NW|NWM|NY|NZ|OA|OAL|OB|OBG|OC|OCH|OD|OE|OF|OG|OH|OHA|OHV|OHZ|OK|OL|OPR|OS|OSL|OVL|OVP|P|PA|PAF|PAN|PB|PCH|PE|PF|PI|PIR|PL|PLÖ|PM|PN|PR|PRÜ|PS|PW|QFT|QLB|R|RA|RC|RD|RDG|RE|REG|RG|RH|RI|RIE|RL|RM|RO|ROW|RP|RS|RSL|RT|RÜD|RÜG|RV|RW|RZ|S|SAB|SAD|SAW|SB|SBK|SC|SCZ|SDH|SDL|SE|SEB|SEE|SFA|SFB|SFT|SG|SGH|SHA|SHG|SHK|SHL|SI|SIG|SIM|SK|SL|SLF|SLK|SLN|SLS|SLÜ|SLZ|SM|SN|SO|SÖM|SOK|SON|SP|SPN|SR|SRB|SRO|ST|STA|STD|STL|SU|SÜW|SW|SZ|SZB|TBB|TDO|TE|TET|TF|TG|TIR|TO|TÖL|TR|TS|TÜ|TUT|UE|UEM|UER|UH|UL|UM|UN|USI|V|VB|VEC|VER|VG|VIE|VK|VR|VS|W|WAF|WAK|WAN|WAT|WB|WBS|WDA|WE|WEN|WES|WF|WHV|WI|WIL|WIS|WIT|WK|WL|WLG|WM|WMS|WN|WND|WO|WOB|WOH|WR|WSF|WST|WT|WTM|WÜ|WUG|WUN|WUR|WW|WZL|X|Y|Z|ZE|ZEL|ZI|ZP|ZR|ZW|ZZ)[\- ]((?:[a-z]{1,2}[\- ]*\d{1,4}H?)|(9\d{3})|(\d{2,3}\-\d{1,3})[a-z]?)$/i,/^0[\- ]\d{1,3}[\- ]\d{1,3}\w?$/i]");

        private string[] districts = new[] { "A","AA","AB","ABG","ABI","AC","AE","AD","AF","AIC","AK","ALF","AM","AN","ANA","ANK","AÖ","AP","APD","ARN","ART","AS","ASL","ASZ","AT","AU","AUR","AW","AZ","AZE",
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
        "M","MM","MA","MAB","MB","MC","MD","ME", "MEG", "MEI","MEK","MG","MGN","MH","MHL","MI","MIL","MKK","ML","MK","MN","MO","MOL","MOS","MQ","MR","MS","MSH","MSP","MST","MTK","MTL","MÜ","MÜR","MW","MYK","MZ","MZG",
        "N","NB","ND","NDH","NE","NEA","NEB","NES","NEW","NF","NH","NI","NK","NM","NMB","NMS","NOH","NOL","NOM","NOR","NP","NR","NU","NVP","NW","NWM","NY","NZ",
        "OA","OAL","OB","OBG","OC","OCH","OD","OE","OF","OG","OH","OHA","OHV","OHZ","OK","OL","OPR","OS","OSL","OVL","OVP",
        "P","PA","PAF","PAN","PB","PCH","PE","PF","PI","PIR","PL","PLÖ","PM","PN","PR","PRÜ","PS","PW",
        "QFT","QLB",
        "R","RA","RC","RD","RDG","RE","REG","RG","RH","RI","RIE","RL","RM","RO", "ROF", "ROW","RP","RS","RSL","RT","RÜD","RÜG","RV","RW","RZ",
        "S","SAB","SAW","SB","SBK","SC","SCZ","SDH","SDL","SE","SEB","SEE","SFA","SFB","SFT","SG","SGH","SHA","SHG","SHK","SHL","SI","SIG","SIM","SK","SL","SLF","SLK","SLN","SLS","SLÜ","SLZ","SM","SN","SO","SÖM","SOK","SON","SP","SPN","SR","SRB","SRO","ST","STA","STD","STL","SU","SÜW","SW","SZ","SZB", "SWA",
        "TBB","TDO","TE","TET","TF","TG","TIR","TO","TÖL","TR","TS","TÜ","TUT",
        "UE","UEM","UER","UH","UL","UM","UN","USI",
        "V","VB","VEC","VER","VG","VIE","VK","VR","VS",
        "W","WW","WAF","WAK","WAN","WAT","WB","WBS","WDA","WE","WEN","WES","WF","WHV","WI","WIL","WIS","WIT","WK","WL","WLG","WM","WMS","WN","WND","WO","WOB","WOH","WR","WSF","WST","WT","WTM","WÜ","WUG","WUN","WUR", "WZ", "WZL",
        "X",
        "Y",
        "Z","ZZ","ZE","ZEL","ZI","ZP","ZR","ZW"};

        public bool IsGermanPlate(string plate)
        {
            var matches = _germanRegex.IsMatch(plate);
            return matches;
        }

        public string getAreasRegex()
        {
            var joined = string.Join("|", districts);
            var regexString = $"^({joined})";
            return regexString;
        }

        public string GetFormattedLicenseFromUnformattedString(string licensePlate)
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
                if (RegexExtensions.Preg_match(new Regex(getAreasRegex() + "$"), district, out List<string> matches))
                {
                    if (district.Length >= letters_only_length - 2)
                    {
                        possible_districts = matches.ToArray();
                    }

                    if (possible_districts.Count() > 2)
                    {
                        var reindexed = new ArrayReindexer(possible_districts);
                        reindexed.Reindex(1, 1);
                    }
                }
            }

            var finalDistrict = possible_districts[0];
            var final_district_length = finalDistrict.Length;

            RegexExtensions.Preg_match_Special(new Regex(@"\D+"), licensePlate, out int number_matches);
            //var middle_part_length = number_matches.ToArray()[0][1] - final_district_length;
            var middle_part_length = number_matches - final_district_length;
            return $"{finalDistrict}-{licensePlate.Substring(final_district_length, middle_part_length)} {licensePlate.Substring(middle_part_length + final_district_length)}";
        }
    }
}
