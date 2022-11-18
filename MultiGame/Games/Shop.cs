using System;
using System.Threading;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame.Games
{
    public partial class Shop : Form
    {
        Thread shopth;
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Form]{(Log)}Opening Form");
            updateshop();
        }

        private void Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            shopth.Abort();
            log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Form]{(Log)}Opening Form");
            shopshown = false;
        }
        private void upshopth()
        {
            button1.Text = "Adder " + add1 + "\r\n$" + add1n;
            button2.Text = "Adder " + add2 + "\r\n$" + add2n;
            button3.Text = "Adder " + add3 + "\r\n$" + add3n;
            button4.Text = "Adder " + add4 + "\r\n$" + add4n;
            button5.Text = "Adder " + add5 + "\r\n$" + add5n;
            button6.Text = "Adder " + add6 + "\r\n$" + add6n;
            button7.Text = "Adder " + add7 + "\r\n$" + add7n;
            button8.Text = "Adder " + add8 + "\r\n$" + add8n;
            button9.Text = "Adder " + add9 + "\r\n$" + add9n;
            button10.Text = "Adder " + add10 + "\r\n$" + add10n;
            button11.Text = "Multipilier " + mult1 + "\r\n$" + mult1n;
            button12.Text = "Multipilier " + mult2 + "\r\n$" + mult2n;
            button13.Text = "Multipilier " + mult3 + "\r\n$" + mult3n;
            button14.Text = "Multipilier " + mult4 + "\r\n$" + mult4n;
            button15.Text = "Multipilier " + mult5 + "\r\n$" + mult5n;
            button16.Text = "Multipilier " + mult6 + "\r\n$" + mult6n;
            button17.Text = "Multipilier " + mult7 + "\r\n$" + mult7n;
            button18.Text = "Multipilier " + mult8 + "\r\n$" + mult8n;
            button19.Text = "Multipilier " + mult9 + "\r\n$" + mult9n;
            button20.Text = "Multipilier " + mult10 + "\r\n$" + mult10n;
            button21.Text = "Autoclickers " + autogenmult + "\r\n$" + autogenmultn;
            button22.Text = "Autoclicker Speed \r\n" + autoclickerinterval + "ms\r\n$" + autoclickerintervaln;
        }
        public void updateshop()
        {
            shopth = new Thread(upshopth);
            shopth.Start();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(money >= add1n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add1 now:" + add1);
                money -= add1n;
                add1n *= 2;
                add1++;
                updateshop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money >= add2n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add2 now:" + add2);
                money -= add2n;
                add2n *= 2;
                add2++;
                updateshop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (money >= add3n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add3 now:" + add3);
                money -= add3n;
                add3n *= 2;
                add3++;
                updateshop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (money >= add4n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add4 now:" + add4);
                money -= add4n;
                add4n *= 2;
                add4++;
                updateshop();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (money >= add5n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add1 now:" + add5);
                money -= add5n;
                add5n *= 2;
                add5++;
                updateshop();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (money >= add6n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add6 now:" + add6);
                money -= add6n;
                add6n *= 2;
                add6++;
                updateshop();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (money >= add7n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add7 now:" + add7);
                money -= add7n;
                add7n *= 2;
                add7++;
                updateshop();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (money >= add8n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add8 now:" + add8);
                money -= add8n;
                add8n *= 2;
                add8++;
                updateshop();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (money >= add9n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add9 now:" + add9);
                money -= add9n;
                add9n *= 2;
                add9++;
                updateshop();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (money >= add10n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased add10 now:" + add10);
                money -= add10n;
                add10n *= 2;
                add10++;
                updateshop();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (money >= mult1n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult1 now:" + mult1);
                money -= mult1n;
                mult1n *= 3;
                mult1++;
                updateshop();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (money >= mult2n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult2 now:" + mult2);
                money -= mult2n;
                mult2n *= 3;
                mult2++;
                updateshop();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (money >= mult3n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult3 now:" + mult3);
                money -= mult3n;
                mult3n *= 3;
                mult3++;
                updateshop();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (money >= mult4n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult4 now:" + mult4);
                money -= mult4n;
                mult4n *= 3;
                mult4++;
                updateshop();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (money >= mult5n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult5 now:" + mult5);
                money -= mult5n;
                mult5n *= 3;
                mult5++;
                updateshop();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (money >= mult6n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult6 now:" + mult6);
                money -= mult6n;
                mult6n *= 3;
                mult6++;
                updateshop();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (money >= mult7n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult7 now:" + mult7);
                money -= mult7n;
                mult7n *= 3;
                mult7++;
                updateshop();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (money >= mult8n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult8 now:" + mult8);
                money -= mult8n;
                mult8n *= 3;
                mult8++;
                updateshop();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (money >= mult9n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult9 now:" + mult9);
                money -= mult9n;
                mult9n *= 3;
                mult9++;
                updateshop();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (money >= mult10n)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult10 now:" + mult10);
                money -= mult10n;
                mult10n *= 3;
                mult10++;
                updateshop();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (money >= autogenmultn)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased mult10 now:" + autogenmult);
                money -= autogenmultn;
                autogenmultn *= 5;
                autogenmult++;
                updateshop();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (autoclickerinterval > 2)
            {
                if (money >= autoclickerintervaln)
                {
                    log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Game]{(Log)}Purchased autoclicker speed now:" + autoclickerinterval);
                    money -= autoclickerintervaln;
                    autoclickerintervaln *= 7;
                    autoclickerinterval--;
                    updateshop();
                }
            }
        }
    }
}
