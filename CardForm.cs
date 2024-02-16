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
using static System.Net.WebRequestMethods;

namespace YGOEditor
{
    public partial class CardForm : Form
    {
        private YuGiCardList cards;
        public CardForm(YuGiData data)
        {
            cards = new YuGiCardList(data);
            InitializeComponent();
        }

        private void CardForm_Load(object sender, EventArgs e)
        {
            cbbLang.SelectedIndex = 0;
            yugiCardBindingSource.ResetBindings(false);
            yugiCardBindingSource.DataSource = cards;
        }


        private void CbbLang_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (var card in cards)
            {
                card.Lang = cbbLang.Text;
            }
            yugiCardBindingSource.ResetBindings(false);
        }

        private void TsbFilter_Click(object sender, EventArgs e)
        {
            if ((yugiCardBindingSource.Filter == null) || (yugiCardBindingSource.Filter == "")) {
                yugiCardBindingSource.Filter = "CardImageName = 'token_sl.bmp'";
            } else
            {
                yugiCardBindingSource.Filter = "";
            }
            
            //yuGiCardBindingSource.ResetBindings(false);
            dgCardList.Refresh();
        }
    }
}
