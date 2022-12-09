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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Order ord1 = new Order();


            ord1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GiftCard gif1 = new GiftCard();


            gif1.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reservations res1 = new Reservations();


            res1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu men1 = new Menu();


            men1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmailCollection mem1 = new EmailCollection();


            mem1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Events eve1 = new Events();


            eve1.ShowDialog();
        }
    }
}
