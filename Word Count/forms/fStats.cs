using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word_Count.classes;

namespace Word_Count.forms
{
    public partial class fStats : Form
    {
        public fStats()
        {
            InitializeComponent();

            lWordsStats.Text = Core.getWordsCount();
            lCharsStats.Text = Core.getCharsCount();
            lWordMost.Text += $" {Core.getWordMost()}";
            lCharMost.Text += $" {Core.getCharMost()}";
        }
    }
}
