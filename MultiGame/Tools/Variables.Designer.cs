namespace MultiGame.Tools;

partial class Variables
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
        this.button2 = new System.Windows.Forms.Button();
        this.timer1 = new System.Windows.Forms.Timer(this.components);
        this.richTextBox1 = new System.Windows.Forms.RichTextBox();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(203, 11);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(91, 23);
        this.button1.TabIndex = 2;
        this.button1.Text = "Refresh";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(203, 40);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(91, 38);
        this.button2.TabIndex = 3;
        this.button2.Text = "Auto Refresh";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // timer1
        // 
        this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        // 
        // richTextBox1
        // 
        this.richTextBox1.Location = new System.Drawing.Point(12, 11);
        this.richTextBox1.Name = "richTextBox1";
        this.richTextBox1.Size = new System.Drawing.Size(185, 206);
        this.richTextBox1.TabIndex = 4;
        this.richTextBox1.Text = "";
        // 
        // Variables
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(306, 229);
        this.Controls.Add(this.richTextBox1);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Name = "Variables";
        this.ShowIcon = false;
        this.Text = "Variables";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Variables_FormClosing);
        this.Load += new System.EventHandler(this.Variables_Load);
        this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.RichTextBox richTextBox1;
}