using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGOEditor.Lib;
using YGOEditor.Structure;

namespace YGOEditor.Extractor.Card
{
    public class CardSortBinExtractor : IExtractor
    {
        private static readonly int MAX_SORT = 2034;

        private static readonly int BYTE_LENGTH = 2;

        public List<Dictionary<string, Int16>> OrderId = new List<Dictionary<string, Int16>>();

        private List<YuGiDataEntry> data = new List<YuGiDataEntry>();
        public bool CheckName(YuGiDataEntry file)
        {
            if (file.FileName.Contains("card_sort"))
            {
                data.Add(file);
                return true;
            }
            return false;
        }

        public void Parse(byte[] bytes, string lang)
        {
            int count = bytes.Length / BYTE_LENGTH;
            for (int i = 0; i < count; i++)
            {
                if (i >= OrderId.Count)
                {
                    OrderId.Add(new Dictionary<string, Int16>());
                }
                OrderId[i].Add(lang, BitConverter.ToInt16(bytes, i * 2));
            }
        }

        public void Parse()
        {
            foreach (YuGiDataEntry entry in data)
            {
                string lang = entry.FileName.Substring(entry.FileName.Length - 7, 3);
                this.Parse(entry.GetData(), lang);
            }
        }
    }
}
