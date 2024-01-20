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
    public class CardIndxBinExtractor : IExtractor
    {
        private static readonly int INDX_LENGTH = 4;

        private static readonly int MAX_INDX = 2048;
        public List<CardIndxBin> ListCardIndxBin { get; set; } = new List<CardIndxBin>();

        private List<YuGiDataEntry> data = new List<YuGiDataEntry>();
        public bool CheckName(YuGiDataEntry file)
        {
            if (file.FileName.Contains("card_indx"))
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
                Parse(entry.GetData(), lang);
            }
            
        }

        public void Parse(byte[] bytes, string lang)
        {
            int count = bytes.Length / INDX_LENGTH;
            for (int i = 0; i < count; i++)
            {
                if (i >= ListCardIndxBin.Count)
                {
                    ListCardIndxBin.Add(new CardIndxBin());
                }
                ListCardIndxBin[i].Offset.Add(lang, BitConverter.ToInt32(bytes, i*4));
            }
        }
    }

    public class CardIndxBin
    {
        public Dictionary<string, int> Offset = new Dictionary<string, int>();
    }
}
