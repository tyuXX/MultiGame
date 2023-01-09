
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shopLevel5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fNFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesIncLevel50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shop2Level100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magicLevel150ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magicPowerGeneratorLevel150ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shop3Level225ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatNumbersOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.hideGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xP00ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processAllXpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeSpent0SecondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSaveOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.populationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.populationGrowthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.populationGrowthPercentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipilierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generation1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automaticGeneration0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generationPerClick1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.money0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mp0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleDevModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugVarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.moreMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.forceMoneyBagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forceGenerationBoostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.autoclicker = new System.Windows.Forms.Timer(this.components);
            this.companytick = new System.Windows.Forms.Timer(this.components);
            this.rngtick = new System.Windows.Forms.Timer(this.components);
            this.boosttimer = new System.Windows.Forms.Timer(this.components);
            this.autoupgrade = new System.Windows.Forms.Timer(this.components);
            this.worldpop = new System.Windows.Forms.Timer(this.components);
            this.MultiGameIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.autosavet = new System.Windows.Forms.Timer(this.components);
            this.clearlogt = new System.Windows.Forms.Timer(this.components);
            this.debugVarsNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.worldToolStripMenuItem,
            this.moneyToolStripMenuItem,
            this.devToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
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
            this.magicPowerGeneratorLevel150ToolStripMenuItem,
            this.shop3Level225ToolStripMenuItem});
            this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
            this.openGameToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.openGameToolStripMenuItem.Text = "Open Game";
            // 
            // clickerToolStripMenuItem
            // 
            this.clickerToolStripMenuItem.Name = "clickerToolStripMenuItem";
            this.clickerToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.clickerToolStripMenuItem.Text = "Clicker Level 0";
            this.clickerToolStripMenuItem.Click += new System.EventHandler(this.clickerToolStripMenuItem_Click);
            // 
            // shopLevel5ToolStripMenuItem
            // 
            this.shopLevel5ToolStripMenuItem.Name = "shopLevel5ToolStripMenuItem";
            this.shopLevel5ToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.shopLevel5ToolStripMenuItem.Text = "Shop Level 5";
            this.shopLevel5ToolStripMenuItem.Click += new System.EventHandler(this.shopLevel5ToolStripMenuItem_Click);
            // 
            // fNFToolStripMenuItem
            // 
            this.fNFToolStripMenuItem.Name = "fNFToolStripMenuItem";
            this.fNFToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.fNFToolStripMenuItem.Text = "FNF Level 25";
            this.fNFToolStripMenuItem.Click += new System.EventHandler(this.fNFToolStripMenuItem_Click);
            // 
            // gamesIncLevel50ToolStripMenuItem
            // 
            this.gamesIncLevel50ToolStripMenuItem.Name = "gamesIncLevel50ToolStripMenuItem";
            this.gamesIncLevel50ToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.gamesIncLevel50ToolStripMenuItem.Text = "Games Inc. Level 50";
            this.gamesIncLevel50ToolStripMenuItem.Click += new System.EventHandler(this.gamesIncLevel50ToolStripMenuItem_Click);
            // 
            // shop2Level100ToolStripMenuItem
            // 
            this.shop2Level100ToolStripMenuItem.Name = "shop2Level100ToolStripMenuItem";
            this.shop2Level100ToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.shop2Level100ToolStripMenuItem.Text = "Shop 2 Level 100";
            this.shop2Level100ToolStripMenuItem.Click += new System.EventHandler(this.shop2Level100ToolStripMenuItem_Click);
            // 
            // magicLevel150ToolStripMenuItem
            // 
            this.magicLevel150ToolStripMenuItem.Name = "magicLevel150ToolStripMenuItem";
            this.magicLevel150ToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.magicLevel150ToolStripMenuItem.Text = "Magic Level 150";
            this.magicLevel150ToolStripMenuItem.Click += new System.EventHandler(this.magicLevel150ToolStripMenuItem_Click);
            // 
            // magicPowerGeneratorLevel150ToolStripMenuItem
            // 
            this.magicPowerGeneratorLevel150ToolStripMenuItem.Name = "magicPowerGeneratorLevel150ToolStripMenuItem";
            this.magicPowerGeneratorLevel150ToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.magicPowerGeneratorLevel150ToolStripMenuItem.Text = "Magic Power Generator Level 150";
            this.magicPowerGeneratorLevel150ToolStripMenuItem.Click += new System.EventHandler(this.magicPowerGeneratorLevel150ToolStripMenuItem_Click);
            // 
            // shop3Level225ToolStripMenuItem
            // 
            this.shop3Level225ToolStripMenuItem.Name = "shop3Level225ToolStripMenuItem";
            this.shop3Level225ToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.shop3Level225ToolStripMenuItem.Text = "Shop 3 Level 225";
            this.shop3Level225ToolStripMenuItem.Click += new System.EventHandler(this.shop3Level225ToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopONToolStripMenuItem,
            this.formatNumbersOFFToolStripMenuItem,
            this.toolStripSeparator8,
            this.hideGameToolStripMenuItem,
            this.closeGameToolStripMenuItem,
            this.toolStripSeparator9,
            this.aboutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // alwaysOnTopONToolStripMenuItem
            // 
            this.alwaysOnTopONToolStripMenuItem.Name = "alwaysOnTopONToolStripMenuItem";
            this.alwaysOnTopONToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.alwaysOnTopONToolStripMenuItem.Text = "Always On Top (OFF)";
            this.alwaysOnTopONToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopONToolStripMenuItem_Click);
            // 
            // formatNumbersOFFToolStripMenuItem
            // 
            this.formatNumbersOFFToolStripMenuItem.Name = "formatNumbersOFFToolStripMenuItem";
            this.formatNumbersOFFToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.formatNumbersOFFToolStripMenuItem.Text = "Format Numbers (OFF)";
            this.formatNumbersOFFToolStripMenuItem.Click += new System.EventHandler(this.formatNumbersOFFToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(193, 6);
            // 
            // hideGameToolStripMenuItem
            // 
            this.hideGameToolStripMenuItem.Name = "hideGameToolStripMenuItem";
            this.hideGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.hideGameToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.hideGameToolStripMenuItem.Text = "Hide Game";
            this.hideGameToolStripMenuItem.Click += new System.EventHandler(this.hideGameToolStripMenuItem_Click);
            // 
            // closeGameToolStripMenuItem
            // 
            this.closeGameToolStripMenuItem.Name = "closeGameToolStripMenuItem";
            this.closeGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Q)));
            this.closeGameToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.closeGameToolStripMenuItem.Text = "Close Game";
            this.closeGameToolStripMenuItem.Click += new System.EventHandler(this.closeGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(193, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelToolStripMenuItem1,
            this.xP00ToolStripMenuItem,
            this.processAllXpToolStripMenuItem,
            this.toolStripSeparator4,
            this.nameToolStripMenuItem,
            this.passCodeToolStripMenuItem,
            this.timeSpent0SecondsToolStripMenuItem,
            this.advancementsToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveGameToolStripMenuItem,
            this.openGameToolStripMenuItem1,
            this.autoSaveOFFToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.levelToolStripMenuItem.Text = "Profile";
            this.levelToolStripMenuItem.Click += new System.EventHandler(this.levelToolStripMenuItem_Click);
            // 
            // levelToolStripMenuItem1
            // 
            this.levelToolStripMenuItem1.Name = "levelToolStripMenuItem1";
            this.levelToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.levelToolStripMenuItem1.Text = "Level:";
            // 
            // xP00ToolStripMenuItem
            // 
            this.xP00ToolStripMenuItem.Name = "xP00ToolStripMenuItem";
            this.xP00ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.xP00ToolStripMenuItem.Text = "XP:0/0";
            // 
            // processAllXpToolStripMenuItem
            // 
            this.processAllXpToolStripMenuItem.Name = "processAllXpToolStripMenuItem";
            this.processAllXpToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.processAllXpToolStripMenuItem.Text = "Process All Xp";
            this.processAllXpToolStripMenuItem.Click += new System.EventHandler(this.processAllXpToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(185, 6);
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.nameToolStripMenuItem.Text = "Name:";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // passCodeToolStripMenuItem
            // 
            this.passCodeToolStripMenuItem.Name = "passCodeToolStripMenuItem";
            this.passCodeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.passCodeToolStripMenuItem.Text = "PassCode:";
            this.passCodeToolStripMenuItem.Click += new System.EventHandler(this.passCodeToolStripMenuItem_Click);
            // 
            // timeSpent0SecondsToolStripMenuItem
            // 
            this.timeSpent0SecondsToolStripMenuItem.Name = "timeSpent0SecondsToolStripMenuItem";
            this.timeSpent0SecondsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.timeSpent0SecondsToolStripMenuItem.Text = "Time Spent:0 seconds";
            // 
            // advancementsToolStripMenuItem
            // 
            this.advancementsToolStripMenuItem.Name = "advancementsToolStripMenuItem";
            this.advancementsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.advancementsToolStripMenuItem.Text = "Advancements";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveGameToolStripMenuItem.Text = "SaveGame";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.saveGameToolStripMenuItem_Click);
            // 
            // openGameToolStripMenuItem1
            // 
            this.openGameToolStripMenuItem1.Name = "openGameToolStripMenuItem1";
            this.openGameToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.openGameToolStripMenuItem1.Text = "OpenGame";
            this.openGameToolStripMenuItem1.Click += new System.EventHandler(this.openGameToolStripMenuItem1_Click);
            // 
            // autoSaveOFFToolStripMenuItem
            // 
            this.autoSaveOFFToolStripMenuItem.Name = "autoSaveOFFToolStripMenuItem";
            this.autoSaveOFFToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.autoSaveOFFToolStripMenuItem.Text = "AutoSave (OFF)";
            this.autoSaveOFFToolStripMenuItem.Click += new System.EventHandler(this.autoSaveOFFToolStripMenuItem_Click);
            // 
            // worldToolStripMenuItem
            // 
            this.worldToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.populationToolStripMenuItem,
            this.populationGrowthToolStripMenuItem,
            this.populationGrowthPercentToolStripMenuItem,
            this.multipilierToolStripMenuItem});
            this.worldToolStripMenuItem.Name = "worldToolStripMenuItem";
            this.worldToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.worldToolStripMenuItem.Text = "World";
            // 
            // populationToolStripMenuItem
            // 
            this.populationToolStripMenuItem.Name = "populationToolStripMenuItem";
            this.populationToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.populationToolStripMenuItem.Text = "Population:";
            // 
            // populationGrowthToolStripMenuItem
            // 
            this.populationGrowthToolStripMenuItem.Name = "populationGrowthToolStripMenuItem";
            this.populationGrowthToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.populationGrowthToolStripMenuItem.Text = "PopulationGrowth:";
            // 
            // populationGrowthPercentToolStripMenuItem
            // 
            this.populationGrowthPercentToolStripMenuItem.Name = "populationGrowthPercentToolStripMenuItem";
            this.populationGrowthPercentToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.populationGrowthPercentToolStripMenuItem.Text = "PopulationGrowthPercent:";
            // 
            // multipilierToolStripMenuItem
            // 
            this.multipilierToolStripMenuItem.Name = "multipilierToolStripMenuItem";
            this.multipilierToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.multipilierToolStripMenuItem.Text = "Multipilier:";
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
            this.moneyToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.moneyToolStripMenuItem.Text = "Money";
            // 
            // generation1ToolStripMenuItem
            // 
            this.generation1ToolStripMenuItem.Name = "generation1ToolStripMenuItem";
            this.generation1ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.generation1ToolStripMenuItem.Text = "Generation:1";
            // 
            // automaticGeneration0ToolStripMenuItem
            // 
            this.automaticGeneration0ToolStripMenuItem.Name = "automaticGeneration0ToolStripMenuItem";
            this.automaticGeneration0ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.automaticGeneration0ToolStripMenuItem.Text = "Automatic Generation:0";
            // 
            // generationPerClick1ToolStripMenuItem
            // 
            this.generationPerClick1ToolStripMenuItem.Name = "generationPerClick1ToolStripMenuItem";
            this.generationPerClick1ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.generationPerClick1ToolStripMenuItem.Text = "Generation Per Click:1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
            // 
            // money0ToolStripMenuItem
            // 
            this.money0ToolStripMenuItem.Name = "money0ToolStripMenuItem";
            this.money0ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.money0ToolStripMenuItem.Text = "Money:0";
            // 
            // mp0ToolStripMenuItem
            // 
            this.mp0ToolStripMenuItem.Name = "mp0ToolStripMenuItem";
            this.mp0ToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.mp0ToolStripMenuItem.Text = "Mp:0";
            // 
            // devToolStripMenuItem
            // 
            this.devToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleDevModeToolStripMenuItem,
            this.toolStripSeparator3,
            this.logToolStripMenuItem,
            this.addLogToolStripMenuItem,
            this.debugVarsToolStripMenuItem,
            this.debugVarsNewToolStripMenuItem,
            this.enableLogToolStripMenuItem,
            this.toolStripSeparator5,
            this.moreMoneyToolStripMenuItem,
            this.resetMoneyToolStripMenuItem,
            this.resetLevelToolStripMenuItem,
            this.toolStripSeparator6,
            this.forceMoneyBagToolStripMenuItem,
            this.forceGenerationBoostToolStripMenuItem,
            this.toolStripSeparator7,
            this.newWorldToolStripMenuItem});
            this.devToolStripMenuItem.Name = "devToolStripMenuItem";
            this.devToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.devToolStripMenuItem.Text = "Dev";
            // 
            // toggleDevModeToolStripMenuItem
            // 
            this.toggleDevModeToolStripMenuItem.Name = "toggleDevModeToolStripMenuItem";
            this.toggleDevModeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.toggleDevModeToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.toggleDevModeToolStripMenuItem.Text = "ToggleDevMode";
            this.toggleDevModeToolStripMenuItem.Click += new System.EventHandler(this.toggleDevModeToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(254, 6);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // addLogToolStripMenuItem
            // 
            this.addLogToolStripMenuItem.Name = "addLogToolStripMenuItem";
            this.addLogToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.addLogToolStripMenuItem.Text = "AddLog";
            this.addLogToolStripMenuItem.Click += new System.EventHandler(this.addLogToolStripMenuItem_Click);
            // 
            // debugVarsToolStripMenuItem
            // 
            this.debugVarsToolStripMenuItem.Name = "debugVarsToolStripMenuItem";
            this.debugVarsToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.debugVarsToolStripMenuItem.Text = "Debug Vars";
            this.debugVarsToolStripMenuItem.Click += new System.EventHandler(this.debugVarsToolStripMenuItem_Click);
            // 
            // enableLogToolStripMenuItem
            // 
            this.enableLogToolStripMenuItem.Name = "enableLogToolStripMenuItem";
            this.enableLogToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.enableLogToolStripMenuItem.Text = "Enable Log (OFF)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(254, 6);
            // 
            // moreMoneyToolStripMenuItem
            // 
            this.moreMoneyToolStripMenuItem.Name = "moreMoneyToolStripMenuItem";
            this.moreMoneyToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.moreMoneyToolStripMenuItem.Text = "More Money OFF";
            this.moreMoneyToolStripMenuItem.Click += new System.EventHandler(this.moreMoneyToolStripMenuItem_Click);
            // 
            // resetMoneyToolStripMenuItem
            // 
            this.resetMoneyToolStripMenuItem.Name = "resetMoneyToolStripMenuItem";
            this.resetMoneyToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.resetMoneyToolStripMenuItem.Text = "Reset Money";
            this.resetMoneyToolStripMenuItem.Click += new System.EventHandler(this.resetMoneyToolStripMenuItem_Click);
            // 
            // resetLevelToolStripMenuItem
            // 
            this.resetLevelToolStripMenuItem.Name = "resetLevelToolStripMenuItem";
            this.resetLevelToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.resetLevelToolStripMenuItem.Text = "Reset Level";
            this.resetLevelToolStripMenuItem.Click += new System.EventHandler(this.resetLevelToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(254, 6);
            // 
            // forceMoneyBagToolStripMenuItem
            // 
            this.forceMoneyBagToolStripMenuItem.Name = "forceMoneyBagToolStripMenuItem";
            this.forceMoneyBagToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.forceMoneyBagToolStripMenuItem.Text = "Force Money Bag";
            this.forceMoneyBagToolStripMenuItem.Click += new System.EventHandler(this.forceMoneyBagToolStripMenuItem_Click);
            // 
            // forceGenerationBoostToolStripMenuItem
            // 
            this.forceGenerationBoostToolStripMenuItem.Name = "forceGenerationBoostToolStripMenuItem";
            this.forceGenerationBoostToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.forceGenerationBoostToolStripMenuItem.Text = "Force Generation Boost";
            this.forceGenerationBoostToolStripMenuItem.Click += new System.EventHandler(this.forceGenerationBoostToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(254, 6);
            // 
            // newWorldToolStripMenuItem
            // 
            this.newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            this.newWorldToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.newWorldToolStripMenuItem.Text = "New World";
            this.newWorldToolStripMenuItem.Click += new System.EventHandler(this.newWorldToolStripMenuItem_Click);
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
            // worldpop
            // 
            this.worldpop.Enabled = true;
            this.worldpop.Interval = 1000;
            this.worldpop.Tick += new System.EventHandler(this.worldpop_Tick);
            // 
            // MultiGameIcon
            // 
            this.MultiGameIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MultiGameIcon.Icon")));
            this.MultiGameIcon.Text = "Multi Game";
            this.MultiGameIcon.Click += new System.EventHandler(this.MultiGameIcon_Click);
            // 
            // autosavet
            // 
            this.autosavet.Enabled = true;
            this.autosavet.Interval = 15000;
            this.autosavet.Tick += new System.EventHandler(this.autosave_Tick);
            // 
            // clearlogt
            // 
            this.clearlogt.Enabled = true;
            this.clearlogt.Tick += new System.EventHandler(this.clearlogt_Tick);
            // 
            // debugVarsNewToolStripMenuItem
            // 
            this.debugVarsNewToolStripMenuItem.Name = "debugVarsNewToolStripMenuItem";
            this.debugVarsNewToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.debugVarsNewToolStripMenuItem.Text = "Debug Vars [New]";
            this.debugVarsNewToolStripMenuItem.Click += new System.EventHandler(this.debugVarsNewToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ToolStripMenuItem debugVarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem populationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem populationGrowthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem populationGrowthPercentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipilierToolStripMenuItem;
        private System.Windows.Forms.Timer worldpop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem newWorldToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon MultiGameIcon;
        private System.Windows.Forms.ToolStripMenuItem hideGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatNumbersOFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processAllXpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoSaveOFFToolStripMenuItem;
        private System.Windows.Forms.Timer autosavet;
        private System.Windows.Forms.ToolStripMenuItem closeGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem shop3Level225ToolStripMenuItem;
        private System.Windows.Forms.Timer clearlogt;
        private System.Windows.Forms.ToolStripMenuItem enableLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugVarsNewToolStripMenuItem;
    }
}

