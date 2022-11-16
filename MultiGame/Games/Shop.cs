using System;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame.Games
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Form]{(Log)}Opening Form");
        }

        private void Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Form]{(Log)}Opening Form");
            shopshown = false;
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            button1.Text = "Adder " + add1 + "\r\n$" + (250 * (exponent(2, add1) + 1));
            button2.Text = "Adder " + add2 + "\r\n$" + (250 * (exponent(2, add2) + 1));
            button3.Text = "Adder " + add3 + "\r\n$" + (250 * (exponent(2, add3) + 1));
            button4.Text = "Adder " + add4 + "\r\n$" + (250 * (exponent(2, add4) + 1));
            button5.Text = "Adder " + add5 + "\r\n$" + (250 * (exponent(2, add5) + 1));
            button6.Text = "Adder " + add6 + "\r\n$" + (250 * (exponent(2, add6) + 1));
            button7.Text = "Adder " + add7 + "\r\n$" + (250 * (exponent(2, add7) + 1));
            button8.Text = "Adder " + add8 + "\r\n$" + (250 * (exponent(2, add8) + 1));
            button9.Text = "Adder " + add9 + "\r\n$" + (250 * (exponent(2, add9) + 1));
            button10.Text = "Adder " + add10 + "\r\n$" + (250 * (exponent(2, add10) + 1));
            button11.Text = "Multipilier " + mult1 + "\r\n$" + (500 * (exponent(3, mult1) + 1));
            button12.Text = "Multipilier " + mult2 + "\r\n$" + (500 * (exponent(3, mult2) + 1));
            button13.Text = "Multipilier " + mult3 + "\r\n$" + (500 * (exponent(3, mult3) + 1));
            button14.Text = "Multipilier " + mult4 + "\r\n$" + (500 * (exponent(3, mult4) + 1));
            button15.Text = "Multipilier " + mult5 + "\r\n$" + (500 * (exponent(3, mult5) + 1));
            button16.Text = "Multipilier " + mult6 + "\r\n$" + (500 * (exponent(3, mult6) + 1));
            button17.Text = "Multipilier " + mult7 + "\r\n$" + (500 * (exponent(3, mult7) + 1));
            button18.Text = "Multipilier " + mult8 + "\r\n$" + (500 * (exponent(3, mult8) + 1));
            button19.Text = "Multipilier " + mult9 + "\r\n$" + (500 * (exponent(3, mult9) + 1));
            button20.Text = "Multipilier " + mult10 + "\r\n$" + (500 * (exponent(3, mult10) + 1));
            button21.Text = "Autoclickers " + autogenmult + "\r\n$" + (1000 * (exponent(5, autogenmult) + 1));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(money >= 250 * (exponent(2, add1) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add1 now:" + add1);
                money -= 250 * (exponent(2, add1) + 1);
                add1++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money >= 250 * (exponent(2, add2) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add2 now:" + add2);
                money -= 250 * (exponent(2, add2) + 1);
                add2++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (money >= 250 * (exponent(2, add3) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add3 now:" + add3);
                money -= 250 * (exponent(2, add3) + 1);
                add3++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (money >= 250 * (exponent(2, add4) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add4 now:" + add4);
                money -= 250 * (exponent(2, add4) + 1);
                add4++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (money >= 250 * (exponent(2, add5) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add1 now:" + add5);
                money -= 250 * (exponent(2, add5) + 1);
                add5++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (money >= 250 * (exponent(2, add6) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add6 now:" + add6);
                money -= 250 * (exponent(2, add6) + 1);
                add6++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (money >= 250 * (exponent(2, add7) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add7 now:" + add7);
                money -= 250 * (exponent(2, add7) + 1);
                add7++;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (money >= 250 * (exponent(2, add8) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add8 now:" + add8);
                money -= 250 * (exponent(2, add8) + 1);
                add8++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (money >= 250 * (exponent(2, add9) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add9 now:" + add9);
                money -= 250 * (exponent(2, add9) + 1);
                add9++;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (money >= 250 * (exponent(2, add10) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add10 now:" + add10);
                money -= 250 * (exponent(2, add10) + 1);
                add10++;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (money >= 500 * (exponent(3, mult1) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult1 now:" + mult1);
                money -= 500 * (exponent(3, mult1) + 1);
                mult1++;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (money >= 500 * (exponent(3, mult2) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult2 now:" + mult2);
                money -= 500 * (exponent(3, mult2) + 1);
                mult2++;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (money >= 500 * (exponent(3, mult3) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult3 now:" + mult3);
                money -= 500 * (exponent(3, mult3) + 1);
                mult3++;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (money >= 500 * (exponent(3, mult4) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult4 now:" + mult4);
                money -= 500 * (exponent(3, mult4) + 1);
                mult4++;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (money >= 500 * (exponent(3, mult5) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult5 now:" + mult5);
                money -= 500 * (exponent(3, mult5) + 1);
                mult5++;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (money >= 500 * (exponent(3, mult6) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult6 now:" + mult6);
                money -= 500 * (exponent(3, mult6) + 1);
                mult6++;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (money >= 500 * (exponent(3, mult7) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult7 now:" + mult7);
                money -= 500 * (exponent(3, mult7) + 1);
                mult7++;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (money >= 500 * (exponent(3, mult8) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult8 now:" + mult8);
                money -= 500 * (exponent(3, mult8) + 1);
                mult8++;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (money >= 500 * (exponent(3, mult9) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult9 now:" + mult9);
                money -= 500 * (exponent(3, mult9) + 1);
                mult9++;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (money >= 500 * (exponent(3, mult10) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult10 now:" + mult10);
                money -= 500 * (exponent(3, mult10) + 1);
                mult10++;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (money >= 1000 * (exponent(5, autogenmult) + 1))
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult10 now:" + autogenmult);
                money -= 1000 * (exponent(5, autogenmult) + 1);
                autogenmult++;
            }
        }
    }
}
