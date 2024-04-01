using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOEditor.Lib;
using YGOEditor.Structure;

namespace YGOEditor.Extractor.Card
{
    public class CardDescBinExtractor : IExtractor
    {
        public List<CardDescBin> ListCardDescBin { get; set; } = new List<CardDescBin>();

        private List<YuGiDataEntry> data = new List<YuGiDataEntry>();
        public bool CheckName(YuGiDataEntry file)
        {
            if (file.FileName.Contains("card_desc"))
            {
                data.Add(file);
                return true;
            }
            return false;
        }

        public void Parse(byte[] bytes, string lang)
        {
            string dataText = YuGiEncoding.GetString(bytes, lang);
            string[] listDesc = dataText.Replace("\0\0", "\n").Replace("\0", "").Split('\n');
            int count = listDesc.Length;
            for (int i = 0; i < count; i++)
            {
                if (i >= ListCardDescBin.Count)
                {
                    ListCardDescBin.Add(new CardDescBin());
                }
                ListCardDescBin[i].Desc.Add(lang, listDesc[i]);
            }
        }

        public void Parse()
        {
            foreach (YuGiDataEntry entry in data)
            {
                string lang = entry.FileName.Substring(entry.FileName.Length - 7, 3);
                this.Parse(entry.Data, lang);
            }
        }
    }
    public class CardDescBin
    {
        public Dictionary<string, string> Desc = new Dictionary<string, string>();
    }
}
