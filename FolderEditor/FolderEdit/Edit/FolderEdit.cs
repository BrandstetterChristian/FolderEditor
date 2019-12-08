using FolderEditor.FolderEdit.Result;
using FolderEditor.Forms;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace FolderEditor.FolderEdit.Edit
{
    /**
     * actual editing of folder
     */
    public class FolderEdit
    {
        public static readonly FolderEdit INSTANCE = new FolderEdit();
        private FolderEdit() { }

        /// <summary>
        /// search text in certain files
        /// </summary>
        /// <param name="editableFolder">paths</param>
        /// <param name="mode">where to search</param>
        /// <param name="searched">text to search</param>
        /// <param name="caseSensitive">match case</param>
        /// <param name="regex">regular expressions</param>
        /// <returns>search result </returns>
        public SearchResult SearchText(EditableFolder editableFolder, EditMode mode, string searched, bool caseSensitive, bool regex)
        {
            if (string.IsNullOrEmpty(searched))
            {
                editableFolder.SendOutput("Cant search empty text");
                return null;
            }
            List<string> allFiles = editableFolder.GetAllFiles();

            SearchResult results = new SearchResult(searched, caseSensitive, regex);
            // pattern with/without regex
            string pattern = regex ? searched : Regex.Escape(searched);
            string fileText;
            MatchCollection matches;

            if (mode == EditMode.CONTENT || mode == EditMode.BOTH)
            {
                foreach (string file in allFiles)
                {
                    try
                    {
                        fileText = File.ReadAllText(file);
                        // get regex matches in file text
                        matches = Regex.Matches(fileText, pattern, caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase);
                        results.AddResult(file, matches);

                    }
                    catch (Exception ex)
                    {
                        results.AddResult(file + " -> " + ex.Message, EditErrorCode.NOTFOUND);
                    }
                }
            }

            if (mode == EditMode.NAME || mode == EditMode.BOTH)
            {
                // include directory names
                // moved allFiles.AddRange(editableFolder.GetAllDirectories());
                foreach (string file in allFiles)
                {
                    if (Regex.IsMatch(file, pattern))
                    {
                        results.AddResult(file, EditErrorCode.FILENAME);
                    }
                }
                List<string> allDirs = editableFolder.GetAllDirectories();

                foreach (string directory in allDirs)
                {
                    if (Regex.IsMatch(directory, pattern))
                    {
                        results.AddResult(directory, EditErrorCode.DIRECTORYNAME);
                    }
                }
            }
            editableFolder.ClearSelection();
            return results;
        }




        /// <summary>
        /// replace text in files
        /// </summary>
        /// <param name="editableFolder">paths</param>
        /// <param name="mode">where to search</param>
        /// <param name="searched">text to search</param>
        /// <param name="replaceWith">replace text with</param>
        /// <param name="caseSensitive">match case</param>
        /// <param name="regex">regular expressions</param>
        /// <returns>repalce result</returns>
        public ReplaceResult ReplaceText(EditableFolder editableFolder, EditMode mode, string searched, string replaceWith, bool caseSensitive, bool regex)
        {
            // replaceWith can be empty string!
            if (string.IsNullOrEmpty(searched) || replaceWith == null)
            {
                editableFolder.SendOutput("Cant search / replace empty text");
                return null;
            }
            List<string> allFiles = editableFolder.GetAllFiles();

            // path -> position
            ReplaceResult results = new ReplaceResult(searched, replaceWith, caseSensitive, regex);
            // pattern with/without regex
            string pattern = regex ? searched : Regex.Escape(searched);
            string fileText;
            string replacedFileText;
            MatchCollection matches;



            if (mode == EditMode.CONTENT || mode == EditMode.BOTH)
            {
                foreach (string file in allFiles)
                {
                    try
                    {
                        fileText = File.ReadAllText(file);
                        // find matches of text that will be replaced
                        matches = Regex.Matches(fileText, pattern, caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase);
                        // if there are matches
                        if (matches.Count > 0)
                        {
                            results.AddResult(file, matches);

                            // replace in file text 
                            replacedFileText = Regex.Replace(fileText, pattern, replaceWith, caseSensitive ? RegexOptions.None : RegexOptions.IgnoreCase);
                            // write to file
                            File.WriteAllText(file, replacedFileText);
                        }
                    }
                    catch (Exception ex)
                    {
                        results.AddResult(file + " -> " + ex.Message, EditErrorCode.NOTFOUND);
                    }
                }
            }

            // must be done after editing files, otherwise file wont exist anymore
            if (mode == EditMode.NAME || mode == EditMode.BOTH)
            {
                // only change file name, not path
                string fileName;
                foreach (string file in allFiles)
                {
                    fileName = file.Substring(file.LastIndexOf('\\') + 1);
                    if (Regex.IsMatch(fileName, pattern))
                    {
                        try
                        {
                            File.Move(file, file.Replace(fileName, "") + Regex.Replace(fileName, pattern, replaceWith));
                            results.AddResult(file, EditErrorCode.FILENAME);
                        }
                        catch (Exception ex)
                        {
                            results.AddResult(file + " -> " + ex.Message, EditErrorCode.NOTFOUND);
                        }
                    }
                }

                // include directory names
                List<string> allDirs = editableFolder.GetAllDirectories();
                foreach (string dir in allDirs)
                {
                    if (Regex.IsMatch(dir, pattern))
                    {
                        try
                        {
                            Directory.Move(dir, Regex.Replace(dir, pattern, replaceWith));
                            results.AddResult(dir, EditErrorCode.FILENAME);
                        }
                        catch (Exception ex)
                        {
                            results.AddResult(dir + " -> " + ex.Message, EditErrorCode.NOTFOUND);
                        }
                    }
                }
            }
            // reset if file names could have been edited
            editableFolder.ClearSelection();
            return results;
        }


        public SearchResult DeleteFiles(EditableFolder editableFolder, EditMode mode, string searched, bool caseSensitive, bool regex)
        {
            SearchResult result = SearchText(editableFolder, mode, searched, caseSensitive, regex);

            foreach (string file in result.Positions.Keys)
            {
                // reference file system
                FileSystem.DeleteFile(file, UIOption.OnlyErrorDialogs, RecycleOption.SendToRecycleBin);
                
            }


            return result;
        }
    }
}
