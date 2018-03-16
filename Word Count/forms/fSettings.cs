using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Count.forms
{
    public partial class fSettings : Form
    {
        // Form ----------------------------------------------------------------------------------------------
        public fSettings()
        {
            InitializeComponent();

            if (classes.Config.Syntax == true)
            {
                comboBSyntax.Enabled = true;
                comboBSyntax.SelectedIndex = (int)classes.Config.Lang;
                cbSyntax.Checked = true;
            }
        }


        // Chekbox -------------------------------------------------------------------------------------------
        private void cbSyntax_CheckedChanged(object sender, EventArgs e)
        {
            if ((classes.Config.Syntax = cbSyntax.Checked) == true)
            {
                comboBSyntax.Enabled = true;
                classes.Core.SyntaxHighlight((classes.Lang)comboBSyntax.SelectedIndex);
            }

            else
            {
                comboBSyntax.Enabled = false;
                classes.Core.SyntaxHighlight((classes.Lang)comboBSyntax.SelectedIndex, true);
            }
        }

        private void comboBSyntax_SelectedIndexChanged(object sender, EventArgs e)
        {
            classes.Config.Lang = (classes.Lang)comboBSyntax.SelectedIndex;
            classes.Core.SyntaxHighlight((classes.Lang)comboBSyntax.SelectedIndex);
        }
    }
}
