namespace Word_Count.forms
{
    partial class fStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStats));
            this.pChars = new System.Windows.Forms.Panel();
            this.pWords = new System.Windows.Forms.Panel();
            this.lChars = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lCharsStats = new System.Windows.Forms.Label();
            this.lWordsStats = new System.Windows.Forms.Label();
            this.lCharMost = new System.Windows.Forms.Label();
            this.lWordMost = new System.Windows.Forms.Label();
            this.pChars.SuspendLayout();
            this.pWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // pChars
            // 
            this.pChars.AutoScroll = true;
            this.pChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pChars.Controls.Add(this.lCharsStats);
            this.pChars.Location = new System.Drawing.Point(11, 30);
            this.pChars.Name = "pChars";
            this.pChars.Size = new System.Drawing.Size(180, 269);
            this.pChars.TabIndex = 0;
            // 
            // pWords
            // 
            this.pWords.AutoScroll = true;
            this.pWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pWords.Controls.Add(this.lWordsStats);
            this.pWords.Location = new System.Drawing.Point(205, 30);
            this.pWords.Name = "pWords";
            this.pWords.Size = new System.Drawing.Size(180, 269);
            this.pWords.TabIndex = 1;
            // 
            // lChars
            // 
            this.lChars.AutoSize = true;
            this.lChars.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lChars.Location = new System.Drawing.Point(12, 9);
            this.lChars.Name = "lChars";
            this.lChars.Size = new System.Drawing.Size(142, 18);
            this.lChars.TabIndex = 2;
            this.lChars.Text = "Character statistics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Word statistics";
            // 
            // lCharsStats
            // 
            this.lCharsStats.AutoSize = true;
            this.lCharsStats.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCharsStats.Location = new System.Drawing.Point(13, 13);
            this.lCharsStats.Name = "lCharsStats";
            this.lCharsStats.Size = new System.Drawing.Size(0, 25);
            this.lCharsStats.TabIndex = 0;
            // 
            // lWordsStats
            // 
            this.lWordsStats.AutoSize = true;
            this.lWordsStats.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWordsStats.Location = new System.Drawing.Point(12, 13);
            this.lWordsStats.Name = "lWordsStats";
            this.lWordsStats.Size = new System.Drawing.Size(0, 25);
            this.lWordsStats.TabIndex = 1;
            // 
            // lCharMost
            // 
            this.lCharMost.AutoSize = true;
            this.lCharMost.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCharMost.Location = new System.Drawing.Point(12, 321);
            this.lCharMost.Name = "lCharMost";
            this.lCharMost.Size = new System.Drawing.Size(146, 18);
            this.lCharMost.TabIndex = 4;
            this.lCharMost.Text = "Most used character: ";
            // 
            // lWordMost
            // 
            this.lWordMost.AutoSize = true;
            this.lWordMost.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWordMost.Location = new System.Drawing.Point(12, 355);
            this.lWordMost.Name = "lWordMost";
            this.lWordMost.Size = new System.Drawing.Size(114, 18);
            this.lWordMost.TabIndex = 5;
            this.lWordMost.Text = "Most used word:";
            // 
            // fStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 387);
            this.Controls.Add(this.lWordMost);
            this.Controls.Add(this.lCharMost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lChars);
            this.Controls.Add(this.pWords);
            this.Controls.Add(this.pChars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "fStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.pChars.ResumeLayout(false);
            this.pChars.PerformLayout();
            this.pWords.ResumeLayout(false);
            this.pWords.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pChars;
        private System.Windows.Forms.Panel pWords;
        private System.Windows.Forms.Label lChars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCharsStats;
        private System.Windows.Forms.Label lWordsStats;
        private System.Windows.Forms.Label lCharMost;
        private System.Windows.Forms.Label lWordMost;
    }
}