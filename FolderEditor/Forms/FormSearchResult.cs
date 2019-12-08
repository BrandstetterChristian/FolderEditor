using FolderEditor.FolderEdit;
using FolderEditor.FolderEdit.Result;
using FolderEditor.FolderEdit.Tools;
using System;
using System.Windows.Forms;

namespace FolderEditor.Forms
{
    public partial class FormSearchResult : Form, IOutput
    {
        private FormSearchResult()
        {
            InitializeComponent();
            // make columns full width
            foreach (ColumnHeader ch in lvResult.Columns)
            {
                ch.Width = -2;
            }
        }

        private void SetContents(EditResult result)
        {
            rtbDescription.Text = result.GetResultDescription();
            foreach (string key in result.Positions.Keys)
            {
                lvResult.Items.Add(new ListViewItem(
                    new string[] { key, ListConverter.ListToString(result.Positions[key]) }));
            }
        }

        public static void ShowResult(EditResult result)
        {
            FormSearchResult formResult = new FormSearchResult();

            formResult.SetContents(result);
            formResult.Show();

        }


        public void SendOutput(string content)
        {
            rtbDescription.Text += "\n" + (content ?? "");
        }

        private void openSelectedFileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ListComponentOpener.OpenListViewFile(lvResult, this, false);
        }

        private void openWithToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListComponentOpener.OpenListViewFile(lvResult, this, true);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListComponentOpener.CopySelected(lvResult, this);
        }
    }
}
