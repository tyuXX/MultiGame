using System.Diagnostics;
using System.Numerics;
using MultiGame.Games;
using MultiGame.Tools;
namespace MultiGame;

internal partial class Main : Form
{
    internal bool splash = true;
    internal Main()
    {
        InitializeComponent();
    }

    private void clickerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!clshown)
        {
            clshown = true;
            Form fm = new Clicker
            {
                MdiParent = this
            };
            fm.Show();
        }
    }

    private void tick_Tick(object sender, EventArgs e)
    {
        BigInteger levelm = levelupmultu.rankvalue;
        TopMost = alwaysontop;
        devToolStripMenuItem.Enabled = devmode;
        autoupgrade.Enabled = automaticupgrade;
        autorankup.Enabled = automaticrank;
        autorebirth.Enabled = automaticrebirth;
        if (cheat)
        {
            money += exponent(int.MaxValue * getmoney, 100);
            xp += exponent(int.MaxValue * getmoney, 100);
        }
        while ((levelm > 0) && (xp >= xpn))
        {
            XpUp();
            levelm--;
        }
        if (formatnums)
        {
            xP00ToolStripMenuItem.Text = "XP:" + FormatBigNum(xp) + "/" + FormatBigNum(xpn);
            money0ToolStripMenuItem.Text = "Money:" + FormatBigNum(money);
            levelToolStripMenuItem1.Text = "Level:" + FormatBigNum(level);
            generation1ToolStripMenuItem.Text = "Generation:" + FormatBigNum(generation);
            automaticGeneration0ToolStripMenuItem.Text = "Automatic Generation:" + FormatBigNum(autogenmultu.rankvalue * getmoney);
            generationPerClick1ToolStripMenuItem.Text = "Generation Per Click:" + FormatBigNum(getmoney);
            populationToolStripMenuItem.Text = "Population:" + FormatBigNum(currentworld.population);
            populationGrowthToolStripMenuItem.Text = "PopulationGrowth:" + FormatBigNum(currentworld.populationgrowth);
            mp0ToolStripMenuItem.Text = "Mp:" + FormatBigNum(magicpower);
        }
        else
        {
            xP00ToolStripMenuItem.Text = "XP:" + xp + "/" + xpn;
            money0ToolStripMenuItem.Text = "Money:" + money;
            levelToolStripMenuItem1.Text = "Level:" + level;
            generation1ToolStripMenuItem.Text = "Generation:" + generation;
            automaticGeneration0ToolStripMenuItem.Text = "Automatic Generation:" + (autogenmultu.rankvalue * getmoney);
            generationPerClick1ToolStripMenuItem.Text = "Generation Per Click:" + getmoney;
            populationToolStripMenuItem.Text = "Population:" + currentworld.population;
            populationGrowthToolStripMenuItem.Text = "PopulationGrowth:" + currentworld.populationgrowth;
            mp0ToolStripMenuItem.Text = "Mp:" + magicpower;
        }
        if (formatranks)
        {
            rankToolStripMenuItem.Text = "Rank:" + RankCalc(rank);
            rebirthToolStripMenuItem.Text = "Rebirth:" + RankCalc(rebirth);
        }
        else
        {
            rankToolStripMenuItem.Text = "Rank:" + rank;
            rebirthToolStripMenuItem.Text = "Rebirth:" + rebirth;
        }
        nameToolStripMenuItem.Text = "Name:" + username;
        passCodeToolStripMenuItem.Text = "PassCode:" + endecode;
        autoclicker.Interval = autoclickerinterval;
        autoupgrade.Interval = autoupgradeinterval;
        timeSpent0SecondsToolStripMenuItem.Text = "Time Spent:" + timespent + " seconds";
        populationGrowthPercentToolStripMenuItem.Text = "PopulationGrowthPercent:" + currentworld.populationgrowthpercent;
        multipilierToolStripMenuItem.Text = "Multipilier:" + currentworld.mult;
    }

    private void fNFToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if ((level >= 25) && (!fnfshown))
        {
            fnfshown = true;
            FNF fm = new FNF
            {
                MdiParent = this
            };
            fm.Show();
        }
    }

    private void Main_Load(object sender, EventArgs e)
    {
        if (File.Exists("MultiGameUpdate.exe")) { File.Delete("MultiGameUpdate.exe"); }
        path = Application.ExecutablePath;
        currentworld.name = "World";
        currentworld.populationgrowthpercent = rng.Next(0, 100);
        currentworld.populationgrowth = rng.Next(0, int.MaxValue);
        currentworld.population = rng.Next(0, int.MaxValue) * rng.Next(0, int.MaxValue);
        currentworld.mult = rng.Next(1, 3);
        Thread.CurrentThread.Name = $"Multigame Main Thread ID:{mid}";
        timerthread.Name = $"MultiGame Timer Thread ID:{tid}";
        timerthread.Start();
        recalculatevars();
        if (splash) { VSplash(); }
        clickerToolStripMenuItem_Click(clickerToolStripMenuItem, null);
    }

    private void logToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!logshown)
        {
            logshown = true;
            Form fm = new Log
            {
                MdiParent = this
            };
            fm.Show();
        }
    }

    private void addLogToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!addlogshown)
        {
            addlogshown = true;
            Form fm = new AddLog
            {
                MdiParent = this
            };
            fm.Show();
        }
    }

    private void toggleDevModeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!toggledevmodeshown)
        {
            toggledevmodeshown = true;
            Form fm = new ToggleDevMode
            {
                MdiParent = this
            };
            fm.Show();
        }
    }

    private void shopLevel5ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if ((level >= 5) && (!shopshown))
        {
            shopshown = true;
            Form fm = new Shop
            {
                MdiParent = this
            };
            fm.Show();
        }
    }

    private void autoclicker_Tick(object sender, EventArgs e)
    {
        if (autoclicktoggle)
        {
            money += getmoney * autogenmultu.rankvalue;
            xp += getmoney * autogenmultu.rankvalue;
            totalclicks += autogenmultu.rankvalue;
        }
    }

    private void passCodeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!changepasscodeshown)
        {
            changepasscodeshown = true;
            Form fm = new ChangePassCode
            {
                MdiParent = this
            };
            fm.Show();
        }
    }

    private void nameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!changeusernameshown)
        {
            changeusernameshown = true;
            Form fm = new ChangeUserName
            {
                MdiParent = this
            };
            fm.Show();
        }
    }

    private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!savegameshown)
        {
            savegameshown = true;
            Form fm = new SaveGame
            {
                MdiParent = this
            };
            fm.Show();
        }
    }

    private void openGameToolStripMenuItem1_Click(object sender, EventArgs e)
    {
        if (!opengameshown)
        {
            opengameshown = true;
            Form fm = new OpenGame
            {
                MdiParent = this
            };
            fm.Show();
        }
    }

    private void gamesIncLevel50ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if ((level >= 50) && (!gamesincshown))
        {
            gamesincshown = true;
            Form fm = new GamesInc
            {
                MdiParent = this
            };
            fm.Show();
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

    private void resetMoneyToolStripMenuItem_Click(object sender, EventArgs e) => money = 0;

    private void resetLevelToolStripMenuItem_Click(object sender, EventArgs e)
    {
        level = 0;
        xp = 0;
        xpn = Xpnt;
    }

    private void companytick_Tick(object sender, EventArgs e)
    {
        if (exponent(2, workers) >= exponent(5, inventions))
        {
            money += getmoney * inventions * invested * 500 * ((currentworld.population / 100000000) + 1);
            companynetworth += getmoney * inventions * 500 * ((currentworld.population / 100000000) + 1);
            xp += getmoney * inventions * invested * 500 * ((currentworld.population / 100000000) + 1);
            companywork = true;
        }
        else
        {
            companywork = false;
        }
    }

    private void Main_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void rngtick_Tick(object sender, EventArgs e)
    {
        if (rng.Next(0, 300) >= moneybagc)
        {
            Form fm = new Boosts.MoneyBag
            {
                MdiParent = this
            };
            fm.Show();
        }
        if (rng.Next(0, 600) >= genboostc)
        {
            Form fm = new Boosts.GenerationBoost
            {
                MdiParent = this
            };
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
        Form fm = new Boosts.MoneyBag
        {
            MdiParent = this
        };
        fm.Show();
    }

    private void forceGenerationBoostToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Form fm = new Boosts.GenerationBoost
        {
            MdiParent = this
        };
        fm.Show();
    }

    private void autoupgrade_Tick(object sender, EventArgs e)
    {
        if (autoupgradetoggle)
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
    }

    private void shop2Level100ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if ((level >= 100) && (!shop2shown))
        {
            shop2shown = true;
            Form fm = new Shop2
            {
                MdiParent = this
            };
            fm.Show();
        }
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!aboutshown)
        {
            aboutshown = true;
            Form fm = new About
            {
                MdiParent = this
            };
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
                Form fm = new Magic
                {
                    MdiParent = this
                };
                fm.Show();
            }
        }
    }

    private void magicPowerGeneratorLevel150ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if ((level >= 150) && (!magicpowergeneratorshown))
        {
            magicpowergeneratorshown = true;
            Form fm = new MagicPowerGenerator
            {
                MdiParent = this
            };
            fm.Show();
        }
    }
    private void debugVarsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!debugvarsshown)
        {
            debugvarsshown = true;
            Form fm = new DebugVars
            {
                MdiParent = this
            };
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

    private void newWorldToolStripMenuItem_Click(object sender, EventArgs e) => newworld();

    private void hideGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Hide();
        MultiGameIcon.Visible = true;
        Toggletickers();
    }

    private void MultiGameIcon_Click(object sender, EventArgs e)
    {
        Show();
        MultiGameIcon.Visible = false;
        Toggletickers();
    }

    private void levelToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void processAllXpToolStripMenuItem_Click(object sender, EventArgs e)
    {
        while (xp > xpn)
        {
            XpUp();
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

    private void closeGameToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

    private void shop3Level225ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if ((level >= 225) && !shopthshown)
        {
            Shop3 shop3 = new Shop3
            {
                MdiParent = this
            };
            shop3.Show();
        }
    }

    private void debugVarsNewToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!varsshown)
        {
            varsshown = true;
            Variables variables = new Variables
            {
                MdiParent = this
            };
            variables.Show();
        }
    }
    internal void closeallchild()
    {
        foreach (Form f in MdiChildren)
        {
            f.Close();
        }
    }

    private void checkForUpdatesToolStripMenuItem_ClickAsync(object sender, EventArgs e)
    {
        if (!updatewindowshown)
        {
            updatewindowshown = true;
            UpdateWindow updateWindow = new()
            {
                MdiParent = this
            };
            updateWindow.Show();
        }
    }

    private void rankToolStripMenuItem_Click(object sender, EventArgs e) => RankUp();

    private void reCalcVarsToolStripMenuItem_Click(object sender, EventArgs e) => recalculatevars();

    private void rebirthToolStripMenuItem_Click(object sender, EventArgs e) => RebirtUp();

    private void shop4Level300ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if ((level >= 300) && (!shop4shown))
        {
            Shop4 shop4 = new Shop4
            {
                MdiParent = this
            };
            shop4.Show();
            shop4shown = true;
        }
    }

    private void autorankup_Tick(object sender, EventArgs e) => RankUp();

    private void autorebirth_Tick(object sender, EventArgs e) => RebirtUp();

    private void gameStarterRebirth2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if ((!rankstartershown) && (rebirth >= 2))
        {
            rankstartershown = true;
            RankStarter rankStarter = new RankStarter
            {
                MdiParent = this
            };
            rankStarter.Show();
        }
    }

    private void webPageToolStripMenuItem_Click(object sender, EventArgs e) => Process.Start("https://github.com/tyuXX/MultiGame");

    private void rankUpToolStripMenuItem_Click(object sender, EventArgs e) => RankUp(true);

    private void rebirthUpToolStripMenuItem_Click(object sender, EventArgs e) => RebirtUp(true);

    private void statusToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!statusopen)
        {
            statusopen = true;
            Status status = new Status
            {
                MdiParent = this
            };
            status.Show();
        }
    }

    private void pauseGameToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (pausetickers)
        {
            Toggletickers();
            pauseGameToolStripMenuItem.Text = "Pause Game";
        }
        else
        {
            Toggletickers();
            pauseGameToolStripMenuItem.Text = "Unpause Game";
        }
    }
    internal void Toggletickers()
    {
        pausetickers = !pausetickers;
        tick.Enabled = !pausetickers;
        autoclicker.Enabled = !pausetickers;
        rngtick.Enabled = !pausetickers;
        companytick.Enabled = !pausetickers;
        autosavet.Enabled = !pausetickers;
        autorankup.Enabled = !pausetickers;
        autorebirth.Enabled = !pausetickers;
        autoupgrade.Enabled = !pausetickers;
        boosttimer.Enabled = !pausetickers;
        worldpop.Enabled = !pausetickers;
    }

    private void advancementsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!advanceshown)
        {
            advanceshown = true;
            Advancements1 advancements1 = new()
            {
                MdiParent = this
            };
            advancements1.Show();
        }
    }

    private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (!settingswindowshown)
        {
            settingswindowshown = true;
            SettingsWindow settingsWindow = new()
            {
                MdiParent = this
            };
            settingsWindow.Show();
        }
    }
}
