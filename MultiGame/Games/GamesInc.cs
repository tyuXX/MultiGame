﻿using MultiGame.Tools;
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
    public partial class GamesInc : Form
    {
        public GamesInc()
        {
            InitializeComponent();
        }

        private void GamesInc_FormClosing(object sender, FormClosingEventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Games/GamesInc/Form]{(Log)}Closing Form");
        }

        private void GamesInc_Load(object sender, EventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Games/GamesInc/Form]{(Log)}Opening Form");
            updatestore();
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            label1.Text = "Company Name:" + username + "'s Company";
            label6.Text = "Gain Per Second:" + (getmoney() * inventions * invested * 100);
        }
        private void updatestore()
        {
            label1.Text = "Company Name:" + username + "'s Company";
            label2.Text = "Net Worth:" + companynetworth;
            label3.Text = "Company Workers:" + workers;
            label4.Text = "Company Work Power:" + exponent(2, workers);
            label5.Text = "Company Work Power Neded:" + exponent(5, inventions);
            label6.Text = "Gain Per Second:" + (getmoney() * inventions * invested * 100);
            button1.Text = "Hire Worker $" + workersn + " Outcome:" + workersn;
            button2.Text = "Buy A Mini Company $" + minicompaniesn;
            button3.Text = "Invest $" + investedn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (money >= workersn)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/GamesInc/Game]{(Log)}Purchased worker now:" + workers);
                outcome += workersn;
                money -= workersn;
                workersn *= 2;
                workers++;
                label4.Text = "Company Work Power:" + exponent(2, workers);
                label3.Text = "Company Workers:" + workers;
                button1.Text = "Hire Worker $" + workersn + " Outcome:" + workersn;
            }
        }

        private void companytick_Tick(object sender, EventArgs e)
        {
            if (exponent(2,workers) >= exponent(5,inventions))
            {
                money += getmoney() * inventions * invested * 500;
                companynetworth += getmoney() * inventions * 500;
                xp += getmoney() * inventions * invested * 500;
                label2.Text = "Net Worth:" + companynetworth;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (money >= investedn)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/GamesInc/Game]{(Log)}Invested now:" + invested);
                money -= investedn;
                investedn *= 2;
                invested++;
                button3.Text = "Invest $" + investedn;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (money >= inventionsn)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/GamesInc/Game]{(Log)}Invented a invention now:" + inventions);
                money -= inventionsn;
                inventionsn *= 2;
                inventions++;
                button4.Text = "Invent Inventions $" + inventionsn;
                label5.Text = "Company Work Power Neded:" + exponent(5, inventions);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (money >= minicompaniesn)
            {
                log.Add("[" + DateTime.Now + "][From:Internal/Games/GamesInc/Game]{(Log)}Purchased a Mini Company now:" + minicompanies);
                money -= minicompaniesn;
                minicompaniesn *= 9;
                minicompanies++;
                button2.Text = "Buy A Mini Company $" + minicompaniesn;
            }
        }
    }
}
