using System;
using System.Threading;
using System.Windows.Forms;
using MultiGame.Games;
using MultiGame.Tools;
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
            this.TopMost = alwaysontop;
            devToolStripMenuItem.Enabled = devmode;
            autoupgrade.Enabled = automaticupgrade;
            clearlogt.Enabled = clearlog;
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
            if (formatnums)
            {
                xP00ToolStripMenuItem.Text = "XP:" + FormatBigNum(xp) + "/" + FormatBigNum(xpn);
                money0ToolStripMenuItem.Text = "Money:" + FormatBigNum(money);
                levelToolStripMenuItem1.Text = "Level:" + FormatBigNum(level);
                generation1ToolStripMenuItem.Text = "Generation:" + FormatBigNum(generation);
                automaticGeneration0ToolStripMenuItem.Text = "Automatic Generation:" + FormatBigNum(autogenmult * getmoney());
                generationPerClick1ToolStripMenuItem.Text = "Generation Per Click:" + FormatBigNum(getmoney());
                populationToolStripMenuItem.Text = "Population:" + FormatBigNum(currentworld.population);
                populationGrowthToolStripMenuItem.Text = "PopulationGrowth:" + FormatBigNum(currentworld.populationgrowth);
            }
            else
            {
                xP00ToolStripMenuItem.Text = "XP:" + xp + "/" + xpn;
                money0ToolStripMenuItem.Text = "Money:" + money;
                levelToolStripMenuItem1.Text = "Level:" + level;
                generation1ToolStripMenuItem.Text = "Generation:" + generation;
                automaticGeneration0ToolStripMenuItem.Text = "Automatic Generation:" + (autogenmult * getmoney());
                generationPerClick1ToolStripMenuItem.Text = "Generation Per Click:" + getmoney();
                populationToolStripMenuItem.Text = "Population:" + currentworld.population;
                populationGrowthToolStripMenuItem.Text = "PopulationGrowth:" + currentworld.populationgrowth;
            }
            nameToolStripMenuItem.Text = "Name:" + username;
            passCodeToolStripMenuItem.Text = "PassCode:" + endecode;
            autoclicker.Interval = autoclickerinterval;
            autoupgrade.Interval = autoupgradeinterval;
            timeSpent0SecondsToolStripMenuItem.Text = "Time Spent:" + timespent + " seconds";
            mp0ToolStripMenuItem.Text = "Mp:" + magicpower;
            populationGrowthPercentToolStripMenuItem.Text = "PopulationGrowthPercent:" + currentworld.populationgrowthpercent;
            multipilierToolStripMenuItem.Text = "Multipilier:" + currentworld.mult;
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
            currentworld.name = "World";
            currentworld.populationgrowthpercent = rng.Next(0, 100);
            currentworld.populationgrowth = rng.Next(0, int.MaxValue);
            currentworld.population = rng.Next(0, int.MaxValue) * rng.Next(0, int.MaxValue);
            currentworld.mult = rng.Next(1, 3);
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
                if (level >= 5)
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
            money += getmoney() * autogenmult;
            xp += getmoney() * autogenmult;
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
                if (level >= 50)
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
            }
            else
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
                money += getmoney() * inventions * invested * 500 * ((currentworld.population / 100000000) + 1);
                companynetworth += getmoney() * inventions * 500 * ((currentworld.population / 100000000) + 1);
                xp += getmoney() * inventions * invested * 500 * ((currentworld.population / 100000000) + 1);
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
            if (rng.Next(0, 300) >= moneybagc)
            {
                Form fm = new Boosts.MoneyBag();
                fm.MdiParent = this;
                fm.Show();
            }
            if (rng.Next(0, 600) >= genboostc)
            {
                Form fm = new Boosts.GenerationBoost();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (boost1t > 0)
            {
                boost1t--;
            }
            else
            {
                boost1 = 1;
            }
            if (boost2t > 0)
            {
                boost2t--;
            }
            else
            {
                boost2 = 1;
            }
            if (boost3t > 0)
            {
                boost3t--;
            }
            else
            {
                boost3 = 1;
            }
            if (boost4t > 0)
            {
                boost4t--;
            }
            else
            {
                boost4 = 1;
            }
            if (boost5t > 0)
            {
                boost5t--;
            }
            else
            {
                boost5 = 1;
            }
            if (boost6t > 0)
            {
                boost6t--;
            }
            else
            {
                boost6 = 1;
            }
            if (boost7t > 0)
            {
                boost7t--;
            }
            else
            {
                boost7 = 1;
            }
            if (boost8t > 0)
            {
                boost8t--;
            }
            else
            {
                boost8 = 1;
            }
            if (boost9t > 0)
            {
                boost9t--;
            }
            else
            {
                boost9 = 1;
            }
            if (boost10t > 0)
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

        private void alwaysOnTopONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (alwaysontop)
            {
                alwaysontop = false;
                alwaysOnTopONToolStripMenuItem.Text = "Always On Top (OFF)";
            }
            else
            {
                alwaysontop = true;
                alwaysOnTopONToolStripMenuItem.Text = "Always On Top (ON)";
            }
        }

        private void autoupgrade_Tick(object sender, EventArgs e)
        {
            upadd1();
            upadd2();
            upadd3();
            upadd4();
            upadd5();
            upadd6();
            upadd7();
            upadd8();
            upadd9();
            upadd10();
            upmult1();
            upmult2();
            upmult3();
            upmult4();
            upmult5();
            upmult6();
            upmult7();
            upmult8();
            upmult9();
            upmult10();
            upautogenmult();
            upautoclickerspeed();
            upautoupgradespeed();
        }

        private void shop2Level100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!shop2shown)
            {
                if (level >= 100)
                {
                    shop2shown = true;
                    Form fm = new Games.Shop2();
                    fm.MdiParent = this;
                    fm.Show();
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!aboutshown)
            {
                aboutshown = true;
                Form fm = new Tools.About();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void magicLevel150ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!magicshown)
            {
                if (level >= 150)
                {
                    magicshown = true;
                    Form fm = new Games.Magic();
                    fm.MdiParent = this;
                    fm.Show();
                }
            }
        }

        private void magicPowerGeneratorLevel150ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!magicpowergeneratorshown)
            {
                if (level >= 150)
                {
                    magicpowergeneratorshown = true;
                    Form fm = new Games.MagicPowerGenerator();
                    fm.MdiParent = this;
                    fm.Show();
                }
            }
        }
        private void debugVarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!debugvarsshown)
            {
                debugvarsshown = true;
                Form fm = new Tools.DebugVars();
                fm.MdiParent = this;
                fm.Show();
            }
        }

        private void worldpop_Tick(object sender, EventArgs e)
        {
            if (currentworld.population < 1)
            {
                currentworld.population = 1;
            }
            currentworld.population += currentworld.populationgrowth;
        }

        private void newWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newworld();
        }

        private void hideGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultiGameIcon.Visible = true;
        }

        private void MultiGameIcon_Click(object sender, EventArgs e)
        {
            this.Show();
            MultiGameIcon.Visible = false;
        }

        private void levelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void formatNumbersOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formatnums)
            {
                formatNumbersOFFToolStripMenuItem.Text = "Format Numbers (OFF)";
                formatnums = false;
            }
            else
            {
                formatNumbersOFFToolStripMenuItem.Text = "Format Numbers (ON)";
                formatnums = true;
            }
        }

        private void processAllXpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (xp > xpn)
            {
                level++;
                log.Add("[" + DateTime.Now + "][From:Internal/Main/LVL]{(Log)}Level Up Level Now:" + level);
                xp -= xpn;
                xpn *= 2;
            }
        }

        private void autoSaveOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autosave)
            {
                autosave = false;
                autoSaveOFFToolStripMenuItem.Text = "AutoSave (OFF)";
            }
            else
            {
                autosave = true;
                autoSaveOFFToolStripMenuItem.Text = "AutoSave (ON)";
            }
        }

        private void autosave_Tick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastfile))
            {
                savegame(lastfile);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closeGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void shop3Level225ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (level >= 225)
            {
                if (!shopthshown)
                {
                    Shop3 shop3 = new Shop3();
                    shop3.MdiParent = this;
                    shop3.Show();
                }
            }
        }

        private void clearlogt_Tick(object sender, EventArgs e)
        {
            log.Clear();
        }

        private void debugVarsNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!varsshown)
            {
                varsshown = true;
                Variables variables = new Variables();
                variables.MdiParent = this;
                variables.Show();
            }
        }
        public void closeallchild()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }
    }
}
