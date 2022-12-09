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
    public partial class Order : Form
    {//  declarations for form 
        const decimal LATTE = 3.00m; //cost of latte 
        const decimal TEA = 3.00m; // cost of tea 
        const decimal AMERICANO = 3.00m; // cost of american 
        const decimal CAPPUCINO = 3.00m; // cost of cappucino 
        const decimal EXPRESSO = 3.00m; // cost of expresso
        const decimal MACCHIATO = 3.00m; // cost of machiato
        const decimal HOT_CHOCOLATE = 3.00m; // cost of hot chocolate
        const decimal CARAMEL = 0.50m; // additional caramel cost
        const decimal NUTELLA = 0.50m; // additional nutella cost    
        const decimal STRAWBERRY_BANANA = 5.00m; // cost of strawberry banana smoothie
        const decimal BERRY_BLAST = 5.00M; // cost of berry blast smoothie
        const decimal PINA_COLADA = 5.00m; // cost of pina colada smoothie
        const decimal ALMOND_MILK = 0.00m; // additional almond milk
        const decimal OAT_MILK = 0.00m; // additional oat milk
        const decimal WHOLE_MILK= 0.00m; // additional whole milk
        const decimal ICEBOX = 2.00m; // cost of icebox cookies
        const decimal LEMON_BARS = 2.00m; // cost of lemon bars cookies
        const decimal BROWNIES = 2.00m; // cost of brownies cookies
        const decimal SPRITZ = 2.00m; // cost of spritz cookies
        const decimal HONEY_TWILES = 2.00m; // cost of honey twiles cookies
        const decimal CHOCOLATE_CHIP = 2.00m; // cost of chocolate chip cookies
        const decimal MACAROONS = 2.00m; // cost of macaroons cookies
        const decimal BISCOTTI = 2.00m; // cost of biscotti cookies
        const decimal SUGAR = 2.00m; // cost of sugar cookies
        const decimal SPECULAAS = 2.00m; // cost of speculaas cookies
        const decimal BLUEBERRY_MUFFIN = 2.00m; // cost of blueberry muffins
        const decimal CRANBERRY = 2.00m; // cost of cranberry muffins
        const decimal CHOCOLATE_CHIP_MUFFINS = 2.000m; // cost of chocolate chip muffins
        const decimal MYSTERY = 2.00m; // cost of mystery muffins
        const decimal BRAN = 2.00m; // cost of bran muffins
        const decimal APPLE_CINNAMON = 2.00m; // cost of apple cinnamon muffins
        const decimal BANANA_NUT = 2.00m; // cost of banana nut muffins
        const decimal APPLE_FRITTER = 4.00m; // cost of apple fritter
        const decimal FRENCH_CRULLER = 4.00m; // cost of french cruller
        const decimal FROSTED_DOUGHNUT = 2.00m; // cost of frosted doughnut
        const decimal GLAZED_DOUGHNUT = 2.00m; // cost of glazed doughnut
        const decimal SUFGANIYAH = 2.00m; // cost of jelly filled sufganiyah
        const decimal TURNOVERS = 2.00m; // cost of turnovers
        const decimal PALMIERS = 2.00m; // cost of palmiers
        const decimal CROISSANTS = 2.00m; // cost of croissants
        const decimal BANANA_NUT_BREAD = 2.00m; // cost of banana nut bread
        const decimal BAGEL = 2.00m; // cost of bagel
        const decimal BLUEBERRY = 0.00m; // jelly filling option
        const decimal RASPBERRY = 0.00m; // jelly filling option
        const decimal STRAWBERRY = 0.00m; // jelly filling option
        const decimal EVERYTHING_BAGEL = 0.00m; // bagel bread option
        const decimal CINNAMON_RASISIN_BAGEL = 0.00m; // bagel bread option
        const decimal CHOCOLATE_CHIP_BAGEL = 0.00m; // bagel bread option
        const decimal BOYSENBERRY_CHEESECAKE = 4.00m; // cost of cheesecake
        const decimal CHOCOLATE_RASPBERRY_TART = 4.00m; // cost of tart
        const decimal CARROT_CAKE = 4.00m; // cost of carrot cake
        const decimal POUND_CAKE = 4.00m; // cost of pound cake
        const decimal CHOCOLATE_CAKE = 4.00m; // cost of chocolate cake
        const decimal BLUEBERRY_SCONES = 4.00m; // cost of scones
        const decimal STICKY_BUNS = 4.00m; // cost of sticky buns
        const decimal CREAM_CHEESE_DANISH = 4.00m; // cost of danish
        const decimal OVEN_ROASTED_TURKEY_BACON_PROVOLONE = 10.00m; // cost of sandwich
        const decimal ANGUS_ROAST_BEEF_COLBY_JACK = 9.00m; // cost of sandwich
        const decimal CHICKEN_CORDON_BLEU_PANINI= 7.00m; // cost of sandwich
        const decimal MONTE_CRISTO = 6.00m; // cost of sandwich
        const decimal BLT = 4.00m; // cost of sandwich
        const decimal CIABATTA = 1.50m; // type of bread for sandwich
        const decimal RYE = 1.50m; // type of bread for sandwich
        const decimal FRENCH = 0.00m; // type of bread for sandwich
        const decimal ITALIAN_HERB_CHEESE = 0.00M; // type of bread for sandwich
        const decimal TAX_RATE = 2.25m; // taxes

        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This method returns the cost of the items selected for the order
            decimal subtotal = 0.00m;
            decimal tax = 0.00m;
            decimal total = 0.00m;
            decimal discount = 0.00m;

            subtotal = OrderCost() + ToppingCost();
            tax = CalcTax(subtotal);
            total = subtotal + tax;

            this.subtotal.Text = subtotal.ToString("c");
            this.tax.Text = tax.ToString("c");
            this.total.Text = total.ToString("c");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subtotal.Text = "";
            total.Text = "";
            tax.Text = "";
        
        }

        //This method returns the cost of the order price


        private decimal OrderCost()

        {
            decimal OrderCost = 0;

            //select an item to order

            if (lattecheckBox.Checked)
            {
                OrderCost += LATTE;
            }
            if (teacheckBox.Checked)
            {
                OrderCost += TEA;
            }
            if (americanocheckBox.Checked)
            {
                OrderCost += AMERICANO;
            }
            if (cappucinocheckBox.Checked)
            {
                OrderCost += CAPPUCINO;
            }
            if (expressocheckBox.Checked)
            {
                OrderCost += EXPRESSO;
            }
            if (macchiatocheckBox.Checked)
            {
                OrderCost += MACCHIATO;
            }
            if (hotchocolatecheckBox.Checked)
            {
                OrderCost += HOT_CHOCOLATE;
            }
            if (caramelcheckBox.Checked)
            {
                OrderCost += CARAMEL;
            }
            if (nutellacheckBox.Checked)
            {
                OrderCost += NUTELLA;
            }
            if (strawberrybananacheckBox.Checked)
            {
                OrderCost += STRAWBERRY_BANANA;
            }
            if (berryblastcheckBox.Checked)
            {
                OrderCost += BERRY_BLAST;
            }
            if (pinacoladacheckBox.Checked)
            {
                OrderCost += PINA_COLADA;
            }
            if (iceboxcheckBox.Checked)
            {
                OrderCost += ICEBOX;
            }
            if (lemonbarscheckBox.Checked)
            {
                OrderCost += LEMON_BARS;
            }
            if (browniescheckBox.Checked)
            {
                OrderCost += BROWNIES;
            }
            if (spritzcheckBox.Checked)
            {
                OrderCost += SPRITZ;
            }
            if (honeytwilescheckBox.Checked)
            {
                OrderCost += HONEY_TWILES;
            }
            if (chocolatechipcheckBox.Checked)
            {
                OrderCost += CHOCOLATE_CHIP;
            }
            if (macaroonscheckBox.Checked)
            {
                OrderCost += MACAROONS;
            }
            if (biscotticheckBox.Checked)
            {
                OrderCost += BISCOTTI;
            }
            if (sugarcheckBox.Checked)
            {
                OrderCost += SUGAR;
            }
            if (speculaascheckBox.Checked)
            {
                OrderCost += SPECULAAS;
            }
            if (blueberrymuffincheckBox.Checked)
            {
                OrderCost += BLUEBERRY_MUFFIN;
            }
            if (cranberrycheckBox.Checked)
            {
                OrderCost += CRANBERRY;
            }
            if (chocolatechipmuffincheckBox.Checked)
            {
                OrderCost += CHOCOLATE_CHIP_MUFFINS;
            }
            if (mysterycheckBox.Checked)
            {
                OrderCost += MYSTERY;
            }
            if (brancheckBox.Checked)
            {
                OrderCost += BRAN;
            }
            if (applecinnamoncheckBox.Checked)
            {
                OrderCost += APPLE_CINNAMON;
            }
            if (banananutcheckBox.Checked)
            {
                OrderCost += BANANA_NUT;
            }
            if (chocolatechipmuffincheckBox.Checked)
            {
                OrderCost += CHOCOLATE_CHIP_MUFFINS;
            }
            if (applefrittercheckBox.Checked)
            {
                OrderCost += APPLE_FRITTER;
            }
            if (frenchcrullercheckBox.Checked)
            {
                OrderCost += FRENCH_CRULLER;
            }
            if (frosteddoughnutcheckBox.Checked)
            {
                OrderCost += FROSTED_DOUGHNUT;
            }
            if (glazeddoughnutcheckBox.Checked)
            {
                OrderCost += GLAZED_DOUGHNUT;
            }
            if (sufganiyahcheckBox.Checked)
            {
                OrderCost += SUFGANIYAH;
            }
            if (turnoverscheckBox.Checked)
            {
                OrderCost += TURNOVERS;
            }
            if (palmierscheckBox.Checked)
            {
                OrderCost += PALMIERS;
            }
            if (croissantcheckBox.Checked)
            {
                OrderCost += CROISSANTS;
            }
            if (banananutbreadcheckBox.Checked)
            {
                OrderCost += BANANA_NUT_BREAD;
            }
            if (bagelcheckBox.Checked)
            {
                OrderCost += BAGEL;
            }

            if (byosenberrycheesecakecheckBox.Checked)
            {
                OrderCost += BOYSENBERRY_CHEESECAKE;
            }
            if (chocolateraspberrytartcheckBox.Checked)
            {
                OrderCost += CHOCOLATE_RASPBERRY_TART;
            }
            if (carrotcheckBox.Checked)
            {
                OrderCost += CARROT_CAKE;
            }
            if (poundcakecheckBox.Checked)
            {
                OrderCost += POUND_CAKE;
            }
            if (chocolatecheckBox.Checked)
            {
                OrderCost += CHOCOLATE_CAKE;
            }
            if (blueberrysconescheckBox.Checked)
            {
                OrderCost += BLUEBERRY_SCONES;
            }
            if (stickybunscheckBox.Checked)
            {
                OrderCost += STICKY_BUNS;
            }
            if (creamcheesedanishcheckBox.Checked)
            {
                OrderCost += CREAM_CHEESE_DANISH;
            }
            if (turkeybaconprovolonecheckBox.Checked)
            {
                OrderCost += OVEN_ROASTED_TURKEY_BACON_PROVOLONE;
            }
            if (angusroastbeefcheckBox.Checked)
            {
                OrderCost += ANGUS_ROAST_BEEF_COLBY_JACK;
            }
            if (chickencordonbleucheckBox.Checked)
            {
                OrderCost += CHICKEN_CORDON_BLEU_PANINI;
            }
            if (montecristocheckBox.Checked)
            {
                OrderCost += MONTE_CRISTO;
            }
            if (bltcheckBox.Checked)
            {
                OrderCost += BLT;
            }
            return OrderCost;

        }
        //this method is to pick optional toppings for order
        private decimal ToppingCost()
           
        {
            decimal ToppingCost = 0;
            
            //select a topping

            if (ciabattacheckBox.Checked)
            {
                ToppingCost += CIABATTA;
            }
            if (italianherbcheesecheckBox.Checked)
            {
                ToppingCost += ITALIAN_HERB_CHEESE;
            }
            if (frenchcheckBox.Checked)
            {
                ToppingCost += FRENCH;
            }
            if (ryecheckBox.Checked)
            {
                ToppingCost += RYE;
            }
            if (almondmilkcheckBox.Checked)
            {
                ToppingCost += ALMOND_MILK;
            }
            if (oatmilkcheckBox.Checked)
            {
                ToppingCost += OAT_MILK;
            }
            if (wholemilkcheckBox.Checked)
            {
                ToppingCost += WHOLE_MILK;
            }
            if (caramelcheckBox.Checked)
            {
                ToppingCost += CARAMEL;
            }
            if (nutellacheckBox.Checked)
            {
                ToppingCost += NUTELLA;
            }
            if (oatmilkcheckBox.Checked)
            {
                ToppingCost += OAT_MILK;
            }
            if (blueberryfillingcheckBox.Checked)
            {
                ToppingCost += BLUEBERRY;
            }
            if (raspberryfillingcheckBox.Checked)
            {
                ToppingCost += RASPBERRY;
            }
            if (strawberryfillingcheckBox.Checked)
            {
                ToppingCost += STRAWBERRY;
            }
            if (everythingcheckBox.Checked)
            {
                ToppingCost += EVERYTHING_BAGEL;
            }
            if (cinnamonraisincheckBox.Checked)
            {
                ToppingCost += CINNAMON_RASISIN_BAGEL;
            }
            if (chocolatechipbagelcheckBox.Checked)
            {
                ToppingCost += CHOCOLATE_CHIP_BAGEL;
            }
            return ToppingCost;


        }
        //this method receives the sale amount and returns it to the amount of the sales tax

        private decimal CalcTax(decimal val)
        {
            return val * TAX_RATE;
        }
            
        private void chocolatecheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void blueberrysconescheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void subtotalLabel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void taxLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }
    }
}
