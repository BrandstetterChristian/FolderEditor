using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FolderEditor.FolderEdit.Tools
{
    public class ListComponentOpener
    {

        public static void OpenListBoxFile(ListBox lb, IOutput output, bool showWithDialog)
        {
            if (lb.SelectedItem == null)
            {
                output.SendOutput("No file selected");
                return;
            }
            OpenPath(output, lb.SelectedItem.ToString(), showWithDialog);
        }

        public static void OpenListViewFile(ListView lv, IOutput output, bool showWithDialog)
        {
            if (lv.SelectedItems == null || lv.SelectedItems[0] == null)
            {
                output.SendOutput("No file selected");
                return;
            }
            try
            {
                OpenPath(output, lv.SelectedItems[0].SubItems[0].Text, showWithDialog);
            }catch
            {
                // for problems with array null:
                output.SendOutput("No file selected...");
            }
        }

        public static void CopySelected(ListBox lv, IOutput output)
        {
            if (lv.SelectedItem == null)
            {
                output.SendOutput("No file selected");
                return;
            } 
            try
            {
                Clipboard.SetText(lv.SelectedItem.ToString());
                output.SendOutput(lv.SelectedItem.ToString());
            } catch
            {
                output.SendOutput("Could not copy to clipboard");
            }
        }

        public static void CopySelected(ListView lv, IOutput output)
        {
            if (lv.SelectedItems == null)
            {
                output.SendOutput("No file selected");
                return;
            }
            try
            {
                Clipboard.SetText(lv.SelectedItems[0].SubItems[0].Text);
                output.SendOutput(lv.SelectedItems[0].SubItems[0].Text);
            }
            catch
            {
                output.SendOutput("Could not copy to clipboard");
            }
        }

        private static void OpenPath(IOutput output, string path, bool showWithDialog)
        {
            if (!File.Exists(path))
            {
                output.SendOutput("Selected file doesn't exist, make sure the full path is displayed");
            }
            else
            {
                try
                {
                    if (showWithDialog)
                    {
                        // https://stackoverflow.com/questions/4726441/how-can-i-show-the-open-with-file-dialog
                        var args = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "shell32.dll");
                        args += ",OpenAs_RunDLL " + path;
                        Process.Start("rundll32.exe", args);
                    }
                    else
                    {
                        Process.Start(path);
                    }
                    output.SendOutput("Opened " + path);
                }
                catch (Exception ex)
                {
                    output.SendOutput("Could not opne " + path + ", " + ex.Message);
                }
            }
        }
    }
}
