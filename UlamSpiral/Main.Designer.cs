namespace UlamSpiral
{
    partial class Main
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
            this.sizeBox = new System.Windows.Forms.TextBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fontList = new System.Windows.Forms.ListBox();
            this.drawDotsBox = new System.Windows.Forms.CheckBox();
            this.squareButton = new System.Windows.Forms.RadioButton();
            this.primeButton = new System.Windows.Forms.RadioButton();
            this.containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeBox
            // 
            this.sizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeBox.Location = new System.Drawing.Point(697, 28);
            this.sizeBox.MaxLength = 3;
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(38, 20);
            this.sizeBox.TabIndex = 1;
            this.sizeBox.TextChanged += new System.EventHandler(this.sizeBox_TextChanged);
            this.sizeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sizeBox_KeyPress);
            // 
            // sizeLabel
            // 
            this.sizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(697, 12);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(30, 13);
            this.sizeLabel.TabIndex = 2;
            this.sizeLabel.Text = "Size:";
            // 
            // containerPanel
            // 
            this.containerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.containerPanel.AutoScroll = true;
            this.containerPanel.Controls.Add(this.viewPanel);
            this.containerPanel.Location = new System.Drawing.Point(12, 12);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(679, 419);
            this.containerPanel.TabIndex = 3;
            // 
            // viewPanel
            // 
            this.viewPanel.Location = new System.Drawing.Point(218, 131);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(200, 100);
            this.viewPanel.TabIndex = 0;
            this.viewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.viewPanel_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(697, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Font:";
            // 
            // fontList
            // 
            this.fontList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fontList.FormattingEnabled = true;
            this.fontList.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.fontList.Location = new System.Drawing.Point(697, 76);
            this.fontList.Name = "fontList";
            this.fontList.Size = new System.Drawing.Size(39, 108);
            this.fontList.TabIndex = 5;
            this.fontList.SelectedIndexChanged += new System.EventHandler(this.fontList_SelectedIndexChanged);
            // 
            // drawDotsBox
            // 
            this.drawDotsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drawDotsBox.AutoSize = true;
            this.drawDotsBox.Checked = true;
            this.drawDotsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.drawDotsBox.Location = new System.Drawing.Point(697, 190);
            this.drawDotsBox.Name = "drawDotsBox";
            this.drawDotsBox.Size = new System.Drawing.Size(48, 17);
            this.drawDotsBox.TabIndex = 6;
            this.drawDotsBox.Text = "Dots";
            this.drawDotsBox.UseVisualStyleBackColor = true;
            this.drawDotsBox.CheckedChanged += new System.EventHandler(this.drawDotsBox_CheckedChanged);
            // 
            // squareButton
            // 
            this.squareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.squareButton.AutoSize = true;
            this.squareButton.Checked = true;
            this.squareButton.Location = new System.Drawing.Point(697, 226);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(64, 17);
            this.squareButton.TabIndex = 7;
            this.squareButton.TabStop = true;
            this.squareButton.Text = "Squares";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.CheckedChanged += new System.EventHandler(this.squareButton_CheckedChanged);
            // 
            // primeButton
            // 
            this.primeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.primeButton.AutoSize = true;
            this.primeButton.Location = new System.Drawing.Point(697, 249);
            this.primeButton.Name = "primeButton";
            this.primeButton.Size = new System.Drawing.Size(56, 17);
            this.primeButton.TabIndex = 8;
            this.primeButton.Text = "Primes";
            this.primeButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(806, 443);
            this.Controls.Add(this.primeButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.drawDotsBox);
            this.Controls.Add(this.fontList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.containerPanel);
            this.Name = "Main";
            this.Text = "Ulam\'s Spiral";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sizeBox;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox fontList;
        private System.Windows.Forms.CheckBox drawDotsBox;
        private System.Windows.Forms.RadioButton squareButton;
        private System.Windows.Forms.RadioButton primeButton;

    }
}

