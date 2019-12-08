namespace FolderEditor
{
    partial class FormEdit
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSelect = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFolders = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.txtFolders = new System.Windows.Forms.TextBox();
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.cmdBrowseFolders = new System.Windows.Forms.Button();
            this.cmdFiles = new System.Windows.Forms.Button();
            this.lblTypeFilter = new System.Windows.Forms.Label();
            this.txtTypeFilter = new System.Windows.Forms.TextBox();
            this.cmdSelect = new System.Windows.Forms.Button();
            this.tabListFiles = new System.Windows.Forms.TabPage();
            this.tblListFiles = new System.Windows.Forms.TableLayoutPanel();
            this.cmdListDirNames = new System.Windows.Forms.Button();
            this.cmdListDirectories = new System.Windows.Forms.Button();
            this.lbAllFiles = new System.Windows.Forms.ListBox();
            this.cmsListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSelectedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdCopyFilesList = new System.Windows.Forms.Button();
            this.cmdListFiles = new System.Windows.Forms.Button();
            this.cmdListNamesOnly = new System.Windows.Forms.Button();
            this.tabFindReplace = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEditMode = new System.Windows.Forms.Label();
            this.chbRegex = new System.Windows.Forms.CheckBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.chbCaseSens = new System.Windows.Forms.CheckBox();
            this.cmbEditMode = new System.Windows.Forms.ComboBox();
            this.cmdStartReplace = new System.Windows.Forms.Button();
            this.cmbReplaceAction = new System.Windows.Forms.ComboBox();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.tipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.tabMain.SuspendLayout();
            this.tabSelect.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabListFiles.SuspendLayout();
            this.tblListFiles.SuspendLayout();
            this.cmsListBox.SuspendLayout();
            this.tabFindReplace.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSelect);
            this.tabMain.Controls.Add(this.tabListFiles);
            this.tabMain.Controls.Add(this.tabFindReplace);
            this.tabMain.Controls.Add(this.tabResult);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(648, 457);
            this.tabMain.TabIndex = 0;
            // 
            // tabSelect
            // 
            this.tabSelect.BackColor = System.Drawing.Color.Silver;
            this.tabSelect.Controls.Add(this.tableLayoutPanel1);
            this.tabSelect.Controls.Add(this.cmdSelect);
            this.tabSelect.Location = new System.Drawing.Point(4, 43);
            this.tabSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSelect.Name = "tabSelect";
            this.tabSelect.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSelect.Size = new System.Drawing.Size(640, 410);
            this.tabSelect.TabIndex = 0;
            this.tabSelect.Text = "Select";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.00178F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.19245F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.80577F));
            this.tableLayoutPanel1.Controls.Add(this.lblFolders, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFiles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtFolders, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFiles, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmdBrowseFolders, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdFiles, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTypeFilter, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTypeFilter, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 328);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFolders
            // 
            this.lblFolders.AutoSize = true;
            this.lblFolders.Location = new System.Drawing.Point(2, 0);
            this.lblFolders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFolders.Name = "lblFolders";
            this.lblFolders.Size = new System.Drawing.Size(113, 30);
            this.lblFolders.TabIndex = 0;
            this.lblFolders.Text = "Folder(s)";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(2, 109);
            this.lblFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(80, 30);
            this.lblFiles.TabIndex = 1;
            this.lblFiles.Text = "File(s)";
            // 
            // txtFolders
            // 
            this.txtFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFolders.Location = new System.Drawing.Point(122, 2);
            this.txtFolders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFolders.Name = "txtFolders";
            this.txtFolders.Size = new System.Drawing.Size(372, 37);
            this.txtFolders.TabIndex = 2;
            this.tipInfo.SetToolTip(this.txtFolders, "format: folder1, folder2, folder3...");
            // 
            // txtFiles
            // 
            this.txtFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFiles.Location = new System.Drawing.Point(122, 111);
            this.txtFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.Size = new System.Drawing.Size(372, 37);
            this.txtFiles.TabIndex = 3;
            this.tipInfo.SetToolTip(this.txtFiles, "format: file1, file2, file3...");
            // 
            // cmdBrowseFolders
            // 
            this.cmdBrowseFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdBrowseFolders.Location = new System.Drawing.Point(502, 6);
            this.cmdBrowseFolders.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdBrowseFolders.Name = "cmdBrowseFolders";
            this.cmdBrowseFolders.Size = new System.Drawing.Size(128, 97);
            this.cmdBrowseFolders.TabIndex = 4;
            this.cmdBrowseFolders.Text = "Browse folders";
            this.cmdBrowseFolders.UseVisualStyleBackColor = true;
            this.cmdBrowseFolders.Click += new System.EventHandler(this.cmdBrowseFolders_Click);
            // 
            // cmdFiles
            // 
            this.cmdFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdFiles.Location = new System.Drawing.Point(502, 115);
            this.cmdFiles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdFiles.Name = "cmdFiles";
            this.cmdFiles.Size = new System.Drawing.Size(128, 97);
            this.cmdFiles.TabIndex = 5;
            this.cmdFiles.Text = "Browse files";
            this.cmdFiles.UseVisualStyleBackColor = true;
            this.cmdFiles.Click += new System.EventHandler(this.cmdFiles_Click);
            // 
            // lblTypeFilter
            // 
            this.lblTypeFilter.AutoSize = true;
            this.lblTypeFilter.Location = new System.Drawing.Point(2, 218);
            this.lblTypeFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeFilter.Name = "lblTypeFilter";
            this.lblTypeFilter.Size = new System.Drawing.Size(76, 60);
            this.lblTypeFilter.TabIndex = 6;
            this.lblTypeFilter.Text = "Type filter";
            // 
            // txtTypeFilter
            // 
            this.txtTypeFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTypeFilter.Location = new System.Drawing.Point(122, 220);
            this.txtTypeFilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTypeFilter.Name = "txtTypeFilter";
            this.txtTypeFilter.Size = new System.Drawing.Size(372, 37);
            this.txtTypeFilter.TabIndex = 7;
            this.tipInfo.SetToolTip(this.txtTypeFilter, "Filter format: *.*, example: *.txt, only for files of folders");
            // 
            // cmdSelect
            // 
            this.cmdSelect.BackColor = System.Drawing.Color.White;
            this.cmdSelect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSelect.Location = new System.Drawing.Point(2, 330);
            this.cmdSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(636, 78);
            this.cmdSelect.TabIndex = 1;
            this.cmdSelect.Text = "Select";
            this.tipInfo.SetToolTip(this.cmdSelect, "Click to reload selected files");
            this.cmdSelect.UseVisualStyleBackColor = false;
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // tabListFiles
            // 
            this.tabListFiles.Controls.Add(this.tblListFiles);
            this.tabListFiles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabListFiles.Location = new System.Drawing.Point(4, 43);
            this.tabListFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabListFiles.Name = "tabListFiles";
            this.tabListFiles.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabListFiles.Size = new System.Drawing.Size(640, 413);
            this.tabListFiles.TabIndex = 3;
            this.tabListFiles.Text = "List files/folders";
            this.tabListFiles.UseVisualStyleBackColor = true;
            // 
            // tblListFiles
            // 
            this.tblListFiles.ColumnCount = 2;
            this.tblListFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblListFiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblListFiles.Controls.Add(this.cmdListDirNames, 1, 1);
            this.tblListFiles.Controls.Add(this.cmdListDirectories, 1, 0);
            this.tblListFiles.Controls.Add(this.lbAllFiles, 0, 3);
            this.tblListFiles.Controls.Add(this.cmdCopyFilesList, 0, 2);
            this.tblListFiles.Controls.Add(this.cmdListFiles, 0, 0);
            this.tblListFiles.Controls.Add(this.cmdListNamesOnly, 0, 1);
            this.tblListFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblListFiles.Location = new System.Drawing.Point(2, 2);
            this.tblListFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tblListFiles.Name = "tblListFiles";
            this.tblListFiles.RowCount = 4;
            this.tblListFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.82957F));
            this.tblListFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.82957F));
            this.tblListFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.7931F));
            this.tblListFiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.70588F));
            this.tblListFiles.Size = new System.Drawing.Size(636, 409);
            this.tblListFiles.TabIndex = 4;
            // 
            // cmdListDirNames
            // 
            this.cmdListDirNames.AutoSize = true;
            this.cmdListDirNames.BackColor = System.Drawing.Color.DarkGray;
            this.cmdListDirNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdListDirNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListDirNames.Location = new System.Drawing.Point(322, 48);
            this.cmdListDirNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdListDirNames.Name = "cmdListDirNames";
            this.cmdListDirNames.Size = new System.Drawing.Size(310, 36);
            this.cmdListDirNames.TabIndex = 5;
            this.cmdListDirNames.Text = "List directory names only";
            this.cmdListDirNames.UseVisualStyleBackColor = false;
            this.cmdListDirNames.Click += new System.EventHandler(this.cmdListDirName_Click);
            // 
            // cmdListDirectories
            // 
            this.cmdListDirectories.AutoSize = true;
            this.cmdListDirectories.BackColor = System.Drawing.Color.DarkGray;
            this.cmdListDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdListDirectories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListDirectories.Location = new System.Drawing.Point(322, 4);
            this.cmdListDirectories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdListDirectories.Name = "cmdListDirectories";
            this.cmdListDirectories.Size = new System.Drawing.Size(310, 36);
            this.cmdListDirectories.TabIndex = 4;
            this.cmdListDirectories.Text = "List selected directories";
            this.cmdListDirectories.UseVisualStyleBackColor = false;
            this.cmdListDirectories.Click += new System.EventHandler(this.cmdListDirectories_Click);
            // 
            // lbAllFiles
            // 
            this.lbAllFiles.BackColor = System.Drawing.Color.Silver;
            this.tblListFiles.SetColumnSpan(this.lbAllFiles, 2);
            this.lbAllFiles.ContextMenuStrip = this.cmsListBox;
            this.lbAllFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAllFiles.FormattingEnabled = true;
            this.lbAllFiles.ItemHeight = 30;
            this.lbAllFiles.Location = new System.Drawing.Point(2, 146);
            this.lbAllFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbAllFiles.Name = "lbAllFiles";
            this.lbAllFiles.Size = new System.Drawing.Size(632, 261);
            this.lbAllFiles.Sorted = true;
            this.lbAllFiles.TabIndex = 1;
            // 
            // cmsListBox
            // 
            this.cmsListBox.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.cmsListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSelectedFileToolStripMenuItem,
            this.openWithToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.cmsListBox.Name = "cmsListBox";
            this.cmsListBox.Size = new System.Drawing.Size(423, 106);
            // 
            // openSelectedFileToolStripMenuItem
            // 
            this.openSelectedFileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.openSelectedFileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSelectedFileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.openSelectedFileToolStripMenuItem.Name = "openSelectedFileToolStripMenuItem";
            this.openSelectedFileToolStripMenuItem.Size = new System.Drawing.Size(422, 34);
            this.openSelectedFileToolStripMenuItem.Text = "Open with standard program";
            this.openSelectedFileToolStripMenuItem.Click += new System.EventHandler(this.openSelectedFileToolStripMenuItem_Click);
            // 
            // openWithToolStripMenuItem
            // 
            this.openWithToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.openWithToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.openWithToolStripMenuItem.Name = "openWithToolStripMenuItem";
            this.openWithToolStripMenuItem.Size = new System.Drawing.Size(422, 34);
            this.openWithToolStripMenuItem.Text = "Open with...";
            this.openWithToolStripMenuItem.Click += new System.EventHandler(this.openWithToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.copyToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(422, 34);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cmdCopyFilesList
            // 
            this.cmdCopyFilesList.BackColor = System.Drawing.Color.White;
            this.tblListFiles.SetColumnSpan(this.cmdCopyFilesList, 2);
            this.cmdCopyFilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdCopyFilesList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCopyFilesList.Location = new System.Drawing.Point(4, 92);
            this.cmdCopyFilesList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCopyFilesList.Name = "cmdCopyFilesList";
            this.cmdCopyFilesList.Size = new System.Drawing.Size(628, 48);
            this.cmdCopyFilesList.TabIndex = 2;
            this.cmdCopyFilesList.Text = "Copy list contents";
            this.cmdCopyFilesList.UseVisualStyleBackColor = false;
            this.cmdCopyFilesList.Click += new System.EventHandler(this.cmdCopyFilesList_Click);
            // 
            // cmdListFiles
            // 
            this.cmdListFiles.AutoSize = true;
            this.cmdListFiles.BackColor = System.Drawing.Color.White;
            this.cmdListFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdListFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListFiles.Location = new System.Drawing.Point(4, 4);
            this.cmdListFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdListFiles.Name = "cmdListFiles";
            this.cmdListFiles.Size = new System.Drawing.Size(310, 36);
            this.cmdListFiles.TabIndex = 0;
            this.cmdListFiles.Text = "List selected files";
            this.cmdListFiles.UseVisualStyleBackColor = false;
            this.cmdListFiles.Click += new System.EventHandler(this.cmdListFiles_Click);
            // 
            // cmdListNamesOnly
            // 
            this.cmdListNamesOnly.AutoSize = true;
            this.cmdListNamesOnly.BackColor = System.Drawing.Color.White;
            this.cmdListNamesOnly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdListNamesOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListNamesOnly.Location = new System.Drawing.Point(4, 48);
            this.cmdListNamesOnly.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdListNamesOnly.Name = "cmdListNamesOnly";
            this.cmdListNamesOnly.Size = new System.Drawing.Size(310, 36);
            this.cmdListNamesOnly.TabIndex = 3;
            this.cmdListNamesOnly.Text = "List file names only";
            this.cmdListNamesOnly.UseVisualStyleBackColor = false;
            this.cmdListNamesOnly.Click += new System.EventHandler(this.cmdListNamesOnly_Click);
            // 
            // tabFindReplace
            // 
            this.tabFindReplace.Controls.Add(this.tableLayoutPanel2);
            this.tabFindReplace.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFindReplace.Location = new System.Drawing.Point(4, 43);
            this.tabFindReplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabFindReplace.Name = "tabFindReplace";
            this.tabFindReplace.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabFindReplace.Size = new System.Drawing.Size(640, 410);
            this.tabFindReplace.TabIndex = 4;
            this.tabFindReplace.Text = "Find / Replace";
            this.tabFindReplace.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.47826F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.52174F));
            this.tableLayoutPanel2.Controls.Add(this.lblEditMode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.chbRegex, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblSearch, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblReplace, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtSearch, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtReplace, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.chbCaseSens, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.cmbEditMode, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmdStartReplace, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cmbReplaceAction, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(636, 406);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblEditMode
            // 
            this.lblEditMode.AutoSize = true;
            this.lblEditMode.Location = new System.Drawing.Point(2, 0);
            this.lblEditMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditMode.Name = "lblEditMode";
            this.lblEditMode.Size = new System.Drawing.Size(84, 30);
            this.lblEditMode.TabIndex = 9;
            this.lblEditMode.Text = "Mode";
            // 
            // chbRegex
            // 
            this.chbRegex.AutoSize = true;
            this.chbRegex.Location = new System.Drawing.Point(278, 304);
            this.chbRegex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbRegex.Name = "chbRegex";
            this.chbRegex.Size = new System.Drawing.Size(271, 34);
            this.chbRegex.TabIndex = 7;
            this.chbRegex.Text = "Regular expressions";
            this.chbRegex.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(2, 67);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(95, 30);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(2, 134);
            this.lblReplace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(170, 30);
            this.lblReplace.TabIndex = 1;
            this.lblReplace.Text = "Replace with";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(278, 69);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(356, 37);
            this.txtSearch.TabIndex = 2;
            // 
            // txtReplace
            // 
            this.txtReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReplace.Location = new System.Drawing.Point(278, 136);
            this.txtReplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(356, 37);
            this.txtReplace.TabIndex = 3;
            // 
            // chbCaseSens
            // 
            this.chbCaseSens.AutoSize = true;
            this.chbCaseSens.Location = new System.Drawing.Point(2, 304);
            this.chbCaseSens.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbCaseSens.Name = "chbCaseSens";
            this.chbCaseSens.Size = new System.Drawing.Size(210, 34);
            this.chbCaseSens.TabIndex = 6;
            this.chbCaseSens.Text = "Case sensitive";
            this.chbCaseSens.UseVisualStyleBackColor = true;
            // 
            // cmbEditMode
            // 
            this.cmbEditMode.BackColor = System.Drawing.Color.LightGray;
            this.cmbEditMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEditMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEditMode.FormattingEnabled = true;
            this.cmbEditMode.Items.AddRange(new object[] {
            "File content",
            "File name",
            "Content and name"});
            this.cmbEditMode.Location = new System.Drawing.Point(278, 2);
            this.cmbEditMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEditMode.Name = "cmbEditMode";
            this.cmbEditMode.Size = new System.Drawing.Size(356, 38);
            this.cmbEditMode.TabIndex = 8;
            // 
            // cmdStartReplace
            // 
            this.cmdStartReplace.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmdStartReplace.Location = new System.Drawing.Point(278, 203);
            this.cmdStartReplace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdStartReplace.Name = "cmdStartReplace";
            this.cmdStartReplace.Size = new System.Drawing.Size(356, 57);
            this.cmdStartReplace.TabIndex = 10;
            this.cmdStartReplace.Text = "Start";
            this.cmdStartReplace.UseVisualStyleBackColor = true;
            this.cmdStartReplace.Click += new System.EventHandler(this.StartReplaceClick);
            // 
            // cmbReplaceAction
            // 
            this.cmbReplaceAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbReplaceAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReplaceAction.FormattingEnabled = true;
            this.cmbReplaceAction.Items.AddRange(new object[] {
            "Search",
            "Replace",
            "Delete files"});
            this.cmbReplaceAction.Location = new System.Drawing.Point(2, 203);
            this.cmbReplaceAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbReplaceAction.Name = "cmbReplaceAction";
            this.cmbReplaceAction.Size = new System.Drawing.Size(272, 38);
            this.cmbReplaceAction.TabIndex = 11;
            // 
            // tabResult
            // 
            this.tabResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabResult.Location = new System.Drawing.Point(4, 43);
            this.tabResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabResult.Name = "tabResult";
            this.tabResult.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabResult.Size = new System.Drawing.Size(640, 413);
            this.tabResult.TabIndex = 5;
            this.tabResult.Text = "Result";
            this.tabResult.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(0, 457);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(648, 35);
            this.txtOutput.TabIndex = 1;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 492);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.txtOutput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEdit";
            this.Text = "Folder Editor";
            this.tabMain.ResumeLayout(false);
            this.tabSelect.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabListFiles.ResumeLayout(false);
            this.tblListFiles.ResumeLayout(false);
            this.tblListFiles.PerformLayout();
            this.cmsListBox.ResumeLayout(false);
            this.tabFindReplace.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFolders;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.TextBox txtFolders;
        private System.Windows.Forms.TextBox txtFiles;
        private System.Windows.Forms.Button cmdBrowseFolders;
        private System.Windows.Forms.Button cmdFiles;
        private System.Windows.Forms.Label lblTypeFilter;
        private System.Windows.Forms.TabPage tabListFiles;
        private System.Windows.Forms.Button cmdListFiles;
        private System.Windows.Forms.ListBox lbAllFiles;
        private System.Windows.Forms.Button cmdSelect;
        private System.Windows.Forms.TextBox txtTypeFilter;
        private System.Windows.Forms.ToolTip tipInfo;
        private System.Windows.Forms.Button cmdCopyFilesList;
        private System.Windows.Forms.Button cmdListNamesOnly;
        private System.Windows.Forms.TabPage tabFindReplace;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.CheckBox chbCaseSens;
        private System.Windows.Forms.CheckBox chbRegex;
        private System.Windows.Forms.ContextMenuStrip cmsListBox;
        private System.Windows.Forms.ToolStripMenuItem openSelectedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithToolStripMenuItem;
        private System.Windows.Forms.Label lblEditMode;
        private System.Windows.Forms.ComboBox cmbEditMode;
        private System.Windows.Forms.TableLayoutPanel tblListFiles;
        private System.Windows.Forms.Button cmdListDirNames;
        private System.Windows.Forms.Button cmdListDirectories;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.Button cmdStartReplace;
        private System.Windows.Forms.ComboBox cmbReplaceAction;
        private System.Windows.Forms.TabPage tabResult;
    }
}

