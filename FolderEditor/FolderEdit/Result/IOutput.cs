using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderEditor.FolderEdit
{
    public interface IOutput
    {
        void SendOutput(string content);
    }
}
