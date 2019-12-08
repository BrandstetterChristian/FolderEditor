using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderEditor.FolderEdit.Result
{
    /// <summary>
    /// searched text
    /// </summary>
    public class SearchResult : EditResult
    {
        public string Searched { get; private set; }

        public SearchResult(string searched, bool caseSens, bool regex) : base(caseSens, regex)
        {
            Searched = searched;
        }

        public override string GetResultDescription()
        {
            return "Searched: " + Searched + ", found: " + Positions.Count + " times, " +
                "case sensitive: " + CaseSens + ", regular expressions: " + Regex;
        }
    }
}
