namespace FolderEditor.Forms
{
    partial class FormSearchResult
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
            this.tblInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lvResult = new System.Windows.Forms.ListView();
            this.clnFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSelectedFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.tblInfo.SuspendLayout();
            this.cmsListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblInfo
            // 
            this.tblInfo.BackColor = System.Drawing.Color.Silver;
            this.tblInfo.ColumnCount = 1;
            this.tblInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblInfo.Controls.Add(this.rtbDescription, 0, 0);
            this.tblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblInfo.Location = new System.Drawing.Point(0, 0);
            this.tblInfo.Name = "tblInfo";
            this.tblInfo.RowCount = 1;
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tblInfo.Size = new System.Drawing.Size(1009, 164);
            this.tblInfo.TabIndex = 0;
            // 
            // lvResult
            // 
            this.lvResult.BackColor = System.Drawing.Color.Silver;
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnFile,
            this.clnPosition});
            this.lvResult.ContextMenuStrip = this.cmsListView;
            this.lvResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(0, 164);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(1009, 356);
            this.lvResult.TabIndex = 1;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            // 
            // clnFile
            // 
            this.clnFile.Text = "File";
            this.clnFile.Width = 321;
            // 
            // clnPosition
            // 
            this.clnPosition.Text = "Position";
            this.clnPosition.Width = 237;
            // 
            // cmsListView
            // 
            this.cmsListView.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.cmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSelectedFileToolStripMenuItem,
            this.openWithToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.cmsListView.Name = "cmsListBox";
            this.cmsListView.Size = new System.Drawing.Size(478, 118);
            // 
            // openSelectedFileToolStripMenuItem
            // 
            this.openSelectedFileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.openSelectedFileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSelectedFileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.openSelectedFileToolStripMenuItem.Name = "openSelectedFileToolStripMenuItem";
            this.openSelectedFileToolStripMenuItem.Size = new System.Drawing.Size(477, 38);
            this.openSelectedFileToolStripMenuItem.Text = "Open with standard program";
            this.openSelectedFileToolStripMenuItem.Click += new System.EventHandler(this.openSelectedFileToolStripMenuItem_Click_1);
            // 
            // openWithToolStripMenuItem
            // 
            this.openWithToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.openWithToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.openWithToolStripMenuItem.Name = "openWithToolStripMenuItem";
            this.openWithToolStripMenuItem.Size = new System.Drawing.Size(477, 38);
            this.openWithToolStripMenuItem.Text = "Open with...";
            this.openWithToolStripMenuItem.Click += new System.EventHandler(this.openWithToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.copyToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(477, 38);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.BackColor = System.Drawing.Color.LightGray;
            this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescription.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.rtbDescription.Location = new System.Drawing.Point(3, 3);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ReadOnly = true;
            this.rtbDescription.Size = new System.Drawing.Size(1003, 158);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "";
            // 
            // FormSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 520);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.tblInfo);
            this.Name = "FormSearchResult";
            this.Text = "Search Result";
            this.tblInfo.ResumeLayout(false);
            this.cmsListView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblInfo;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader clnFile;
        private System.Windows.Forms.ColumnHeader clnPosition;
        private System.Windows.Forms.ContextMenuStrip cmsListView;
        private System.Windows.Forms.ToolStripMenuItem openSelectedFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbDescription;
    }
}