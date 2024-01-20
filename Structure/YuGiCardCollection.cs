using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOEditor.Extractor.Card;

namespace YGOEditor.Structure
{
    public class YuGiCardCollection
    {
        public List<YuGiCard> Cards { get; set; } = new List<YuGiCard>();
        public YuGiData Data { get; set; }
        public List<IExtractor> CardExtractors { get; set; } = new List<IExtractor> { 
            new ListCardBinExtractor(),
            new CardNameBinExtractor(),
            new CardDescBinExtractor(),
            new CardIdBinExtractor(),
            new CardImageExtractor(),
            new CardIndxBinExtractor(),
            new CardPackBinExtractor(),
            new CardPassBinExtractor(),
            new CardPropBinExtractor(),
            new CardSortBinExtractor()
        };

        public YuGiCardCollection(YuGiData data) { 
            Data = data;
            Parse();
        }

        private void Parse()
        {            
            foreach (var item in Data.Files)
            {
                foreach (var extractor in CardExtractors)
                {
                    extractor.CheckName(item);
                }
            }
            foreach (var extractor in CardExtractors)
            {
                extractor.Parse();
            }

        }

        public void BuildCollection()
        {
            ListCardBinExtractor listCardBinExtractor = (ListCardBinExtractor)CardExtractors[0];
            CardNameBinExtractor cardNameBinExtractor = (CardNameBinExtractor)CardExtractors[1];
            CardDescBinExtractor cardDescBinExtractor = (CardDescBinExtractor)CardExtractors[2];
            CardIdBinExtractor   cardIdBinExtractor   = (CardIdBinExtractor)CardExtractors[3];
            CardImageExtractor   cardImageExtractor   = (CardImageExtractor)CardExtractors[4];
            CardIndxBinExtractor cardIndxBinExtractor = (CardIndxBinExtractor)CardExtractors[5];
            CardPackBinExtractor cardPackBinExtractor = (CardPackBinExtractor)CardExtractors[6];
            CardPassBinExtractor cardPassBinExtractor = (CardPassBinExtractor)CardExtractors[7];
            CardPropBinExtractor cardPropBinExtractor = (CardPropBinExtractor)CardExtractors[8];
            CardSortBinExtractor cardSortBinExtractor = (CardSortBinExtractor)CardExtractors[9];
            int cardNumer = listCardBinExtractor.ListCardBinEntries.Count;
            for (int idx = 0; idx < cardNumer; idx++)
            {
                YuGiCard card = new YuGiCard() 
                {
                    BasicInfo = listCardBinExtractor.ListCardBinEntries[idx],
                    Name = cardNameBinExtractor.ListCardNameBin[idx],
                    Desc = cardDescBinExtractor.ListCardDescBin[idx],
                    Id = cardIdBinExtractor.ListCardIdBin[idx],
                    DescOffest = cardIndxBinExtractor.ListCardIndxBin[idx],
                    Pack = cardPackBinExtractor.CardPacksBin[idx],
                    Password = cardPassBinExtractor.ListCardPassBin[idx],
                    Properties = cardPropBinExtractor.ListCardPropBin[idx],
                    OrderId = cardSortBinExtractor.OrderId[idx],
                    Images = cardImageExtractor.images,
                    ImagesMini = cardImageExtractor.imagesMini,
                };
                this.Cards.Add(card);
            }
        }
    }
}
