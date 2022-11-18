using System;
using System.Reflection.Emit;
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
            timerthread.Name = "MultiGame Timer Thread";
            timerthread.Start();
            recalculatevars();
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

        private void companytick_Tick(object sender, EventArgs e)
        {
            if (exponent(2, workers) >= exponent(5, inventions))
            {
                money += getmoney() * inventions * invested * 500;
                companynetworth += getmoney() * inventions * 500;
                xp += getmoney() * inventions * invested * 500;
                companywork = true;
            }
            else
            {
                companywork = false;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerthread.Abort();
        }

        private void rngtick_Tick(object sender, EventArgs e)
        {
            if(rng.Next(0,300) == 299)
            {
                Form fm = new Boosts.MoneyBag();
                fm.MdiParent = this;
                fm.Show();
            }if(rng.Next(0,600) == 599)
            {
                Form fm = new Boosts.GenerationBoost();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(boost1t > 0)
            {
                boost1t--;
            }
            else
            {
                boost1 = 1;
            }
            if(boost2t > 0)
            {
                boost2t--;
            }
            else
            {
                boost2 = 1;
            }if(boost3t > 0)
            {
                boost3t--;
            }
            else
            {
                boost3 = 1;
            }
            if(boost4t > 0)
            {
                boost4t--;
            }
            else
            {
                boost4 = 1;
            }
            if(boost5t > 0)
            {
                boost5t--;
            }
            else
            {
                boost5 = 1;
            }
            if(boost6t > 0)
            {
                boost6t--;
            }
            else
            {
                boost6 = 1;
            }
            if(boost7t > 0)
            {
                boost7t--;
            }
            else
            {
                boost7 = 1;
            }
            if(boost8t > 0)
            {
                boost8t--;
            }
            else
            {
                boost8 = 1;
            }
            if(boost9t > 0)
            {
                boost9t--;
            }
            else
            {
                boost9 = 1;
            }
            if(boost10t > 0)
            {
                boost10t--;
            }
            else
            {
                boost10 = 1;
            }
        }

        private void forceMoneyBagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new Boosts.MoneyBag();
            fm.MdiParent = this;
            fm.Show();
        }

        private void forceGenerationBoostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new Boosts.GenerationBoost();
            fm.MdiParent = this;
            fm.Show();
        }
    }
}
