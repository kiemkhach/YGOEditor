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
        }
        public string CardDesc
        {
            get { return Desc.Desc[Lang]; }
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
            get { return Images[BasicInfo.FileName.ToLower()]; }
        }

        public string CardImageName
        {
            get { return BasicInfo.FileName; }
        }

        public string CardImageType
        {
            get { return BasicInfo.FileType; }
        }

        public Image CardImageMini
        {
            get { return ImagesMini[BasicInfo.FileName.ToLower()]; }
        }

        public string CardImageNameMini
        {
            get { return BasicInfo.FileName; }
        }

        public string CardImageMiniType
        {
            get { return BasicInfo.FileType; }
        }

        public CardInfo BasicInfo { private get; set; }

        public CardDescBin Desc { private get; set; }

        public CardIndxBin DescOffest { private get; set; }

        public CardNameBin Name { private get; set; }

        public CardProperty Properties { private get; set; }

        public Int32 Pack { private get; set; }

        public Int32 Id { private get; set; }

        public String Password { private get; set; }

        public Dictionary<string, Int16> OrderId { private get; set; }

        public Dictionary<string, Image> Images { private get; set; }

        public Dictionary<string, Image> ImagesMini { private get; set; }
    }
}
