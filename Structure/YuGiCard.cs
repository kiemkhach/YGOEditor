using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using YGOEditor.Extractor.Card;

namespace YGOEditor.Structure
{
    public class YuGiCard
    {
        public string Lang { get; set; } = "eng";
        public int CardIdx
        {
            get { return BasicInfo.Idx; }
        }
        public int CardId
        {
            get { return BasicInfo.Id; }
        }
        public string CardName {
            get { return Name.Name[Lang]; }
            set
            {
                Name.Name[Lang] = value;
                if (Lang == "eng") { BasicInfo.Name = value; }
            }
        }
        public string CardDesc
        {
            get { return Desc.Desc[Lang]; }
            set
            {
                Desc.Desc[Lang] = value;
            }
        }

        public int CardDescOffset
        {
            get { return DescOffest.Offset[Lang]; }
        }

        public int CardAtk
        {
            get { return Properties.Atk; }
        }

        public int CardDef
        {
            get { return Properties.Def; }
        }

        public string CardAtb
        {
            get { return Properties.Atb; }
        }

        public string CardType
        {
            get { return Properties.Type; }
        }

        public int CardLevel
        {
            get { return Properties.Level; }
        }

        public int CardPack
        {
            get { return Pack; }
        }

        public String CardPassword
        {
            get { return Password; }
        }

        public int CardOrderId
        {
            get { return OrderId[Lang]; }
        }

        public Image CardImage
        {
            get { return funcGetImage(BasicInfo.FileName.ToLower(), false); }
        }

        public string CardImageName
        {
            get { return BasicInfo.FileName; }
        }

        public Image CardImageMini
        {
            get { return funcGetImage(BasicInfo.FileMiniName.ToLower(), true); }
        }

        public string CardImageNameMini
        {
            get { return BasicInfo.FileMiniName; }
        }

        public CardBasicInfo BasicInfo { private get; set; }

        public CardDescBin Desc { private get; set; }

        public CardIndxBin DescOffest { private get; set; }

        public CardNameBin Name { private get; set; }

        public CardProperty Properties { private get; set; }

        public Int32 Pack { private get; set; }

        public Int32 Id { private get; set; }

        public String Password { private get; set; }

        public Dictionary<string, Int16> OrderId { private get; set; }

        public Func<string, bool, Image> funcGetImage;

        public Func<Image, string, string, bool, bool> funcSetImage;
    }
}
