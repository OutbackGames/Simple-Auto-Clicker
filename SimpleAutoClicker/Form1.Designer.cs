namespace SimpleAutoClicker
{
    partial class Form1
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
            this.startClickerBtn = new System.Windows.Forms.Button();
            this.stopClickerBtn = new System.Windows.Forms.Button();
            this.tboxMaxSeconds = new System.Windows.Forms.TextBox();
            this.tboxMinSeconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setTimeRangeBtn = new System.Windows.Forms.Button();
            this.resetTimeRangeBtn = new System.Windows.Forms.Button();
            this.lblClickerState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startClickerBtn
            // 
            this.startClickerBtn.Location = new System.Drawing.Point(37, 113);
            this.startClickerBtn.Name = "startClickerBtn";
            this.startClickerBtn.Size = new System.Drawing.Size(175, 34);
            this.startClickerBtn.TabIndex = 0;
            this.startClickerBtn.Text = "Toggle Clicker\r\n(Home Button when In game)";
            this.startClickerBtn.UseVisualStyleBackColor = true;
            this.startClickerBtn.Click += new System.EventHandler(this.startClickerBtn_Click);
            // 
            // stopClickerBtn
            // 
            this.stopClickerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopClickerBtn.Location = new System.Drawing.Point(285, 113);
            this.stopClickerBtn.Name = "stopClickerBtn";
            this.stopClickerBtn.Size = new System.Drawing.Size(162, 33);
            this.stopClickerBtn.TabIndex = 1;
            this.stopClickerBtn.Text = "Force Stop Clicker";
            this.stopClickerBtn.UseVisualStyleBackColor = true;
            this.stopClickerBtn.Click += new System.EventHandler(this.stopClickerBtn_Click);
            // 
            // tboxMaxSeconds
            // 
            this.tboxMaxSeconds.Location = new System.Drawing.Point(98, 25);
            this.tboxMaxSeconds.MaxLength = 4;
            this.tboxMaxSeconds.Name = "tboxMaxSeconds";
            this.tboxMaxSeconds.Size = new System.Drawing.Size(114, 20);
            this.tboxMaxSeconds.TabIndex = 2;
            // 
            // tboxMinSeconds
            // 
            this.tboxMinSeconds.Location = new System.Drawing.Point(98, 61);
            this.tboxMinSeconds.MaxLength = 4;
            this.tboxMinSeconds.Name = "tboxMinSeconds";
            this.tboxMinSeconds.Size = new System.Drawing.Size(114, 20);
            this.tboxMinSeconds.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Max Seconds";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Min Seconds";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setTimeRangeBtn
            // 
            this.setTimeRangeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setTimeRangeBtn.Location = new System.Drawing.Point(285, 25);
            this.setTimeRangeBtn.Name = "setTimeRangeBtn";
            this.setTimeRangeBtn.Size = new System.Drawing.Size(149, 20);
            this.setTimeRangeBtn.TabIndex = 6;
            this.setTimeRangeBtn.Text = "Set Clicker Time Range";
            this.setTimeRangeBtn.UseVisualStyleBackColor = true;
            this.setTimeRangeBtn.Click += new System.EventHandler(this.setTimeRangeBtn_Click);
            // 
            // resetTimeRangeBtn
            // 
            this.resetTimeRangeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetTimeRangeBtn.Location = new System.Drawing.Point(284, 54);
            this.resetTimeRangeBtn.Name = "resetTimeRangeBtn";
            this.resetTimeRangeBtn.Size = new System.Drawing.Size(149, 26);
            this.resetTimeRangeBtn.TabIndex = 7;
            this.resetTimeRangeBtn.Text = "Use Default Time Ranges";
            this.resetTimeRangeBtn.UseVisualStyleBackColor = true;
            this.resetTimeRangeBtn.Click += new System.EventHandler(this.resetTimeRangeBtn_Click);
            // 
            // lblClickerState
            // 
            this.lblClickerState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickerState.Location = new System.Drawing.Point(129, 167);
            this.lblClickerState.Name = "lblClickerState";
            this.lblClickerState.Size = new System.Drawing.Size(259, 43);
            this.lblClickerState.TabIndex = 8;
            this.lblClickerState.Text = "Clicker State: Disabled";
            this.lblClickerState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClickerState.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 256);
            this.Controls.Add(this.lblClickerState);
            this.Controls.Add(this.resetTimeRangeBtn);
            this.Controls.Add(this.setTimeRangeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxMinSeconds);
            this.Controls.Add(this.tboxMaxSeconds);
            this.Controls.Add(this.stopClickerBtn);
            this.Controls.Add(this.startClickerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Simple Auto Clicker";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblClickerState;

        private System.Windows.Forms.Button resetTimeRangeBtn;

        private System.Windows.Forms.Button setTimeRangeBtn;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox tboxMaxSeconds;
        private System.Windows.Forms.TextBox tboxMinSeconds;

        private System.Windows.Forms.Button startClickerBtn;
        private System.Windows.Forms.Button stopClickerBtn;

        #endregion
    }
}