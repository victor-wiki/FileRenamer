using FileRenameHandler;
using System.Collections.Generic;

namespace FileRenamer
{
    public class InfoHelper
    {
        public static Dictionary<FileRenameMode, string> HandleModeDescriptions = new Dictionary<FileRenameMode, string>()
        {
            { FileRenameMode.RemoveOrReplace, "Remove or replace characters." },
            { FileRenameMode.Trim, "Remove specified leading and trailing characters."},
            { FileRenameMode.Insert, "Insert characters at beginning or ending." },          
            { FileRenameMode.Extract, "Extract some characters from file name." },           
            { FileRenameMode.InsertFolderName, "Insert the folder name of file to file name." }
        };
    }
}
