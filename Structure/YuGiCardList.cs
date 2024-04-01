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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            set { _data = value; Initialize(); Parse(); }
        }
        public List<IExtractor> CardExtractors { get; set; }
        ListCardBinExtractor listCardBinExtractor;
        CardNameBinExtractor cardNameBinExtractor;
        CardDescBinExtractor cardDescBinExtractor;
        CardIdBinExtractor   cardIdBinExtractor;
        CardImageExtractor   cardImageExtractor;
        CardIndxBinExtractor cardIndxBinExtractor;
        CardPackBinExtractor cardPackBinExtractor;
        CardPassBinExtractor cardPassBinExtractor;
        CardPropBinExtractor cardPropBinExtractor;
        CardSortBinExtractor cardSortBinExtractor;

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
                    funcGetImage = cardImageExtractor.GetImage,
                    funcSetImage = cardImageExtractor.UpSertCardImage,
                };
                this.Cards.Add(card);
                this.Items.Add(card);
            }
        }

        public void Initialize()
        {
            listCardBinExtractor = new ListCardBinExtractor();
            cardNameBinExtractor = new CardNameBinExtractor();
            cardDescBinExtractor = new CardDescBinExtractor();
            cardIdBinExtractor   = new CardIdBinExtractor()  ;
            cardImageExtractor   = new CardImageExtractor()  ;
            cardIndxBinExtractor = new CardIndxBinExtractor();
            cardPackBinExtractor = new CardPackBinExtractor();
            cardPassBinExtractor = new CardPassBinExtractor();
            cardPropBinExtractor = new CardPropBinExtractor();
            cardSortBinExtractor = new CardSortBinExtractor();
            Cards.Clear();
            this.Items.Clear();

            CardExtractors = new List<IExtractor> {
                listCardBinExtractor,
                cardNameBinExtractor,
                cardDescBinExtractor,
                cardIdBinExtractor  ,
                cardImageExtractor  ,
                cardIndxBinExtractor,
                cardPackBinExtractor,
                cardPassBinExtractor,
                cardPropBinExtractor,
                cardSortBinExtractor,
            };

            cardImageExtractor.funcUpdateFileEntry = _data.UpdateEntry;
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
