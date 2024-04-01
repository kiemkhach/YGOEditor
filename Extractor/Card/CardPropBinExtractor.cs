using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using YGOEditor.Structure;
using static System.Net.WebRequestMethods;

namespace YGOEditor.Extractor.Card
{
    public class CardPropBinExtractor : IExtractor
    {
        private static List<string> ATTRIBUTES = new List<string>() {
            "", "", "light", "light", "dark", "dark", "warter", "warter",
            "fire", "fire", "earth", "earth", "wind", "wind", "", "",
        };

        private static List<(string, string)> TYPES = new List<(string, string)>() {
            ("winged beast" , ""           ),
            ("dragon"       , "fairy"      ),
            ("zombie"       , "spellcaster"),
            ("fiend"        , "thunder"    ),
            ("pyro"         , "replite"    ),
            ("sea serpent"  , "trapcard"   ),
            ("rock"         , "spellcard"  ),
            ("machine"      , ""           ),
            ("fish"         , ""           ),
            ("dinosauor"    , ""           ),
            ("Insect"       , ""           ),
            ("beast"        , ""           ),
            ("beast warrior", ""           ),
            ("plant"        , ""           ),
            ("aqua"         , ""           ),
            ("warrior"      , ""           )
        };

        private readonly int BYTE_LENGTH = 4;

        public List<CardProperty> ListCardPropBin { get; set; } = new List<CardProperty>();

        private List<YuGiDataEntry> data = new List<YuGiDataEntry>();
        public bool CheckName(YuGiDataEntry file)
        {
            if (file.FileName.Contains("card_prop.bin"))
            {
                data.Add(file);
                return true;
            }
            return false;
        }

        public void Parse()
        {
            foreach (YuGiDataEntry entry in data)
            {
                Parse(entry.Data, "eng");
                break;
            }
        }
        public void Parse(byte[] bytes, string lang)
        {
            for (int i = 0; i < bytes.Length / BYTE_LENGTH; i++)
            {
                String hex = BitConverter.ToString(bytes, i * 4, 4).Replace("-", "");
                int[] arr = hex.Select(h => Convert.ToInt32(h.ToString(), 16)).ToArray();
                ListCardPropBin.Add(new CardProperty()
                {
                    Atk   = arr[2] * 80 + (arr[3] - (arr[3] % 2)) * 5 + 1280 * (arr[5] % 4),
                    Def   = arr[0] * 160 + arr[1] * 10 + (arr[3] % 2)*2560,
                    Atb   = ATTRIBUTES[arr[6]],
                    Type  = arr[7] % 2 == 0 ? TYPES[arr[4]].Item1 : TYPES[arr[4]].Item2,
                    Level = (arr[7] / 2) + (arr[6] % 2)*8,
                });
            }
        }
    }

    public class CardProperty
    {
        public int Atk { get; set; }
        public int Def { get; set; }
        public string Atb { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }
    }
}
