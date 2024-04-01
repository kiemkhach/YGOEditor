using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOEditor.Lib;
using YGOEditor.Structure;

namespace YGOEditor.Extractor.Card
{
    public class CardIdBinExtractor : IExtractor
    {
        private readonly int BYTE_LENGTH = 2;

        public List<Int16> ListCardIdBin = new List<Int16>();

        private List<YuGiDataEntry> data = new List<YuGiDataEntry>();
        public bool CheckName(YuGiDataEntry file)
        {
            if (file.FileName.Contains("card_id.bin"))
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
                byte[] bytes = entry.Data;
                for (int i = 0; i < bytes.Length / BYTE_LENGTH; i++)
                {
                    ListCardIdBin.Add(BitConverter.ToInt16(bytes, i * BYTE_LENGTH));
                }
                break;
            }
        }
        public void Parse(byte[] bytes, string lang)
        {
            throw new NotImplementedException();
        }
    }
}
