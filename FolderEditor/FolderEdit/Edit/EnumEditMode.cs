namespace FolderEditor.FolderEdit
{
    public class EditModes
    {
        public static EditMode GetModeByName(string name)
        {
            switch(name)
            {
                case "Content and name":
                    return EditMode.BOTH;
                case "File name":
                    return EditMode.NAME;
                case "File content":
                    return EditMode.CONTENT;
            }
            return EditMode.CONTENT;
        }
    }

    public enum EditMode
    {
        CONTENT, NAME, BOTH

    }
}
