using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FolderEditor.FolderEdit.Tools
{
    public class ListConverter
    {
        /// <summary>
        /// converts list into string output
        /// </summary>
        /// <param name="list">list to convert</param>
        /// <param name="split">character to split output</param>
        /// <returns></returns>
        public static string ListToString(IEnumerable list, string split = ",")
        {
            string output = string.Empty;
            foreach (object o in list)
            {
                output += o.ToString() + split;
            }
            // remove last split character
            if (output.Length > split.Length)
            {
                output = output.Substring(0, output.Length - split.Length);
            }
            return output;
        }

        /// <summary>
        /// converts string to list
        /// </summary>
        /// <param name="input">input string</param>
        /// <param name="split">character between parts of list</param>
        /// <returns></returns>
        public static List<string> StringToList(string input, string split = ",")
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return new List<string>();
            }
            return input.Trim().Split(new string[] { split }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}
