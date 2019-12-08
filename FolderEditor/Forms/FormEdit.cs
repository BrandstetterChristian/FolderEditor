using FolderEditor.FolderEdit;
using FolderEditor.FolderEdit.Edit;
using FolderEditor.FolderEdit.Result;
using FolderEditor.FolderEdit.Tools;
using FolderEditor.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FolderEditor
{
    public partial class FormEdit : Form, IOutput
    {
        private EditableFolder editableFolder;

        public FormEdit()
        {
            InitializeComponent();
            editableFolder = null;
            cmbEditMode.SelectedIndex = 2;
            cmbReplaceAction.SelectedIndex = 0;
        }

        #region fcts
        private void SetOrAdd(TextBox tb, string text)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = text;
            }
            else
            {
                tb.Text += "," + text;
            }
        }
        public void SendOutput(string content)
        {
            txtOutput.Text = content ?? "NULL";
        }
        #endregion

        #region select
        private bool AreFilesSelected()
        {
            if (editableFolder == null)
            {
                SendOutput("No files/folders selected!");
                return false;
            }
            return true;
        }


        private void cmdSelect_Click(object sender, EventArgs e)
        {
            editableFolder = new EditableFolder(this);
            editableFolder.SetFiles(txtFiles.Text);
            editableFolder.SetFolders(txtFolders.Text);
            editableFolder.SetTypeFilter(txtTypeFilter.Text);
            SendOutput("Paths + filters set, " + DateTime.Now);
        }

        private void cmdBrowseFolders_Click(object sender, EventArgs e)
        {
            List<string> folders = BrowseDialoges.BrowseFolders();
            if (folders != null)
            {
                SetOrAdd(txtFolders, ListConverter.ListToString(folders));
            }
        }

        private void cmdFiles_Click(object sender, EventArgs e)
        {
            List<string> files = BrowseDialoges.BrowseFiles();
            if (files != null)
            {
                SetOrAdd(txtFiles, ListConverter.ListToString(files));
            }
        }
        #endregion



        #region list_files
        private void ListAllFiles(bool namesOnly)
        {
            lbAllFiles.Items.Clear();
            if (AreFilesSelected())
            {
                List<string> allFiles = editableFolder.GetAllFiles();
                if (namesOnly)
                {
                    lbAllFiles.Items.AddRange(allFiles.Select(s => s.Substring(s.LastIndexOf("\\") + 1)).ToArray());
                }
                else
                {
                    lbAllFiles.Items.AddRange(allFiles.ToArray());
                }
            }
        }

        private void ListAllDirectories(bool namesOnly)
        {
            lbAllFiles.Items.Clear();
            if (AreFilesSelected())
            {
                List<string> allDirectories = editableFolder.GetAllDirectories();
                if (namesOnly)
                {
                    lbAllFiles.Items.AddRange(allDirectories.Select(s => s.Substring(s.LastIndexOf("\\") + 1)).ToArray());
                }
                else
                {
                    lbAllFiles.Items.AddRange(allDirectories.ToArray());
                }
            }
        }

        private void cmdListFiles_Click(object sender, EventArgs e)
        {
            ListAllFiles(false);
        }

        private void cmdCopyFilesList_Click(object sender, EventArgs e)
        {
            if (lbAllFiles.Items.Count > 0)
            {
                string copy = "";
                foreach (string s in lbAllFiles.Items)
                {
                    copy += s + "\n";
                }
                Clipboard.SetText(copy);
            }
        }

        private void cmdListNamesOnly_Click(object sender, EventArgs e)
        {
            ListAllFiles(true);
        }

        private void cmdListDirectories_Click(object sender, EventArgs e)
        {
            ListAllDirectories(false);
        }

        private void cmdListDirName_Click(object sender, EventArgs e)
        {
            ListAllDirectories(true);

        }
        #endregion

        #region search_replace
        private void StartReplaceClick(object sender, EventArgs e)
        {
            if (AreFilesSelected())
            {
                EditResult result = null;
                switch (cmbReplaceAction.SelectedIndex)
                {
                    case 0:
                        result = FolderEdit.Edit.FolderEdit.INSTANCE.SearchText(
                            editableFolder, EditModes.GetModeByName(cmbEditMode.Text),
                            txtSearch.Text, chbCaseSens.Checked, chbRegex.Checked);
                        break;
                    case 1:
                        result = FolderEdit.Edit.FolderEdit.INSTANCE.ReplaceText(
                            editableFolder, EditModes.GetModeByName(cmbEditMode.Text),
                            txtSearch.Text, txtReplace.Text, chbCaseSens.Checked, chbRegex.Checked);
                        break;
                    case 2:
                        result = FolderEdit.Edit.FolderEdit.INSTANCE.DeleteFiles(
                            editableFolder, EditModes.GetModeByName(cmbEditMode.Text),
                            txtSearch.Text, chbCaseSens.Checked, chbRegex.Checked);
                        break;
                }

                if (result != null)
                {
                    FormSearchResult.ShowResult(result);
                }
         
            }
        }

        #endregion

        #region openSeleted
        private void openSelectedFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListComponentOpener.OpenListBoxFile(lbAllFiles, this, false);
        }

        private void openWithToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListComponentOpener.OpenListBoxFile(lbAllFiles, this, true);
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListComponentOpener.CopySelected(lbAllFiles, this);
        }


        #endregion

  
    }
}
