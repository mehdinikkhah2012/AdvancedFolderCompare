namespace CompareDir
{
    partial class FoldersCompareForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoldersCompareForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiCompareButton = new System.Windows.Forms.Button();
            this.uiFoundDifferencesDataGridView = new System.Windows.Forms.DataGridView();
            this.File1Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.File2Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifferenceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiOptionsButton = new System.Windows.Forms.Button();
            this.uiResultsTabControl = new System.Windows.Forms.TabControl();
            this.uiFoundDifferencesTabPage = new System.Windows.Forms.TabPage();
            this.uiExcludedFilesTabPage = new System.Windows.Forms.TabPage();
            this.uiExcludedFilesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DifferenceType2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.uiPath2ComboBox = new System.Windows.Forms.ComboBox();
            this.Path2RemoveButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.uiPath1ComboBox = new System.Windows.Forms.ComboBox();
            this.Path1RemoveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.uiSelectedCellTextTextBox = new System.Windows.Forms.TextBox();
            this.CellClickTimer = new System.Windows.Forms.Timer(this.components);
            this.uiStatusBarLabel = new System.Windows.Forms.Label();
            this.uiOpenSelectedFileButton = new System.Windows.Forms.Button();
            this.uiCompareEndMessageLabel = new System.Windows.Forms.Label();
            this.uiGitHubLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.uiFoundDifferencesDataGridView)).BeginInit();
            this.uiResultsTabControl.SuspendLayout();
            this.uiFoundDifferencesTabPage.SuspendLayout();
            this.uiExcludedFilesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiExcludedFilesDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path1:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path2:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiCompareButton
            // 
            this.uiCompareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiCompareButton.Location = new System.Drawing.Point(972, 21);
            this.uiCompareButton.Name = "uiCompareButton";
            this.uiCompareButton.Size = new System.Drawing.Size(75, 24);
            this.uiCompareButton.TabIndex = 5;
            this.uiCompareButton.Text = "Compare";
            this.uiCompareButton.UseVisualStyleBackColor = true;
            this.uiCompareButton.Click += new System.EventHandler(this.uiCompareButton_Click);
            // 
            // uiFoundDifferencesDataGridView
            // 
            this.uiFoundDifferencesDataGridView.AllowUserToAddRows = false;
            this.uiFoundDifferencesDataGridView.AllowUserToDeleteRows = false;
            this.uiFoundDifferencesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiFoundDifferencesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.File1Path,
            this.File2Path,
            this.DifferenceType});
            this.uiFoundDifferencesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiFoundDifferencesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.uiFoundDifferencesDataGridView.MultiSelect = false;
            this.uiFoundDifferencesDataGridView.Name = "uiFoundDifferencesDataGridView";
            this.uiFoundDifferencesDataGridView.ReadOnly = true;
            this.uiFoundDifferencesDataGridView.Size = new System.Drawing.Size(1217, 457);
            this.uiFoundDifferencesDataGridView.TabIndex = 6;
            this.uiFoundDifferencesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiFoundDifferencesDataGridView_CellClick);
            this.uiFoundDifferencesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiFoundDifferencesDataGridView_CellDoubleClick);
            this.uiFoundDifferencesDataGridView.SelectionChanged += new System.EventHandler(this.uiFoundDifferencesDataGridView_SelectionChanged);
            this.uiFoundDifferencesDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uiFoundDifferencesDataGridView_MouseDown);
            // 
            // File1Path
            // 
            this.File1Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.File1Path.DataPropertyName = "File1Path";
            this.File1Path.HeaderText = "File1 Path";
            this.File1Path.Name = "File1Path";
            this.File1Path.ReadOnly = true;
            // 
            // File2Path
            // 
            this.File2Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.File2Path.DataPropertyName = "File2Path";
            this.File2Path.HeaderText = "File2 Path";
            this.File2Path.Name = "File2Path";
            this.File2Path.ReadOnly = true;
            // 
            // DifferenceType
            // 
            this.DifferenceType.DataPropertyName = "DifferenceType";
            this.DifferenceType.HeaderText = "Difference type";
            this.DifferenceType.Name = "DifferenceType";
            this.DifferenceType.ReadOnly = true;
            this.DifferenceType.Width = 130;
            // 
            // uiOptionsButton
            // 
            this.uiOptionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiOptionsButton.Location = new System.Drawing.Point(1188, 2);
            this.uiOptionsButton.Name = "uiOptionsButton";
            this.uiOptionsButton.Size = new System.Drawing.Size(73, 24);
            this.uiOptionsButton.TabIndex = 8;
            this.uiOptionsButton.Text = "Options ...";
            this.uiOptionsButton.UseVisualStyleBackColor = true;
            this.uiOptionsButton.Click += new System.EventHandler(this.uiOptionsButton_Click);
            // 
            // uiResultsTabControl
            // 
            this.uiResultsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiResultsTabControl.Controls.Add(this.uiFoundDifferencesTabPage);
            this.uiResultsTabControl.Controls.Add(this.uiExcludedFilesTabPage);
            this.uiResultsTabControl.Location = new System.Drawing.Point(18, 66);
            this.uiResultsTabControl.Name = "uiResultsTabControl";
            this.uiResultsTabControl.SelectedIndex = 0;
            this.uiResultsTabControl.Size = new System.Drawing.Size(1231, 489);
            this.uiResultsTabControl.TabIndex = 9;
            // 
            // uiFoundDifferencesTabPage
            // 
            this.uiFoundDifferencesTabPage.Controls.Add(this.uiFoundDifferencesDataGridView);
            this.uiFoundDifferencesTabPage.Location = new System.Drawing.Point(4, 22);
            this.uiFoundDifferencesTabPage.Name = "uiFoundDifferencesTabPage";
            this.uiFoundDifferencesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.uiFoundDifferencesTabPage.Size = new System.Drawing.Size(1223, 463);
            this.uiFoundDifferencesTabPage.TabIndex = 0;
            this.uiFoundDifferencesTabPage.Text = "Found differences";
            this.uiFoundDifferencesTabPage.UseVisualStyleBackColor = true;
            // 
            // uiExcludedFilesTabPage
            // 
            this.uiExcludedFilesTabPage.Controls.Add(this.uiExcludedFilesDataGridView);
            this.uiExcludedFilesTabPage.Location = new System.Drawing.Point(4, 22);
            this.uiExcludedFilesTabPage.Name = "uiExcludedFilesTabPage";
            this.uiExcludedFilesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.uiExcludedFilesTabPage.Size = new System.Drawing.Size(1230, 468);
            this.uiExcludedFilesTabPage.TabIndex = 1;
            this.uiExcludedFilesTabPage.Text = "Excluded files report";
            this.uiExcludedFilesTabPage.UseVisualStyleBackColor = true;
            // 
            // uiExcludedFilesDataGridView
            // 
            this.uiExcludedFilesDataGridView.AllowUserToAddRows = false;
            this.uiExcludedFilesDataGridView.AllowUserToDeleteRows = false;
            this.uiExcludedFilesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiExcludedFilesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.DifferenceType2});
            this.uiExcludedFilesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiExcludedFilesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.uiExcludedFilesDataGridView.MultiSelect = false;
            this.uiExcludedFilesDataGridView.Name = "uiExcludedFilesDataGridView";
            this.uiExcludedFilesDataGridView.ReadOnly = true;
            this.uiExcludedFilesDataGridView.Size = new System.Drawing.Size(1224, 462);
            this.uiExcludedFilesDataGridView.TabIndex = 7;
            this.uiExcludedFilesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.uiExcludedFilesDataGridView_CellClick);
            this.uiExcludedFilesDataGridView.SelectionChanged += new System.EventHandler(this.uiExcludedFilesDataGridView_SelectionChanged);
            this.uiExcludedFilesDataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uiExcludedFilesDataGridView_MouseUp);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "File1Path";
            this.dataGridViewTextBoxColumn1.HeaderText = "File1 Path";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "File2Path";
            this.dataGridViewTextBoxColumn2.HeaderText = "File2 Path";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DifferenceType";
            this.dataGridViewTextBoxColumn3.HeaderText = "Exclude pattern";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // DifferenceType2
            // 
            this.DifferenceType2.HeaderText = "DifferenceType";
            this.DifferenceType2.Name = "DifferenceType2";
            this.DifferenceType2.ReadOnly = true;
            this.DifferenceType2.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(949, 34);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Controls.Add(this.uiPath2ComboBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Path2RemoveButton, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(477, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(469, 28);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // uiPath2ComboBox
            // 
            this.uiPath2ComboBox.BackColor = System.Drawing.Color.Yellow;
            this.uiPath2ComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPath2ComboBox.FormattingEnabled = true;
            this.uiPath2ComboBox.Location = new System.Drawing.Point(53, 3);
            this.uiPath2ComboBox.Name = "uiPath2ComboBox";
            this.uiPath2ComboBox.Size = new System.Drawing.Size(383, 21);
            this.uiPath2ComboBox.TabIndex = 8;
            this.uiPath2ComboBox.TextChanged += new System.EventHandler(this.uiPath2ComboBox_TextChanged);
            // 
            // Path2RemoveButton
            // 
            this.Path2RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("Path2RemoveButton.Image")));
            this.Path2RemoveButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Path2RemoveButton.Location = new System.Drawing.Point(442, 3);
            this.Path2RemoveButton.Name = "Path2RemoveButton";
            this.Path2RemoveButton.Size = new System.Drawing.Size(20, 22);
            this.Path2RemoveButton.TabIndex = 4;
            this.Path2RemoveButton.UseVisualStyleBackColor = true;
            this.Path2RemoveButton.Click += new System.EventHandler(this.Path2RemoveButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.uiPath1ComboBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Path1RemoveButton, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(468, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // uiPath1ComboBox
            // 
            this.uiPath1ComboBox.BackColor = System.Drawing.Color.Red;
            this.uiPath1ComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPath1ComboBox.FormattingEnabled = true;
            this.uiPath1ComboBox.Location = new System.Drawing.Point(53, 3);
            this.uiPath1ComboBox.Name = "uiPath1ComboBox";
            this.uiPath1ComboBox.Size = new System.Drawing.Size(382, 21);
            this.uiPath1ComboBox.TabIndex = 7;
            this.uiPath1ComboBox.TextChanged += new System.EventHandler(this.uiPath1ComboBox_TextChanged);
            // 
            // Path1RemoveButton
            // 
            this.Path1RemoveButton.Image = ((System.Drawing.Image)(resources.GetObject("Path1RemoveButton.Image")));
            this.Path1RemoveButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Path1RemoveButton.Location = new System.Drawing.Point(441, 3);
            this.Path1RemoveButton.Name = "Path1RemoveButton";
            this.Path1RemoveButton.Size = new System.Drawing.Size(20, 22);
            this.Path1RemoveButton.TabIndex = 2;
            this.Path1RemoveButton.UseVisualStyleBackColor = true;
            this.Path1RemoveButton.Click += new System.EventHandler(this.Path1RemoveButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 573);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Selected file:";
            // 
            // uiSelectedCellTextTextBox
            // 
            this.uiSelectedCellTextTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiSelectedCellTextTextBox.Location = new System.Drawing.Point(99, 570);
            this.uiSelectedCellTextTextBox.Name = "uiSelectedCellTextTextBox";
            this.uiSelectedCellTextTextBox.ReadOnly = true;
            this.uiSelectedCellTextTextBox.Size = new System.Drawing.Size(743, 20);
            this.uiSelectedCellTextTextBox.TabIndex = 12;
            // 
            // CellClickTimer
            // 
            this.CellClickTimer.Interval = 150;
            this.CellClickTimer.Tick += new System.EventHandler(this.CellClickTimer_Tick);
            // 
            // uiStatusBarLabel
            // 
            this.uiStatusBarLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiStatusBarLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiStatusBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.uiStatusBarLabel.Location = new System.Drawing.Point(0, 609);
            this.uiStatusBarLabel.Name = "uiStatusBarLabel";
            this.uiStatusBarLabel.Size = new System.Drawing.Size(1263, 22);
            this.uiStatusBarLabel.TabIndex = 13;
            this.uiStatusBarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiOpenSelectedFileButton
            // 
            this.uiOpenSelectedFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiOpenSelectedFileButton.Location = new System.Drawing.Point(848, 568);
            this.uiOpenSelectedFileButton.Name = "uiOpenSelectedFileButton";
            this.uiOpenSelectedFileButton.Size = new System.Drawing.Size(75, 24);
            this.uiOpenSelectedFileButton.TabIndex = 14;
            this.uiOpenSelectedFileButton.Text = "Open";
            this.uiOpenSelectedFileButton.UseVisualStyleBackColor = true;
            this.uiOpenSelectedFileButton.Click += new System.EventHandler(this.uiOpenSelectedFileButton_Click);
            // 
            // uiCompareEndMessageLabel
            // 
            this.uiCompareEndMessageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiCompareEndMessageLabel.BackColor = System.Drawing.Color.White;
            this.uiCompareEndMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.uiCompareEndMessageLabel.Location = new System.Drawing.Point(499, 278);
            this.uiCompareEndMessageLabel.Name = "uiCompareEndMessageLabel";
            this.uiCompareEndMessageLabel.Size = new System.Drawing.Size(264, 75);
            this.uiCompareEndMessageLabel.TabIndex = 16;
            this.uiCompareEndMessageLabel.Text = "Double click to compare files.";
            this.uiCompareEndMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiCompareEndMessageLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uiCompareEndMessageLabel_MouseDown);
            // 
            // uiGitHubLink
            // 
            this.uiGitHubLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGitHubLink.AutoSize = true;
            this.uiGitHubLink.Font = new System.Drawing.Font("0 Aria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.uiGitHubLink.Location = new System.Drawing.Point(1210, 589);
            this.uiGitHubLink.Name = "uiGitHubLink";
            this.uiGitHubLink.Size = new System.Drawing.Size(51, 20);
            this.uiGitHubLink.TabIndex = 17;
            this.uiGitHubLink.TabStop = true;
            this.uiGitHubLink.Text = "github";
            this.uiGitHubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uiGitHubLink_LinkClicked);
            // 
            // FoldersCompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 631);
            this.Controls.Add(this.uiGitHubLink);
            this.Controls.Add(this.uiCompareEndMessageLabel);
            this.Controls.Add(this.uiOpenSelectedFileButton);
            this.Controls.Add(this.uiStatusBarLabel);
            this.Controls.Add(this.uiSelectedCellTextTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.uiResultsTabControl);
            this.Controls.Add(this.uiOptionsButton);
            this.Controls.Add(this.uiCompareButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoldersCompareForm";
            this.Text = "Compare Folders 61 -";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.uiFoundDifferencesDataGridView)).EndInit();
            this.uiResultsTabControl.ResumeLayout(false);
            this.uiFoundDifferencesTabPage.ResumeLayout(false);
            this.uiExcludedFilesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiExcludedFilesDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uiCompareButton;
        private System.Windows.Forms.DataGridView uiFoundDifferencesDataGridView;
        private System.Windows.Forms.Button uiOptionsButton;
        private System.Windows.Forms.TabControl uiResultsTabControl;
        private System.Windows.Forms.TabPage uiFoundDifferencesTabPage;
        private System.Windows.Forms.TabPage uiExcludedFilesTabPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView uiExcludedFilesDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uiSelectedCellTextTextBox;
        private System.Windows.Forms.Timer CellClickTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn File1Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn File2Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifferenceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DifferenceType2;
        private System.Windows.Forms.Button Path2RemoveButton;
        private System.Windows.Forms.Button Path1RemoveButton;
        private System.Windows.Forms.ComboBox uiPath2ComboBox;
        private System.Windows.Forms.ComboBox uiPath1ComboBox;
        private System.Windows.Forms.Label uiStatusBarLabel;
        private System.Windows.Forms.Button uiOpenSelectedFileButton;
        private System.Windows.Forms.Label uiCompareEndMessageLabel;
        private System.Windows.Forms.LinkLabel uiGitHubLink;
    }
}

