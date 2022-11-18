﻿using System;
using System.Threading;
using System.Windows.Forms;
using static MultiGame.rntm;

namespace MultiGame
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public void timerth()
        {
            while (true)
            {
                Thread.Sleep(999);
                timespent++;
            }
        }

        private void clickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!clshown)
            {
                clshown = true;
                Form fm = new Games.Clicker();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            devToolStripMenuItem.Enabled = devmode;
            if (cheat)
            {
                money += exponent(int.MaxValue * getmoney(), 100);
                xp += exponent(int.MaxValue * getmoney(), 100);
            }
            if (xp >= xpn)
            {
                level++;
                log.Add("[" + DateTime.Now + "][From:Internal/Main/LVL]{(Log)}Level Up Level Now:" + level);
                xp -= xpn;
                xpn *= 2;
            }
            xP00ToolStripMenuItem.Text = "XP:" + xp + "/" + xpn;
            levelToolStripMenuItem1.Text = "Level:" + level;
            money0ToolStripMenuItem.Text = "Money:" + money;
            generation1ToolStripMenuItem.Text = "Generation:" + generation;
            automaticGeneration0ToolStripMenuItem.Text = "Automatic Generation:" + (autogenmult * getmoney());
            nameToolStripMenuItem.Text = "Name:" + username;
            passCodeToolStripMenuItem.Text = "PassCode:" + endecode;
            generationPerClick1ToolStripMenuItem.Text = "Generation Per Click:" + getmoney();
            autoclicker.Interval = autoclickerinterval;
            timeSpent0SecondsToolStripMenuItem.Text = "Time Spent:" + timespent + " seconds";
        }

        private void fNFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!fnfshown)
            {
                if (level >= 25)
                {
                    fnfshown = true;
                    Games.FNF fm = new Games.FNF();
                    fm.MdiParent = this;
                    fm.Show();
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            log.Add("[" + DateTime.Now + "][From:Internal/Main/Form]{(Log)}Opening Form");
            Thread.CurrentThread.Name = "Multigame Main Thread";
            Thread th = new Thread(timerth);
            th.Name = "MultiGame Timer Thread";
            th.Start();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!logshown)
            {
                logshown = true;
                Form fm = new Tools.Log();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void addLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!addlogshown)
            {
                addlogshown = true;
                Form fm = new Tools.AddLog();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void toggleDevModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!toggledevmodeshown)
            {
                toggledevmodeshown = true;
                Form fm = new Tools.ToggleDevMode();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void shopLevel5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!shopshown)
            {
                if(level >= 5)
                {
                    shopshown = true;
                    Form fm = new Games.Shop();
                    fm.MdiParent = this;
                    fm.Show();
                }
            }
        }

        private void autoclicker_Tick(object sender, EventArgs e)
        {
            money += getmoney()*autogenmult;
            xp += getmoney()*autogenmult;
        }

        private void passCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!changepasscodeshown)
            {
                changepasscodeshown = true;
                Form fm = new Tools.ChangePassCode();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!changeusernameshown)
            {
                changeusernameshown = true;
                Form fm = new Tools.ChangeUserName();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!savegameshown)
            {
                savegameshown = true;
                Form fm = new Tools.SaveGame();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void openGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!opengameshown)
            {
                opengameshown = true;
                Form fm = new Tools.OpenGame();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void gamesIncLevel50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!gamesincshown)
            {
                if(level >= 50)
                {
                    gamesincshown = true;
                    Form fm = new Games.GamesInc();
                    fm.MdiParent = this;
                    fm.Show();
                }
            }
        }

        private void moreMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cheat)
            {
                cheat = false;
                moreMoneyToolStripMenuItem.Text = "More Money OFF";
            }else
            {
                cheat = true;
                moreMoneyToolStripMenuItem.Text = "More Money ON";
            }
        }

        private void resetMoneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            money = 0;
        }

        private void resetLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level = 0;
            xp = 0;
            xpn = 2;
        }
    }
}
