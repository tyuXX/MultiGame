namespace MultiGame.Games;

partial class MagicPowerGenerator
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
        this.button1 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(12, 12);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(157, 94);
        this.button1.TabIndex = 0;
        this.button1.Text = "Create Magic Power $1";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // MagicPowerGenerator
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(181, 118);
        this.Controls.Add(this.button1);
        this.Name = "MagicPowerGenerator";
        this.ShowIcon = false;
        this.Text = "MagicPowerGenerator";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MagicPowerGenerator_FormClosing);
        this.Load += new System.EventHandler(this.MagicPowerGenerator_Load);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
}