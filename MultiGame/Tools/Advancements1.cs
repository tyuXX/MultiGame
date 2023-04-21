namespace MultiGame.Tools;

internal partial class Advancements1 : Form
{
    internal Advancements1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void Advancements1_Load(object sender, EventArgs e)
    {
        if (!advance[ 1 ])
        {
            if (level >= 25)
            {
                advance[ 1 ] = true;
            }
            else
            {
                button2.BackColor = Color.Gray;
            }
        }
        if (!advance[ 2 ])
        {
            if (level >= 50)
            {
                advance[ 2 ] = true;
            }
            else
            {
                button3.BackColor = Color.Gray;
            }
        }
        if (!advance[ 3 ])
        {
            if (level >= 75)
            {
                advance[ 3 ] = true;
            }
            else
            {
                button4.BackColor = Color.Gray;
            }
        }
        if (!advance[ 4 ])
        {
            if (level >= 100)
            {
                advance[ 4 ] = true;
            }
            else
            {
                button5.BackColor = Color.Gray;
            }
        }
        if (!advance[ 5 ])
        {
            if (level >= 125)
            {
                advance[ 5 ] = true;
            }
            else
            {
                button6.BackColor = Color.Gray;
            }
        }
        if (!advance[ 6 ])
        {
            if (level >= 150)
            {
                advance[ 6 ] = true;
            }
            else
            {
                button7.BackColor = Color.Gray;
            }
        }
        if (!advance[ 7 ])
        {
            if (level >= 175)
            {
                advance[ 7 ] = true;
            }
            else
            {
                button8.BackColor = Color.Gray;
            }
        }
        if (!advance[ 8 ])
        {
            if (level >= 200)
            {
                advance[ 8 ] = true;
            }
            else
            {
                button9.BackColor = Color.Gray;
            }
        }
        if (!advance[ 9 ])
        {
            if (level >= 225)
            {
                advance[ 9 ] = true;
            }
            else
            {
                button10.BackColor = Color.Gray;
            }
        }
        if (!advance[ 10 ])
        {
            if (level >= 250)
            {
                advance[ 10 ] = true;
            }
            else
            {
                button11.BackColor = Color.Gray;
            }
        }
        if (!advance[ 11 ])
        {
            if (level >= 300)
            {
                advance[ 11 ] = true;
            }
            else
            {
                button12.BackColor = Color.Gray;
            }
        }
        if (!advance[ 12 ])
        {
            if (level >= 400)
            {
                advance[ 12 ] = true;
            }
            else
            {
                button13.BackColor = Color.Gray;
            }
        }
        if (!advance[ 13 ])
        {
            if (level >= 500)
            {
                advance[ 13 ] = true;
            }
            else
            {
                button14.BackColor = Color.Gray;
            }
        }
        if (!advance[ 14 ])
        {
            if (level >= 600)
            {
                advance[ 14 ] = true;
            }
            else
            {
                button15.BackColor = Color.Gray;
            }
        }
        if (!advance[ 15 ])
        {
            if (level >= 700)
            {
                advance[ 15 ] = true;
            }
            else
            {
                button16.BackColor = Color.Gray;
            }
        }
        if (!advance[ 16 ])
        {
            if (level >= 800)
            {
                advance[ 16 ] = true;
            }
            else
            {
                button17.BackColor = Color.Gray;
            }
        }
        if (!advance[ 17 ])
        {
            if (level >= 900)
            {
                advance[ 17 ] = true;
            }
            else
            {
                button18.BackColor = Color.Gray;
            }
        }
        if (!advance[ 18 ])
        {
            if (level >= 1000)
            {
                advance[ 18 ] = true;
            }
            else
            {
                button19.BackColor = Color.Gray;
            }
        }
    }

    private void Advancements1_FormClosing(object sender, FormClosingEventArgs e)
    {
        advanceshown = false;
    }
}
