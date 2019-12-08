using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderEditor.FolderEdit.Result
{
    /// <summary>
    /// replaced with
    /// </summary>
    public class ReplaceResult : SearchResult
    {
        public string ReplacedWith { get; private set; }

        public ReplaceResult(string searched, string replacedWith, bool caseSens, bool regex) : base(searched, caseSens, regex)
        {
            ReplacedWith = replacedWith;
        }

        public override string GetResultDescription()
        {
            return "Searched: " + Searched + ", replaced with: " + ReplacedWith + ", replaced: " 
                + Positions.Count + " times, " +
                "case sensitive: " + CaseSens + ", regular expressions: " + Regex;
        }
    }
}
