using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FolderEditor.FolderEdit.Result
{
    /// <summary>
    /// regex, case sensitive, result-list
    /// </summary>
    public abstract class EditResult
    {
        public bool Regex { get; private set; }
        public bool CaseSens { get; private set; }


        public Dictionary<string, List<int>> Positions { get; private set; }
        

        public EditResult(bool caseSens, bool regex)
        {
            CaseSens = caseSens;
            Regex = regex;
            Positions = new Dictionary<string, List<int>>();
        }

        /*private void AddResult(string file, List<int> pos)
        {
            Positions.Add(file, pos);
        }*/

        // 0 = filename (change!), -1 = not found
        public void AddResult(string file, EditErrorCode code)
        {
            if (Positions.ContainsKey(file))
            {
                Positions[file].Add((int)code);
            } else {
                Positions.Add(file, new List<int> { (int)code });
            }
        }

        public void AddResult(string file, MatchCollection matchCollection)
        {
            List<int> matches = new List<int>();
            foreach (Match m in matchCollection)
            {
                matches.Add(m.Index);
            }
            Positions.Add(file, matches.ToList());
        }

        public abstract string GetResultDescription();

      
           
    }

    public enum EditErrorCode
    {
        NOTFOUND = -1,
        FILENAME = -2,
        DIRECTORYNAME = -3
    }
}
