namespace MultiGame.Tools;

partial class Log
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
        this.timer1 = new System.Windows.Forms.Timer(this.components);
        this.richTextBox1 = new System.Windows.Forms.RichTextBox();
        this.SuspendLayout();
        // 
        // timer1
        // 
        this.timer1.Enabled = true;
        this.timer1.Interval = 1000;
        this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        // 
        // richTextBox1
        // 
        this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.richTextBox1.Location = new System.Drawing.Point(0, 0);
        this.richTextBox1.Name = "richTextBox1";
        this.richTextBox1.Size = new System.Drawing.Size(448, 303);
        this.richTextBox1.TabIndex = 0;
        this.richTextBox1.Text = "";
        // 
        // Log
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(448, 303);
        this.Controls.Add(this.richTextBox1);
        this.Name = "Log";
        this.ShowIcon = false;
        this.Text = "Log";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_FormClosing);
        this.Load += new System.EventHandler(this.Log_Load);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.RichTextBox richTextBox1;
}