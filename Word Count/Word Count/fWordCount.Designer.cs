namespace Word_Count
{
    partial class fWordCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fWordCount));
            this.panel_footer = new System.Windows.Forms.Panel();
            this.label_wordCountL = new System.Windows.Forms.Label();
            this.label_wordCount = new System.Windows.Forms.Label();
            this.label_spaceCountL = new System.Windows.Forms.Label();
            this.label_spaceCount = new System.Windows.Forms.Label();
            this.label_lineCountL = new System.Windows.Forms.Label();
            this.label_lineCount = new System.Windows.Forms.Label();
            this.label_characterCountL = new System.Windows.Forms.Label();
            this.label_characterCountSpaces = new System.Windows.Forms.Label();
            this.label_characterCountSpacesL = new System.Windows.Forms.Label();
            this.label_characterCount = new System.Windows.Forms.Label();
            this.richTextBox_main = new System.Windows.Forms.RichTextBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_border = new System.Windows.Forms.Panel();
            this.menuStrip_settings = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontFamillyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_footer.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_border.SuspendLayout();
            this.menuStrip_settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_footer
            // 
            this.panel_footer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_footer.Controls.Add(this.label_wordCountL);
            this.panel_footer.Controls.Add(this.label_wordCount);
            this.panel_footer.Controls.Add(this.label_spaceCountL);
            this.panel_footer.Controls.Add(this.label_spaceCount);
            this.panel_footer.Controls.Add(this.label_lineCountL);
            this.panel_footer.Controls.Add(this.label_lineCount);
            this.panel_footer.Controls.Add(this.label_characterCountL);
            this.panel_footer.Controls.Add(this.label_characterCountSpaces);
            this.panel_footer.Controls.Add(this.label_characterCountSpacesL);
            this.panel_footer.Controls.Add(this.label_characterCount);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 396);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(744, 74);
            this.panel_footer.TabIndex = 0;
            // 
            // label_wordCountL
            // 
            this.label_wordCountL.AutoSize = true;
            this.label_wordCountL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wordCountL.Location = new System.Drawing.Point(286, 17);
            this.label_wordCountL.Name = "label_wordCountL";
            this.label_wordCountL.Size = new System.Drawing.Size(53, 16);
            this.label_wordCountL.TabIndex = 13;
            this.label_wordCountL.Text = "Word(s)";
            // 
            // label_wordCount
            // 
            this.label_wordCount.AutoSize = true;
            this.label_wordCount.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wordCount.Location = new System.Drawing.Point(343, 17);
            this.label_wordCount.Name = "label_wordCount";
            this.label_wordCount.Size = new System.Drawing.Size(15, 16);
            this.label_wordCount.TabIndex = 14;
            this.label_wordCount.Text = "0";
            // 
            // label_spaceCountL
            // 
            this.label_spaceCountL.AutoSize = true;
            this.label_spaceCountL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_spaceCountL.Location = new System.Drawing.Point(286, 44);
            this.label_spaceCountL.Name = "label_spaceCountL";
            this.label_spaceCountL.Size = new System.Drawing.Size(57, 16);
            this.label_spaceCountL.TabIndex = 11;
            this.label_spaceCountL.Text = "Space(s)";
            // 
            // label_spaceCount
            // 
            this.label_spaceCount.AutoSize = true;
            this.label_spaceCount.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_spaceCount.Location = new System.Drawing.Point(343, 44);
            this.label_spaceCount.Name = "label_spaceCount";
            this.label_spaceCount.Size = new System.Drawing.Size(15, 16);
            this.label_spaceCount.TabIndex = 12;
            this.label_spaceCount.Text = "0";
            // 
            // label_lineCountL
            // 
            this.label_lineCountL.AutoSize = true;
            this.label_lineCountL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lineCountL.Location = new System.Drawing.Point(627, 44);
            this.label_lineCountL.Name = "label_lineCountL";
            this.label_lineCountL.Size = new System.Drawing.Size(46, 16);
            this.label_lineCountL.TabIndex = 9;
            this.label_lineCountL.Text = "Line(s)";
            // 
            // label_lineCount
            // 
            this.label_lineCount.AutoSize = true;
            this.label_lineCount.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lineCount.Location = new System.Drawing.Point(684, 44);
            this.label_lineCount.Name = "label_lineCount";
            this.label_lineCount.Size = new System.Drawing.Size(15, 16);
            this.label_lineCount.TabIndex = 10;
            this.label_lineCount.Text = "0";
            // 
            // label_characterCountL
            // 
            this.label_characterCountL.AutoSize = true;
            this.label_characterCountL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_characterCountL.Location = new System.Drawing.Point(40, 17);
            this.label_characterCountL.Name = "label_characterCountL";
            this.label_characterCountL.Size = new System.Drawing.Size(185, 16);
            this.label_characterCountL.TabIndex = 5;
            this.label_characterCountL.Text = "Character(s) (excluding spaces)";
            // 
            // label_characterCountSpaces
            // 
            this.label_characterCountSpaces.AutoSize = true;
            this.label_characterCountSpaces.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_characterCountSpaces.Location = new System.Drawing.Point(231, 46);
            this.label_characterCountSpaces.Name = "label_characterCountSpaces";
            this.label_characterCountSpaces.Size = new System.Drawing.Size(15, 16);
            this.label_characterCountSpaces.TabIndex = 8;
            this.label_characterCountSpaces.Text = "0";
            // 
            // label_characterCountSpacesL
            // 
            this.label_characterCountSpacesL.AutoSize = true;
            this.label_characterCountSpacesL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_characterCountSpacesL.Location = new System.Drawing.Point(40, 44);
            this.label_characterCountSpacesL.Name = "label_characterCountSpacesL";
            this.label_characterCountSpacesL.Size = new System.Drawing.Size(182, 16);
            this.label_characterCountSpacesL.TabIndex = 6;
            this.label_characterCountSpacesL.Text = "Character(s) (including spaces)";
            // 
            // label_characterCount
            // 
            this.label_characterCount.AutoSize = true;
            this.label_characterCount.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_characterCount.Location = new System.Drawing.Point(231, 17);
            this.label_characterCount.Name = "label_characterCount";
            this.label_characterCount.Size = new System.Drawing.Size(15, 16);
            this.label_characterCount.TabIndex = 7;
            this.label_characterCount.Text = "0";
            // 
            // richTextBox_main
            // 
            this.richTextBox_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_main.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_main.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox_main.Location = new System.Drawing.Point(21, 16);
            this.richTextBox_main.Name = "richTextBox_main";
            this.richTextBox_main.Size = new System.Drawing.Size(612, 304);
            this.richTextBox_main.TabIndex = 1;
            this.richTextBox_main.Text = "Input a text here...";
            this.richTextBox_main.WordWrap = false;
            this.richTextBox_main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox_main_MouseClick);
            this.richTextBox_main.TextChanged += new System.EventHandler(this.richTextBox_main_TextChanged);
            this.richTextBox_main.Leave += new System.EventHandler(this.richTextBox_main_Leave);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_border);
            this.panel_main.Controls.Add(this.menuStrip_settings);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(744, 396);
            this.panel_main.TabIndex = 1;
            // 
            // panel_border
            // 
            this.panel_border.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel_border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_border.Controls.Add(this.richTextBox_main);
            this.panel_border.Location = new System.Drawing.Point(43, 34);
            this.panel_border.Name = "panel_border";
            this.panel_border.Size = new System.Drawing.Size(656, 337);
            this.panel_border.TabIndex = 2;
            // 
            // menuStrip_settings
            // 
            this.menuStrip_settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip_settings.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_settings.Name = "menuStrip_settings";
            this.menuStrip_settings.Size = new System.Drawing.Size(744, 24);
            this.menuStrip_settings.TabIndex = 3;
            this.menuStrip_settings.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteTextToolStripMenuItem,
            this.copyTextToolStripMenuItem,
            this.cutTextToolStripMenuItem,
            this.changeTextColorToolStripMenuItem,
            this.changeBackgroundColorToolStripMenuItem,
            this.changeFontFamillyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // pasteTextToolStripMenuItem
            // 
            this.pasteTextToolStripMenuItem.Name = "pasteTextToolStripMenuItem";
            this.pasteTextToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.pasteTextToolStripMenuItem.Text = "Paste text";
            this.pasteTextToolStripMenuItem.Click += new System.EventHandler(this.pasteTextToolStripMenuItem_Click);
            // 
            // copyTextToolStripMenuItem
            // 
            this.copyTextToolStripMenuItem.Name = "copyTextToolStripMenuItem";
            this.copyTextToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.copyTextToolStripMenuItem.Text = "Copy text";
            this.copyTextToolStripMenuItem.Click += new System.EventHandler(this.copyTextToolStripMenuItem_Click);
            // 
            // cutTextToolStripMenuItem
            // 
            this.cutTextToolStripMenuItem.Name = "cutTextToolStripMenuItem";
            this.cutTextToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.cutTextToolStripMenuItem.Text = "Cut text";
            this.cutTextToolStripMenuItem.Click += new System.EventHandler(this.cutTextToolStripMenuItem_Click);
            // 
            // changeTextColorToolStripMenuItem
            // 
            this.changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
            this.changeTextColorToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.changeTextColorToolStripMenuItem.Text = "Change text color";
            this.changeTextColorToolStripMenuItem.Click += new System.EventHandler(this.changeTextColorToolStripMenuItem_Click);
            // 
            // changeBackgroundColorToolStripMenuItem
            // 
            this.changeBackgroundColorToolStripMenuItem.Name = "changeBackgroundColorToolStripMenuItem";
            this.changeBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.changeBackgroundColorToolStripMenuItem.Text = "Change background color";
            this.changeBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.changeBackgroundColorToolStripMenuItem_Click);
            // 
            // changeFontFamillyToolStripMenuItem
            // 
            this.changeFontFamillyToolStripMenuItem.Name = "changeFontFamillyToolStripMenuItem";
            this.changeFontFamillyToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.changeFontFamillyToolStripMenuItem.Text = "Change font familly";
            this.changeFontFamillyToolStripMenuItem.Click += new System.EventHandler(this.changeFontFamillyToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fWordCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 470);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_settings;
            this.MaximizeBox = false;
            this.Name = "fWordCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Count";
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.panel_border.ResumeLayout(false);
            this.menuStrip_settings.ResumeLayout(false);
            this.menuStrip_settings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_footer;
        private System.Windows.Forms.RichTextBox richTextBox_main;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_border;
        private System.Windows.Forms.Label label_lineCountL;
        private System.Windows.Forms.Label label_lineCount;
        private System.Windows.Forms.Label label_characterCountL;
        private System.Windows.Forms.Label label_characterCountSpaces;
        private System.Windows.Forms.Label label_characterCountSpacesL;
        private System.Windows.Forms.Label label_characterCount;
        private System.Windows.Forms.Label label_spaceCountL;
        private System.Windows.Forms.Label label_spaceCount;
        private System.Windows.Forms.Label label_wordCountL;
        private System.Windows.Forms.Label label_wordCount;
        private System.Windows.Forms.MenuStrip menuStrip_settings;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTextColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeBackgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontFamillyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutTextToolStripMenuItem;
    }
}

