
namespace MultiGame.Games;

partial class FNF
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
        this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        this.button3 = new System.Windows.Forms.Button();
        this.button4 = new System.Windows.Forms.Button();
        this.button5 = new System.Windows.Forms.Button();
        this.button6 = new System.Windows.Forms.Button();
        this.tick = new System.Windows.Forms.Timer(this.components);
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.SpeedTick = new System.Windows.Forms.Timer(this.components);
        this.button7 = new System.Windows.Forms.Button();
        this.button8 = new System.Windows.Forms.Button();
        this.button9 = new System.Windows.Forms.Button();
        this.button10 = new System.Windows.Forms.Button();
        this.button11 = new System.Windows.Forms.Button();
        this.button12 = new System.Windows.Forms.Button();
        this.menuStrip1.SuspendLayout();
        this.SuspendLayout();
        // 
        // menuStrip1
        // 
        this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.controlsToolStripMenuItem});
        this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        this.menuStrip1.Name = "menuStrip1";
        this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
        this.menuStrip1.Size = new System.Drawing.Size(345, 24);
        this.menuStrip1.TabIndex = 0;
        this.menuStrip1.Text = "menuStrip1";
        // 
        // controlsToolStripMenuItem
        // 
        this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        this.leftToolStripMenuItem,
        this.rightToolStripMenuItem,
        this.upToolStripMenuItem,
        this.downToolStripMenuItem});
        this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
        this.controlsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
        this.controlsToolStripMenuItem.Text = "Controls";
        // 
        // leftToolStripMenuItem
        // 
        this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
        this.leftToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
        this.leftToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        this.leftToolStripMenuItem.Text = "Left";
        this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
        // 
        // rightToolStripMenuItem
        // 
        this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
        this.rightToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
        this.rightToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        this.rightToolStripMenuItem.Text = "Right";
        this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
        // 
        // upToolStripMenuItem
        // 
        this.upToolStripMenuItem.Name = "upToolStripMenuItem";
        this.upToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
        this.upToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        this.upToolStripMenuItem.Text = "Up";
        this.upToolStripMenuItem.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
        // 
        // downToolStripMenuItem
        // 
        this.downToolStripMenuItem.Name = "downToolStripMenuItem";
        this.downToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        this.downToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
        this.downToolStripMenuItem.Text = "Down";
        this.downToolStripMenuItem.Click += new System.EventHandler(this.downToolStripMenuItem_Click);
        // 
        // button1
        // 
        this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.button1.AutoSize = true;
        this.button1.BackColor = System.Drawing.Color.Red;
        this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.button1.Location = new System.Drawing.Point(9, 27);
        this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(63, 50);
        this.button1.TabIndex = 1;
        this.button1.Text = "←";
        this.button1.UseVisualStyleBackColor = false;
        this.button1.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
        // 
        // button2
        // 
        this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.button2.AutoSize = true;
        this.button2.BackColor = System.Drawing.Color.Red;
        this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.button2.Location = new System.Drawing.Point(72, 27);
        this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(58, 50);
        this.button2.TabIndex = 2;
        this.button2.Text = "↑";
        this.button2.UseVisualStyleBackColor = false;
        this.button2.Click += new System.EventHandler(this.upToolStripMenuItem_Click);
        // 
        // button3
        // 
        this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.button3.AutoSize = true;
        this.button3.BackColor = System.Drawing.Color.Red;
        this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.button3.Location = new System.Drawing.Point(135, 27);
        this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.button3.Name = "button3";
        this.button3.Size = new System.Drawing.Size(58, 50);
        this.button3.TabIndex = 3;
        this.button3.Text = "↓";
        this.button3.UseVisualStyleBackColor = false;
        this.button3.Click += new System.EventHandler(this.downToolStripMenuItem_Click);
        // 
        // button4
        // 
        this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.button4.AutoSize = true;
        this.button4.BackColor = System.Drawing.Color.Red;
        this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.button4.Location = new System.Drawing.Point(198, 27);
        this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.button4.Name = "button4";
        this.button4.Size = new System.Drawing.Size(63, 50);
        this.button4.TabIndex = 4;
        this.button4.Text = "→";
        this.button4.UseVisualStyleBackColor = false;
        this.button4.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
        // 
        // button5
        // 
        this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.button5.AutoSize = true;
        this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
        this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.button5.Location = new System.Drawing.Point(72, 82);
        this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.button5.Name = "button5";
        this.button5.Size = new System.Drawing.Size(58, 50);
        this.button5.TabIndex = 5;
        this.button5.UseVisualStyleBackColor = false;
        // 
        // button6
        // 
        this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.button6.AutoSize = true;
        this.button6.BackColor = System.Drawing.SystemColors.Highlight;
        this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
        this.button6.Location = new System.Drawing.Point(9, 82);
        this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.button6.Name = "button6";
        this.button6.Size = new System.Drawing.Size(58, 50);
        this.button6.TabIndex = 6;
        this.button6.UseVisualStyleBackColor = false;
        // 
        // tick
        // 
        this.tick.Interval = 1000;
        this.tick.Tick += new System.EventHandler(this.tick_Tick);
        // 
        // label1
        // 
        this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(292, 28);
        this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(40, 13);
        this.label1.TabIndex = 7;
        this.label1.Text = "Rights:";
        // 
        // label2
        // 
        this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(292, 41);
        this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(42, 13);
        this.label2.TabIndex = 8;
        this.label2.Text = "Misses:";
        // 
        // SpeedTick
        // 
        this.SpeedTick.Enabled = true;
        this.SpeedTick.Interval = 1;
        this.SpeedTick.Tick += new System.EventHandler(this.SpeedTick_Tick);
        // 
        // button7
        // 
        this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.button7.BackColor = System.Drawing.Color.Lime;
        this.button7.Location = new System.Drawing.Point(11, 28);
        this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.button7.Name = "button7";
        this.button7.Size = new System.Drawing.Size(56, 50);
        this.button7.TabIndex = 9;
        this.button7.Text = "Easy";
        this.button7.UseVisualStyleBackColor = false;
        this.button7.Click += new System.EventHandler(this.button7_Click);
        // 
        // button8
        // 
        this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.button8.BackColor = System.Drawing.Color.Aqua;
        this.button8.Location = new System.Drawing.Point(74, 28);
        this.button8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.button8.Name = "button8";
        this.button8.Size = new System.Drawing.Size(56, 50);
        this.button8.TabIndex = 10;
        this.button8.Text = "Normal";
        this.button8.UseVisualStyleBackColor = false;
        this.button8.Click += new System.EventHandler(this.button8_Click);
        // 
        // button9
        // 
        this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.button9.BackColor = System.Drawing.Color.Blue;
        this.button9.Location = new System.Drawing.Point(136, 27);
        this.button9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.button9.Name = "button9";
        this.button9.Size = new System.Drawing.Size(56, 50);
        this.button9.TabIndex = 11;
        this.button9.Text = "Medium";
        this.button9.UseVisualStyleBackColor = false;
        this.button9.Click += new System.EventHandler(this.button9_Click);
        // 
        // button10
        // 
        this.button10.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        this.button10.Location = new System.Drawing.Point(200, 28);
        this.button10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.button10.Name = "button10";
        this.button10.Size = new System.Drawing.Size(56, 50);
        this.button10.TabIndex = 12;
        this.button10.Text = "Hard";
        this.button10.UseVisualStyleBackColor = false;
        this.button10.Click += new System.EventHandler(this.button10_Click);
        // 
        // button11
        // 
        this.button11.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.button11.BackColor = System.Drawing.Color.Red;
        this.button11.Location = new System.Drawing.Point(260, 28);
        this.button11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.button11.Name = "button11";
        this.button11.Size = new System.Drawing.Size(56, 50);
        this.button11.TabIndex = 13;
        this.button11.Text = "Very Hard";
        this.button11.UseVisualStyleBackColor = false;
        this.button11.Click += new System.EventHandler(this.button11_Click);
        // 
        // button12
        // 
        this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
        this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
        this.button12.Location = new System.Drawing.Point(74, 81);
        this.button12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.button12.Name = "button12";
        this.button12.Size = new System.Drawing.Size(183, 50);
        this.button12.TabIndex = 14;
        this.button12.Text = "INSANE";
        this.button12.UseVisualStyleBackColor = false;
        this.button12.Click += new System.EventHandler(this.button12_Click);
        // 
        // FNF
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(345, 154);
        this.Controls.Add(this.button12);
        this.Controls.Add(this.button11);
        this.Controls.Add(this.button10);
        this.Controls.Add(this.button9);
        this.Controls.Add(this.button8);
        this.Controls.Add(this.button7);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.button6);
        this.Controls.Add(this.button5);
        this.Controls.Add(this.button4);
        this.Controls.Add(this.button3);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.menuStrip1);
        this.MainMenuStrip = this.menuStrip1;
        this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.Name = "FNF";
        this.ShowIcon = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "FNF";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FNF_FormClosing);
        this.Load += new System.EventHandler(this.FNF_Load);
        this.menuStrip1.ResumeLayout(false);
        this.menuStrip1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem upToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Timer tick;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Timer SpeedTick;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button10;
    private System.Windows.Forms.Button button11;
    private System.Windows.Forms.Button button12;
}

