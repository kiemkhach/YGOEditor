using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using YGOEditor.Extractor.Card;

namespace YGOEditor.Structure
{
    public class YuGiCardList: FilterBindingList<YuGiCard>
    {
        #region CustomDefinition
        public YuGiCardList() { }
        public YuGiCardList(YuGiData data)
        {
            Data = data;
        }
        public List<YuGiCard> Cards { get; private set; } = new List<YuGiCard>();

        private YuGiData _data;
        public YuGiData Data { 
            get {  return _data; }
            set { _data = value; Parse(); Initialize();  }
        }
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

        private void Parse()
        {
            foreach (var item in Data)
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

        public void Initialize()
        {
            ListCardBinExtractor listCardBinExtractor = (ListCardBinExtractor)CardExtractors[0];
            CardNameBinExtractor cardNameBinExtractor = (CardNameBinExtractor)CardExtractors[1];
            CardDescBinExtractor cardDescBinExtractor = (CardDescBinExtractor)CardExtractors[2];
            CardIdBinExtractor cardIdBinExtractor = (CardIdBinExtractor)CardExtractors[3];
            CardImageExtractor cardImageExtractor = (CardImageExtractor)CardExtractors[4];
            CardIndxBinExtractor cardIndxBinExtractor = (CardIndxBinExtractor)CardExtractors[5];
            CardPackBinExtractor cardPackBinExtractor = (CardPackBinExtractor)CardExtractors[6];
            CardPassBinExtractor cardPassBinExtractor = (CardPassBinExtractor)CardExtractors[7];
            CardPropBinExtractor cardPropBinExtractor = (CardPropBinExtractor)CardExtractors[8];
            CardSortBinExtractor cardSortBinExtractor = (CardSortBinExtractor)CardExtractors[9];
            int cardNumer = listCardBinExtractor.ListCardInfo.Count;
            for (int idx = 0; idx < cardNumer; idx++)
            {
                YuGiCard card = new YuGiCard()
                {
                    BasicInfo = listCardBinExtractor.ListCardInfo[idx],
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
                this.Items.Add(card);
            }
        }
        #endregion CustomDefinition


        #region ImplementBidingList
        protected override FilterBindingList<YuGiCard> NewInstance()
        {
            return new YuGiCardList();
        }

        protected override IEnumerable GetOriginList()
        {
            return Cards;
        }

        protected override int CountOrigin()
        {
            return Cards.Count;
        }

        protected override void AddOrigin(YuGiCard o)
        {
            Cards.Add(o);
        }

        protected override void RemoveOrigin(int index)
        {
            Cards.RemoveAt(index);
        }
        #endregion ImplementBidingList

    }

}
