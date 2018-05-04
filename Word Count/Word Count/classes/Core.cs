using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;

namespace Word_Count.classes
{
    public enum Style { Regular, Bold, Italic, Underline, Strike }

    public enum Align { Left = 0, Center, Right }

    public static class Core
    {
        // Text processing --------------------------------------------------------------------------
        public static void Paste()
        {
            if (Clipboard.GetText().Length > 0)
            {
                if (fWordCount.textField.SelectionLength > 0)
                {
                    if (MessageBox.Show("Do you want to paste over current selection?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        fWordCount.textField.SelectionStart = fWordCount.textField.SelectionStart + fWordCount.textField.SelectionLength;
                }

                fWordCount.textField.Paste();
            }
        }

        public static void Copy()
        {
            if(fWordCount.textField.SelectionLength > 0)
            {
                fWordCount.textField.Copy();
            }
        }

        public static void Cut()
        {
            if (fWordCount.textField.Text != "")
            {
                fWordCount.textField.Cut();
            }
        }

        public static void ChangeColor(ColorDialog cDialog)
        {
            fWordCount.textField.SelectionColor = cDialog.Color;
        }

        public static void Highlight(ColorDialog cDialog)
        {
            fWordCount.textField.SelectionBackColor = cDialog.Color;
        }

        public static void ChangeFont(string font)
        {
            FontFamily ff = new FontFamily(font);
            fWordCount.textField.SelectionFont = new Font(ff, fWordCount.textField.SelectionFont.Size, fWordCount.textField.SelectionFont.Style);
        }

        public static void ChangeStyle(Style style)
        {
            switch(style)
            {
                case Style.Regular:
                {
                    fWordCount.textField.SelectionFont = new Font(fWordCount.textField.Font, FontStyle.Regular);
                    break;
                }

                case Style.Bold :
                {
                    fWordCount.textField.SelectionFont = new Font(fWordCount.textField.Font, FontStyle.Bold);
                    break;
                }

                case Style.Italic:
                {
                    fWordCount.textField.SelectionFont = new Font(fWordCount.textField.Font, FontStyle.Italic);
                    break;
                }

                case Style.Underline:
                {
                    fWordCount.textField.SelectionFont = new Font(fWordCount.textField.Font, FontStyle.Underline);
                    break;
                }

                case Style.Strike:
                {
                    fWordCount.textField.SelectionFont = new Font(fWordCount.textField.Font, FontStyle.Strikeout);
                    break;
                }
            }
        }

        public static void Align(Align align)
        {
            switch(align)
            {
                case classes.Align.Left:
                {
                    fWordCount.textField.SelectionAlignment = HorizontalAlignment.Left;
                    break;
                }

                case classes.Align.Center:
                {
                    fWordCount.textField.SelectionAlignment = HorizontalAlignment.Center;
                    break;
                }

                case classes.Align.Right:
                {
                    fWordCount.textField.SelectionAlignment = HorizontalAlignment.Right;
                    break;
                }
            }
            
        }

        public static void SyntaxHighlight()
        {
            Regex regexKeywords = new Regex(@"\b(for|return|sizeof|int|string|float|char|if|new|stock|public|true|false)\b");
            int selIndex = fWordCount.textField.SelectionStart;

            foreach(Match match in regexKeywords.Matches(fWordCount.textField.Text))
            {
                fWordCount.textField.Select(match.Index, match.Value.Length);
                fWordCount.textField.SelectionColor = Color.Blue;
                fWordCount.textField.SelectionStart = selIndex;
                fWordCount.textField.SelectionColor = Color.Black;
            }
        }


        // Statistics -------------------------------------------------------------------------------
        public static int getCharCount(int type)
        {
            int count = 0;

            switch (type)
            {
                case 1:
                    {
                        count = fWordCount.textField.Text.Length;
                        break;
                    }

                case 2:
                    {
                        count = fWordCount.textField.Text.Replace(" ", string.Empty).Trim().Length;
                        break;
                    }
            }

            return count;
        }

        public static int getLineCount()
        {
            int count = 1;

            foreach (char _char in fWordCount.textField.Text)
            {
                if (_char == '\n')
                    count++;
            }

            return count;
        }
    }
}
