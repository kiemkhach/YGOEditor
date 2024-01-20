using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOEditor.Lib;
using YGOEditor.Structure;

namespace YGOEditor.Extractor.Card
{
    public class CardNameBinExtractor : IExtractor
    {
        private static readonly int NAME_LENGTH = 64;
        public List<CardNameBin> ListCardNameBin { get; set; } = new List<CardNameBin>();

        private List<YuGiDataEntry> data = new List<YuGiDataEntry>();

        public bool CheckName(YuGiDataEntry file)
        {
            if (file.FileName.Contains("card_name"))
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
                string lang = entry.FileName.Substring(entry.FileName.Length - 7, 3);
                this.Parse(entry.GetData(), lang);
            }
        }

        public void Parse(byte[] bytes, string lang)
        {
            string dataText = YuGiEncoding.GetString(bytes, lang);
            int count = dataText.Length / NAME_LENGTH;
            for (int i = 0; i < count; i++)
            {
                if (i >= ListCardNameBin.Count)
                {
                    ListCardNameBin.Add(new CardNameBin());
                }
                ListCardNameBin[i].Name.Add(lang, dataText.Substring(i * NAME_LENGTH, NAME_LENGTH).Trim('\0'));
            }
        }
    }

    public class CardNameBin
    {
        public Dictionary<string, string> Name = new Dictionary<string, string>();
    }
}
