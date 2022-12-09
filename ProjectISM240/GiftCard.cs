using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectISM240
{
    public partial class GiftCard : Form
    {
        public GiftCard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiftCardOrderCart gift1 = new GiftCardOrderCart();


            gift1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GiftCardPhysical gift2 = new GiftCardPhysical();


            gift2.ShowDialog();
        }
    }
}
