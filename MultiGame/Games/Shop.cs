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
            update.Enabled = Autoupdateshops;
            updateshop();
        }

        private void Shop_FormClosing(object sender, FormClosingEventArgs e) => shopshown = false;
        private void upshopth()
        {
            if (formatnums)
            {
                button1.Text = "Adder " + FormatBigNum(add1u.value) + "\r\n$" + FormatBigNum(add1u.cache);
                button2.Text = "Adder " + FormatBigNum(add2u.value) + "\r\n$" + FormatBigNum(add2u.cache);
                button3.Text = "Adder " + FormatBigNum(add3u.value) + "\r\n$" + FormatBigNum(add3u.cache);
                button4.Text = "Adder " + FormatBigNum(add4u.value) + "\r\n$" + FormatBigNum(add4u.cache);
                button5.Text = "Adder " + FormatBigNum(add5u.value) + "\r\n$" + FormatBigNum(add5u.cache);
                button6.Text = "Adder " + FormatBigNum(add6u.value) + "\r\n$" + FormatBigNum(add6u.cache);
                button7.Text = "Adder " + FormatBigNum(add7u.value) + "\r\n$" + FormatBigNum(add7u.cache);
                button8.Text = "Adder " + FormatBigNum(add8u.value) + "\r\n$" + FormatBigNum(add8u.cache);
                button9.Text = "Adder " + FormatBigNum(add9u.value) + "\r\n$" + FormatBigNum(add9u.cache);
                button10.Text = "Adder " + FormatBigNum(add10u.value) + "\r\n$" + FormatBigNum(add10u.cache);
                button11.Text = "Multipilier " + FormatBigNum(mult1u.value) + "\r\n$" + FormatBigNum(mult1u.cache);
                button12.Text = "Multipilier " + FormatBigNum(mult2u.value) + "\r\n$" + FormatBigNum(mult2u.cache);
                button13.Text = "Multipilier " + FormatBigNum(mult3u.value) + "\r\n$" + FormatBigNum(mult3u.cache);
                button14.Text = "Multipilier " + FormatBigNum(mult4u.value) + "\r\n$" + FormatBigNum(mult4u.cache);
                button15.Text = "Multipilier " + FormatBigNum(mult5u.value) + "\r\n$" + FormatBigNum(mult5u.cache);
                button16.Text = "Multipilier " + FormatBigNum(mult6u.value) + "\r\n$" + FormatBigNum(mult6u.cache);
                button17.Text = "Multipilier " + FormatBigNum(mult7u.value) + "\r\n$" + FormatBigNum(mult7u.cache);
                button18.Text = "Multipilier " + FormatBigNum(mult8u.value) + "\r\n$" + FormatBigNum(mult8u.cache);
                button19.Text = "Multipilier " + FormatBigNum(mult9u.value) + "\r\n$" + FormatBigNum(mult9u.cache);
                button20.Text = "Multipilier " + FormatBigNum(mult10u.value) + "\r\n$" + FormatBigNum(mult10u.cache);
                button21.Text = "Autoclickers " + FormatBigNum(autogenmultu.value) + "\r\n$" + FormatBigNum(autogenmultu.cache);
                button22.Text = "Autoclicker Speed\r\n ms" + FormatBigNum(autoclickerinterval) + "\r\n$" + FormatBigNum(autoclickerintervaln);
            }
            else
            {
                button1.Text = "Adder " + add1u.value + "\r\n$" + add1u.cache;
                button2.Text = "Adder " + add2u.value + "\r\n$" + add2u.cache;
                button3.Text = "Adder " + add3u.value + "\r\n$" + add3u.cache;
                button4.Text = "Adder " + add4u.value + "\r\n$" + add4u.cache;
                button5.Text = "Adder " + add5u.value + "\r\n$" + add5u.cache;
                button6.Text = "Adder " + add6u.value + "\r\n$" + add6u.cache;
                button7.Text = "Adder " + add7u.value + "\r\n$" + add7u.cache;
                button8.Text = "Adder " + add8u.value + "\r\n$" + add8u.cache;
                button9.Text = "Adder " + add9u.value + "\r\n$" + add9u.cache;
                button10.Text = "Adder " + add10u.value + "\r\n$" + add10u.cache;
                button11.Text = "Multipilier " + mult1u.value + "\r\n$" + mult1u.cache;
                button12.Text = "Multipilier " + mult2u.value + "\r\n$" + mult2u.cache;
                button13.Text = "Multipilier " + mult3u.value + "\r\n$" + mult3u.cache;
                button14.Text = "Multipilier " + mult4u.value + "\r\n$" + mult4u.cache;
                button15.Text = "Multipilier " + mult5u.value + "\r\n$" + mult5u.cache;
                button16.Text = "Multipilier " + mult6u.value + "\r\n$" + mult6u.cache;
                button17.Text = "Multipilier " + mult7u.value + "\r\n$" + mult7u.cache;
                button18.Text = "Multipilier " + mult8u.value + "\r\n$" + mult8u.cache;
                button19.Text = "Multipilier " + mult9u.value + "\r\n$" + mult9u.cache;
                button20.Text = "Multipilier " + mult10u.value + "\r\n$" + mult10u.cache;
                button21.Text = "Autoclickers " + autogenmultu.value + "\r\n$" + autogenmultu.cache;
                button22.Text = "Autoclicker Speed\r\n ms" + autoclickerinterval + "\r\n$" + autoclickerintervaln;
            }
            button22.Text = "Autoclicker Speed \r\n" + autoclickerinterval + "ms\r\n$" + autoclickerintervaln;
        }
        public void updateshop() => upshopth();

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

        private void update_Tick(object sender, EventArgs e) => upshopth();
    }
}
