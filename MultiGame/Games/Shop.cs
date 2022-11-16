using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }
    }
}
