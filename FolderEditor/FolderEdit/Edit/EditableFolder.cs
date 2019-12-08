using FolderEditor.FolderEdit.Tools;
using System;
using System.Collections.Generic;
using System.IO;

namespace FolderEditor.FolderEdit
{
    public class EditableFolder
    {
        private List<string> filesToEdit;
        private List<string> foldersToEdit;
        // after changes null, values are set in getter
        private List<string> allFiles;
        private List<string> allDirectories;

        private string typeFilter;
        private IOutput iOutput;

  
        /// <summary>
        /// uses ioutput as output
        /// </summary>
        /// <param name="outp"></param>
        public EditableFolder(IOutput outp)
        {
            filesToEdit = new List<string>();
            foldersToEdit = new List<string>();
            ClearSelection();
            typeFilter = "*.*";
            iOutput = outp;
        }

        /// <summary>
        /// sets files and folder selected to null
        /// </summary>
        public void ClearSelection()
        {
            allFiles = null;
            allDirectories = null;
        }

        public void SendOutput(string msg)
        {
            if (iOutput != null)
            {
                iOutput.SendOutput(msg);
            }
        }

        #region setters
        /// <summary>
        /// sets file list by input string
        /// </summary>
        /// <param name="input">format: path1, path2...</param>
        public void SetFiles(string input)
        {
            filesToEdit = ListConverter.StringToList(input);
            ClearSelection();
        }

        /// <summary>
        /// sets folders list by input string
        /// </summary>
        /// <param name="input">format: path1, path2...</param>
        public void SetFolders(string input)
        {
            foldersToEdit = ListConverter.StringToList(input);
            ClearSelection();
        }
        #endregion

        #region functions
        /// <summary>
        /// gets a list of all files
        /// displays errors in output
        /// </summary>
        /// <returns>allFiles</returns>
        public List<string> GetAllFiles()
        {
            bool count = true;
            if (allFiles == null)
            {
                allFiles = new List<string>();
                allFiles.AddRange(filesToEdit);
                //allFiles.AddRange
                foreach (string dir in foldersToEdit)
                {
                    // TODO filters here!
                    try
                    {
                        string[] folderFiles = Directory.GetFiles(dir, typeFilter, SearchOption.AllDirectories);
                        allFiles.AddRange(folderFiles);
                    }
                    catch (Exception ex)
                    {
                        SendOutput("Error while getting files from " + dir + "\n" + ex.Message);
                        count = false;
                    }

                }
            }

            if (count)
            {
                SendOutput("Found " + allFiles.Count + " files");
            }
            return allFiles;
        }

        /// <summary>
        /// gets list of all directories
        /// </summary>
        /// <returns>allDirectories</returns>
        public List<string> GetAllDirectories()
        {
            bool count = true;
            if (allDirectories == null)
            {
                allDirectories = new List<string>();
                foreach (string dir in foldersToEdit)
                {
                    allDirectories.Add(dir);
                    try
                    {
                        // TODO filter
                        string[] folderFiles = Directory.GetDirectories(dir, "*", SearchOption.AllDirectories);
                        allDirectories.AddRange(folderFiles);
                    }
                    catch (Exception ex)
                    {
                        SendOutput("Error while getting directories from " + dir + "\n" + ex.Message);
                        count = false;
                    }
                }
            }
            if (count)
            {
                SendOutput("Found " + allDirectories.Count + " directories");
            }
            return allDirectories;
        }

        public bool SetTypeFilter(string filter)
        {
            if (!string.IsNullOrEmpty(filter))
            {
                typeFilter = filter;
                ClearSelection();
                return true;
            }
            return false;
        }

      
        #endregion

    }


}
