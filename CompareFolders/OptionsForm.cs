using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CompareDir
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();

            try
            {
                uiExcludedFoldersTextBox.Text = File.ReadAllText("ExcludedFolders.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading ExcludedFolders.txt file");
            }

            try
            {
                uiExcludePatternsTextBox.Text = File.ReadAllText("ExcludePatterns.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading ExcludePatterns.txt file");
            }

            uiCompareToolComboBox.Text = FoldersCompareForm.Instance.CompareTool;
            uiIgnoreSpacesAndEntersCheckBox.Checked = FoldersCompareForm.Instance.IgnoreSpacesAndEnters;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            File.WriteAllText("ExcludedFolders.txt", uiExcludedFoldersTextBox.Text);
            FoldersCompareForm.Instance.ReadExcludedFolders();

            File.WriteAllText("ExcludePatterns.txt", uiExcludePatternsTextBox.Text);
            FoldersCompareForm.Instance.ReadExcludePatterns();

            FoldersCompareForm.Instance.CompareTool = uiCompareToolComboBox.Text;
            FoldersCompareForm.Instance.IgnoreSpacesAndEnters = uiIgnoreSpacesAndEntersCheckBox.Checked;
        }
    }
}
