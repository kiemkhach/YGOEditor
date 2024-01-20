using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YGOEditor.Structure;

namespace YGOEditor.Extractor.Card
{
    public class CardImageExtractor : IExtractor
    {
        private readonly string CARD_IMAGE_NAME_PATTREN = @"^card\\[\d\w_]+\.bmp";

        private readonly string CARD_MINI_IMAGE_NAME_PATTREN = @"^mini\\[\d\w_]+\.bmp";

        private List<YuGiDataEntry> data = new List<YuGiDataEntry>();

        private Regex regex;

        private Regex regexMini;

        public Dictionary<string, Image> images = new Dictionary<string, Image>();

        public Dictionary<string, Image> imagesMini = new Dictionary<string, Image>();

        public CardImageExtractor()
        {
            regex = new Regex(CARD_IMAGE_NAME_PATTREN);
            regexMini = new Regex(CARD_MINI_IMAGE_NAME_PATTREN);
        }

        public bool CheckName(YuGiDataEntry file)
        {
            if (regex.IsMatch(file.FileName) || regexMini.IsMatch(file.FileName))
            {
                data.Add(file);
                return true;
            }
            return false;
        }

        public void Parse(byte[] bytes, string path)
        {
            using (var ms = new MemoryStream(bytes))
            {
                Dictionary<string, Image> imagesList = path.Contains("card\\") ? images : imagesMini;
                string name = path.Split('\\')[1];
                imagesList[name] = Image.FromStream(ms);
            }
        }

        public void Parse()
        {
            foreach (YuGiDataEntry entry in data)
            {
                Parse(entry.GetData(), entry.FileName);
            }
        }
    }
}
