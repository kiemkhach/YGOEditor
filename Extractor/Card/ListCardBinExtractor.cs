using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using YGOEditor.Lib;
using YGOEditor.Structure;

namespace YGOEditor.Extractor.Card
{
    public class CardBasicInfo
    {
        public string Name { get; set; }
        public int Idx { get; set; }
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Note { get; set; }
        public string FileType { get; set; }
    }
    public class ListCardBinExtractor : IExtractor
    {
        private static readonly string TEMPLATE = @"\/\/\t([^\r]*)\r\n\/\/\t(\d{4})\:\[(\d{4})\]\s?(Back)?\r\n([^\r]*)\r\n";
        public List<CardBasicInfo> ListCardInfo { get; set; } = new List<CardBasicInfo>();
        
        private List<YuGiDataEntry> data = new List<YuGiDataEntry>();

        /*public YuGiData<YuGiDataEntry> AllData { get; set; }

        public ListCardBinExtractor(YuGiData<YuGiDataEntry> allData)
        {
            AllData = allData;
        }*/

        public bool CheckName(YuGiDataEntry file)
        {
            if (file.FileName.Contains("list_card.txt"))
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
                this.Parse(entry.GetData(), "eng");
                break;
            }
        }

        public void Parse(byte[] bytes, string lang)
        {
            string dataText = Encoding.UTF8.GetString(bytes);
            if (string.IsNullOrEmpty(dataText))
            {
                return;
            }
            Regex regex = new Regex(TEMPLATE);
            MatchCollection match = regex.Matches(dataText);
            bool flag;
            foreach (Match item in match)
            {
                string[] str = item.Value.Split('\n');
                flag = int.TryParse(item.Groups[2].Value, out int idx);
                flag = int.TryParse(item.Groups[3].Value, out int id);

                ListCardInfo.Add(new CardBasicInfo
                {
                    Name = item.Groups[1].Value,
                    Idx = idx,
                    Id = id,
                    FileName = item.Groups[5].Value,
                    Note = item.Groups[4].Value,
                    FileType = item.Groups[5].Value.Split('.')[1]
                });

            }
        }
    }
}
