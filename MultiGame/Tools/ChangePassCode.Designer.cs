namespace MultiGame.Tools;

partial class ChangePassCode
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
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.button1 = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textBox1.Location = new System.Drawing.Point(12, 28);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(247, 22);
        this.textBox1.TabIndex = 0;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(116, 16);
        this.label1.TabIndex = 1;
        this.label1.Text = "Current PassCode";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(12, 53);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(101, 16);
        this.label2.TabIndex = 3;
        this.label2.Text = "New PassCode";
        // 
        // textBox2
        // 
        this.textBox2.Location = new System.Drawing.Point(12, 72);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(247, 22);
        this.textBox2.TabIndex = 2;
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(12, 100);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(247, 31);
        this.button1.TabIndex = 4;
        this.button1.Text = "Change";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // ChangePassCode
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(271, 148);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.textBox2);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.textBox1);
        this.Name = "ChangePassCode";
        this.ShowIcon = false;
        this.Text = "ChangePassCode";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassCode_FormClosing);
        this.Load += new System.EventHandler(this.ChangePassCode_Load);
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button1;
}