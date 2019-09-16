using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Reflection;
using CompareFolders;

namespace CompareDir
{
    public partial class FoldersCompareForm : Form
    {
        public static FoldersCompareForm Instance;
        public List<string> ExcludedFolders;
        public List<string> ExcludePatterns;
        public string CompareTool = "WinDiff";//default value
        public bool IgnoreSpacesAndEnters = false;//default value
        public List<string> Path1List = new List<string>();
        public List<string> Path2List = new List<string>();

        int ClickedCell_RowIndex;
        int ClickedCell_ColumnIndex;

        bool StopClicked = false;

        public FoldersCompareForm()
        {
            InitializeComponent();

            Instance = this;
            this.Text += " V" + Application.ProductVersion.ToString();
            uiCompareEndMessageLabel.Visible = false;

            //File name is changed from Config.ini to DirsCompare.settings
            if (File.Exists("Config.ini"))
                File.Delete("Config.ini");

            //File name is changed from DirsCompare.settings to CompareFolders.settings
            if (File.Exists(Path.Combine(Path.GetTempPath(), "DirsCompare.settings")))
            {
                if (!File.Exists(Path.Combine(Path.GetTempPath(), "CompareFolders.settings")))
                    File.Copy(Path.Combine(Path.GetTempPath(), "DirsCompare.settings"), Path.Combine(Path.GetTempPath(), "CompareFolders.settings"));

                File.Delete(Path.Combine(Path.GetTempPath(), "DirsCompare.settings"));
            }

            //File name is changed from ExcludeList to ExcludePatterns:
            if (File.Exists("ExcludeList.txt"))
            {
                if (!File.Exists("ExcludePatterns.txt"))
                    File.Copy("ExcludeList.txt", "ExcludePatterns.txt");

                File.Delete("ExcludeList.txt");
            }

            ReadSettings();
        }

        private void uiCompareButton_Click(object sender, EventArgs e)
        {
            if (uiCompareButton.Text == "Compare")
            {
                uiCompareButton.Text = "Stop";
                StopClicked = false;

                try
                {
                    uiStatusBarLabel.Text = "Loading files list...";
                    Application.DoEvents();

                    var path1FileInfos = GetAllFiles(uiPath1ComboBox.Text);
                    var path2FileInfos = GetAllFiles(uiPath2ComboBox.Text);
                    var differentItems = new List<FileCompareItem>();
                    var excludedItems = new List<FileCompareItem>();
                    var totalItemsCount = path1FileInfos.Count;
                    var checkedItems = 0;

                    if (!Path1List.Any(o => o.ToLower().Trim() == uiPath1ComboBox.Text.ToLower().Trim()))
                    {
                        Path1List.Add(uiPath1ComboBox.Text.Trim());
                        uiPath1ComboBox.Items.Add(uiPath1ComboBox.Text.Trim());
                    }

                    if (!Path2List.Any(o => o.ToLower().Trim() == uiPath2ComboBox.Text.ToLower().Trim()))
                    {
                        Path2List.Add(uiPath2ComboBox.Text.Trim());
                        uiPath2ComboBox.Items.Add(uiPath2ComboBox.Text.Trim());
                    }

                    {
                        LightFileInfo path2FileInfo;

                        foreach (var path1FileInfo in path1FileInfos)
                        {
                            if (StopClicked)
                            {
                                return;
                            }

                            try
                            {
                                //if (checkedItems % 10 == 0)
                                //{
                                //    uiStatusBarLabel.Text = string.Format("Comparing files: {0} / {1}", checkedItems, totalItemsCount);
                                //    Application.DoEvents();
                                //}

                                uiStatusBarLabel.Text = string.Format("Checking files: {0}/{1}    ({2})", checkedItems, totalItemsCount, path1FileInfo.FullName);
                                Application.DoEvents();

                                path2FileInfo = path2FileInfos.FirstOrDefault(p2f => p2f.FullName.Replace(uiPath2ComboBox.Text, "") == path1FileInfo.FullName.Replace(uiPath1ComboBox.Text, ""));
                                var matchedExcludePattern = ExcludePatterns.FirstOrDefault(o => path1FileInfo.FullName.ToLower().Contains(o.ToLower()));

                                if (matchedExcludePattern != null)
                                    excludedItems.Add(new FileCompareItem(path1FileInfo.FileInfo, path2FileInfo != null ? path2FileInfo.FileInfo : null, matchedExcludePattern));
                                else if (path2FileInfo == null)
                                    differentItems.Add(new FileCompareItem(path1FileInfo.FileInfo, null, "Not in Path2"));
                                else if (!FilesAreEqual(path1FileInfo.FullName, path2FileInfo.FullName, IgnoreSpacesAndEnters))
                                {
                                    if (path1FileInfo.LastWriteTime > path2FileInfo.LastWriteTime)
                                        differentItems.Add(new FileCompareItem(path1FileInfo.FileInfo, path2FileInfo.FileInfo, "Path1 is newer"));
                                    else
                                        differentItems.Add(new FileCompareItem(path1FileInfo.FileInfo, path2FileInfo.FileInfo, "Path2 is newer"));
                                }

                                if (path2FileInfo != null)
                                    path2FileInfos.Remove(path2FileInfo);//for performance

                                checkedItems++;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    {
                        LightFileInfo path1FileInfo;

                        foreach (var path2FileInfo in path2FileInfos)
                        {
                            if (StopClicked)
                            {
                                return;
                            }

                            try
                            {
                                uiStatusBarLabel.Text = string.Format("Checking Path2 files: ({0})", path2FileInfo.FullName);
                                Application.DoEvents();

                                path1FileInfo = path1FileInfos.FirstOrDefault(p1f => p1f.FullName.Replace(uiPath1ComboBox.Text, "") == path2FileInfo.FullName.Replace(uiPath2ComboBox.Text, ""));
                                var matchedExcludePattern = ExcludePatterns.FirstOrDefault(o => path2FileInfo.FullName.ToLower().Contains(o.ToLower()));

                                if (matchedExcludePattern != null)
                                    excludedItems.Add(new FileCompareItem(path1FileInfo != null ? path1FileInfo.FileInfo : null, path2FileInfo.FileInfo, matchedExcludePattern));
                                else if (path1FileInfo == null)
                                    differentItems.Add(new FileCompareItem(null, path2FileInfo.FileInfo, "Not in Path1"));
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    uiStatusBarLabel.Text = "Generating report...";
                    Application.DoEvents();

                    uiFoundDifferencesTabPage.Text = string.Format("Found differences ({0})", differentItems.Count);
                    uiFoundDifferencesDataGridView.DataSource = differentItems;
                    uiFoundDifferencesDataGridView.Refresh();

                    uiExcludedFilesTabPage.Text = string.Format("Excluded files report ({0})", excludedItems.Count);
                    uiExcludedFilesDataGridView.DataSource = excludedItems;
                    uiExcludedFilesDataGridView.Refresh();

                    uiStatusBarLabel.Text = "Done.";
                    uiCompareEndMessageLabel.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    OnCompareStoped();
                }
            }
            else if (uiCompareButton.Text == "Stop")
            {
                uiStatusBarLabel.Text = "Stop clicked.";
                StopClicked = true;
                uiCompareButton.Enabled = false; //disable button until compare action completely stops (OnCompareStoped).
            }
                
        }

        private void OnCompareStoped()
        {
            uiCompareButton.Text = "Compare";
            uiCompareButton.Enabled = true;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            SaveSettings();
        }

        List<LightFileInfo> GetAllFiles(string path)
        {
            var fileInfosList = new List<LightFileInfo>();
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            foreach (FileInfo fileInfo in dirInfo.GetFiles())
            {
                fileInfosList.Add(new LightFileInfo(fileInfo));
            }

            foreach (DirectoryInfo subDirInfo in dirInfo.GetDirectories())
            {
                var comparePath1 = uiPath1ComboBox.Text.ToLower().Trim();
                var comparePath2 = uiPath2ComboBox.Text.ToLower().Trim();
                var folderPath = subDirInfo.FullName.ToLower();

                if (folderPath.StartsWith(comparePath1))
                {
                    if (ExcludedFolders.Any(excludedFolder => folderPath.Replace(comparePath1, "").Trim('\\').StartsWith(excludedFolder.ToLower().Trim().Trim('\\'))))
                        continue;
                }

                if (folderPath.StartsWith(comparePath2))
                {
                    if (ExcludedFolders.Any(excludedFolder => folderPath.Replace(comparePath2, "").Trim('\\').StartsWith(excludedFolder.ToLower().Trim().Trim('\\'))))
                        continue;
                }
                
                fileInfosList.AddRange(GetAllFiles(subDirInfo.FullName));
            }

            return fileInfosList;
        }

        private void uiOptionsButton_Click(object sender, EventArgs e)
        {
            var optionsForm = new OptionsForm();
            optionsForm.ShowDialog();
        }

        static bool FilesAreEqual(FileInfo file1, FileInfo file2, bool IgnoreSpacesAndEnters)
        {
            if (file1.LastWriteTime == file2.LastWriteTime)
                return true;

            byte[] file1Bytes = File.ReadAllBytes(file1.FullName);
            byte[] file2Bytes = File.ReadAllBytes(file2.FullName);

            if (file1Bytes.Length == 0 && file2Bytes.Length == 0)
                return true;

            if ((file1Bytes.Length == 0 && file2Bytes.Length != 0) || (file2Bytes.Length == 0 && file1Bytes.Length != 0))
                return false;

            var file1Text = File.ReadAllText(file1.FullName);
            var file2Text = File.ReadAllText(file2.FullName);

            var file1CurrentIndex = 0;
            var file2CurrentIndex = 0;

            //Ignore characters that some editors add to files
            if (file1Bytes[0] == 239 && file1Bytes[1] == 187 && file1Bytes[2] == 191)
                file1CurrentIndex = 3;

            if (file2Bytes[0] == 239 && file2Bytes[1] == 187 && file2Bytes[2] == 191)
                file2CurrentIndex = 3;

            var singleSkipCharacters = new byte[] { 10, 13/*, 32*/ };

            //if len of files are equal, Compare bytes:
            while (file1CurrentIndex < file1.Length)
            {
                //skip some characters:
                if (singleSkipCharacters.Contains(file1Bytes[file1CurrentIndex]))
                {
                    file1CurrentIndex++;
                    continue;
                }

                if (singleSkipCharacters.Contains(file2Bytes[file2CurrentIndex]))
                {
                    file2CurrentIndex++;
                    continue;
                }

                if (IgnoreSpacesAndEnters)
                {
                    if (file1Bytes[file1CurrentIndex] == '\r' || file1Bytes[file1CurrentIndex] == '\n' || file1Bytes[file1CurrentIndex] == ' ')
                    {
                        file1CurrentIndex++;
                        continue;
                    }

                    if (file2Bytes[file2CurrentIndex] == '\r' || file2Bytes[file2CurrentIndex] == '\n' || file2Bytes[file2CurrentIndex] == ' ')
                    {
                        file2CurrentIndex++;
                        continue;
                    }
                }
                //----------------------

                if (file1Bytes[file1CurrentIndex] != file2Bytes[file2CurrentIndex])
                    return false;

                file1CurrentIndex++;
                file2CurrentIndex++;
            }

            //if file1 has reached it's end but file2 has not reached it's end:
            while (file2CurrentIndex < file2.Length)
            {
                if (!singleSkipCharacters.Contains(file2Bytes[file2CurrentIndex]))
                    return false;

                file2CurrentIndex++;
            }

            return true;
        }

        static bool FilesAreEqual(string file1Path, string file2Path, bool IgnoreSpacesAndEnters)
        {
            var file1 = new FileInfo(file1Path);
            var file2 = new FileInfo(file2Path);

            return FilesAreEqual(file1, file2, IgnoreSpacesAndEnters);
        }

        private void uiFoundDifferencesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            string file1Path = null;
            string file2Path = null;

            if (uiFoundDifferencesDataGridView["File1Path", e.RowIndex].Value != null)
                file1Path = uiFoundDifferencesDataGridView["File1Path", e.RowIndex].Value.ToString();
            if (uiFoundDifferencesDataGridView["File2Path", e.RowIndex].Value != null)
                file2Path = uiFoundDifferencesDataGridView["File2Path", e.RowIndex].Value.ToString();

            if (file1Path != null && file2Path != null)
            {
                if (CompareTool == "WinDiff")
                    Process.Start("WinDiff.exe", string.Format("\"{0}\" \"{1}\"", file1Path, file2Path));
                else
                {
                    //prelunch visual studio if is not running to prevent error

                    if (!Utils.ProcessIsRunning("devenv"))
                    {
                        var process = new Process
                        {
                            StartInfo = new ProcessStartInfo
                            {
                                FileName = "devenv.exe"
                            }
                        };

                        process.Start();
                        process.WaitForInputIdle();
                    }

                    //windows will run visual studio only if it's not running
                    Process.Start("devenv.exe", string.Format("/diff \"{0}\" \"{1}\"", file1Path, file2Path));
                }
            }
            else if (file1Path != null)
                Process.Start(file1Path);
            else if (file2Path != null)
                Process.Start(file2Path);
        }

        private void uiFoundDifferencesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            uiSelectedCellTextTextBox.Text = null;
        }

        private void uiFoundDifferencesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ClickedCell_RowIndex = e.RowIndex;
                ClickedCell_ColumnIndex = e.ColumnIndex;
                CellClickTimer.Start();
            }
        }

        private void uiExcludedFilesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            uiSelectedCellTextTextBox.Text = null;
        }

        private void uiExcludedFilesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ClickedCell_RowIndex = e.RowIndex;
                ClickedCell_ColumnIndex = e.ColumnIndex;
                CellClickTimer.Start();
            }
        }

        private void CellClickTimer_Tick(object sender, EventArgs e)
        {
            //because some times SelectionChanged triggers after CellContentClick, we delay setting text

            if (ClickedCell_ColumnIndex == 0 || ClickedCell_ColumnIndex == 1)
            {
                if (uiResultsTabControl.SelectedTab == uiFoundDifferencesTabPage)
                    uiSelectedCellTextTextBox.Text = (string)uiFoundDifferencesDataGridView.Rows[ClickedCell_RowIndex].Cells[ClickedCell_ColumnIndex].Value;
                else if (uiResultsTabControl.SelectedTab == uiExcludedFilesTabPage)
                    uiSelectedCellTextTextBox.Text = (string)uiExcludedFilesDataGridView.Rows[ClickedCell_RowIndex].Cells[ClickedCell_ColumnIndex].Value;
            }

            CellClickTimer.Stop();
        }

        private string GetSettingsFilePath()
        {
            return Path.Combine(Path.GetTempPath(), "CompareFolders.settings");
        }

        private void SaveSettings()
        {
            var settingsFilePath = GetSettingsFilePath();

            var settingsString = string.Format(
                "<?xml version=\"1.0\" standalone=\"yes\"?>\r\n" +
                "<settings>\r\n" +
                "   <Path1List>{0}</Path1List>\r\n" +
                "   <Path1>{1}</Path1>\r\n" +
                "   <Path2List>{2}</Path2List>\r\n" +
                "   <Path2>{3}</Path2>\r\n" +
                "   <CompareTool>{4}</CompareTool>\r\n" +
                "   <IgnoreSpacesAndEnters>{5}</IgnoreSpacesAndEnters>\r\n" +
                "</settings>",
                string.Join(",", Path1List.ToArray()),
                uiPath1ComboBox.Text,
                string.Join(",", Path2List.ToArray()),
                uiPath2ComboBox.Text,
                CompareTool,
                IgnoreSpacesAndEnters);

            File.WriteAllText(settingsFilePath, settingsString);
        }

        private void ReadSettings()
        {
            var settingsFilePath = GetSettingsFilePath();

            if (!File.Exists(settingsFilePath))
                return;

            var settingsString = File.ReadAllText(settingsFilePath);

            try
            {
                var ds = new DataSet();
                var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(settingsString));
                ds.ReadXml(memoryStream);
                var settingRow = ds.Tables[0].Rows[0];

                if (settingRow.Table.Columns.Contains("Path1List") && !string.IsNullOrEmpty(settingRow["Path1List"].ToString()))
                {
                    Path1List = settingRow["Path1List"].ToString().Split(',').ToList();
                    uiPath1ComboBox.Items.AddRange(Path1List.ToArray());
                }

                if (settingRow.Table.Columns.Contains("Path1") && !string.IsNullOrEmpty(settingRow["Path1"].ToString()))
                    uiPath1ComboBox.Text = settingRow["Path1"].ToString();

                if (settingRow.Table.Columns.Contains("Path2List") && !string.IsNullOrEmpty(settingRow["Path2List"].ToString()))
                {
                    Path2List = settingRow["Path2List"].ToString().Split(',').ToList();
                    uiPath2ComboBox.Items.AddRange(Path2List.ToArray());
                }

                if (settingRow.Table.Columns.Contains("Path2") && !string.IsNullOrEmpty(settingRow["Path2"].ToString()))
                    uiPath2ComboBox.Text = settingRow["Path2"].ToString();

                if (settingRow.Table.Columns.Contains("CompareTool") && !string.IsNullOrEmpty(settingRow["CompareTool"].ToString()))
                    CompareTool = settingRow["CompareTool"].ToString();

                if (settingRow.Table.Columns.Contains("IgnoreSpacesAndEnters") && !string.IsNullOrEmpty(settingRow["IgnoreSpacesAndEnters"].ToString()))
                    IgnoreSpacesAndEnters = bool.Parse(settingRow["IgnoreSpacesAndEnters"].ToString());
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error reading settings file '{0}'.\r\n", settingsFilePath));
            }

            ReadExcludedFolders();
            ReadExcludePatterns();
        }

        internal void ReadExcludedFolders()
        {
            if (File.Exists("ExcludedFolders.txt"))
            {
                try
                {
                    ExcludedFolders = File.ReadAllLines("ExcludedFolders.txt").ToList();
                    ExcludedFolders.RemoveAll(o => o.Trim() == "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading ExcludedFolders.txt file");
                }
            }
            else
                ExcludedFolders = new List<string>();
        }
 
        public void ReadExcludePatterns()
        {
            if (File.Exists("ExcludePatterns.txt"))
            {
                try
                {
                    ExcludePatterns = File.ReadAllLines("ExcludePatterns.txt").ToList();
                    ExcludePatterns.RemoveAll(o => o.Trim() == "");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading ExcludePatterns.txt file");
                }
            }
            else
                ExcludePatterns = new List<string>();
        }

        private void Path1RemoveButton_Click(object sender, EventArgs e)
        {
            Path1List.RemoveAll(o => o.ToLower().Trim() == uiPath1ComboBox.Text.ToLower().Trim());
            uiPath1ComboBox.Items.Clear();
            uiPath1ComboBox.Items.AddRange(Path1List.ToArray());
            uiPath1ComboBox.Text = "";
        }

        private void Path2RemoveButton_Click(object sender, EventArgs e)
        {
            Path2List.RemoveAll(o => o.ToLower().Trim() == uiPath2ComboBox.Text.ToLower().Trim());
            uiPath2ComboBox.Items.Clear();
            uiPath2ComboBox.Items.AddRange(Path2List.ToArray());
            uiPath2ComboBox.Text = "";
        }

        private void uiPath1ComboBox_TextChanged(object sender, EventArgs e)
        {
            ClearResults();
        }

        private void uiPath2ComboBox_TextChanged(object sender, EventArgs e)
        {
            ClearResults();
        }

        private void ClearResults()
        {
            var differentItems = new List<FileCompareItem>();
            var excludedItems = new List<FileCompareItem>();

            uiFoundDifferencesTabPage.Text = "Found differences";
            uiFoundDifferencesDataGridView.DataSource = differentItems;
            uiFoundDifferencesDataGridView.Refresh();

            uiExcludedFilesTabPage.Text = "Excluded files report";
            uiExcludedFilesDataGridView.DataSource = excludedItems;
            uiExcludedFilesDataGridView.Refresh();
        }

        private void uiOpenSelectedFileButton_Click(object sender, EventArgs e)
        {
            Process.Start(uiSelectedCellTextTextBox.Text);
        }

        private void uiCompareEndMessageLabel_MouseDown(object sender, MouseEventArgs e)
        {
            uiCompareEndMessageLabel.Visible = false;
        }

        private void uiFoundDifferencesDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            uiCompareEndMessageLabel.Visible = false;
        }

        private void uiExcludedFilesDataGridView_MouseUp(object sender, MouseEventArgs e)
        {
            uiCompareEndMessageLabel.Visible = false;
        }

        private void uiGitHubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Utils.GetDefaultBrowserPath(), "https://github.com/mehdinikkhah2012/CompareFolders61");
        }
    }
}