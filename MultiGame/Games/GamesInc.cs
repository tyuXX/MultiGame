namespace MultiGame.Games;

internal partial class GamesInc : Form
{
    internal GamesInc()
    {
        InitializeComponent();
    }

    private void GamesInc_FormClosing(object sender, FormClosingEventArgs e) => gamesincshown = false;

    private void GamesInc_Load(object sender, EventArgs e) => updatestore();

    private void tick_Tick(object sender, EventArgs e)
    {
        label1.Text = "Company Name:" + username + "'s Company";
        if (formatnums)
        {
            label2.Text = "Net Worth:" + FormatBigNum(companynetworth);
        }
        else
        {
            label2.Text = "Net Worth:" + companynetworth;
        }
        label6.Text = "Gain Per Second:" + (getmoney * inventions * invested * 100);
        if (companywork)
        {
            label7.Text = "Status:Onboard";
        }
        else
        {
            label7.Text = "Status:Idle";
        }
    }
    private void updatestore()
    {
        if (formatnums)
        {
            label1.Text = "Company Name:" + username + "'s Company";
            label2.Text = "Net Worth:" + FormatBigNum(companynetworth);
            label3.Text = "Company Workers:" + FormatBigNum(workers);
            label4.Text = "Company Work Power:" + FormatBigNum(exponent(2, workers));
            label5.Text = "Company Work Power Neded:" + FormatBigNum(exponent(5, inventions));
            label6.Text = "Gain Per Second:" + FormatBigNum(getmoney * inventions * invested * 100);
            button1.Text = "Hire Worker $" + FormatBigNum((workersn)) + " Outcome:" + FormatBigNum(workersn);
            button2.Text = "Buy A Mini Company $" + FormatBigNum(minicompaniesn);
            button3.Text = "Invest $" + FormatBigNum(investedn);
        }
        else
        {
            label1.Text = "Company Name:" + username + "'s Company";
            label2.Text = "Net Worth:" + companynetworth;
            label3.Text = "Company Workers:" + workers;
            label4.Text = "Company Work Power:" + exponent(2, workers);
            label5.Text = "Company Work Power Neded:" + exponent(5, inventions);
            label6.Text = "Gain Per Second:" + (getmoney * inventions * invested * 100);
            button1.Text = "Hire Worker $" + workersn + " Outcome:" + workersn;
            button2.Text = "Buy A Mini Company $" + minicompaniesn;
            button3.Text = "Invest $" + investedn;
        }
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (money >= workersn)
        {
            outcome += workersn;
            money -= workersn;
            workersn *= 2;
            workers++;
            if (formatnums)
            {
                label4.Text = $"Company Work Power:{FormatBigNum(exponent(2, workers))}";
                label3.Text = $"Company Workers:{FormatBigNum(workers)}";
                button1.Text = $"Hire Worker ${FormatBigNum(workersn)} Outcome:{FormatBigNum(workersn)}";
            }
            else
            {
                label4.Text = $"Company Work Power:{exponent(2, workers)}";
                label3.Text = $"Company Workers:{workers}";
                button1.Text = $"Hire Worker ${workersn} Outcome:{workersn}";
            }
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (maxbuy)
        {
            while (money >= investedn)
            {
                money -= investedn;
                investedn *= 2;
                invested++;
                if (formatnums)
                {
                    button3.Text = $"Invest ${FormatBigNum(investedn)}";
                }
                else
                {
                    button3.Text = $"Invest ${investedn}";
                }
            }
        }
        else
        {
            if (money >= investedn)
            {
                money -= investedn;
                investedn *= 2;
                invested++;
                if (formatnums)
                {
                    button3.Text = $"Invest ${FormatBigNum(investedn)}";
                }
                else
                {
                    button3.Text = $"Invest ${investedn}";
                }
            }
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (money >= inventionsn)
        {
            money -= inventionsn;
            inventionsn *= 2;
            inventions++;
            if (formatnums)
            {
                button4.Text = $"Invent Inventions ${FormatBigNum(inventionsn)}";
                label5.Text = $"Company Work Power Neded:{FormatBigNum(exponent(5, inventions))}";
            }
            else
            {
                button4.Text = $"Invent Inventions ${inventionsn}";
                label5.Text = $"Company Work Power Neded:{exponent(5, inventions)}";
            }
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (maxbuy)
        {
            while (money >= minicompaniesn)
            {
                money -= minicompaniesn;
                minicompaniesn *= 9;
                minicompanies++;
                if (formatnums)
                {
                    button2.Text = "Buy A Mini Company $" + FormatBigNum(minicompaniesn);
                }
                else
                {
                    button2.Text = "Buy A Mini Company $" + minicompaniesn;
                }
            }
        }
        else
        {
            if (money >= minicompaniesn)
            {
                money -= minicompaniesn;
                minicompaniesn *= 9;
                minicompanies++;
                if (formatnums)
                {
                    button2.Text = "Buy A Mini Company $" + FormatBigNum(minicompaniesn);
                }
                else
                {
                    button2.Text = "Buy A Mini Company $" + minicompaniesn;
                }
            }
        }
    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void button5_Click(object sender, EventArgs e)
    {
        workers = 0;
        inventions = 0;
        recalculatevars();
        updatestore();
    }
}
