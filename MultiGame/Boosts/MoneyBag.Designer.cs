﻿namespace MultiGame.Boosts;

partial class MoneyBag
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
        this.label1 = new System.Windows.Forms.Label();
        this.button1 = new System.Windows.Forms.Button();
        this.tick = new System.Windows.Forms.Timer(this.components);
        this.timer1 = new System.Windows.Forms.Timer(this.components);
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(9, 7);
        this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(42, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Money:";
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(9, 23);
        this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(154, 19);
        this.button1.TabIndex = 1;
        this.button1.Text = "Accept";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // tick
        // 
        this.tick.Enabled = true;
        this.tick.Interval = 1000;
        this.tick.Tick += new System.EventHandler(this.tick_Tick);
        // 
        // timer1
        // 
        this.timer1.Enabled = true;
        this.timer1.Interval = 1;
        this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
        // 
        // MoneyBag
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(172, 52);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.label1);
        this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
        this.Name = "MoneyBag";
        this.ShowIcon = false;
        this.Text = "MoneyBag";
        this.Load += new System.EventHandler(this.MoneyBag_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Timer tick;
    private System.Windows.Forms.Timer timer1;
}