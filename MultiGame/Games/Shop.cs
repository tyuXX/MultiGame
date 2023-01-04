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
            updateshop();
        }

        private void Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Games/Shop/Form]{(Log)}Opening Form");
            shopshown = false;
        }
        private void upshopth()
        {
            if (formatnums)
            {
                button1.Text = "Adder " + FormatBigNum(add1) + "\r\n$" + FormatBigNum(add1n);
                button2.Text = "Adder " + FormatBigNum(add2) + "\r\n$" + FormatBigNum(add2n);
                button3.Text = "Adder " + FormatBigNum(add3) + "\r\n$" + FormatBigNum(add3n);
                button4.Text = "Adder " + FormatBigNum(add4) + "\r\n$" + FormatBigNum(add4n);
                button5.Text = "Adder " + FormatBigNum(add5) + "\r\n$" + FormatBigNum(add5n);
                button6.Text = "Adder " + FormatBigNum(add6) + "\r\n$" + FormatBigNum(add6n);
                button7.Text = "Adder " + FormatBigNum(add7) + "\r\n$" + FormatBigNum(add7n);
                button8.Text = "Adder " + FormatBigNum(add8) + "\r\n$" + FormatBigNum(add8n);
                button9.Text = "Adder " + FormatBigNum(add9) + "\r\n$" + FormatBigNum(add9n);
                button10.Text = "Adder " + FormatBigNum(add10) + "\r\n$" + FormatBigNum(add10n);
                button11.Text = "Multipilier " + FormatBigNum(mult1) + "\r\n$" + FormatBigNum(mult1n);
                button12.Text = "Multipilier " + FormatBigNum(mult2) + "\r\n$" + FormatBigNum(mult2n);
                button13.Text = "Multipilier " + FormatBigNum(mult3) + "\r\n$" + FormatBigNum(mult3n);
                button14.Text = "Multipilier " + FormatBigNum(mult4) + "\r\n$" + FormatBigNum(mult4n);
                button15.Text = "Multipilier " + FormatBigNum(mult5) + "\r\n$" + FormatBigNum(mult5n);
                button16.Text = "Multipilier " + FormatBigNum(mult6) + "\r\n$" + FormatBigNum(mult6n);
                button17.Text = "Multipilier " + FormatBigNum(mult7) + "\r\n$" + FormatBigNum(mult7n);
                button18.Text = "Multipilier " + FormatBigNum(mult8) + "\r\n$" + FormatBigNum(mult8n);
                button19.Text = "Multipilier " + FormatBigNum(mult9) + "\r\n$" + FormatBigNum(mult9n);
                button20.Text = "Multipilier " + FormatBigNum(mult10) + "\r\n$" + FormatBigNum(mult10n);
                button21.Text = "Autoclickers " + FormatBigNum(autogenmult) + "\r\n$" + FormatBigNum(autogenmultn);
            }
            else
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
            }
            button22.Text = "Autoclicker Speed \r\n" + autoclickerinterval + "ms\r\n$" + autoclickerintervaln;
        }
        public void updateshop()
        {
            upshopth();
        }

        private void tick_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            upadd1();
            upshopth();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            upadd2();
            upshopth();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            upadd3();
            upshopth();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            upadd4();
            upshopth();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            upadd5();
            upshopth();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            upadd6();
            upshopth();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            upadd7();
            upshopth();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            upadd8();
            upshopth();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            upadd9();
            upshopth();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            upadd10();
            upshopth();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            upmult1();
            upshopth();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            upmult2();
            upshopth();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            upmult3();
            upshopth();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            upmult4();
            upshopth();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            upmult5();
            upshopth();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            upmult6();
            upshopth();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            upmult7();
            upshopth();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            upmult8();
            upshopth();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            upmult9();
            upshopth();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            upmult10();
            upshopth();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            upautogenmult();
            upshopth();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            upautoclickerspeed();
            upshopth();
        }
    }
}
