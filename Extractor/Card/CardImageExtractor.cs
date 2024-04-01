using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

        private Dictionary<string, YuGiDataEntry> data = new Dictionary<string, YuGiDataEntry>();

        private Regex regex;

        private Regex regexMini;

        private Dictionary<string, Image> images = new Dictionary<string, Image>();

        private Dictionary<string, Image> imagesMini = new Dictionary<string, Image>();

        // 0 => not change; -1 => deleted; 1 => change; 2 => new
        private Dictionary<string, int> flagChange = new Dictionary<string, int>();

        public Func<string, byte[], YuGiDataEntry> funcUpdateFileEntry;

        public CardImageExtractor()
        {
            regex = new Regex(CARD_IMAGE_NAME_PATTREN);
            regexMini = new Regex(CARD_MINI_IMAGE_NAME_PATTREN);
        }

        public bool CheckName(YuGiDataEntry file)
        {
            if (regex.IsMatch(file.FileName) || regexMini.IsMatch(file.FileName))
            {
                data.Add(file.FileName, file);
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
            foreach (KeyValuePair<string, YuGiDataEntry> entry in data)
            {
                Parse(entry.Value.Data, entry.Key);
            }
        }

        public bool UpSertCardImage(Image img, string name, string oldName = "", bool isMini = false)
        {
            if (name == null || name == "")
            {
                return false;
            }
            string path = (isMini ? "mini\\" : "card\\") + name;
            string oldPath = (isMini ? "mini\\" : "card\\") + oldName;
            if (!new List<string>(new string[] { "", "token_sl.bmp", name }).Any(oldName.Contains))
            {
                if (flagChange[oldPath] == 2)
                {
                    flagChange.Remove(oldPath);
                } else {
                    flagChange[oldPath] = -1;
                }
            }
            flagChange[path] = (flagChange.ContainsKey(path) && flagChange[path] != 2) ? 1 : 2;
            if (isMini)
            {
                imagesMini[name] = img;
            }
            else
            {
                images[name] = img;
            }
            return true;

            /*using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return funcNewFileEntry(path, ms.ToArray());
            }*/
        }

        public Image GetImage(string name, bool isMini)
        {
            return isMini ? imagesMini[name] : images[name];
        }

        public void Save()
        {
            foreach (KeyValuePair<string, int> entry in flagChange)
            {
                string path = entry.Key;
                Dictionary<string, Image> imagesList = path.Contains("card\\") ? images : imagesMini;
                string name = path.Split('\\')[1];
                Image img = imagesList[name];

                switch (entry.Value)
                {
                    case -1:
                        funcUpdateFileEntry(path, null);
                        break;
                    case 0:
                        break;
                    case 1:
                    case 2:
                        using (var ms = new MemoryStream())
                        {
                            
                            img.Save(ms, img.RawFormat);
                            funcUpdateFileEntry(path, ms.ToArray());
                        }
                        break;
                }
            }
        }
    }
}
