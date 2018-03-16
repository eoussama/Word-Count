namespace Word_Count.forms
{
    partial class fSettings
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
            this.gbSyntax = new System.Windows.Forms.GroupBox();
            this.comboBSyntax = new System.Windows.Forms.ComboBox();
            this.cbSyntax = new System.Windows.Forms.CheckBox();
            this.gbSyntax.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSyntax
            // 
            this.gbSyntax.Controls.Add(this.comboBSyntax);
            this.gbSyntax.Controls.Add(this.cbSyntax);
            this.gbSyntax.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSyntax.Location = new System.Drawing.Point(12, 7);
            this.gbSyntax.Name = "gbSyntax";
            this.gbSyntax.Size = new System.Drawing.Size(312, 58);
            this.gbSyntax.TabIndex = 0;
            this.gbSyntax.TabStop = false;
            this.gbSyntax.Text = "Syntax highlight";
            // 
            // comboBSyntax
            // 
            this.comboBSyntax.Enabled = false;
            this.comboBSyntax.FormattingEnabled = true;
            this.comboBSyntax.Items.AddRange(new object[] {
            "pawn"});
            this.comboBSyntax.Location = new System.Drawing.Point(183, 26);
            this.comboBSyntax.Name = "comboBSyntax";
            this.comboBSyntax.Size = new System.Drawing.Size(121, 22);
            this.comboBSyntax.TabIndex = 1;
            this.comboBSyntax.SelectedIndexChanged += new System.EventHandler(this.comboBSyntax_SelectedIndexChanged);
            // 
            // cbSyntax
            // 
            this.cbSyntax.AutoSize = true;
            this.cbSyntax.Location = new System.Drawing.Point(9, 31);
            this.cbSyntax.Name = "cbSyntax";
            this.cbSyntax.Size = new System.Drawing.Size(110, 18);
            this.cbSyntax.TabIndex = 0;
            this.cbSyntax.Text = "Highlight syntax";
            this.cbSyntax.UseVisualStyleBackColor = true;
            this.cbSyntax.CheckedChanged += new System.EventHandler(this.cbSyntax_CheckedChanged);
            // 
            // fSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 261);
            this.Controls.Add(this.gbSyntax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Count - Settings";
            this.gbSyntax.ResumeLayout(false);
            this.gbSyntax.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSyntax;
        private System.Windows.Forms.ComboBox comboBSyntax;
        private System.Windows.Forms.CheckBox cbSyntax;
    }
}