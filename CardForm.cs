using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YGOEditor.Structure;

namespace YGOEditor
{
    public partial class CardForm : Form
    {
        private YuGiCardCollection _cards;
        public CardForm(YuGiData data)
        {
            _cards = new YuGiCardCollection(data);
            InitializeComponent();
        }

        private void CardForm_Load(object sender, EventArgs e)
        {
            cbbLang.SelectedIndex = 0;
            _cards.BuildCollection();
            yuGiCardBindingSource.ResetBindings(false);
            yuGiCardBindingSource.DataSource = _cards.Cards;
        }

        private void CardList_SelectionChanged(object sender, EventArgs e)
        {
            if (CardList.SelectedRows.Count != 0)
            {
                YuGiCard yuGiCard = _cards.Cards[CardList.SelectedRows[0].Index];

                

            }
        }

        private void cbbLang_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var card in _cards.Cards)
            {
                card.Lang = cbbLang.Text;
            }
            yuGiCardBindingSource.ResetBindings(false);
        }
    }
}
