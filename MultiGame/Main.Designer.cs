
namespace MultiGame
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopLevel5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fNFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesIncLevel50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xP00ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeSpent0SecondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generation1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticGeneration0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generationPerClick1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.money0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleDevModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.moreMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.forceMoneyBagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceGenerationBoostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.autoclicker = new System.Windows.Forms.Timer(this.components);
            this.companytick = new System.Windows.Forms.Timer(this.components);
            this.rngtick = new System.Windows.Forms.Timer(this.components);
            this.boosttimer = new System.Windows.Forms.Timer(this.components);
            this.autoupgrade = new System.Windows.Forms.Timer(this.components);
            this.shop2Level100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magicLevel150ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mp0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magicPowerGeneratorLevel150ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGameToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.levelToolStripMenuItem,
            this.moneyToolStripMenuItem,
            this.devToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openGameToolStripMenuItem
            // 
            this.openGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickerToolStripMenuItem,
            this.shopLevel5ToolStripMenuItem,
            this.fNFToolStripMenuItem,
            this.gamesIncLevel50ToolStripMenuItem,
            this.shop2Level100ToolStripMenuItem,
            this.magicLevel150ToolStripMenuItem,
            this.magicPowerGeneratorLevel150ToolStripMenuItem});
            this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
            this.openGameToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.openGameToolStripMenuItem.Text = "Open Game";
            // 
            // clickerToolStripMenuItem
            // 
            this.clickerToolStripMenuItem.Name = "clickerToolStripMenuItem";
            this.clickerToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.clickerToolStripMenuItem.Text = "Clicker Level 0";
            this.clickerToolStripMenuItem.Click += new System.EventHandler(this.clickerToolStripMenuItem_Click);
            // 
            // shopLevel5ToolStripMenuItem
            // 
            this.shopLevel5ToolStripMenuItem.Name = "shopLevel5ToolStripMenuItem";
            this.shopLevel5ToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.shopLevel5ToolStripMenuItem.Text = "Shop Level 5";
            this.shopLevel5ToolStripMenuItem.Click += new System.EventHandler(this.shopLevel5ToolStripMenuItem_Click);
            // 
            // fNFToolStripMenuItem
            // 
            this.fNFToolStripMenuItem.Name = "fNFToolStripMenuItem";
            this.fNFToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.fNFToolStripMenuItem.Text = "FNF Level 25";
            this.fNFToolStripMenuItem.Click += new System.EventHandler(this.fNFToolStripMenuItem_Click);
            // 
            // gamesIncLevel50ToolStripMenuItem
            // 
            this.gamesIncLevel50ToolStripMenuItem.Name = "gamesIncLevel50ToolStripMenuItem";
            this.gamesIncLevel50ToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.gamesIncLevel50ToolStripMenuItem.Text = "Games Inc. Level 50";
            this.gamesIncLevel50ToolStripMenuItem.Click += new System.EventHandler(this.gamesIncLevel50ToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopONToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // alwaysOnTopONToolStripMenuItem
            // 
            this.alwaysOnTopONToolStripMenuItem.Name = "alwaysOnTopONToolStripMenuItem";
            this.alwaysOnTopONToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.alwaysOnTopONToolStripMenuItem.Text = "Always On Top (OFF)";
            this.alwaysOnTopONToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopONToolStripMenuItem_Click);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelToolStripMenuItem1,
            this.xP00ToolStripMenuItem,
            this.toolStripSeparator4,
            this.nameToolStripMenuItem,
            this.passCodeToolStripMenuItem,
            this.timeSpent0SecondsToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveGameToolStripMenuItem,
            this.openGameToolStripMenuItem1});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.levelToolStripMenuItem.Text = "Profile";
            // 
            // levelToolStripMenuItem1
            // 
            this.levelToolStripMenuItem1.Name = "levelToolStripMenuItem1";
            this.levelToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.levelToolStripMenuItem1.Text = "Level:";
            // 
            // xP00ToolStripMenuItem
            // 
            this.xP00ToolStripMenuItem.Name = "xP00ToolStripMenuItem";
            this.xP00ToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.xP00ToolStripMenuItem.Text = "XP:0/0";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(232, 6);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.nameToolStripMenuItem.Text = "Name:";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // passCodeToolStripMenuItem
            // 
            this.passCodeToolStripMenuItem.Name = "passCodeToolStripMenuItem";
            this.passCodeToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.passCodeToolStripMenuItem.Text = "PassCode:";
            this.passCodeToolStripMenuItem.Click += new System.EventHandler(this.passCodeToolStripMenuItem_Click);
            // 
            // timeSpent0SecondsToolStripMenuItem
            // 
            this.timeSpent0SecondsToolStripMenuItem.Name = "timeSpent0SecondsToolStripMenuItem";
            this.timeSpent0SecondsToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.timeSpent0SecondsToolStripMenuItem.Text = "Time Spent:0 seconds";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.saveGameToolStripMenuItem.Text = "SaveGame";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // openGameToolStripMenuItem1
            // 
            this.openGameToolStripMenuItem1.Name = "openGameToolStripMenuItem1";
            this.openGameToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.openGameToolStripMenuItem1.Text = "OpenGame";
            this.openGameToolStripMenuItem1.Click += new System.EventHandler(this.openGameToolStripMenuItem1_Click);
            // 
            // moneyToolStripMenuItem
            // 
            this.moneyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generation1ToolStripMenuItem,
            this.automaticGeneration0ToolStripMenuItem,
            this.generationPerClick1ToolStripMenuItem,
            this.toolStripSeparator2,
            this.money0ToolStripMenuItem,
            this.mp0ToolStripMenuItem});
            this.moneyToolStripMenuItem.Name = "moneyToolStripMenuItem";
            this.moneyToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.moneyToolStripMenuItem.Text = "Money";
            // 
            // generation1ToolStripMenuItem
            // 
            this.generation1ToolStripMenuItem.Name = "generation1ToolStripMenuItem";
            this.generation1ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.generation1ToolStripMenuItem.Text = "Generation:1";
            // 
            // automaticGeneration0ToolStripMenuItem
            // 
            this.automaticGeneration0ToolStripMenuItem.Name = "automaticGeneration0ToolStripMenuItem";
            this.automaticGeneration0ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.automaticGeneration0ToolStripMenuItem.Text = "Automatic Generation:0";
            // 
            // generationPerClick1ToolStripMenuItem
            // 
            this.generationPerClick1ToolStripMenuItem.Name = "generationPerClick1ToolStripMenuItem";
            this.generationPerClick1ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.generationPerClick1ToolStripMenuItem.Text = "Generation Per Click:1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(246, 6);
            // 
            // money0ToolStripMenuItem
            // 
            this.money0ToolStripMenuItem.Name = "money0ToolStripMenuItem";
            this.money0ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.money0ToolStripMenuItem.Text = "Money:0";
            // 
            // devToolStripMenuItem
            // 
            this.devToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleDevModeToolStripMenuItem,
            this.toolStripSeparator3,
            this.logToolStripMenuItem,
            this.addLogToolStripMenuItem,
            this.toolStripSeparator5,
            this.moreMoneyToolStripMenuItem,
            this.resetMoneyToolStripMenuItem,
            this.resetLevelToolStripMenuItem,
            this.toolStripSeparator6,
            this.forceMoneyBagToolStripMenuItem,
            this.forceGenerationBoostToolStripMenuItem});
            this.devToolStripMenuItem.Name = "devToolStripMenuItem";
            this.devToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.devToolStripMenuItem.Text = "Dev";
            // 
            // toggleDevModeToolStripMenuItem
            // 
            this.toggleDevModeToolStripMenuItem.Name = "toggleDevModeToolStripMenuItem";
            this.toggleDevModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.toggleDevModeToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.toggleDevModeToolStripMenuItem.Text = "ToggleDevMode";
            this.toggleDevModeToolStripMenuItem.Click += new System.EventHandler(this.toggleDevModeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(322, 6);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // addLogToolStripMenuItem
            // 
            this.addLogToolStripMenuItem.Name = "addLogToolStripMenuItem";
            this.addLogToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.addLogToolStripMenuItem.Text = "AddLog";
            this.addLogToolStripMenuItem.Click += new System.EventHandler(this.addLogToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(322, 6);
            // 
            // moreMoneyToolStripMenuItem
            // 
            this.moreMoneyToolStripMenuItem.Name = "moreMoneyToolStripMenuItem";
            this.moreMoneyToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.moreMoneyToolStripMenuItem.Text = "More Money OFF";
            this.moreMoneyToolStripMenuItem.Click += new System.EventHandler(this.moreMoneyToolStripMenuItem_Click);
            // 
            // resetMoneyToolStripMenuItem
            // 
            this.resetMoneyToolStripMenuItem.Name = "resetMoneyToolStripMenuItem";
            this.resetMoneyToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.resetMoneyToolStripMenuItem.Text = "Reset Money";
            this.resetMoneyToolStripMenuItem.Click += new System.EventHandler(this.resetMoneyToolStripMenuItem_Click);
            // 
            // resetLevelToolStripMenuItem
            // 
            this.resetLevelToolStripMenuItem.Name = "resetLevelToolStripMenuItem";
            this.resetLevelToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.resetLevelToolStripMenuItem.Text = "Reset Level";
            this.resetLevelToolStripMenuItem.Click += new System.EventHandler(this.resetLevelToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(322, 6);
            // 
            // forceMoneyBagToolStripMenuItem
            // 
            this.forceMoneyBagToolStripMenuItem.Name = "forceMoneyBagToolStripMenuItem";
            this.forceMoneyBagToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.forceMoneyBagToolStripMenuItem.Text = "Force Money Bag";
            this.forceMoneyBagToolStripMenuItem.Click += new System.EventHandler(this.forceMoneyBagToolStripMenuItem_Click);
            // 
            // forceGenerationBoostToolStripMenuItem
            // 
            this.forceGenerationBoostToolStripMenuItem.Name = "forceGenerationBoostToolStripMenuItem";
            this.forceGenerationBoostToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.forceGenerationBoostToolStripMenuItem.Text = "Force Generation Boost";
            this.forceGenerationBoostToolStripMenuItem.Click += new System.EventHandler(this.forceGenerationBoostToolStripMenuItem_Click);
            // 
            // tick
            // 
            this.tick.Enabled = true;
            this.tick.Interval = 1;
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // autoclicker
            // 
            this.autoclicker.Enabled = true;
            this.autoclicker.Interval = 1000;
            this.autoclicker.Tick += new System.EventHandler(this.autoclicker_Tick);
            // 
            // companytick
            // 
            this.companytick.Enabled = true;
            this.companytick.Interval = 5000;
            this.companytick.Tick += new System.EventHandler(this.companytick_Tick);
            // 
            // rngtick
            // 
            this.rngtick.Enabled = true;
            this.rngtick.Interval = 3000;
            this.rngtick.Tick += new System.EventHandler(this.rngtick_Tick);
            // 
            // boosttimer
            // 
            this.boosttimer.Enabled = true;
            this.boosttimer.Interval = 1000;
            this.boosttimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // autoupgrade
            // 
            this.autoupgrade.Enabled = true;
            this.autoupgrade.Interval = 3000;
            this.autoupgrade.Tick += new System.EventHandler(this.autoupgrade_Tick);
            // 
            // shop2Level100ToolStripMenuItem
            // 
            this.shop2Level100ToolStripMenuItem.Name = "shop2Level100ToolStripMenuItem";
            this.shop2Level100ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.shop2Level100ToolStripMenuItem.Text = "Shop 2 Level 100";
            this.shop2Level100ToolStripMenuItem.Click += new System.EventHandler(this.shop2Level100ToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // magicLevel150ToolStripMenuItem
            // 
            this.magicLevel150ToolStripMenuItem.Name = "magicLevel150ToolStripMenuItem";
            this.magicLevel150ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.magicLevel150ToolStripMenuItem.Text = "Magic Level 150";
            this.magicLevel150ToolStripMenuItem.Click += new System.EventHandler(this.magicLevel150ToolStripMenuItem_Click);
            // 
            // mp0ToolStripMenuItem
            // 
            this.mp0ToolStripMenuItem.Name = "mp0ToolStripMenuItem";
            this.mp0ToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.mp0ToolStripMenuItem.Text = "Mp:0";
            // 
            // magicPowerGeneratorLevel150ToolStripMenuItem
            // 
            this.magicPowerGeneratorLevel150ToolStripMenuItem.Name = "magicPowerGeneratorLevel150ToolStripMenuItem";
            this.magicPowerGeneratorLevel150ToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.magicPowerGeneratorLevel150ToolStripMenuItem.Text = "Magic Power Generator Level 150";
            this.magicPowerGeneratorLevel150ToolStripMenuItem.Click += new System.EventHandler(this.magicPowerGeneratorLevel150ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fNFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.Timer tick;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xP00ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleDevModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generation1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automaticGeneration0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem money0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shopLevel5ToolStripMenuItem;
        private System.Windows.Forms.Timer autoclicker;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gamesIncLevel50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generationPerClick1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem moreMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeSpent0SecondsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetLevelToolStripMenuItem;
        private System.Windows.Forms.Timer companytick;
        private System.Windows.Forms.Timer rngtick;
        private System.Windows.Forms.Timer boosttimer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem forceMoneyBagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forceGenerationBoostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopONToolStripMenuItem;
        private System.Windows.Forms.Timer autoupgrade;
        private System.Windows.Forms.ToolStripMenuItem shop2Level100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magicLevel150ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mp0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magicPowerGeneratorLevel150ToolStripMenuItem;
    }
}

