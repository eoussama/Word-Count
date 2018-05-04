using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Word_Count
{
    public partial class fWordCount : Form
    {
        ContextMenu contextMenu = new ContextMenu();
        public fWordCount()
        {
            InitializeComponent();

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

        private void richTextBox_main_TextChanged(object sender, EventArgs e)
        {
            label_characterCount.Text = getCharCount(1).ToString();
            label_characterCountSpaces.Text = getCharCount(2).ToString();
            label_wordCount.Text = (from word in richTextBox_main.Text.Trim().Split(new char[] { '\n', ' ', '.', ',', '!', '?', ':', ';', '/', '\\', '@' }, StringSplitOptions.RemoveEmptyEntries) where word.ToLowerInvariant() != " " select word).Count().ToString();
            label_spaceCount.Text = (getCharCount(1) - getCharCount(2)).ToString();
            label_lineCount.Text = getLineCount().ToString();
        }

        private int getCharCount(int type)
        {
            int count = 0;

            switch(type)
            {
                case 1:
                    {
                        count = richTextBox_main.Text.Length;
                        break;
                    }

                case 2:
                    {
                        count = richTextBox_main.Text.Replace(" ", string.Empty).Trim().Length;
                        break;
                    }
            }

            return count;
        }

        private int getLineCount()
        {
            int count = 1;

            foreach(char _char in richTextBox_main.Text)
            {
                if (_char == '\n')
                    count++;
            }

            return count;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A very simple word counting programme, made on 12/29/2017 - 11:40PM", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox_main.Text.Length > 0 && richTextBox_main.Text != "Input a text here...")
            {
                if (MessageBox.Show("Do you really want to create a new file?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    richTextBox_main.Clear();
            }
            else
                richTextBox_main.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you really want to close this application?", "Application exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                Application.Exit();
        }

        private void pasteTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Clipboard.GetText().Length > 0)
                richTextBox_main.Text += Clipboard.GetText();
        }

        private void copyTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox_main.SelectedText.Length > 0)
                Clipboard.SetText(richTextBox_main.Text);
        }

        private void cutTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox_main.SelectedText.Length > 0)
            {
                Clipboard.SetText(richTextBox_main.Text);
                richTextBox_main.Clear();
            }
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
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveF = new SaveFileDialog() { Filter = "Text files (*.txt)|*.txt", Title = "Select a text file" } ;
            if (saveF.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveF.FileName, richTextBox_main.Lines));
                MessageBox.Show("File saved under " + saveF.FileName, "File save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Styling

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
    }
}
