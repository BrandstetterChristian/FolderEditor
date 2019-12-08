using Microsoft.WindowsAPICodePack.Dialogs;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FolderEditor.FolderEdit.Tools
{
    public class BrowseDialoges
    {
        public static List<string> BrowseFiles()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true,
                Title = "Browse files"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileNames.ToList();
            }
            return null;
        }

        public static List<string> BrowseFolders()
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog
            {
                Multiselect = true,
                IsFolderPicker = true,
                Title = "Browse folders"
            };
            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return cofd.FileNames.ToList();
            }
            return null;
        }
    }
}
