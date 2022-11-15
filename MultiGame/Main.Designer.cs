
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
            this.fNFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tick = new System.Windows.Forms.Timer(this.components);
            this.levelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xP00ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openGameToolStripMenuItem,
            this.levelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openGameToolStripMenuItem
            // 
            this.openGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickerToolStripMenuItem,
            this.fNFToolStripMenuItem});
            this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
            this.openGameToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.openGameToolStripMenuItem.Text = "Open Game";
            // 
            // clickerToolStripMenuItem
            // 
            this.clickerToolStripMenuItem.Name = "clickerToolStripMenuItem";
            this.clickerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clickerToolStripMenuItem.Text = "Clicker Level 1";
            this.clickerToolStripMenuItem.Click += new System.EventHandler(this.clickerToolStripMenuItem_Click);
            // 
            // fNFToolStripMenuItem
            // 
            this.fNFToolStripMenuItem.Name = "fNFToolStripMenuItem";
            this.fNFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.fNFToolStripMenuItem.Text = "FNF Level 25";
            this.fNFToolStripMenuItem.Click += new System.EventHandler(this.fNFToolStripMenuItem_Click);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelToolStripMenuItem1,
            this.xP00ToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.levelToolStripMenuItem.Text = "Level";
            // 
            // tick
            // 
            this.tick.Enabled = true;
            this.tick.Interval = 1;
            this.tick.Tick += new System.EventHandler(this.tick_Tick);
            // 
            // levelToolStripMenuItem1
            // 
            this.levelToolStripMenuItem1.Name = "levelToolStripMenuItem1";
            this.levelToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.levelToolStripMenuItem1.Text = "Level:";
            // 
            // xP00ToolStripMenuItem
            // 
            this.xP00ToolStripMenuItem.Name = "xP00ToolStripMenuItem";
            this.xP00ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xP00ToolStripMenuItem.Text = "XP:0/0";
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
    }
}

