namespace CompareDir
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.uiExcludePatternsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uiCompareToolComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiIgnoreSpacesAndEntersCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiExcludedFoldersTextBox = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiExcludePatternsTextBox
            // 
            this.uiExcludePatternsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiExcludePatternsTextBox.Location = new System.Drawing.Point(3, 35);
            this.uiExcludePatternsTextBox.Multiline = true;
            this.uiExcludePatternsTextBox.Name = "uiExcludePatternsTextBox";
            this.uiExcludePatternsTextBox.Size = new System.Drawing.Size(527, 303);
            this.uiExcludePatternsTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exclude patterns (Excluded files are reported - Slow)";
            // 
            // uiCompareToolComboBox
            // 
            this.uiCompareToolComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiCompareToolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiCompareToolComboBox.FormattingEnabled = true;
            this.uiCompareToolComboBox.Items.AddRange(new object[] {
            "Microsoft Visual Studio",
            "WinDiff"});
            this.uiCompareToolComboBox.Location = new System.Drawing.Point(88, 569);
            this.uiCompareToolComboBox.Name = "uiCompareToolComboBox";
            this.uiCompareToolComboBox.Size = new System.Drawing.Size(189, 21);
            this.uiCompareToolComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Compare tool:";
            // 
            // uiIgnoreSpacesAndEntersCheckBox
            // 
            this.uiIgnoreSpacesAndEntersCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.uiIgnoreSpacesAndEntersCheckBox.AutoSize = true;
            this.uiIgnoreSpacesAndEntersCheckBox.Location = new System.Drawing.Point(13, 539);
            this.uiIgnoreSpacesAndEntersCheckBox.Name = "uiIgnoreSpacesAndEntersCheckBox";
            this.uiIgnoreSpacesAndEntersCheckBox.Size = new System.Drawing.Size(149, 17);
            this.uiIgnoreSpacesAndEntersCheckBox.TabIndex = 4;
            this.uiIgnoreSpacesAndEntersCheckBox.Text = "Ignore Spaces and Enters";
            this.uiIgnoreSpacesAndEntersCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Excluded folders (Set relative paths - Excluded files are not reported - Fast):";
            // 
            // uiExcludedFoldersTextBox
            // 
            this.uiExcludedFoldersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiExcludedFoldersTextBox.Location = new System.Drawing.Point(3, 37);
            this.uiExcludedFoldersTextBox.Multiline = true;
            this.uiExcludedFoldersTextBox.Name = "uiExcludedFoldersTextBox";
            this.uiExcludedFoldersTextBox.Size = new System.Drawing.Size(527, 124);
            this.uiExcludedFoldersTextBox.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.uiExcludedFoldersTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.uiExcludePatternsTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(533, 518);
            this.splitContainer1.SplitterDistance = 173;
            this.splitContainer1.TabIndex = 9;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 611);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.uiIgnoreSpacesAndEntersCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiCompareToolComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiExcludePatternsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uiCompareToolComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox uiIgnoreSpacesAndEntersCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiExcludedFoldersTextBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}