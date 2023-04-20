namespace MultiGame.Games;

partial class Shop5
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.button1 = new System.Windows.Forms.Button();
        this.update = new System.Windows.Forms.Timer(this.components);
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(12, 12);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(117, 70);
        this.button1.TabIndex = 0;
        this.button1.Text = "LevelUp Speed 1\r\n$";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // update
        // 
        this.update.Interval = 1000;
        this.update.Tick += new System.EventHandler(this.update_Tick);
        // 
        // Shop5
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(141, 94);
        this.Controls.Add(this.button1);
        this.Name = "Shop5";
        this.ShowIcon = false;
        this.Text = "Shop LvL5";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shop5_FormClosing);
        this.Load += new System.EventHandler(this.Shop5_Load);
        this.ResumeLayout(false);

    }

    #endregion

    private Button button1;
    private System.Windows.Forms.Timer update;
}