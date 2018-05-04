using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Word_Count.classes;

namespace Word_Count
{
    public partial class fWordCount : Form
    {
        public static RichTextBox textField;
        private static string filePath = "";
        private ContextMenu contextMenu = new ContextMenu();
        
        // Form --------------------------------------------------------------------------------------------------
        public fWordCount()
        {
            InitializeComponent();

            cbAlign.SelectedIndex = 0;
            nudSize.Value = (int)richTextBox_main.Font.Size;
            foreach (FontFamily font in FontFamily.Families)
                cbFont.Items.Add(font.Name);
            cbFont.Text = richTextBox_main.Font.FontFamily.Name;

            textField = richTextBox_main;
            MenuItem mItem_Paste = new MenuItem();
            MenuItem mItem_Copy = new MenuItem();
            MenuItem mItem_Cut = new MenuItem();

            mItem_Paste.Index = 0;
            mItem_Copy.Index = 1;
            mItem_Cut.Index = 2;
            mItem_Paste.Text = "Paste";
            mItem_Copy.Text = "Copy";
            mItem_Cut.Text = "Cut";

            mItem_Paste.Click += new System.EventHandler(pasteTextToolStripMenuItem_Click);
            mItem_Copy.Click += new System.EventHandler(copyTextToolStripMenuItem_Click);
            mItem_Cut.Click += new System.EventHandler(cutTextToolStripMenuItem_Click);

            contextMenu.MenuItems.Add(mItem_Paste);
            contextMenu.MenuItems.Add(mItem_Copy);
            contextMenu.MenuItems.Add(mItem_Cut);

            richTextBox_main.ContextMenu = contextMenu;
        }


        // RichTextBox -------------------------------------------------------------------------------------------
        private void richTextBox_main_TextChanged(object sender, EventArgs e)
        {
            label_characterCount.Text = Core.getCharCount(1).ToString();
            label_characterCountSpaces.Text = Core.getCharCount(2).ToString();
            label_wordCount.Text = (from word in richTextBox_main.Text.Trim().Split(new char[] { '\n', ' ', '.', ',', '!', '?', ':', ';', '/', '\\', '@' }, StringSplitOptions.RemoveEmptyEntries) where word.ToLowerInvariant() != " " select word).Count().ToString();
            label_spaceCount.Text = (Core.getCharCount(1) - Core.getCharCount(2)).ToString();
            label_lineCount.Text = Core.getLineCount().ToString();
            Core.SyntaxHighlight();
        }

        private void richTextBox_main_MouseClick(object sender, MouseEventArgs e)
        {
            if (richTextBox_main.Text == "Input a text here...")
            {
                richTextBox_main.ForeColor = SystemColors.WindowText;
                richTextBox_main.Clear();
            }
        }

        private void richTextBox_main_Leave(object sender, EventArgs e)
        {
            if (richTextBox_main.Text.Length == 0)
            {
                richTextBox_main.ForeColor = Color.DarkGray;
                richTextBox_main.Text = "Input a text here...";
            }
        }


        // ToolStrip - File --------------------------------------------------------------------------------------
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox_main.Text.Length > 0 && richTextBox_main.Text != "Input a text here...")
            {
                if (MessageBox.Show("Do you really want to create a new file?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    richTextBox_main.Clear();
            }
            else
                richTextBox_main.Clear();

            filePath = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox_main.Text.Length > 0 && richTextBox_main.Text != "Input a text here...")
            {
                if (MessageBox.Show("Opening a new file will reset your current file\n do you want to open a new file?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    OpenFileDialog openF = new OpenFileDialog() { Filter = "Text files (*.txt)|*.txt", Multiselect = false, Title = "Select a text file" };
                    if (openF.ShowDialog() == DialogResult.OK)
                    {
                        StreamReader sReader = new StreamReader(openF.FileName);
                        richTextBox_main.Text = sReader.ReadToEnd();
                        sReader.Close();
                        richTextBox_main.ForeColor = SystemColors.WindowText;
                        filePath = openF.FileName;
                    }
                }
            }

            else
            {
                OpenFileDialog openF = new OpenFileDialog() { Filter = "Text files (*.txt)|*.txt", Multiselect = false, Title = "Select a text file" };
                if (openF.ShowDialog() == DialogResult.OK)
                {
                    StreamReader sReader = new StreamReader(openF.FileName);
                    richTextBox_main.Text = sReader.ReadToEnd();
                    sReader.Close();
                    richTextBox_main.ForeColor = SystemColors.WindowText;
                    filePath = openF.FileName;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filePath != "")
            {
                StreamWriter streamW = new StreamWriter(filePath, false);
                streamW.Write(richTextBox_main.Text);
                streamW.Flush();
                streamW.Close();
            }

            else
                saveAsToolStripMenuItem_Click(this, e);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveF = new SaveFileDialog() { Filter = "Text files (*.txt)|*.txt", Title = "Select a text file" };
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveF.FileName, richTextBox_main.Lines);
                MessageBox.Show("File saved under " + saveF.FileName, "File save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                filePath = saveF.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to close this application?", "Application exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }


        // ToolStrip - Edit --------------------------------------------------------------------------------------
        private void pasteTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Core.Paste();
        }

        private void copyTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Core.Copy();
        }

        private void cutTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Core.Cut();
        }

        private void changeTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog() { Color = richTextBox_main.ForeColor };
            if (colorDialog.ShowDialog() == DialogResult.OK)
                richTextBox_main.ForeColor = colorDialog.Color;
        }

        private void changeBackgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog() { Color = richTextBox_main.BackColor };
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox_main.BackColor = colorDialog.Color;
                panel_border.BackColor = colorDialog.Color;
            }
        }

        private void changeFontFamillyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog() { Font = richTextBox_main.Font };
            if (fontDialog.ShowDialog() == DialogResult.OK)
                richTextBox_main.Font = fontDialog.Font;
        }

        private void clearDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_main.Clear();
        }

        // ToolStrip - About --------------------------------------------------------------------------------------
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A very simple word counting programme, made on 12/29/2017 - 11:40PM", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        // Toolbox ------------------------------------------------------------------------------------------------
        private void bBold_Click(object sender, EventArgs e)
        {
            if(richTextBox_main.SelectionLength > 0)
                Core.ChangeStyle(Style.Bold);
        }

        private void bRegular_Click(object sender, EventArgs e)
        {
            if (richTextBox_main.SelectionLength > 0)
                Core.ChangeStyle(Style.Regular);
        }

        private void bItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox_main.SelectionLength > 0)
                Core.ChangeStyle(Style.Italic);
        }

        private void bUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBox_main.SelectionLength > 0)
                Core.ChangeStyle(Style.Underline);
        }

        private void bStrike_Click(object sender, EventArgs e)
        {
            if (richTextBox_main.SelectionLength > 0)
                Core.ChangeStyle(Style.Strike);
        }

        private void nudSize_ValueChanged(object sender, EventArgs e)
        {
            if (richTextBox_main.SelectionLength > 0)
                richTextBox_main.SelectionFont = new Font(richTextBox_main.SelectionFont.FontFamily, (float)nudSize.Value, richTextBox_main.SelectionFont.Style);
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox_main.SelectionLength > 0)
                Core.ChangeFont(cbFont.Text);
        }

        private void cbAlign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox_main.SelectionLength > 0)
                Core.Align((Align)cbAlign.SelectedIndex);
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog() { Color = richTextBox_main.SelectionColor };
            if (cDialog.ShowDialog() == DialogResult.OK)
                Core.ChangeColor(cDialog);
        }

        private void bHighlight_Click(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog() { Color = richTextBox_main.SelectionBackColor };
            if (cDialog.ShowDialog() == DialogResult.OK)
                Core.Highlight(cDialog);
        }
    }
}
