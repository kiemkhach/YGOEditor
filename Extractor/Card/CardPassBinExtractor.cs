using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOEditor.Structure;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace YGOEditor.Extractor.Card
{
    public class CardPassBinExtractor : IExtractor
    {
        private readonly int BYTE_LENGTH = 4;

        public List<String> ListCardPassBin = new List<String>();

        private List<YuGiDataEntry> data = new List<YuGiDataEntry>();
        public bool CheckName(YuGiDataEntry file)
        {
            if (file.FileName.Contains("card_pass.bin"))
            {
                data.Add(file);
                return true;
            }
            return false;
        }

        public void Parse(byte[] bytes, string lang)
        {
            for (int i = 0; i < bytes.Length / BYTE_LENGTH; i++)
            {
                ListCardPassBin.Add(BitConverter.ToString(bytes, i * 4, 4).Replace("-", ""));
            }
        }

        public void Parse()
        {
            foreach (YuGiDataEntry entry in data)
            {
                Parse(entry.GetData(), "eng");
                break;
            }
        }
    }
}
