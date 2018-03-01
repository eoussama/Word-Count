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
            this.pToolBox = new System.Windows.Forms.Panel();
            this.bRegular = new System.Windows.Forms.Button();
            this.cbAlign = new System.Windows.Forms.ComboBox();
            this.lAlignment = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.lSize = new System.Windows.Forms.Label();
            this.bHighlight = new System.Windows.Forms.Button();
            this.bStrike = new System.Windows.Forms.Button();
            this.bColor = new System.Windows.Forms.Button();
            this.bUnderline = new System.Windows.Forms.Button();
            this.bItalic = new System.Windows.Forms.Button();
            this.bBold = new System.Windows.Forms.Button();
            this.panel_border = new System.Windows.Forms.Panel();
            this.menuStrip_settings = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTextColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeBackgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontFamillyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDocumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.lFont = new System.Windows.Forms.Label();
            this.panel_footer.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.pToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
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
            this.panel_footer.Location = new System.Drawing.Point(0, 416);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(744, 54);
            this.panel_footer.TabIndex = 0;
            // 
            // label_wordCountL
            // 
            this.label_wordCountL.AutoSize = true;
            this.label_wordCountL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wordCountL.Location = new System.Drawing.Point(286, 10);
            this.label_wordCountL.Name = "label_wordCountL";
            this.label_wordCountL.Size = new System.Drawing.Size(53, 16);
            this.label_wordCountL.TabIndex = 13;
            this.label_wordCountL.Text = "Word(s)";
            // 
            // label_wordCount
            // 
            this.label_wordCount.AutoSize = true;
            this.label_wordCount.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_wordCount.Location = new System.Drawing.Point(343, 10);
            this.label_wordCount.Name = "label_wordCount";
            this.label_wordCount.Size = new System.Drawing.Size(15, 16);
            this.label_wordCount.TabIndex = 14;
            this.label_wordCount.Text = "0";
            // 
            // label_spaceCountL
            // 
            this.label_spaceCountL.AutoSize = true;
            this.label_spaceCountL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_spaceCountL.Location = new System.Drawing.Point(286, 30);
            this.label_spaceCountL.Name = "label_spaceCountL";
            this.label_spaceCountL.Size = new System.Drawing.Size(57, 16);
            this.label_spaceCountL.TabIndex = 11;
            this.label_spaceCountL.Text = "Space(s)";
            // 
            // label_spaceCount
            // 
            this.label_spaceCount.AutoSize = true;
            this.label_spaceCount.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_spaceCount.Location = new System.Drawing.Point(343, 30);
            this.label_spaceCount.Name = "label_spaceCount";
            this.label_spaceCount.Size = new System.Drawing.Size(15, 16);
            this.label_spaceCount.TabIndex = 12;
            this.label_spaceCount.Text = "0";
            // 
            // label_lineCountL
            // 
            this.label_lineCountL.AutoSize = true;
            this.label_lineCountL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lineCountL.Location = new System.Drawing.Point(627, 29);
            this.label_lineCountL.Name = "label_lineCountL";
            this.label_lineCountL.Size = new System.Drawing.Size(46, 16);
            this.label_lineCountL.TabIndex = 9;
            this.label_lineCountL.Text = "Line(s)";
            // 
            // label_lineCount
            // 
            this.label_lineCount.AutoSize = true;
            this.label_lineCount.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lineCount.Location = new System.Drawing.Point(684, 29);
            this.label_lineCount.Name = "label_lineCount";
            this.label_lineCount.Size = new System.Drawing.Size(15, 16);
            this.label_lineCount.TabIndex = 10;
            this.label_lineCount.Text = "0";
            // 
            // label_characterCountL
            // 
            this.label_characterCountL.AutoSize = true;
            this.label_characterCountL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_characterCountL.Location = new System.Drawing.Point(40, 10);
            this.label_characterCountL.Name = "label_characterCountL";
            this.label_characterCountL.Size = new System.Drawing.Size(185, 16);
            this.label_characterCountL.TabIndex = 5;
            this.label_characterCountL.Text = "Character(s) (excluding spaces)";
            // 
            // label_characterCountSpaces
            // 
            this.label_characterCountSpaces.AutoSize = true;
            this.label_characterCountSpaces.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_characterCountSpaces.Location = new System.Drawing.Point(231, 31);
            this.label_characterCountSpaces.Name = "label_characterCountSpaces";
            this.label_characterCountSpaces.Size = new System.Drawing.Size(15, 16);
            this.label_characterCountSpaces.TabIndex = 8;
            this.label_characterCountSpaces.Text = "0";
            // 
            // label_characterCountSpacesL
            // 
            this.label_characterCountSpacesL.AutoSize = true;
            this.label_characterCountSpacesL.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_characterCountSpacesL.Location = new System.Drawing.Point(40, 29);
            this.label_characterCountSpacesL.Name = "label_characterCountSpacesL";
            this.label_characterCountSpacesL.Size = new System.Drawing.Size(182, 16);
            this.label_characterCountSpacesL.TabIndex = 6;
            this.label_characterCountSpacesL.Text = "Character(s) (including spaces)";
            // 
            // label_characterCount
            // 
            this.label_characterCount.AutoSize = true;
            this.label_characterCount.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_characterCount.Location = new System.Drawing.Point(231, 10);
            this.label_characterCount.Name = "label_characterCount";
            this.label_characterCount.Size = new System.Drawing.Size(15, 16);
            this.label_characterCount.TabIndex = 7;
            this.label_characterCount.Text = "0";
            // 
            // richTextBox_main
            // 
            this.richTextBox_main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_main.CausesValidation = false;
            this.richTextBox_main.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_main.ForeColor = System.Drawing.Color.Gray;
            this.richTextBox_main.HideSelection = false;
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
            this.panel_main.Controls.Add(this.pToolBox);
            this.panel_main.Controls.Add(this.panel_border);
            this.panel_main.Controls.Add(this.menuStrip_settings);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(744, 416);
            this.panel_main.TabIndex = 1;
            // 
            // pToolBox
            // 
            this.pToolBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pToolBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pToolBox.Controls.Add(this.cbFont);
            this.pToolBox.Controls.Add(this.lFont);
            this.pToolBox.Controls.Add(this.bRegular);
            this.pToolBox.Controls.Add(this.cbAlign);
            this.pToolBox.Controls.Add(this.lAlignment);
            this.pToolBox.Controls.Add(this.nudSize);
            this.pToolBox.Controls.Add(this.lSize);
            this.pToolBox.Controls.Add(this.bHighlight);
            this.pToolBox.Controls.Add(this.bStrike);
            this.pToolBox.Controls.Add(this.bColor);
            this.pToolBox.Controls.Add(this.bUnderline);
            this.pToolBox.Controls.Add(this.bItalic);
            this.pToolBox.Controls.Add(this.bBold);
            this.pToolBox.Location = new System.Drawing.Point(43, 32);
            this.pToolBox.Name = "pToolBox";
            this.pToolBox.Size = new System.Drawing.Size(656, 25);
            this.pToolBox.TabIndex = 4;
            // 
            // bRegular
            // 
            this.bRegular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bRegular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegular.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegular.Location = new System.Drawing.Point(-1, -1);
            this.bRegular.Name = "bRegular";
            this.bRegular.Size = new System.Drawing.Size(27, 25);
            this.bRegular.TabIndex = 11;
            this.bRegular.Text = "R";
            this.bRegular.UseVisualStyleBackColor = true;
            this.bRegular.Click += new System.EventHandler(this.bRegular_Click);
            // 
            // cbAlign
            // 
            this.cbAlign.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbAlign.DisplayMember = "0";
            this.cbAlign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAlign.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlign.FormattingEnabled = true;
            this.cbAlign.Items.AddRange(new object[] {
            "Left",
            "Center",
            "Right"});
            this.cbAlign.Location = new System.Drawing.Point(579, 1);
            this.cbAlign.Name = "cbAlign";
            this.cbAlign.Size = new System.Drawing.Size(74, 22);
            this.cbAlign.TabIndex = 10;
            this.cbAlign.SelectedIndexChanged += new System.EventHandler(this.cbAlign_SelectedIndexChanged);
            // 
            // lAlignment
            // 
            this.lAlignment.AutoSize = true;
            this.lAlignment.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAlignment.Location = new System.Drawing.Point(517, 4);
            this.lAlignment.Name = "lAlignment";
            this.lAlignment.Size = new System.Drawing.Size(61, 14);
            this.lAlignment.TabIndex = 9;
            this.lAlignment.Text = "Alignment";
            // 
            // nudSize
            // 
            this.nudSize.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSize.Location = new System.Drawing.Point(295, 0);
            this.nudSize.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(47, 23);
            this.nudSize.TabIndex = 7;
            this.nudSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSize.Location = new System.Drawing.Point(265, 4);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(29, 14);
            this.lSize.TabIndex = 6;
            this.lSize.Text = "Size";
            // 
            // bHighlight
            // 
            this.bHighlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bHighlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHighlight.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bHighlight.Location = new System.Drawing.Point(192, -1);
            this.bHighlight.Name = "bHighlight";
            this.bHighlight.Size = new System.Drawing.Size(71, 25);
            this.bHighlight.TabIndex = 5;
            this.bHighlight.Text = "Highlight";
            this.bHighlight.UseVisualStyleBackColor = true;
            this.bHighlight.Click += new System.EventHandler(this.bHighlight_Click);
            // 
            // bStrike
            // 
            this.bStrike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bStrike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStrike.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStrike.Location = new System.Drawing.Point(103, -1);
            this.bStrike.Name = "bStrike";
            this.bStrike.Size = new System.Drawing.Size(27, 25);
            this.bStrike.TabIndex = 4;
            this.bStrike.Text = "S";
            this.bStrike.UseVisualStyleBackColor = true;
            this.bStrike.Click += new System.EventHandler(this.bStrike_Click);
            // 
            // bColor
            // 
            this.bColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bColor.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bColor.Location = new System.Drawing.Point(129, -1);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(66, 25);
            this.bColor.TabIndex = 3;
            this.bColor.Text = "Color";
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            // 
            // bUnderline
            // 
            this.bUnderline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUnderline.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUnderline.Location = new System.Drawing.Point(77, -1);
            this.bUnderline.Name = "bUnderline";
            this.bUnderline.Size = new System.Drawing.Size(27, 25);
            this.bUnderline.TabIndex = 2;
            this.bUnderline.Text = "U";
            this.bUnderline.UseVisualStyleBackColor = true;
            this.bUnderline.Click += new System.EventHandler(this.bUnderline_Click);
            // 
            // bItalic
            // 
            this.bItalic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bItalic.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bItalic.Location = new System.Drawing.Point(51, -1);
            this.bItalic.Name = "bItalic";
            this.bItalic.Size = new System.Drawing.Size(27, 25);
            this.bItalic.TabIndex = 1;
            this.bItalic.Text = "I";
            this.bItalic.UseVisualStyleBackColor = true;
            this.bItalic.Click += new System.EventHandler(this.bItalic_Click);
            // 
            // bBold
            // 
            this.bBold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBold.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBold.Location = new System.Drawing.Point(25, -1);
            this.bBold.Name = "bBold";
            this.bBold.Size = new System.Drawing.Size(27, 25);
            this.bBold.TabIndex = 0;
            this.bBold.Text = "B";
            this.bBold.UseVisualStyleBackColor = true;
            this.bBold.Click += new System.EventHandler(this.bBold_Click);
            // 
            // panel_border
            // 
            this.panel_border.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel_border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_border.Controls.Add(this.richTextBox_main);
            this.panel_border.Location = new System.Drawing.Point(43, 63);
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
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
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
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
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
            this.changeFontFamillyToolStripMenuItem,
            this.clearDocumentToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // pasteTextToolStripMenuItem
            // 
            this.pasteTextToolStripMenuItem.Name = "pasteTextToolStripMenuItem";
            this.pasteTextToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.pasteTextToolStripMenuItem.Text = "Paste text";
            this.pasteTextToolStripMenuItem.Click += new System.EventHandler(this.pasteTextToolStripMenuItem_Click);
            // 
            // copyTextToolStripMenuItem
            // 
            this.copyTextToolStripMenuItem.Name = "copyTextToolStripMenuItem";
            this.copyTextToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.copyTextToolStripMenuItem.Text = "Copy text";
            this.copyTextToolStripMenuItem.Click += new System.EventHandler(this.copyTextToolStripMenuItem_Click);
            // 
            // cutTextToolStripMenuItem
            // 
            this.cutTextToolStripMenuItem.Name = "cutTextToolStripMenuItem";
            this.cutTextToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cutTextToolStripMenuItem.Text = "Cut text";
            this.cutTextToolStripMenuItem.Click += new System.EventHandler(this.cutTextToolStripMenuItem_Click);
            // 
            // changeTextColorToolStripMenuItem
            // 
            this.changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
            this.changeTextColorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.changeTextColorToolStripMenuItem.Text = "Change text color";
            this.changeTextColorToolStripMenuItem.Click += new System.EventHandler(this.changeTextColorToolStripMenuItem_Click);
            // 
            // changeBackgroundColorToolStripMenuItem
            // 
            this.changeBackgroundColorToolStripMenuItem.Name = "changeBackgroundColorToolStripMenuItem";
            this.changeBackgroundColorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.changeBackgroundColorToolStripMenuItem.Text = "Change background color";
            this.changeBackgroundColorToolStripMenuItem.Click += new System.EventHandler(this.changeBackgroundColorToolStripMenuItem_Click);
            // 
            // changeFontFamillyToolStripMenuItem
            // 
            this.changeFontFamillyToolStripMenuItem.Name = "changeFontFamillyToolStripMenuItem";
            this.changeFontFamillyToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.changeFontFamillyToolStripMenuItem.Text = "Change font familly";
            this.changeFontFamillyToolStripMenuItem.Click += new System.EventHandler(this.changeFontFamillyToolStripMenuItem_Click);
            // 
            // clearDocumentToolStripMenuItem
            // 
            this.clearDocumentToolStripMenuItem.Name = "clearDocumentToolStripMenuItem";
            this.clearDocumentToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.clearDocumentToolStripMenuItem.Text = "Clear document";
            this.clearDocumentToolStripMenuItem.Click += new System.EventHandler(this.clearDocumentToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cbFont
            // 
            this.cbFont.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cbFont.DisplayMember = "0";
            this.cbFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFont.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(410, 1);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(103, 22);
            this.cbFont.TabIndex = 13;
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.cbFont_SelectedIndexChanged);
            // 
            // lFont
            // 
            this.lFont.AutoSize = true;
            this.lFont.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFont.Location = new System.Drawing.Point(345, 4);
            this.lFont.Name = "lFont";
            this.lFont.Size = new System.Drawing.Size(66, 14);
            this.lFont.TabIndex = 12;
            this.lFont.Text = "Font family";
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
            this.pToolBox.ResumeLayout(false);
            this.pToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
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
        private System.Windows.Forms.Panel pToolBox;
        private System.Windows.Forms.Button bBold;
        private System.Windows.Forms.Button bUnderline;
        private System.Windows.Forms.Button bItalic;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.Button bStrike;
        private System.Windows.Forms.Button bHighlight;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label lAlignment;
        private System.Windows.Forms.ComboBox cbAlign;
        private System.Windows.Forms.ToolStripMenuItem clearDocumentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button bRegular;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Label lFont;
    }
}

